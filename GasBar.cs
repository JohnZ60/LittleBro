using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GasBar : MonoBehaviour
{
    public static float Gas;
    private float maxGas = 400f;
    private Image gasBar;
    
    void Start()
    {
        gasBar = GetComponent<Image>();
        Gas = maxGas;
    }

    private void Update()
    {
        gasBar.fillAmount = Gas / maxGas;
    }

    private void FixedUpdate()
    {
        if (Gas < maxGas)
        {
            Gas++;
        }
    }
}
