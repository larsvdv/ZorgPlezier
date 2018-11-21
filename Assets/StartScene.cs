using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour {

    public void LoadForestScene()
    {
        SceneManager.LoadScene("Demo");
    }

    public void LoadBeachScene()
    {
        SceneManager.LoadScene("Strand");
    }


}
