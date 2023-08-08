using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy : MonoBehaviour
{
    public float speed = 3f;
    public float timeLimit = 1f; 
    private float timer = 0f; 
    private int direction = 1;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "iguana")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void Update()
    {
        timer += Time.deltaTime; 
        if (timer >= timeLimit) 
        {
            ChangeDirection();
            timer = 0f; 
        }
        transform.Translate(Vector2.right * direction * speed * Time.deltaTime); 
    }

    void ChangeDirection()
    {
        direction *= -1; 
    }
}
