using UnityEngine;
using TMPro;

public class JuiiansHopefulAttemptatFP01 : MonoBehaviour
{
    [SerializeField] private TMP_Text myText;
    [SerializeField] HardCodedText hardCodedText;
    [SerializeField] TinyDictionary tinyDictionary;
    [SerializeField] LocalizedString localizedString;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //myText.text = hardCodedText.getText();      //F1
        myText.text = tinyDictionary.getText(gameObject.name);       //F2,3,4,5
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
