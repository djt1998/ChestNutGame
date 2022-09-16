using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heavy_Block : MonoBehaviour
{
    private Player player;
    public float ratio;
    public Rigidbody rb;
    public int min_mass;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
        if (min_mass == 0) { min_mass = 12; }
        rb.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
        rb.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Player")
        {
            if (player.rb.mass > min_mass)
            {
                rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
                rb.isKinematic = false;
            }
            else
            {
                rb.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
                rb.isKinematic = true;
            }

        }
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.name == "Player")
        {
            rb.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
            rb.isKinematic = true;
        }
    }
}
