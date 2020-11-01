using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieScript : MonoBehaviour
{
	public static ZombieScript Instance;
	private Animator _animator;
	public float _proximity = 1;
	public NavMeshAgent navMesh;
	public Transform player1;
	public Transform player2;
	public int character;
	public float detectionRange;
	public int i = 0;
	public float timeLeft = 0.1f;
	public AudioSource voice;
	public AudioSource fire;
	public AudioSource ice;

    // Start is called before the first frame update
    void Awake(){
        Instance = this;
    	character = RandomPlay.Instance.getChar();
    }
    void Start()
    {
    	navMesh = GetComponent<NavMeshAgent>();
        _animator = GetComponent<Animator>();
    }
    
    // Update is called once per frame
    void Update()
    {

    	int r = Random.Range(1, 3);
    	if (character == 0){
    		timeLeft -= Time.deltaTime;
    		if( Vector3.Distance(player1.position, transform.position) <= detectionRange){
    			if(timeLeft < 0) {	
    				float health = HealthController.Instance.getHealth();
    				HealthController.Instance.setHealth(health - 20);
    				
    				timeLeft = 2.5f;
    				_proximity = 2;
    				//navMesh.isStopped = true;
    				//voice.Play();
    			}
    		}
    		else{
    			
    			navMesh.destination = player1.position;
    			_proximity = 1;
    		}
    	}
    	if (character == 1){
    		timeLeft -= Time.deltaTime;
    		if( Vector3.Distance(player2.position, transform.position) <= detectionRange){
    			if(timeLeft < 0) {	
    				float health = HealthController.Instance.getHealth();
    				HealthController.Instance.setHealth(health - 20);
    				//navMesh.isStopped = true;
    				
    				timeLeft = 2.5f;
    				_proximity = 2;
    				//voice.Play();
    			}
    		}
    		else{
    			
    			navMesh.destination = player2.position;
    			_proximity = 1;
    		}
    	}
    	
        _animator.SetFloat("Proximity", _proximity);
    }
}
