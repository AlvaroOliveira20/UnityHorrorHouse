using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Death : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SwitchSceneLoad(){
    	UnityEngine.SceneManagement.SceneManager.LoadScene("Load");
    }
    public void MainMenuButton()
    {
    	Invoke("SwitchSceneLoad", 0.25f);
    }
    void SwitchSceneExit(){
    	UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
    public void QuitButton()
    {
    	Invoke("SwitchSceneExit", 0.25f);
    }
}
