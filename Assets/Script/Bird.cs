using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    public GameObject bird;
    public GameObject gameOverObj;
    public GameObject gamePlayObj;
    public GameObject gameMenuObj;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector3.up * speed;
        }
    }

    void GameOver()
    {
        Time.timeScale = 0;
        gameOverObj.SetActive(true);
        gamePlayObj.SetActive(true);
        gameMenuObj.SetActive(true);
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameOver();
    }


}
