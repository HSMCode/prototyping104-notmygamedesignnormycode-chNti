using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    public GameObject RB;
    private Transform target; 

    private Vector3 offset = new Vector3(0f,0f,-15f);

    // Start is called before the first frame update
    void Start()
    {
        target = RB.transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
       // transform.position = car.transform.position + offset;

       // set camera to the position of car with offset, converted to world space
        transform.position = target.TransformPoint(offset);

        // Look at our cars transform position
        transform.LookAt(target);
    }
}