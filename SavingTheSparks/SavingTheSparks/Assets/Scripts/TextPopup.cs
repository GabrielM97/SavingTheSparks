using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextPopup : MonoBehaviour
{
    private Text popTxt;

	void Start ()
    {
        popTxt = gameObject.GetComponent<Text>();
    }

    public void PopUp(string text)
    {
        popTxt.text = text;
    }
}
