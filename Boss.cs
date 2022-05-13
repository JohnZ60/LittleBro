using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{


    public Transform spawnPoint;
    public GameObject spawner;
    
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            Instantiate(spawner, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
