using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ringgenrator : MonoBehaviour {

public GameObject ring;
	public Transform GenPoint;

	float width=23f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {	
		int i=Random.Range(0,4);
		
		if(transform.position.y > GenPoint.position.y){
			transform.position = new Vector3(transform.position.x,transform.position.y-width,transform.position.z);
			Vector3 newPos = new Vector3(0,transform.position.y,0);
			GameObject g =  Instantiate(ring,newPos,Quaternion.identity);
			g.transform.parent = GameObject.Find("Main").transform;

			Debug.Log("Generated");

		}
	}
}
