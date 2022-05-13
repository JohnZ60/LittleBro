using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackUp : MonoBehaviour
{
    public int ap;

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
        //Debug.Log("AttackUp Hit By: " + other.gameObject.name);
        if (other.gameObject.CompareTag("PlayerHitBox"))
        {
            if (other.gameObject.transform.parent.gameObject.GetComponent<PlayerController>().getHealth() > 0)
            {
                other.gameObject.transform.parent.gameObject.GetComponent<PlayerController>().upAttackPower(ap);
                Destroy(gameObject);
                Debug.Log("Player Attack: " + other.gameObject.transform.parent.gameObject.GetComponent<PlayerController>().getAttackPower());
            }
        }
    }

}
