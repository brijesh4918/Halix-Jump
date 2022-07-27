using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_script : MonoBehaviour {

	// Use this for initialization
	public float speed=20f;
	// Use this for initialization
	private void OnMouseDrag() {
		float rotX = Input.GetAxis("Mouse X")*speed*Mathf.Deg2Rad;
		transform.RotateAround(Vector3.up,-rotX);
	}
}
