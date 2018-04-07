using UnityEngine;

using System.Collections;

using UnityEngine;

using System.Collections;

using UnityEngine.UI;

public class timer : MonoBehaviour {

	public int TotalTime=90;//总时间

	public Text TimeText;//在UI里显示时间
	public string LoadsceneName;

	private int mumite;//分

	private int second;//秒

	void Start(){

		StartCoroutine(startTime());   //运行一开始就进行协程

	}

	public IEnumerator  startTime() {

		while (TotalTime >= 0) {

			//Debug.Log(TotalTime);//打印出每一秒剩余的时间

			yield return new WaitForSeconds(1);//由于开始倒计时，需要经过一秒才开始减去1秒，
			//所以要先用yield return new WaitForSeconds(1);然后再进行TotalTime--;运算

			TotalTime--;

			TimeText.text="Time:"+TotalTime;

			if (TotalTime<= 0){                //如果倒计时剩余总时间为0时，就跳转场景

				LoadScene();

			}

			mumite=TotalTime/60; 

			second=TotalTime%60; //输出显示秒

			string length = mumite.ToString ();
			if (second >= 10) {

				TimeText.text = "0" + mumite + ":" + second;
			}     //如果秒大于10的时候，就输出格式为 00：00

			else
				TimeText.text = "0" + mumite + ":0" + second;      //如果秒小于10的时候，就输出格式为 00：00

		} 


	}

	void LoadScene() {

		Application.LoadLevel(LoadsceneName);//倒计时结束跳转到场景,LoadsceneName可以在外部修改

	}

}