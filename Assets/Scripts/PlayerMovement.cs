using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    Rigidbody player;

    [SerializeField]
    float movementSpeed = 7f;

    // Update is called once per frame
    void Update()
    {
        float horizontalAxis = Input.GetAxis("Horizontal");
        float verticalAxis = Input.GetAxis("Vertical");

        player.velocity = new Vector3(verticalAxis * movementSpeed, player.velocity.y, horizontalAxis * movementSpeed);
    }
}
