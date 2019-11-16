using UnityEngine;
using System.Collections;

public class PatronAccion : MonoBehaviour
{
    // Public variables
    public GameObject ObjetoActivador;
   
    public float TiempoDespuesDeAccion;
    // Private variables
    
    private float timeToEnd;
    private bool workDone;
    

    void Start()
    {
        // Justo al inicio deshabilitamos el script (será activado por el script 
        // 'ComportamientoPatron.cs' cuando el objeto activador llegue al hito)
        this.enabled = false;
        
        timeToEnd = 0;
        workDone = false;

    }


    void Update()
    {
        if (!workDone)
        {
           


            // No realizamos la acción hasta que no pase el tiempo 'TiempoAntesDeAccion'
            //timeToStart >= TiempoAntesDeAccion
            if (Input.GetKey(KeyCode.W))
            {
                // IMPLEMENTACIÓN DE LA ACCIÓN...
                // ...
                   

                workDone = true;
            }
        }
        else
        {
            timeToEnd += Time.deltaTime;

            //No avanzamos al siguiente hito hasta que no pase el tiempo 'TiempoDespuesDeAccion'
            if (timeToEnd >= TiempoDespuesDeAccion)
            {
                // Se inicializa el script
                Start();

                // Indicamos que se puede pasar el siguiente hito
                ObjetoActivador.GetComponentInParent<ComportamientoPatron>().CanGoToNextMilestone = true;
            }
        }
    }



}