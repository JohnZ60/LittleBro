using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if ((gameObject.transform.position.x) - (player.gameObject.transform.position.x) <= 50f)
        {
            GameObject newEnemy = Instantiate(enemy, gameObject.transform.position, Quaternion.identity);
            newEnemy.gameObject.GetComponent<EnemyAI>().target = player.transform;
            Destroy(gameObject);
        }
    }
}
