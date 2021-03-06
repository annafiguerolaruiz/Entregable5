using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 8f;
    private float turnSpeed = 20f;
    private float verticalInput;
    private float zMax = 450f;

   //
    void Start()
    {
        transform.position = Vector3.zero;
    }

    // 
    void Update()
    {
        if (transform.position.z > zMax)
        {
            Debug.Log("GAME OVER");
            Time.timeScale = 0;
        }
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        transform.Rotate(Vector3.left, turnSpeed * Time.deltaTime * verticalInput);
    }
}
