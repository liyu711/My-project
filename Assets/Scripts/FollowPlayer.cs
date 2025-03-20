using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject following_object;
    public GameObject test;
    // offset of the camera
    private Vector3 offset = new Vector3(0, 5, -8);
    // Start is called before the first frame update
    void Start()
    {
        test = GameObject.Find("vehicle");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = following_object.transform.position + offset;
    }
}
