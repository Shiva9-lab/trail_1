using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Name : MonoBehaviour
{
    public TextMeshProUGUI text;
    public InputField display;

    private void Start()
    {
        text.text = PlayerPrefs.GetString("user_name");
    }

    public void StoreName()
    {
        text.text = display.text;
        PlayerPrefs.SetString("user_name", text.text);
        PlayerPrefs.Save();
    }
}
