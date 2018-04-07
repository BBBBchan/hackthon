using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dm1 : MonoBehaviour {
	private Rigidbody rb;
	public float speed;
	public float tile;
	public float x;
	public float y;
	// Use this for initialization
	void Awake(){
	}

	void Start () {
		rb = GetComponent<Rigidbody> ();

		//射击方向
		//rb.transform.LookAt(new Vector3(x,y,0));

		rb.velocity = transform.right * speed * 1;
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
