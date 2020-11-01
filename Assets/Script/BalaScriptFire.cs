using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaScriptFire : MonoBehaviour
{
    public Transform zombie;
    public static BalaScriptFire Instance;
    void Awake(){
        Instance = this;
       
    }
    
	
    // Start is called before the first frame update
    void Start()
    {
        zombie = ZombieMoment.Instance.getZombie();
        
    	
        //zombie = GameObject.Find("ZombieAttacker");
       

        GetComponent<Rigidbody>().AddForce(zombie.transform.forward*1500);
    }

    // Update is called once per frame
    void Update()
    {
    	Destroy(gameObject, 2f);

        
    }


    void OnTriggerEnter(Collider player){
        
        if(player.gameObject.name == "hill"){
            Playsound.Instance.fire();
            float health = HealthController.Instance.getHealth();
            HealthController.Instance.setHealth(health - 10);
            Destroy(gameObject);
        }
        if(player.gameObject.name == "amnesia"){
            Playsound.Instance.fire();
            float health = HealthController.Instance.getHealth();
            HealthController.Instance.setHealth(health - 9);
            Destroy(gameObject);
        }else{
        	Destroy(gameObject);
        }
        
    }
}
