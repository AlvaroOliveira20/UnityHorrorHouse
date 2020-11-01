using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjetilTeste : MonoBehaviour
{
	public Transform bala;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	if (Input.GetKeyDown(KeyCode.LeftControl)){
    		Instantiate(bala, transform.position, Quaternion.identity);
    	}
        
    }
}
