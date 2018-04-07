using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootit : MonoBehaviour {
	public GameObject sp;
	public GameObject bolt;
	private float mytime;
	public float nextfire;
	public float fireDelta;
	public float x;
	public float y;
	// Use this for initialization
	void Start () {
		
	}
	Rigidbody bullet;
	// Update is called once per frame
	void Update () {
		mytime = mytime + Time.deltaTime;
		if (mytime > nextfire && Gameloop.Ins.start1==true) {
			nextfire = mytime + fireDelta;
			//dm.dis.where=	each;
			Instantiate (bolt, sp.transform.position, Quaternion.identity) ;
			nextfire = nextfire - mytime;
			mytime = 0.0F;
		}
	}
}
