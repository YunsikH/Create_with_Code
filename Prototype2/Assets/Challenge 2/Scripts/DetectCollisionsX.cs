using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        Destroy(gameObject);
    }
}
