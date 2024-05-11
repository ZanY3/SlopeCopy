using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float movementSpeed = 1f;
    public float speed;
    [Space]
    public GameObject DieParticles;
    public GameObject loseScreen;
    public AudioClip dieSound;
    public AudioSource source;
    Animator animator;
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        print(rb.velocity);
       if(rb.velocity.magnitude < 23 )
       {
           rb.AddForce(Vector3.forward * speed * Time.deltaTime);
       }
       if(Input.GetKey(KeyCode.A))
       {
           rb.AddForce(Vector3.left * movementSpeed);
       }
       if(Input.GetKey(KeyCode.D))
       {
           rb.AddForce(Vector3.right * movementSpeed);
       }
       if(rb.velocity.y <= -80)
       {
            Die();
       }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Die();
        }
    }
    public async void Die()
    {
        source.PlayOneShot(dieSound);
        Instantiate(DieParticles, transform.position, Quaternion.identity);
        rb.isKinematic = true;
        Destroy(gameObject);
        await new WaitForSeconds(1);
        loseScreen.SetActive(true);
        Time.timeScale = 0f;

    }
}
