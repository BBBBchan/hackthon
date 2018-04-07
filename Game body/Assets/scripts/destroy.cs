using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {
	void OnTriggerEnter(Collider other){
		Destroy ( other.gameObject);
		print ("destroy success");
	}
}
