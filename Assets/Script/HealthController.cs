using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
	public static HealthController Instance;
    public float health = 2;
    public float Health {
        get {
            return health;
        }
        set {
            health = Mathf.Clamp(value, 0, healthMax);
        }
    }
    public float healthMax = 14;

    public Image healthBar;

    void Awake(){
        Instance = this;
    }

    private void Update() {
        if (health<60 && health>30){
            healthBar.GetComponent<Image>().color = new Color32(255,255,0,100);
        }
        if (health<30){
            healthBar.GetComponent<Image>().color = new Color32(255,0,0,100);
        }
        
        if (Health <= 0){
            if( RandomPlay.Instance.getChar() == 0)
        	   UnityEngine.SceneManagement.SceneManager.LoadScene("DeathScreenHill");
            if( RandomPlay.Instance.getChar() == 1)
               UnityEngine.SceneManagement.SceneManager.LoadScene("DeathScreenAmnesia");
        }
        UpdateHealthBar();

    }
    

    private void UpdateHealthBar() {
        healthBar.fillAmount = Health / healthMax;
    }
    public float getHealth(){
    	return health;
    }
    public void setHealth(float Param){
    	health = Param;
    }
}