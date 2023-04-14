using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Transform T_FollowCamera;
    public GameObject Sphere;

    // Start is called before the first frame update
    void Start()
    {
        //T_FollowCamera = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    { 
        Vector3 newPos = new Vector3(Sphere.transform.position.x, 10, Sphere.transform.position.z);
        transform.position = newPos;
    }
}
