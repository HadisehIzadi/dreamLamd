using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
	//[SerializeField] GameObject player;
	//float distanceBetweenObjects;

    void Start()
    {
        
    }


    void Update()
    {
//        distanceBetweenObjects = Vector3.Distance(transform.position, player.transform.position);
//        if(distanceBetweenObjects >= 100)

		
        	Destroy(gameObject , 10f);

    }
}
