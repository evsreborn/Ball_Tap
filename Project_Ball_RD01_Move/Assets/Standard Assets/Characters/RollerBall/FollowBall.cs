using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBall : MonoBehaviour
{

    [Range(0.1f, 1.0f)]
    public float smooth;

    public Transform ballTransform;
    Vector3 _cameraOffset;

    public bool lookAtBall;

    // Start is called before the first frame update
    void Start()
    {
        _cameraOffset = transform.position - ballTransform.position;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPos = ballTransform.position + _cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPos, smooth);

        if(lookAtBall)
        {
            transform.LookAt(ballTransform);
        }
    }
}
