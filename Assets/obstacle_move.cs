using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_move : MonoBehaviour {

	// Use this for initialization
	public GameObject obj;
	public float speed = .2f;
	public float strength = 9f;

	private float randomOffset;

	void Start () {
		randomOffset = Random.Range(-2f, 2f);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = obj.transform.position;
		pos.x = Mathf.Sin(Time.time * speed + randomOffset) * strength;
		obj.transform.position = pos;
	}
}
