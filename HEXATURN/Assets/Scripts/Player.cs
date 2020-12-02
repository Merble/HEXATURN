using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float moveSpeed = 600f;
    float movement = 0f;
    public static int life = 3;

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.deltaTime * -moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        life -=1 ;
        if (life <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}
