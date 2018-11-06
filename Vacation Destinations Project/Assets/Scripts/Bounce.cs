using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class Bounce : MonoBehaviour {

	public AnimationCurve curve;

	float initial = 0;
	float time = 0;

	void Start(){
		initial = transform.localPosition.y;
	}

	void Update() {
		time += Time.deltaTime;
		transform.localPosition = new Vector3(transform.localPosition.x, initial + curve.Evaluate(time), transform.localPosition.z);
		if (time > 1)
			time = 0;
	}

}
