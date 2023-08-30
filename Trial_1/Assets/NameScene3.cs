using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NameScene3 : MonoBehaviour
{
    Name n;
    string display;
    
    public TextMeshProUGUI text;

    private void Start()
    {
        n = GetComponent<Name>();
        display = n.input;
        text.text = "Hey " + display;
    }



}
