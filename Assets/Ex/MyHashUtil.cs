using System;
using System.Text;
using UnityEngine;
using System.Collections.Generic;

public static class MyHashUtil
    {
        public static int Encode3DIndexTo1D(Vector3Int v, int sizeX, int sizeY)
        {
            return v.x + sizeX * (v.y + sizeY * v.z);
        }

        public static int GenerateHashForString(String stringInput)
        {
            // if (startIndex < 0 || startIndex + hashLength > list.Count)
            //     throw new ArgumentOutOfRangeException();

            IntHasher64 hasher = new IntHasher64();
            hasher.Init();
            for (int i = 0; i < stringInput.Length; i++)
            {
                hasher.Add(stringInput[i]);
            }
            return hasher.Value;
        }

        public static void GenerateHashesForList(
                List<int> list,
                HashSet<int> hashSet,
                int hashLength,
                bool includeReverse = false)
        {
            int count = list.Count;
            if (count < hashLength) return;

            IntHasher64 hasher = new IntHasher64();

            for (int i = 0; i <= list.Count - hashLength; i++)
            {
                // Forward
                hasher.Init();
                for (int j = 0; j < hashLength; j++)
                {
                    hasher.Add(list[i + j]);
                }
                hashSet.Add(hasher.Value);

                if (!includeReverse) continue;

                // Reverse
                hasher.Init();
                for (int j = 0; j < hashLength; j++)
                {
                    hasher.Add(list[i + hashLength - 1 - j]);
                }
                hashSet.Add(hasher.Value);
            }
        }
    }

    public struct IntHasher64
    {
        private int hash;
        private int count;

        private const int OffsetBasis = unchecked((int)2166136261);   //from 14695981039346656037UL
        private const int Prime = 16777619;  //from 1099511628211UL

        public void Add(int value)
        {
            unchecked
            {
                hash ^= value; //from (ulong)(uint)value
                hash *= Prime;
                count++;
            }
        }

        public int Value  //from ulong
        {
            get
            {
                unchecked
                {
                    int h = hash;
                    h ^= count;
                    h *= Prime;
                    return h;
                }
            }
        }

        public void Init()
        {
            hash = OffsetBasis;
            count = 0;
        }
}