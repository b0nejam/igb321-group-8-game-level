using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTriggerR1 : MonoBehaviour
{
    public GameObject triggerObject3;
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            if (triggerObject3.GetComponent<Doortest1>().open == true)
                triggerObject3.GetComponent<Doortest1>().Activate();
        }
    }
}