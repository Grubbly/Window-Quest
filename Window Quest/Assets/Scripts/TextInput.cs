using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextInput : MonoBehaviour {

    public InputField inputField;
    //private GameObject controller;

    private void Awake()
    {
        //controller = gameObject;
        inputField.onEndEdit.AddListener(AcceptStringInput);
    }

    private void AcceptStringInput(string userInput)
    {
        userInput = userInput.ToLower();
        InputComplete();
    }

    private void InputComplete()
    {
        //controller.DisplayLoggedText();
        inputField.ActivateInputField();
        inputField.text = null;
    }
}
