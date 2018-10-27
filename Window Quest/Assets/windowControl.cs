using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windowControl : MonoBehaviour {

    public GameObject window;

    private void Awake()
    {
        window.SetActive(false);
    }
}
