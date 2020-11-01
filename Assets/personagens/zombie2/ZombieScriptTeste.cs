using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieScriptTeste : MonoBehaviour
{
	public static ZombieScriptTeste Instance;
	private Animator _animator;
	public float _proximity = 1;
	public NavMeshAgent navMesh;
	public Transform player1;
	public Transform player2;
	public int character;
	public float detectionRange;
	public int i = 0;
	public float timeLeft = 0.1f;
    public float timeLeft2 = 4f;
	public AudioSource voice;
    public AudioSource woosh;
    public Transform balaFire;
    public Transform balaIce;
    public Transform ponto;
    public Transform zombie;
    

    // Start is called before the first frame update
    void Awake(){
        Instance = this;
    	
    }
    public Transform getPonto(){
        return zombie;
    }
    void Start()
    {
        character = RandomPlay.Instance.getChar();
    	navMesh = GetComponent<NavMeshAgent>();
        _animator = GetComponent<Animator>();
    }
    void BalaIce(){

        Instantiate(balaIce, ponto.position, Quaternion.identity);
    }
    void BalaFire(){
        Instantiate(balaFire, ponto.position, Quaternion.identity);
    }
    void AttackDelay(){
        _animator.SetFloat("Attack", 0);
    }
    void callIce(){
        woosh.Play();
        BalaIce();
    }
    void callFire(){
        woosh.Play();
        BalaFire();
    }
    // Update is called once per frame
    void Update()
    {
        int r = Random.Range(1, 3);

    	
        if (character == 0){
            timeLeft -= Time.deltaTime;
            //Arremesso --- COMEÇA
            if( Vector3.Distance(player1.position, transform.position) > 5){
                timeLeft2 -= Time.deltaTime;
                if(timeLeft2 < 0) {  
                	ZombieMoment.Instance.setZombie(zombie);
                    
                    _animator.SetFloat("Attack", 1);
                    if(r==1){
                        Invoke("callIce", 1f);
                    }else if(r==2){
                        Invoke("callFire", 1f);
                    }
                    timeLeft2 = 4f;
                    Invoke("AttackDelay", 1f);
                }else{
                    
                }
            }
            //Arremesso --- ACABA

            if( Vector3.Distance(player1.position, transform.position) <= detectionRange){
                if(timeLeft < 0) {  
                    float health = HealthController.Instance.getHealth();
                    voice.Play();
                    HealthController.Instance.setHealth(health - 20);
                    
                    
                    timeLeft = 2.5f;
                    _proximity = 2;
                    
                }
            }else{
                
                navMesh.destination = player1.position;
                _proximity = 1;
            }
        }else if (character == 1){
            timeLeft -= Time.deltaTime;
            //Arremesso --- COMEÇA
            if(Vector3.Distance(player2.position, transform.position) > 5){
                timeLeft2 -= Time.deltaTime;
                if(timeLeft2 < 0) { 
                	ZombieMoment.Instance.setZombie(zombie); 

                    _animator.SetFloat("Attack", 1);
                    if(r==1){
                        Invoke("callIce", 1f);
                    }else if(r==2){
                        Invoke("callFire", 1f);
                    }
                    timeLeft2 = 4f;
                    Invoke("AttackDelay", 1f);  
                }
            }
            //Arremesso --- ACABA

            if( Vector3.Distance(player2.position, transform.position) <= detectionRange){
                if(timeLeft < 0) {  
                    float health = HealthController.Instance.getHealth();
                    voice.Play();
                    HealthController.Instance.setHealth(health - 20);
                    
                    
                    timeLeft = 2.5f;
                    _proximity = 2;
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
