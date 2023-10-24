using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTrigger2 : MonoBehaviour
{
    public GameObject triggerObject2;
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            if (triggerObject2.GetComponent<Doortest>().open == true)
                triggerObject2.GetComponent<Doortest>().Activate();
        }
    }
}