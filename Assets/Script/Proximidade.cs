using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proximidade : MonoBehaviour
{
	public static Proximidade Instance;
	public float _proximity = 0;
	void Awake(){
        Instance = this;
    }
    public void setProximity(int proximity){
    	_proximity = proximity;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
