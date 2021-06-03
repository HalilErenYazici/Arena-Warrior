using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator playerAnimator;
    Animator animator;
    
    public float enemySpeed;
    public Transform player;

    public ScoreCounter scoreCounter;

    public GameObject dieScreen;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, enemySpeed * Time.deltaTime);
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            animator.SetTrigger("enemyAttacking");
            playerAnimator.SetBool("die",true);
            dieScreen.SetActive(true);
        }

        if (collision.gameObject.tag == "Sword")
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject, 5f);
        animator.SetBool("isDie",true);
        scoreCounter.Score += 10;
    }

}
