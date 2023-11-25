using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public float speed = 5f; // Скорость движения препятствия

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime); // Движение препятствия вперед
    }
    // Проверка столкновения с игроком
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Уменьшение скорости движения препятствия
            speed *= 0.8f;
            Destroy(gameObject);
        }
    }

}