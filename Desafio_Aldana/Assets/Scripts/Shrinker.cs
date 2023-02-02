using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrinker : MonoBehaviour
{
    [SerializeField] private float currentTime;
    [SerializeField] private float timeToReset = 0.5f;

    //Activar el trigger desde el inspector para que se cambien los tamaños

    [SerializeField] private bool portalIsTrigger;
    private void OnTriggerEnter(Collider other)
    {
        var harryController = other.GetComponent<HarryController>();
        if (portalIsTrigger)
        {
            if (currentTime <= Time.time && harryController != null)
            {
                currentTime = Time.time + timeToReset;
                harryController.ReduceSize();
            }
        }
        
        else 
        {
            if (!portalIsTrigger)
            {
                if (currentTime <= Time.time && harryController != null)
                {
                    currentTime = Time.time + timeToReset;
                    harryController.BackToOgSize();
                }
            }

            
        }
        
    }

}
