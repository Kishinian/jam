using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player: MonoBehaviour
{
    private new Vector2 targetPos;
    public float Yincrement;

    public float speed;
    public float minHeight;
    public float maxHeight;

    
    private void Update()

    {
        

        if (Input.GetKeyDown(KeyCode.W) && transform.position.y < maxHeight) 
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            transform.position = targetPos;
        }

        else if (Input.GetKeyDown(KeyCode.S) && transform.position.y > minHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            transform.position = targetPos;
        }
    }
}
