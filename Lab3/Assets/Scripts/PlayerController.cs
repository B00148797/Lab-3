using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 10.0f;
    private Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.right * speed * horizontalInput);
        playerRb.AddForce(Vector3.forward * speed * verticalInput);

        if (this.transform.position.z >= 8.5)
        {
            transform.position = new Vector3(this.transform.position.x, 0.5f, -4f);
        }
        else if (this.transform.position.z <= -4)
        {
            transform.position = new Vector3(this.transform.position.x, 0.5f, 8.5f);
        }
    }
}
