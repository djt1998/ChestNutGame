using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area : MonoBehaviour
{
    // Start is called before the first frame update
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

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "Player")
        {
            Debug.Log("Area Effected");
            player.change_radius(ratio * Time.deltaTime);
        }
    }
}
