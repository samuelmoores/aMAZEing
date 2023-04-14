using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCameraSphere : MonoBehaviour
{
    Transform m_FollowCamera;
    public GameObject Sphere;

    // Start is called before the first frame update
    void Start()
    {
        m_FollowCamera = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(Sphere.transform.position.x, 45, Sphere.transform.position.z);
        m_FollowCamera.transform.position = newPos;
        //m_FollowCamera.rotation = Quaternion.Euler(90.0f, 0f, 0f); // lock rotation
    }
}

 
