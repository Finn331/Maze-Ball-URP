using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInstantiate : MonoBehaviour
{
    public GameObject ball;
    public Transform initialPos;
    
    // Start is called before the first frame update
    void Start()
    {
        Vector2 newPos = new Vector2 (initialPos.position.x, initialPos.position.y);
        //initialPos.transform.position = newPos;
        Instantiate(ball, newPos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
