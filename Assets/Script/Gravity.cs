using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
	public GameObject hill;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 velocity = new Vector3(10f/*x*/, 1000f/*y*/, 10f/*z*/);
        hill.GetComponent<Rigidbody>().velocity = velocity;
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
