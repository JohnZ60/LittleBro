using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealUp : MonoBehaviour
{
    public int heal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PlayerHitBox"))
        {
            if(other.gameObject.transform.parent.gameObject.GetComponent<PlayerController>().getHealth() < 100)
            {
                other.gameObject.transform.parent.gameObject.GetComponent<PlayerController>().healPlayer(heal);
                Destroy(gameObject);
                Debug.Log("Player Health: " + other.gameObject.transform.parent.gameObject.GetComponent<PlayerController>().getHealth());
            }
        }
    }


}
