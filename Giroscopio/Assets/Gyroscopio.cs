using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gyroscopio : MonoBehaviour
{
    GameObject MainCamera;
    private Gyroscope m_Gyro;

    void Start()
    {
        MainCamera = Camera.main.gameObject;

        if(SystemInfo.supportsGyroscope)
        {
            m_Gyro = Input.gyro;
            m_Gyro.enabled = true;
        }
    }

    void Gyro()
    {
        MainCamera.transform.rotation = new Quaternion(0, -m_Gyro.rotationRateUnbiased.y / 2, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Gyro();
    }
}
