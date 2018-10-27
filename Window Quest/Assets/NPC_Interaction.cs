using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC_Interaction : MonoBehaviour {

    public string Name = "NPC";
    public string Prompt = "FLAG";
    public string Success = ":)";

    private Text title_text;
    private Text body_text;
    private Canvas input_canvas;
    private Canvas dialog_canvas;

    private void Awake()
    {
        DialogBox playerDialogBoxScript = GameObject.Find("Player").GetComponent<DialogBox>();
        title_text = playerDialogBoxScript.title_text;
        body_text = playerDialogBoxScript.body_text;
        input_canvas = playerDialogBoxScript.input_canvas;
        dialog_canvas = playerDialogBoxScript.dialog_canvas;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name != "Player")
            return;

        Debug.Log(gameObject.name + " NPC Interaction With: " + other.gameObject);
        title_text.text = Name;
        body_text.text = Prompt;
        toggleDisplay(true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name != "Player")
            return;

        title_text.text = null;
        body_text.text = null;
        toggleDisplay(false);
    }

    private void toggleDisplay(bool state)
    {
        input_canvas.gameObject.SetActive(state);
        dialog_canvas.gameObject.SetActive(state);
    }
}
