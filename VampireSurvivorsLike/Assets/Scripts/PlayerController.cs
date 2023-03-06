using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] int _speed;

    private Vector2 movement;
    private Rigidbody2D rb2D;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        rb2D.AddForce(movement * _speed * Time.deltaTime);
    }

    public void OnMove(InputValue value) => movement = value.Get<Vector2>();
}
