using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTrigger2T : MonoBehaviour
{
    public GameObject triggerObject2T;
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            if (triggerObject2T.GetComponent<Doortest1S>().open == true)
                triggerObject2T.GetComponent<Doortest1S>().Activate();
        }
    }
}