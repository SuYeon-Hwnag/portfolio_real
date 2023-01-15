using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_3D : MonoBehaviour
{
    private Transform pp; // camera_position
    Vector3 cameraplus; // camera를 플레이어 뒤에 놓음

    // Start is called before the first frame update
    void Start()
    {
        pp = GameObject.FindGameObjectWithTag("Player").transform;
        cameraplus = transform.position - pp.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = pp.position + cameraplus;
    }
}
