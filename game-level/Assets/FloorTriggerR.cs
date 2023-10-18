using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTriggerR : MonoBehaviour
{
    public GameObject triggerObject4;
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            if (triggerObject4.GetComponent<Doortest1>().open == false)
                triggerObject4.GetComponent<Doortest1>().Activate();
        }
    }
}
