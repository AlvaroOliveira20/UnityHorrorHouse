using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerScript : MonoBehaviour
{
	private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }
	public float _proximity = 0;
    public float detectionRange;
 	public Transform amnesia;
 	public Transform hill;
 	private float timeLeft = 2.5f;
 	
 	void Update(){
 		if(_proximity > 0){
 			timeLeft -= Time.deltaTime;
 			if(timeLeft < 0) {	
            	gameObject.SetActive(false);
         	}
         }
 		if( Vector3.Distance( amnesia.position, transform.position) <= detectionRange ){
 			_proximity += 1;
 			
 			
 		}
 		if( Vector3.Distance( hill.position, transform.position) <= detectionRange ){
 			_proximity += 1;
 			
 		}

 		_animator.SetFloat("Proximity", _proximity);
 	}
 	
}
