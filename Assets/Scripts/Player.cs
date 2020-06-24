using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float maxSpeed = 5;
    [SerializeField] private float acceleration = 5;

    [SerializeField] private BoxCollider2D frontCollider;

    private float currentSpeed = 0;
    

    void Update()
    {
        Vector3 direction = directionalInput();

        currentSpeed += acceleration * Time.deltaTime;

        Mathf.Clamp(currentSpeed, 0, maxSpeed);
        transform.position += direction * currentSpeed;
    }

    Vector3 directionalInput()
    {
        Vector3 direction = new Vector3(0, 0, 0);

        bool front = Input.GetKey(KeyCode.W);
        bool left = Input.GetKey(KeyCode.A);
        bool behind = Input.GetKey(KeyCode.S);
        bool right = Input.GetKey(KeyCode.D);

        if (front) direction.y += 1;
        if (left) direction.x -= 1;
        if (behind) direction.y -= 1;
        if (right) direction.x += 1;

        return direction;
    }
}
