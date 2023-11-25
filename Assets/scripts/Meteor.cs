using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public float speed = 5f; // �������� �������� �����������

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime); // �������� ����������� ������
    }
    // �������� ������������ � �������
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // ���������� �������� �������� �����������
            speed *= 0.8f;
            Destroy(gameObject);
        }
    }

}