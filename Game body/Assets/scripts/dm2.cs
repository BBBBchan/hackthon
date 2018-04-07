using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dm2 : MonoBehaviour {
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
		//GameObject zj = GameObject.Find ("Sphere");
		//射击方向
		//rb.transform.LookAt(new Vector3(x,y,0));
		GameObject zj = GameObject.Find ("Sphere");
		rb.transform.LookAt(zj.transform.position);
		rb.velocity = transform.forward * speed * 1;
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
