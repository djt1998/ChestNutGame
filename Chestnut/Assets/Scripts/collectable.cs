using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : MonoBehaviour
{
    public Transform item;
    private Player player;
    public float ratio;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if(item != null)
        {
            item.transform.Rotate(0.0f, 0.05f, 0.0f, Space.Self);
        }
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.name == "Player"){
            Debug.Log("Trigger");
            Destroy(this.gameObject);
            player.change_radius(ratio);
            // other.gameObject.transform.localScale = new Vector3(1,1,1);
        }
    }
}
