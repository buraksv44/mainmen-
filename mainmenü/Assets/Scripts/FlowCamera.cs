using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowCamera : MonoBehaviour
{
    float speed = 5;
    float Scorllspeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       gameObject.transform.position = Vector3.right;
       
        
        
        if (Input.GetMouseButton(1))
        {
            transform.eulerAngles += speed * new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0);
        }
        if (Camera.main.orthographic)
        {
            Camera.main.orthographicSize -= Input.GetAxis("Mouse ScrollWheel") * Scorllspeed;
        }
        else
        {
            Camera.main.fieldOfView -= Input.GetAxis("Mouse ScrollWheel") * Scorllspeed;
        }
    }
}
