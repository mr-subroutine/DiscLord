using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 direction = new Vector3(horizontalInput, 0, 0);
        transform.Translate(direction * _speed * Time.deltaTime);
        Debug.Log(transform.position);

        if (transform.position.x < -3.1f)
        {
            transform.position = new Vector3(-3.1f, transform.position.y, 0);
        }

        if (transform.position.x > 3.1f)
        {
            transform.position = new Vector3(3.1f, transform.position.y, 0);
        }
    }
}
