using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playercontrol : MonoBehaviour
{
    private new Vector2 targetpos;
    public float Yincrement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        if (Input.GetKey(KeyCode.W)) 
        {
            targetpos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            transform.position = targetpos;
        }

        else if (Input.GetKey(KeyCode.S))
        {
            targetpos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            transform.position = targetpos;
        }
    }
}
