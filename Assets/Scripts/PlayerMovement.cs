using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector3 _moveDirection;

    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        InputManager.Init(this);
        InputManager.SetGameControls();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * Time.deltaTime * _moveDirection;

        
    }
    public void SetMovementDirection(Vector3 currentDirection)
    {
        _moveDirection = currentDirection;
    }
}
