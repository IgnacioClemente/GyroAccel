using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiroAccel : MonoBehaviour
{

    void Update()
    {
        transform.Translate(Input.acceleration.x / 3, 0, -Input.acceleration.z / 3);
    }
}
