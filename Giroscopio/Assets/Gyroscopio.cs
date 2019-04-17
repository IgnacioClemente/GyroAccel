using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gyroscopio : MonoBehaviour
{
    public Text text;
    private Gyroscope m_Gyro;

    void Start()
    {
        if(SystemInfo.supportsGyroscope)
        {
            m_Gyro = Input.gyro;
            m_Gyro.enabled = true;
        }
        Input.compass.enabled = true;
    }

    void Gyro()
    {
        if (m_Gyro == null) return;
        if(Input.compass.enabled) transform.rotation = m_Gyro.attitude;
        text.text = "Giroscopio habilitado = " + SystemInfo.supportsGyroscope + " y su valor es: " + m_Gyro.attitude;
    }

    // Update is called once per frame
    void Update()
    {
        Gyro();
    }
}
