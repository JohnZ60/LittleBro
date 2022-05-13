using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = this.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.name + " " + other.gameObject.tag);
        if (other.gameObject.CompareTag("Enemy") )
        {
            //Debug.Log("Eneny: " + other.gameObject.transform.parent.gameObject.name + "Player: " + Player.gameObject.name);
            int playerAP = Player.GetComponent<PlayerController>().getAttackPower();
            other.gameObject.GetComponent<EnemyAI>().damageEnemy(playerAP);
            Debug.Log("Enemy Health: " + other.gameObject.GetComponent<EnemyAI>().getHealth());
            if (other.gameObject.GetComponent<EnemyAI>().getHealth() <= 0)
            {
                Player.GetComponent<PlayerController>().addPoints(other.gameObject.GetComponent<EnemyAI>().reward);
                Debug.Log("Points: " + Player.GetComponent<PlayerController>().points );
            }
        }
    }
}
