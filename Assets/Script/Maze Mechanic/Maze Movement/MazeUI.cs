using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeUI : MonoBehaviour
{
    [SerializeField] private MazeMovement mazeMovement;

    private void Start()
    {
        
    }

    public void OnLeftButtonDown()
    {
        if (mazeMovement != null)
        {
            mazeMovement.OnLeftButtonDown();
        }
    }

    public void OnRightButtonDown()
    {
        if (mazeMovement != null)
        {
            mazeMovement.OnRightButtonDown();
        }
    }

    public void OnButtonUp()
    {
        if (mazeMovement != null)
        {
            mazeMovement.OnButtonUp();
        }
    }
}
