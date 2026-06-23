using System;
using UnityEngine;

[Serializable]
public class LocalizedString : IEquatable<LocalizedString>
{
    [field: SerializeField] public string Namespace {get; private set;}
    [field: SerializeField] public string Key {get; private set;}
    public int NamespaceHash => MyHashUtil.GenerateHashForString(Namespace);    
    public int KeyHash => MyHashUtil.GenerateHashForString(Key);              


    public bool Equals(LocalizedString other)
    {
        return NamespaceHash == other.NamespaceHash && KeyHash == other.KeyHash;
    }

    public override bool Equals(object obj)
    {
        if (obj is LocalizedString other) return Equals(other);
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(NamespaceHash, KeyHash);
    }
}

