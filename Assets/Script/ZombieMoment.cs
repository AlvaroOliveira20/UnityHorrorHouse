using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMoment : MonoBehaviour
{
	private Transform zombie;
	public static ZombieMoment Instance;
	void Awake(){
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setZombie(Transform Param){
        zombie = Param;
    }
    public Transform getZombie(){
        return zombie;
    }
}
