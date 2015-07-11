using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class cameraControl : MonoBehaviour {

	public Transform target;
	float angle = 0;
	public TextMesh text;
	//public List<List<int>> list;
	public List<int> list;
	// Use this for initialization
	float start = -0.02f;
	void Start () {
		var color = text.color;
		color.a = start;
		text.color = color;
	}
	
	// Update is called once per frame
	void Update () {
		const float distance = 400;
		angle+=0.001f;
		var x = target.position.x+ Mathf.Cos(angle)*distance;
		var z = target.position.z+ Mathf.Sin(angle)*distance;
		gameObject.transform.position = new Vector3(x, target.transform.position.y - 50, z);
		gameObject.transform.LookAt(target);
		target.forward = gameObject.transform.forward;

		var color = text.color;
		start += 0.0001f;
		color.a += start;
		text.color = color;
	}
}
