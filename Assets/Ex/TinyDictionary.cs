using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AYellowpaper.SerializedCollections;
using UnityEngine;

[Serializable]
public class TinyDictionary
{
    [SerializeField] private SerializedDictionary<int, string> tiny = new SerializedDictionary<int, string>()
    {
        {0, "I did it."},
        {1, "I couldn't do it"},
        {2, "I maybe did it"}
    };

    [SerializeField] private int key = 0;
    public string getText()
    {
        return tiny[key]; 
    }
}
