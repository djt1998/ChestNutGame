using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public int force_coef;
    public float density;
    private Vector3 speed;
    private int spd_val;
    private float player_radius;
    private bool is_jump;
    // Start is called before the first frame update
    void Start()
    {
        is_jump = false;
        speed = new Vector3(0, 0, 0);
        spd_val = 5;
        rb.drag = 1;
        if (force_coef == 0) { force_coef = 25; }
        if (density == 0) { density = 0.25f; }
        if (rb.mass == 0) { rb.mass = 10; }
        player_radius = (float)transform.localScale[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (is_jump == false)
        {
            if (Input.GetKey("a"))
            {
                rb.AddForce(Vector3.left * force_coef * (float)Math.Sqrt(player_radius));
            }
            else if (Input.GetKey("d"))
            {
                rb.AddForce(Vector3.right * force_coef * (float)Math.Sqrt(player_radius));
            }
            else if (Input.GetKey("w"))
            {
                rb.AddForce(Vector3.forward * force_coef * (float)Math.Sqrt(player_radius));
            }
            else if (Input.GetKey("s"))
            {
                rb.AddForce(Vector3.back * force_coef * (float)Math.Sqrt(player_radius));
            }

            if (Input.GetKeyDown("space"))
            {

                is_jump = true;
                rb.AddForce(Vector3.up * force_coef * 200);
            }
        }

        if (Input.GetKeyDown("r"))
        {
            change_radius(0.2f);
        }
        else if (Input.GetKeyDown("f"))
        {
            change_radius(-0.2f);
        }
    }

    public void change_radius(float amount)
    {
        if(player_radius + amount < 0.1)
        {
            return;
        }
        player_radius += amount;
        transform.localScale = new Vector3(player_radius, player_radius, player_radius);
        Debug.Log(player_radius);
       /* float scale = transform.localScale[0];
        Vector3 pos = transform.position;
        pos[1] += scale / 2;
        transform.position = pos;*/
        rb.mass += amount / density;
    }

    private void OnCollisionEnter(Collision other)
    {
        is_jump = false;
    }

}
