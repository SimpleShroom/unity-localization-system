using System;
using UnityEngine;

[Serializable]
public class HardCodedText
{
    [SerializeField] private string NTHING = "this is my hardcoded text";
    public string getText()
    {
        return NTHING;
    }
}
