using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour
{
    public string input;
  
    public void StoreName(string s)
    {
        input = s;
        Debug.Log(input);
    }
}
