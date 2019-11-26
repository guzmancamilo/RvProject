using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class Arduino : MonoBehaviour
{
   public SerialPort serialPort = new SerialPort ("COM3",9600);
    void Start()
    {
        serialPort.Open();
        serialPort.ReadTimeout = 1;
    }

    // Update is called once per frame
    void Update()
    {
try
{
    if(serialPort.IsOpen){
        print(serialPort.ReadLine());
    }
}
catch (System.Exception ex)
{
    
    ex= new System.Exception();
}
    }
}
