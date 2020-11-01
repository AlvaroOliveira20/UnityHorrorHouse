using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieRun2 : MonoBehaviour
{
	private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }
	public float _proximity = 0;
	public Transform ativacao;
    public float detectionRange;
    public Transform zombie;
 	public Transform amnesia;
 	public Transform hill;
    public Transform scary;
 	private float timeLeft = 2.5f;
 	
 	void Update(){
 		if(_proximity > 0){
 			timeLeft -= Time.deltaTime;
 			if(timeLeft < 0) {	
            	gameObject.SetActive(false);
         	}
         }
 		if( Vector3.Distance( amnesia.position, ativacao.position) <= detectionRange ){
 			gameObject.SetActive(true);
 			_proximity += 1;
 			scary.gameObject.SetActive(true);
 			
 		}
 		if( Vector3.Distance( hill.position, ativacao.position) <= detectionRange ){
 			_proximity += 1;
 			scary.gameObject.SetActive(true);
 			gameObject.SetActive(true);
 		}

 		_animator.SetFloat("Proximity", _proximity);
 	}
 	
}
