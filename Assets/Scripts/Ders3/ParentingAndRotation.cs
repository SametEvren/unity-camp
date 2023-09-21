using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentingAndRotation : MonoBehaviour
{
    public Transform medeaTransform;
    public float speed;
    private void Start()
    {
        medeaTransform.parent = transform;
    }

    private void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * 180, Space.World);
        transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.World);
        
        if(Input.GetKeyDown(KeyCode.Space))
            medeaTransform.localPosition = Vector3.zero;
        if(Input.GetKeyDown(KeyCode.H))
            medeaTransform.position = Vector3.zero;
    }
}
