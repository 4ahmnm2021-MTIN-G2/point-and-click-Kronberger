using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    
    public Transform thisTransform;
    public Vector3 mousePos;
    public Vector3 worldPos;
    public Vector3 playerPos;
    public float speed = 0.2f;

    void Start()
    {
        playerPos = thisTransform.position;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePos = Input.mousePosition;
            worldPos = Camera.main.ScreenToWorldPoint(mousePos);
            playerPos = new Vector3(worldPos.x, worldPos.y, thisTransform.position.z);
        }

        thisTransform.position = Vector3.MoveTowards(thisTransform.position, playerPos, speed);
    }

}
