using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTrigger : MonoBehaviour
{
    public GameObject triggerObject;
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            if (triggerObject.GetComponent<Doortest>().open == false)
                triggerObject.GetComponent<Doortest>().Activate();
        }
    }
}
