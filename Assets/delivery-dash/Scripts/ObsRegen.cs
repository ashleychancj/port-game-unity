using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsRegen : MonoBehaviour {

	public Rigidbody Human;
	Vector3 intPos=new Vector3(0,0,0);

	void OnTriggerEnter(Collider Col)
	{
		if (Col.tag == "Human") 
		{
			if (Col.transform.position.x<0)
			intPos = new Vector3 (-100, -3, Col.transform.position.z);

			if (Col.transform.position.x>0)
			intPos = new Vector3 (100, -3, Col.transform.position.z);
			
			Destroy (Col.gameObject,4);


		Rigidbody humanIns = Instantiate (Human) as Rigidbody;
		humanIns.transform.position = intPos;
		}
}
}