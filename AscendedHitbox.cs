using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AscendedHitbox : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = this.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
           
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {

            collision.gameObject.GetComponent<EnemyAI>().damageEnemy(50);
        }
    }
}
