using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTriggerS2 : MonoBehaviour
{
    public GameObject triggerObjectb;
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            if (triggerObjectb.GetComponent<Doortest2>().open == true)
                triggerObjectb.GetComponent<Doortest2>().Activate();
        }
    }
}