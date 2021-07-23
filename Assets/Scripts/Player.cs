using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int movementSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector2 pos = transform.position;
            transform.position = new Vector2(pos.x, pos.y + (movementSpeed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.S))
        {
            Vector2 pos = transform.position;
            transform.position = new Vector2(pos.x, pos.y - (movementSpeed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.A))
        {
            Vector2 pos = transform.position;
            transform.position = new Vector2(pos.x - (movementSpeed * Time.deltaTime), pos.y);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Vector2 pos = transform.position;
            transform.position = new Vector2(pos.x + (movementSpeed * Time.deltaTime), pos.y);
        }
    }
}
