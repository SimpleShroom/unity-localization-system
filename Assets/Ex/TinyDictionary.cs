using System;
using System.Linq;
using AYellowpaper.SerializedCollections;
using UnityEngine;

[Serializable]
public class TinyDictionary
{
    [SerializeField] private SerializedDictionary<LocalizedString, string> tiny = new SerializedDictionary<LocalizedString, string>();

    //[SerializeField] private SerializedDictionary<LocalizedString, string> tiny = new SerializedDictionary<LocalizedString, string>();
    // {
    //     {0, "I did it."},
    //     {1, "I couldn't do it"},
    //     {2, "I maybe did it"}
    // };

    //[SerializeField] private int key;
    [SerializeField] private LocalizedString key;
    public string getText()
    {
        // foreach (var kvp in tiny)
        // {
        //     Debug.Log(kvp.Key.GetHashCode());
        // }
        // Debug.Log(key.GetHashCode());


        if(!tiny.ContainsKey(key))
        {
            Debug.LogWarning("Key wasn't found fivehead");
            return $"[{key.Namespace}:{key.Key}] not found.";
        }

        // Debug.Log(tiny.ContainsKey(key));

        return tiny[key]; 
    }
}


