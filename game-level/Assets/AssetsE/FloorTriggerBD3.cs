using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTriggerBD3: MonoBehaviour
{
    public GameObject triggerObjectTBD1;
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            if (triggerObjectTBD1.GetComponent<DoortestBD2>().open == true)
                triggerObjectTBD1.GetComponent<DoortestBD2>().Activate();
        }
    }
}
