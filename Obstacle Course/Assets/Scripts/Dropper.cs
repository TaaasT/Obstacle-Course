using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer mR;
    Rigidbody rB;
    [SerializeField] float timeToWait = 5f;

    void Start()
    {
        mR = GetComponent<MeshRenderer>();
        rB = GetComponent<Rigidbody>();
       
        mR.enabled = false;
        rB.useGravity = false;

    }
    void Update()
    {
        if (Time.time > timeToWait)
        {
            mR.enabled = true;
            rB.useGravity = true;
        }
    }

}
