using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneMusic : MonoBehaviour
{
    private static NextSceneMusic instance = null;
    public static NextSceneMusic Instance
    {
        get { return instance; }
    }
    // Update is called once per frame
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 6)
        {
            gameObject.GetComponent<AudioSource>().Stop();
        }
    }
}
