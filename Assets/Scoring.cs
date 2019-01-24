using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scoring : MonoBehaviour {

public UnityEngine.AI.NavMeshAgent player;
public UnityEngine.AI.NavMeshAgent enemy1;
public UnityEngine.AI.NavMeshAgent enemy2;
public UnityEngine.AI.NavMeshAgent enemy3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = player.transform.position;
		Vector3 pos1 = enemy1.transform.position;
		Vector3 pos2 = enemy2.transform.position;
		Vector3 pos3 = enemy3.transform.position;
		
		/*if(pos==pos1 || pos==pos2 || pos==pos3)
		{
			SceneManager.LoadScene("StartUp", LoadSceneMode.Single);
		}
		if(pos.x<=pos1.x+5 || pos.x==pos1.x-5 /*|| pos==pos2 || pos==pos3)
		{
			SceneManager.LoadScene("StartUp", LoadSceneMode.Single);
		}*/
		
		float dist1 = Vector3.Distance(pos,pos1);
		float dist2 = Vector3.Distance(pos,pos2);
		float dist3 = Vector3.Distance(pos,pos3);
		
		if(dist1<0.5 || dist2<0.5 || dist3<0.5)
		{
			SceneManager.LoadScene("StartUp", LoadSceneMode.Single);
		}
		
		
	}
}
