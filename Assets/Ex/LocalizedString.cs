using System;
using System.ComponentModel;
using UnityEngine;

[Serializable]
public class LocalizedString : IEquatable<LocalizedString>
{
    [field: SerializeField] public string Namespace {get; private set;}
    [field: SerializeField] public string Key {get; private set;}

    public bool Equals(LocalizedString other)
    {
        return Namespace == other.Namespace && Key == other.Key;
    }
}

