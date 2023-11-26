using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player: MonoBehaviour
{
    public new Vector2 targetPos;
    public float Yincrement;

    public float speed;
    public float minHeight;
    public float maxHeight;

    public int health = 5;
    public Text healthDisplay;
    

    private void Update()

    {
        healthDisplay.text = health.ToString();
        if (health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.W) && transform.position.y < maxHeight) 
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            
        }

        else if (Input.GetKeyDown(KeyCode.S) && transform.position.y > minHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            
        }
    }
}
