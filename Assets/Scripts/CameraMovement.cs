using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public GameObject Miguel;

    private Miguel pn;

    // Use this for initialization
    void Start()
    {
        pn = Miguel.GetComponent<Miguel>();
    }

    // Update is called once per frame
    void Update()
    {
        float posx = pn.transform.position.x;
        transform.position = new Vector3(posx, transform.position.y, transform.position.z);
    }
}
