using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UITextManager : MonoBehaviour
{

    [SerializeField] private string message;
    [SerializeField] private TextMeshProUGUI messageLabel;


    public void UpdateText()
    {
        //messageLabel.text = "Whatever you have on the... yep! " + message;
        messageLabel.text += "\nHi!";
        // \n is a linebreak.
        // \t is an indent.
    }
}
