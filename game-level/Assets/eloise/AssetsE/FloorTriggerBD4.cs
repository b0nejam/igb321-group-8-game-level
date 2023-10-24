using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTriggerBD4: MonoBehaviour
{
    public GameObject triggerObjectTBD2;
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            if (triggerObjectTBD2.GetComponent<DoortestBD2>().open == false)
                triggerObjectTBD2.GetComponent<DoortestBD2>().Activate();
        }
    }
}
