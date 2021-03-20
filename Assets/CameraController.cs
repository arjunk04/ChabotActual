using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject astronaut;
    private Vector3 offset;

    void Start () {
        offset = transform.position - astronaut.transform.position;
    }

    void LateUpdate () {
        transform.position = astronaut.transform.position + offset;
    }
}
