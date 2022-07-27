using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {
Rigidbody rigidbody;
bool isforce;
public float force;
	// Use this for initialization
	void Start () {
		Time.timeScale=1;
		rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if(isforce==true)
		{
			getforce();
		}
	}
	void getforce()
	{
		isforce=false;
	}
	private void OnCollisionEnter(Collision other) {
		//print(force);
		isforce=true;
		rigidbody.AddForce(Vector3.up*force);
		if(other.gameObject.tag=="win")
		{
			Debug.Log("Win");
			Time.timeScale=0;
		}
		if(other.gameObject.tag=="lose")
		{
			Debug.Log("lose");
			//SceneManager.LoadScene("SampleScene");
		//	Time.timeScale=0;
		//	GameObject.Find("game").transform.GetChild(0).gameObject.SetActive(true);
		}
	}
}

