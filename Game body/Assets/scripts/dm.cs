using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dm : MonoBehaviour {
	private Rigidbody rb;
	public float speed;
	public float tile;
	// Use this for initialization

	void Awake(){
	}

	void Start () {
		rb = GetComponent<Rigidbody> ();

			rb.velocity = transform.up * speed * -1;

	}

	void OnMouseDown(){
		if (Input.GetMouseButtonDown (0)) {
			print ("点击消失");
			Destroy (this.gameObject);
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
