using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/Actions/Move", fileName = "ActionMove")]
public class ActionMove : AIAction
{
	public float minDistanceToFollow = 1f;

	public override void Action(StateController controller)
	{
		FollowTarget(controller);
	}

	private void FollowTarget(StateController controller)
	{
		controller.CharacterMovement.SetHorizontal(-1);
	}

}
