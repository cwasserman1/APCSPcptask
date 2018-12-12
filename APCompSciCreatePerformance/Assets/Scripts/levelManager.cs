using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class levelManager : MonoBehaviour
{

    public GameObject Male;
    public GameObject Female;
   public void LoadScene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }
    public void Quitapp(){
        Application.Quit();
    }
    public void InstantiatePlayers(){

        Instantiate(Male, new Vector2(0, 0), Quaternion.identity);
        Instantiate(Female, new Vector2(0, 0), Quaternion.identity);
       Object.DontDestroyOnLoad(Female);
        Object.DontDestroyOnLoad(Male);
    }
   
    
}
