using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
	private int a=0;
	public float where;
	public float x;
	public float y;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
//控制位置
		//gameObject.transform.localPosition=new Vector3(x,y,0);





//	测试
		if (where == 0) {
			if (a ==0) {
				gameObject.transform.Translate (new Vector3(1,0,0)*Time.deltaTime*10);
				if (gameObject.transform.position.x > 60) {
					a = 1;
				}
			}
			else if(a==1){
				gameObject.transform.Translate (new Vector3(-1,0,0)*Time.deltaTime*10);
				if(gameObject.transform.position.x <0){
					a=0;
				}
			}
		}

		if (where == 1) {
			if (a == 0) {	
				gameObject.transform.Translate (new Vector3 (0,1,0)*Time.deltaTime*20);
				if (gameObject.transform.position.y > 90) {
					a = 1;
				}
			}
			else if(a==1){
				gameObject.transform.Translate (new Vector3(0,-1,0)*Time.deltaTime*20);
				if(gameObject.transform.position.y <0){
					a=0;
				}
			}
		}

	}


}
