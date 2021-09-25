using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10;
    float screenHalfWidth;
    // Start is called before the first frame update
    void Start()
    {
        float halfPlayerWidth = transform.localScale.x / 2f;
        screenHalfWidth = Camera.main.aspect * Camera.main.orthographicSize + halfPlayerWidth;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 input = new Vector3(input.GetAxisisRaw("Horizontal"), input.GetAxisisRaw("Vertical"), 0f);
        Vector3 direction = input.normalized;
        Vector3 velocity = speed * direction;
        Vector3 moveAmount = velocity * Time.deltaTime;

        transform.Translate(movement);

        if (transform.position.x < -screenHalfWidth)
        {
            transform.position = new Vector2(screenHalfWidth, transform.position.y);
        }
        else if (transfrom.position.x > screenHalfWidth)
        {
            transform.position = new Vector2(-screenHalfWidth, transform.position.y);
        }
    }

    void OnTriggerEnter2D(Collider2D triggerCollider)
    {
        Destroy(gameObject);
    }
}