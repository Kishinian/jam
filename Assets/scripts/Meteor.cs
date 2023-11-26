using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public float speed = 5f; // �������� �������� �����������

    public int damage = 1;

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime); // �������� ����������� ������
    }
    // �������� ������������ � �������
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // ���������� �������� �������� �����������
            other.GetComponent<Player>().health -= damage;
            Destroy(gameObject);
        }
    }

}