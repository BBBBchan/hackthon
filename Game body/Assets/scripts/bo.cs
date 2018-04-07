using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class bo : MonoBehaviour {
	private Transform m_Transform;
	bool isInvincible;
	private float timeSpentInvincible; 
	public float speed;

	void OnTriggerEnter(Collider other){
		if (isInvincible==false &&  Gameloop.Ins.life>0) {
			Gameloop.Ins.life -= 1;

		}
		isInvincible = true;

	}
	void Start () {
		m_Transform = gameObject.GetComponent<Transform>();
	}
	// Update is called once per frame
	void Update () {
		MoveControl();

//		GUI.Label (new Rect (Screen.width * 0.5f, Screen.height * 0.5f, 100, 30), "haha");

		if (isInvincible )
		{
			//2
			timeSpentInvincible += Time.deltaTime;

			//3
			if (timeSpentInvincible < 3f) {
				float remainder = timeSpentInvincible % 0.3f;
				GetComponent<Renderer>().enabled = remainder > 0.15f; 
			}
			//4
			else {
				GetComponent<Renderer>().enabled = true;
				isInvincible = false;
				timeSpentInvincible = 0;
			}
		}
	}

	void MoveControl()
	{
		if (Input.GetKey(KeyCode.W)&&this.transform.localPosition.y<90 &&  Gameloop.Ins.life>0)
		{
			m_Transform.Translate(Vector3.up * speed, Space.Self);
		}
		if (Input.GetKey(KeyCode.S)&&this.transform.localPosition.y>0 &&  Gameloop.Ins.life>0)
		{
			m_Transform.Translate(Vector3.down * speed, Space.Self);
		}
		if (Input.GetKey(KeyCode.A) &&this.transform.localPosition.x>0 &&  Gameloop.Ins.life>0)
		{
			m_Transform.Translate(Vector3.left * speed, Space.Self);
		}
		if (Input.GetKey(KeyCode.D) &&this.transform.localPosition.x<60 &&  Gameloop.Ins.life>0)
		{
			m_Transform.Translate(Vector3.right * speed, Space.Self);
		}
	
	}
}