using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO.Ports;

public class ZonaF : MonoBehaviour
{
    public SerialPort serialPort = new SerialPort("COM1", 9600);
    public GameObject referenciaMensaje;
    public Canvas Canva;
    public Image[] image;
    public int v = 0;
     
    private void Start()
    {
        serialPort.Open();
        serialPort.ReadTimeout = 1;
        image[0].enabled = false;
        image[1].enabled = false;
        image[2].enabled = false;
        image[3].enabled = false;
        image[4].enabled = false;
        image[5].enabled = false;
        image[6].enabled = false;
        image[7].enabled = false;
        image[8].enabled = false;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "ZonaVestier")
        {
            Debug.Log("Entro a la zona de vestier");
            referenciaMensaje.active = false;
            image[8].enabled = true;

        }

        if (other.name == "ZonaHombres")
        {
            Debug.Log("Entro a la zona de Hombres");
            referenciaMensaje.active = false;
            image[2].enabled = true;

        }

        if (other.name == "ZonaMujeres")
        {
            Debug.Log("Entro a la zona de Mujeres");
            referenciaMensaje.active = false;
            image[3].enabled = true;

        }
        if (other.name == "ZonaCaja")
        {
            Debug.Log("Entro a la zona de Caja");
            referenciaMensaje.active = false;

            image[1].enabled = true;

        }
        if (other.name == "ZonaTest")
        {
            Debug.Log("Entro a la zona de Test");
            referenciaMensaje.active = false;
            v = 1;
            image[5].enabled = true;
        }
    }
    void Update()
    {
        if (v == 1)
        {

            if (serialPort.IsOpen)
            {
                if (serialPort.ReadLine() == "1")
                {
                    image[5].enabled = false;
                    image[4].enabled = true;
                    v = 0;
                    ;
                }
                if (serialPort.ReadLine() == "2")
                {
                    image[5].enabled = false;
                    image[6].enabled = true;
                    v = 2;
                    ;
                }

                if (serialPort.ReadLine() == "3")
                {
                    image[5].enabled = false;
                    image[4].enabled = true;
                    v = 0;
                    ;
                }

            }
        }
        if (v == 2)
        {
            if (serialPort.IsOpen)
            {
                if (serialPort.ReadLine() == "1")
                {
                    image[6].enabled = false;
                    image[4].enabled = true;
                    v = 0;
                    ;
                }

                if (serialPort.ReadLine() == "2")
                {
                    image[6].enabled = false;
                    image[4].enabled = true;
                    v = 0;
                    ;
                }

                if (serialPort.ReadLine() == "3")
                {
                    image[6].enabled = false;
                    image[7].enabled = true;
                    v = 3;
                    ;
                }
            }
        }
        if (v == 3)
        {
            if (serialPort.IsOpen)
            {
                if (serialPort.ReadLine() == "1")
                {
                    image[7].enabled = false;
                    image[4].enabled = true;
                    v = 0;
                    ;
                }

                if (serialPort.ReadLine() == "2")
                {
                    image[7].enabled = false;
                    image[4].enabled = true;
                    v = 0;
                    ;
                }

                if (serialPort.ReadLine() == "3")
                {
                    image[5].enabled = false;
                    image[1].enabled = true;
                    v = 0;
                    ;
                }
            }
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.name == "ZonaTest" || other.name == "ZonaCaja" || other.name == "ZonaMujeres" || other.name == "ZonaHombres" || other.name == "ZonaVestier" ) {
            Debug.Log("salio a la zona de cajones!");
            referenciaMensaje.active = false;
            image[0].enabled = false;
            image[1].enabled = false;
            image[2].enabled = false;
            image[3].enabled = false;
            image[4].enabled = false;
            image[5].enabled = false;
            image[6].enabled = false;
            image[7].enabled = false;
            image[8].enabled = false;
        }
    }
}
