using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour {

public Sprite forestBackground;
public Sprite beachBackground;
public Sprite castleBackground;
public GameObject image;

    public void LoadScene(string scene){
        SceneManager.LoadScene(scene);

        switch (scene)
      {
          case "Bos":
                image.GetComponent<Image>().sprite = forestBackground;
              break;
          case "Strand":
                image.GetComponent<Image>().sprite = beachBackground;
              break;
          case "Kasteel":
                image.GetComponent<Image>().sprite = castleBackground;
              break;
      }
    }
}
