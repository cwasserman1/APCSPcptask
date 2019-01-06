using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class levelManager : MonoBehaviour
{

    public GameObject Male;
    public GameObject Female;
   public void LoadScene(string sceneName){
        SceneManager.LoadScene(sceneName);//Loads Scene of "sceneName"
    }
    public void Quitapp(){
        Application.Quit();//Quits the Game
    }

   
    
}
