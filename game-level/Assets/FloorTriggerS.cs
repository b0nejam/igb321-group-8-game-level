using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTriggerS : MonoBehaviour
{
    public GameObject triggerObjecta;
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            if (triggerObjecta.GetComponent<Doortest2>().open == false)
                triggerObjecta.GetComponent<Doortest2>().Activate();
        }
    }
}
