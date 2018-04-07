using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Gameloop : MonoBehaviour {
	public static Gameloop Ins;
	public int life;
	public bool start1 = false;
	// Use this for initialization
	void Awake(){
		Ins = this;

	}

	void Start () {
		
	}
	[SerializeField]GameObject gameover;
	public void Gameover(){
		gameover.SetActive (true);
		print ("Gameloop:Gameover");
	}
	// Update is called once per frame


	void Update () {
		if (life == 0) {
			Gameover ();
		}
	}

	public void Replay(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
	[SerializeField]GameObject pu;
	[SerializeField]Camera er;
	[SerializeField]GameObject ha;
	public void start(){
		pu.SetActive (false);
		ha.SetActive (true);
		er.depth = 0;
		start1 = true;
	}
}
