using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zappar;

public class AR : MonoBehaviour
{
    public ZapparInstantTrackingTarget instantTrackingTarget;
    private bool hasPlacedModel = false; // Variable para controlar que solo se coloque una vez

    void Update()
    {
        // Si no hemos colocado el modelo y se detecta un toque en la pantalla
        if (!hasPlacedModel && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            // Llamar a PlaceInModel solo una vez
            PlaceModel();
        }
    }

    void PlaceModel()
    {
        // Desactivar el seguimiento una vez que se ha colocado el modelo
        instantTrackingTarget.PlaceTrackerAnchor();

        // Marcar que el modelo ya fue colocado para no hacerlo de nuevo
        hasPlacedModel = true;
    }
}
