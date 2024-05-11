using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float movementSpeed = 1f;
    public float speed;
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
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
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene("Game");
        }
    }
    public void Die()
    {

    }
}
