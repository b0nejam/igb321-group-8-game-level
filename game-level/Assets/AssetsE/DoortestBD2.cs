using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoortestBD2 : MonoBehaviour
{
    public bool open = false;
    // Use this for initialization
    void Start()
    {
        GetComponent<Animation>();
    }
    // Update is called once per frame
    public void Activate()
    {
        //If not playing an animation
        if (!GetComponent<Animation>().isPlaying)
        {
            //If closed, open
            if (!open)
            {
                GetComponent<Animation>().Play("bigD2open");
                open = true;
            }
            //Otherwise if open, close
            else if (open)
            {
                GetComponent<Animation>().Play("bigD2close");
                open = false;
            }
        }
    }
}
