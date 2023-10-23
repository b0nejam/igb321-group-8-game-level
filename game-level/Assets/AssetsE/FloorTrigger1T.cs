using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTrigger1T : MonoBehaviour
{
    public GameObject triggerObjectT;
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            if (triggerObjectT.GetComponent<Doortest1S>().open == false)
                triggerObjectT.GetComponent<Doortest1S>().Activate();
        }
    }
}
