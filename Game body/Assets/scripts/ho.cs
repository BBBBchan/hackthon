using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ho : MonoBehaviour {
	public float maxhp=100f;
	int hp;
	// Use this for initialization
	void Start () {
		hp = Gameloop.Ins.life;
	}

	void OnGUI(){
		hp = Gameloop.Ins.life;
		GUIStyle bb = new GUIStyle ();
		bb.normal.background = null;
		bb.normal.textColor = new Color (0, 0, 0);
		bb.fontSize = 40;
		if (Gameloop.Ins.start1 == true) {
			GUI.Label (new Rect (20, 20, 500, 500), "Hp:" + hp.ToString (), bb);
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
