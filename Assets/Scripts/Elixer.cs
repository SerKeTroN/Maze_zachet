using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elixer : MonoBehaviour {

    public void OnTriggerEnter()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
