using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform teleportPoint;
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Transform>().position = teleportPoint.position;


    }
}
