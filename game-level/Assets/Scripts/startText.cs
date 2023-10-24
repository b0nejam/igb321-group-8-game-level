using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startText : MonoBehaviour
{
    void OnEnable()
    {
        // load Level 1 scene after intro text
        SceneManager.LoadScene("Level 1", LoadSceneMode.Single);
    }

}
