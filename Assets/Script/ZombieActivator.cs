using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieActivator : MonoBehaviour
{
	public float detectionRange;
	public Transform pressure;
	public Transform hill;
	public Transform amnesia;
	public Transform zombie;
	public Transform detector;
	private int contador = 0;
    // Start is called before the first frame update
    void Start()
    {

        
    }
    void OnGUI() {

        if(contador == 1){
			GUI.Label(new Rect(Screen.width - 250, Screen.height - 50, 1000, 20), "Há algo te perseguindo. CUIDADO!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if( Vector3.Distance(hill.position, detector.position) <= detectionRange || Vector3.Distance(amnesia.position, detector.position) <= detectionRange){
        	zombie.gameObject.SetActive(true);
        	pressure.gameObject.SetActive(true);
        	contador = 1;
        }
    }
}
