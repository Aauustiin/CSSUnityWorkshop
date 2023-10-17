using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] GameObject gameOverScreen;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var rigidbody2d = GetComponent<Rigidbody2D>();
            rigidbody2d.AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        Time.timeScale = 0;
        gameOverScreen.SetActive(true);
    }
}
