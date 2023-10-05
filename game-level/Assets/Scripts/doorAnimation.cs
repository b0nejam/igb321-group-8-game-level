using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorAnimation : MonoBehaviour
{
    public bool open = false;
    Animation animation;

    public void Activate()
    {
        //If not playing an animation
        if (!animation.isPlaying)
        {
            //If closed, open
            if (!open)
            {
                animation.Play("door open");
                open = true;
            }
        }
    }
}
