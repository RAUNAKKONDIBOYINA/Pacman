using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class Move : MonoBehaviour {
public UnityEngine.AI.NavMeshAgent nmAgent;
public ThirdPersonCharacter character;
public GameObject ThirdCam;
	void Start()
	{
		nmAgent.updateRotation=false;
		
	}
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//If the player has left clicked
        {
            Vector3 mouse = Input.mousePosition;//Get the mouse Position
            Ray castPoint = Camera.main.ScreenPointToRay(mouse);//Cast a ray to get where the mouse is pointing at
            RaycastHit hit;//Stores the position where the ray hit.
            if (Physics.Raycast(castPoint, out hit, Mathf.Infinity))//If the raycast doesnt hit a wall
            {	
				//ThirdCam.SetActive(true);
                nmAgent.SetDestination(hit.point);
            }
        }
		
		if(nmAgent.remainingDistance > nmAgent.stoppingDistance)
		{
			character.Move(nmAgent.desiredVelocity, false, false);
		}
		else
		{
			character.Move(Vector3.zero, false, false);
			
		}
		
		
    }
}
