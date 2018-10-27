using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC_Interaction : MonoBehaviour {

    public string Name = "NPC";
    public string Prompt = "FLAG";
    public string Success = ":)";
    public int flag = 0;


    private Text title_text;
    private Text body_text;
    private Canvas input_canvas;
    private Canvas dialog_canvas;
    private TextInput textInput;
    public GameObject bang;
    public GameObject window;

    private void Awake()
    {
        DialogBox playerDialogBoxScript = GameObject.Find("Player").GetComponent<DialogBox>();
        textInput = GameObject.Find("Player").GetComponent<TextInput>();
        title_text = playerDialogBoxScript.title_text;
        body_text = playerDialogBoxScript.body_text;
        input_canvas = playerDialogBoxScript.input_canvas;
        dialog_canvas = playerDialogBoxScript.dialog_canvas;
        bang = gameObject.transform.Find("Bang").gameObject;
        if (!bang)
            Debug.Log(gameObject + " Failed bang init");

        window = GameObject.Find("GameMaster").GetComponent<ProgressTracker>().windows[flag].GetComponent<windowControl>().window;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name != "Player")
            return;

        if (!bang && !title_text.text.Contains("(COMPLETE)"))
        {
            title_text.color = Color.green;
            title_text.text = title_text.text + " (COMPLETE)";
        }

        textInput.window = window;
        textInput.turnInIndex = flag;
        textInput.bang = bang;

        Debug.Log(gameObject.name + " NPC Interaction With: " + other.gameObject + " set flag #: " + flag);
        title_text.text = Name;
        body_text.text = Prompt;
        toggleDisplay(true);
    }



    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name != "Player")
            return;

        textInput.window = null;
        textInput.turnInIndex = -1;

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
