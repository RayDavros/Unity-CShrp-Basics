using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{

    [SerializeField] private float speed;
    private Vector3 MoveDirection;
    private bool isSprint;
    private Rigidbody RBD;

    // Start is called before the first frame update
    void Start()
    {
        RBD = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isSprint = Input.GetButton("Sprint");
    }
    private void Update()
    {
        Movement();

    }
    private void Movement()
    {
        float moveX = 0f;
        float moveY = 0f;
        float moveZ = 0f;

        if (Input.GetButton("Forward"))
        {
            moveZ = +1f;
        }
        if (Input.GetButton("Back"))
        {
            moveZ = -1f;
        }
        if (Input.GetButton("Left"))
        {
            moveX = -1f;
        }
        if (Input.GetButton("Right"))
        {
            moveX = +1f;
        }

        Vector3 MoveDirection = new Vector3(moveX * speed, moveY * speed, moveZ * speed).normalized;
        float sprint = (isSprint) ? 2f : 1f;
        transform.Translate(MoveDirection.normalized * sprint * Time.fixedDeltaTime);
    }


}
