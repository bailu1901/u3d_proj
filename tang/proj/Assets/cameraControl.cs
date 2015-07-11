using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class cameraControl : MonoBehaviour {

	public Transform target;
	float angle = 0;

	//public List<List<int>> list;
	public List<int> list;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		const float distance = 400;
		angle+=0.0005f;
		var x = target.position.x+ Mathf.Cos(angle)*distance;
		var z = target.position.z+ Mathf.Sin(angle)*distance;
		gameObject.transform.position = new Vector3(x, target.transform.position.y - 50, z);
		gameObject.transform.LookAt(target);
		target.forward = gameObject.transform.forward;
		//target.LookAt(gameObject.transform);
		//gameObject.transform.Rotate(Vector3.up,2);
	}
}
