using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public GameObject meteor;
    private void Start()
    {
        Instantiate(meteor, transform.position, Quaternion.identity);
    }
}
