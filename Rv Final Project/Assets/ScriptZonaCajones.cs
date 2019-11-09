using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptZonaCajones : MonoBehaviour
{
    public GameObject referenciaMensaje;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "PlayerController") {
            Debug.Log("Entro a la zona de cajones!");
            referenciaMensaje.active = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.name == "PlayerController") {
            Debug.Log("salio a la zona de cajones!");
            referenciaMensaje.active = false;
        }
    }
}
