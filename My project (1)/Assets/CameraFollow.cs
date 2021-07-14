using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Camera;
    public float PlayerSpeed = 10;
    public float CameraFollowSpeed;
    private Vector3 CamOffset;

    // Start is called before the first frame update
    void Start()
    {
        CamOffset = Camera.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Camera.transform.position = Vector3.Lerp(Camera.transform.position, transform.position + CamOffset, Time.smoothDeltaTime * CameraFollowSpeed);
    }
}
