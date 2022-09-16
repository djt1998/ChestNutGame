using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable_revers : MonoBehaviour
{
    public Rigidbody player;
    public Transform player_t;
    public Transform item;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        item.transform.Rotate(0.0f, 0.05f, 0.0f, Space.Self);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.name == "Player"){
            Debug.Log("Trigger");
            Destroy(this.gameObject);

            player.mass /= 2;
            other.transform.localScale /= (float)1.25;
            float scale = other.transform.localScale[0];
            Vector3 pos = other.transform.position;
            pos[1] = scale / 2;

            other.transform.position = pos;


            Debug.Log(scale);

            // other.gameObject.transform.localScale = new Vector3(1,1,1);
        }
    }
}
