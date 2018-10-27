using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce : MonoBehaviour {

    public float speed = 0.1f;
    public int max = 50;
    private Transform _transform;
    private float height;
    private int count = 0;

    private void Awake()
    {
        _transform = gameObject.GetComponent<Transform>();
        height = _transform.position.y;
    }

    // Update is called once per frame
    void Update () {
        if (count < max) {
            _transform.Translate(new Vector3(0, speed, 0));
            count++;
        }
        else if(count >= max) {
            _transform.Translate(new Vector3(0, -speed, 0));
            count++;
        }
        if(count == 2*max) {
            count = 0;
        }
	}
}
