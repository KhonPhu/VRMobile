﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTogether : MonoBehaviour
{
    public GameObject otherObject;
    public Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = new Vector3(transform.position.x, transform.position.y - 2.8f, transform.position.z);
        otherObject.transform.position = newPosition;
        Vector3 newRotation = new Vector3(0.0f, transform.eulerAngles.y, 0.0f);
        otherObject.transform.eulerAngles = newRotation;
    }
}
