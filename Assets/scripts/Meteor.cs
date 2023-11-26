using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public float speed = 5f; // Скорость движения препятствия

    public int damage = 1;

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime); // Движение препятствия вперед
    }
    // Проверка столкновения с игроком
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Уменьшение скорости движения препятствия
            other.GetComponent<Player>().health -= damage;
            Destroy(gameObject);
        }
    }

}