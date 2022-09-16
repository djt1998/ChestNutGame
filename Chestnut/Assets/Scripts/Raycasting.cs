using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycasting : MonoBehaviour
{
    public float raycast_length;


    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * raycast_length, Color.red);
    }
}