using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogBox : MonoBehaviour {

    public Text title_text;
    public Text body_text;
    public Canvas input_canvas;
    public Canvas dialog_canvas;

    private void Awake()
    {
        input_canvas.gameObject.SetActive(false);
        dialog_canvas.gameObject.SetActive(false);
    }
}
