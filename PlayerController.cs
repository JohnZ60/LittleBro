using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animator;
    private float attackTimer = 0f;

    public int health = 100;
    public int attackPower = 20;
    public int points = 0;
    public bool ascended = false;
    public GameObject ascendedHitbox;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    bool isAttacking = false;
    SpriteRenderer rend;
    Color original;
    BoxCollider coll;


    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rend = GetComponent<SpriteRenderer>();
        original = rend.color;
        coll = GetComponent<BoxCollider>();
    }
    // Update is called once per frame
    void Update()
    {
        health = getHealth();

        if (health <=0)
        {
            //go to gameover screen
            SceneManager.LoadScene(0);
        }
        
        if (rb.velocity.magnitude >= 90)
        {
            rend.color = Color.blue;
            ascended = true;
        }
        else
        {
            rend.color = original;
            ascended = false;
        }

        if (ascended)
        {
            ascendedHitbox.SetActive(true);
        }
        else
        {
            ascendedHitbox.SetActive(false);
        }

        

        //Debug.Log(gameObject.transform.position.y);

        if (gameObject.transform.position.y < -150f)
        {
            Debug.Log("Player Fell");
            damagePlayer(30);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        // Name of our parameter we created in the animator.
        // Mathf.abs is to get the absolute value. We need a positive value for horizontalMove, so this is necessary.
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }


        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            animator.SetTrigger("IsAttacking");
            animator.SetInteger("AttackType", Random.Range(1, 4));
        }

        if (animator.GetCurrentAnimatorStateInfo(0).IsTag("Base Layer") && Input.GetButtonDown("Fire1"))
        {
            animator.SetBool("IsJumping", false);
            animator.SetTrigger("IsAttacking");
           // animator.SetBool("IsJumping", true);
        }
    }

    public void onLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    public void onCrouching(bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }

    void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
    

    public int getHealth()
    {
        return health;
    }

    public void healPlayer(int heal)
    {
        health += heal;
    }

    public void damagePlayer(int damage)
    {
        if (ascended)
            return;
        animator.SetTrigger("IsHurt");
        health = health - damage;
    }

    public void setAttackPower(int ap)
    {
        attackPower = ap;
    }

    public void upAttackPower(int ap)
    {
        attackPower += ap;
    }

    public int getAttackPower()
    {
        return attackPower;
    }

    public void addPoints(int point)
    {
        points = points + point;
    }

    void AirburstAnimation()
    {
        
    }



    


}
