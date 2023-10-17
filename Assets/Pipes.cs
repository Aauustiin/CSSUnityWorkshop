using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var rigidbody2d = GetComponent<Rigidbody2D>();
        rigidbody2d.AddForce(new Vector2(-10, 0), ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        var scoreText = GameObject.Find("Canvas/ScoreText").GetComponent<TextMeshProUGUI>();
        var tokens = scoreText.text.Split(' ');
        var score = Int32.Parse(tokens[1]);
        score++;
        scoreText.text = "Score: " + score;
    }
}
