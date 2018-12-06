using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class levelManager : MonoBehaviour
{
   public void LoadScene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }
    public void Quitapp(){
        Application.Quit();
    }
}
