using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{


    private void Update()
    {
        if (gameObject.GetComponent<EnemyAI>().health <= 0)
            SceneManager.LoadScene(0);
    }
}
