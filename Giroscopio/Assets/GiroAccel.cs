using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiroAccel : MonoBehaviour
{
    public Text text;

    void Update()
    {
        transform.Translate(Input.acceleration.x / 4, 0, -Input.acceleration.z / 4);
        text.text = "Acelorometro habilitado = " + SystemInfo.supportsAccelerometer + " y su valor es: " + Input.acceleration;
    }
}
