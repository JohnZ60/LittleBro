using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public static float Health;
    private float maxHealth = 100f;
    private Image healthBar;
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<Image>();
        Health = maxHealth;
    }

    private void Update()
    {
        Health = player.gameObject.GetComponent<PlayerController>().getHealth();
        healthBar.fillAmount = Health / maxHealth;
    }

    
}
