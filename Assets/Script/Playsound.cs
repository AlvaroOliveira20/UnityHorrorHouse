using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playsound : MonoBehaviour
{
	public static Playsound Instance;
	public AudioSource fireSound;
	public AudioSource iceSound;
    // Start is called before the first frame update
    public void ice(){
    	iceSound.Play();
    }
    public void fire(){
    	fireSound.Play();
    }
    void Awake(){
    	Instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
