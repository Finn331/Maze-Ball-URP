using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MazeMovement : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;

    private bool isMovingLeft = false;
    private bool isMovingRight = false;

    private void Update()
    {
        if (isMovingLeft)
        {
            MoveLeft();
        }
        if (isMovingRight)
        {
            MoveRight();
        }
    }

    private void MoveLeft()
    {
        transform.Rotate(0, 0, Time.deltaTime * rotationSpeed);
    }

    private void MoveRight()
    {
        transform.Rotate(0, 0, -Time.deltaTime * rotationSpeed);
    }

    // event trigger function ketika tombol ditekan
    public void OnLeftButtonDown() => isMovingLeft = true;
    public void OnRightButtonDown() => isMovingRight = true;

    public void OnButtonUp()
    {
        isMovingLeft = false;
        isMovingRight = false;
    }
}

