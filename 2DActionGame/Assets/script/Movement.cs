using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private VariableJoystick variableJoystick;
    [SerializeField] private float movementSpeed = 10f;
    void Update() {
        Vector2 movementDirection = new Vector2(
            Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        movementDirection = variableJoystick.Direction;

        transform.Translate(movementDirection * movementSpeed * Time.deltaTime);
    }
}
