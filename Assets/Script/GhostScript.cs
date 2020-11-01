using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostScript : MonoBehaviour
{
	public float _proximity = 0;
    public float detectionRange;
 	public Transform amnesia;
 	public Transform hill;
    public Transform scary;
 	private float timeLeft = 5f;
 	Rigidbody m_Rigidbody;
    float m_Speed;
    private int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        //Set the speed of the GameObject
        m_Speed = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
    	if(_proximity > 0){
 				timeLeft -= Time.deltaTime;
 				if(timeLeft < 0) {	
            		gameObject.SetActive(false);
         		}
         	}
    	if(counter == 0){
    		
 			if( Vector3.Distance( amnesia.position, transform.position) <= detectionRange ){
 				GetComponent<Rigidbody>().AddForce(transform.forward*600);
 				scary.gameObject.SetActive(true);
 				_proximity++;
 				counter = 1;
 			
 			}
 			if( Vector3.Distance( hill.position, transform.position) <= detectionRange ){
 				GetComponent<Rigidbody>().AddForce(transform.forward*600);
 				scary.gameObject.SetActive(true);
 				_proximity++;
 				counter = 1;
 			}
 			
 		}

 		
        
    }
}
