using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windowControl : MonoBehaviour {

    public GameObject window;
    public bool active = false;

    private void Update()
    {
        if (active)
        {
            gameObject.SetActive(true);
            active = !active;
        }
    }
}
