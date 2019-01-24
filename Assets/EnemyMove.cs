using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class EnemyMove : MonoBehaviour {

public UnityEngine.AI.NavMeshAgent player;
public UnityEngine.AI.NavMeshAgent Enemy;
public ThirdPersonCharacter character;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = player.transform.position;
		//Ray castPoint = Camera.main.ScreenPointToRay(pos);//Cast a ray to get where the mouse is pointing at
          //  RaycastHit hit;//Stores the position where the ray hit.
         //   if (Physics.Raycast(castPoint, out hit, Mathf.Infinity))//If the raycast doesnt hit a wall
           // {	
				//ThirdCam.SetActive(true);
                //Enemy.SetDestination(hit.point);
           // }
			Enemy.SetDestination(pos);
			
			if(Enemy.remainingDistance > Enemy.stoppingDistance)
			{
				character.Move(Enemy.desiredVelocity, false, false);
			}
			else
			{
				character.Move(Vector3.zero, false, false);
			
			}
	}
}
