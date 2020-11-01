using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SC_MainMenu : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject CreditsMenu;
    //public AudioSource Selection;
	

    // Start is called before the first frame update
    void Start()
    {
        MainMenuButton();
    }
    void SwitchScene(){
    	UnityEngine.SceneManagement.SceneManager.LoadScene("Load");
    }

    public void PlayNowButton()
    {
        Invoke("SwitchScene", 0.25f);
    }

    public void CreditsButton()
    {
    	//Selection.Play();
        // Show Credits Menu
        MainMenu.SetActive(false);
        CreditsMenu.SetActive(true);
    }

    public void MainMenuButton()
    {
    	//Selection.Play();
        // Show Main Menu
        MainMenu.SetActive(true);
        CreditsMenu.SetActive(false);
    }

    public void QuitButton()
    {
    	//Selection.Play();
        // Quit Game
        Application.Quit();
    }
}