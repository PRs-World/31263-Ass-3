using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{

    public float moveSpeed = 5.0f;
    private Vector3 targetPosition;
    private bool isMoving = false;

    // Start is called before the first frame update
    void Start()
    {
        targetPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isMoving) 
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            if(horizontalInput != 0f || verticalInput != 0f)
            {
                Vector3 inputDirection = new Vector3(horizontalInput, verticalInput, 0f);
                targetPosition = transform.position + inputDirection;
                StartCoroutine(MoveToPosition());
            }
        }
    }
    IEnumerator MoveToPosition()
    {
        isMoving = true;
        float travelLength = Vector3.Distance(transform.position, targetPosition);
        float startTime = Time.time;
        
        while(transform.position != targetPosition) 
        {
            float coveredGround = (Time.time - startTime) * moveSpeed;
            float groundFraction = coveredGround / travelLength;
            transform.position = Vector3.Lerp(transform.position, targetPosition, groundFraction);
            yield return null;
        }
        isMoving = false;
    }
}
