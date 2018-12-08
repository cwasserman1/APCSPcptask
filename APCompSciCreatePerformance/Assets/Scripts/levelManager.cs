using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class levelManager : MonoBehaviour
{

    public GameObject Trump;
    public GameObject Hillary;
   public void LoadScene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }
    public void Quitapp(){
        Application.Quit();
    }
    public void LoadTrump(){

        Instantiate(Trump, new Vector3(0, 0, 0), Quaternion.identity);
        Object.DontDestroyOnLoad(Trump);
    }
    public void LoadHillary(){
      
    }
    
}
