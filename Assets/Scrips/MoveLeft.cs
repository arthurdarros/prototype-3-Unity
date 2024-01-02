using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [Header("Movement Parameters")]
    [SerializeField] private float speed = 30;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
