using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour {
	int cnt;
	// Use this for initialization
	void Start () {
		cnt=0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnTriggerExit(Collider other) {
		Debug.Log("cnt="+cnt++);
	}
}
