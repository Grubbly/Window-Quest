using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowPlayer : MonoBehaviour {

    private void kill()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Transform>().transform.localScale = new Vector3(3.5f, 3.5f, 3.5f);
        Invoke("kill", 1f);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
