using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    private void OnCollisionEnter(Collision collision)
    {
        hits++;
        Debug.Log("You've bumped into a wall this many times: " + hits);
    }

}
