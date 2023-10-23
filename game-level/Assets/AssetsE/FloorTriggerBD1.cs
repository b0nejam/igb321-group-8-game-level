using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTriggerBD1: MonoBehaviour
{
    public GameObject triggerObjectTBD;
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            if (triggerObjectTBD.GetComponent<Doortest1BD>().open == false)
                triggerObjectTBD.GetComponent<Doortest1BD>().Activate();
        }
    }
}
