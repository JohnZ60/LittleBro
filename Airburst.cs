using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Airburst : MonoBehaviour
{
    public Transform player;
    public float shotForce;
    Rigidbody2D rb;
    public Vector3 shotDirection;
    private Plane plane = new Plane(Vector3.up, Vector3.zero);
    public float max;
    public float velocity;

    //variables for meter
    public Image gasBar;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    // build up a force that is to be applied to the player when the mouse is held down
    private void Update()
    {
        velocity = rb.velocity.magnitude;
        if (velocity >= 90)
        {

        }
        if (Input.GetMouseButton(1))
        {
            shotForce += 5;
        }
        else if (Input.GetMouseButtonUp(1))
        {

            shotDirection = Input.mousePosition;
            shotDirection.z = 0.0f;
            shotDirection = Camera.main.ScreenToWorldPoint(shotDirection);
            shotDirection = shotDirection - transform.position;
            if (Mathf.Clamp(shotForce, 0f, max) <= GasBar.Gas)
            {
                rb.AddForce(-shotDirection.normalized * 30f * Mathf.Clamp(shotForce, 0f, max));
                GasBar.Gas -= Mathf.Clamp(shotForce, 0f, max);
                shotForce = 0f;
            }
            else
            {
                rb.AddForce(-shotDirection.normalized * 30f * (Mathf.Clamp(shotForce, 0f, max) - GasBar.Gas));
                GasBar.Gas = 0;
                shotForce = 0f;
            }
        }
    }


    // TODO: apply that force to player when mouse is released.

    // TODO: apply the force in the direction of the mouse position.



    /*    METER SYSTEM FOR AIRBURST     */

    /* save some information about the force
        - level of damage that has been achieved , determnined by how long mouse was held down. We use this to see if we can kill what we collide with.
        - any collisions that happen with projectiles that we collide with. A projectile will be worth a least one bar of meter.
    */





}
