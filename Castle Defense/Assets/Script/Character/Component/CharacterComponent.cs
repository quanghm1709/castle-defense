using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class CharacterComponent : MonoBehaviour
{
	protected float horizontalInput;
	protected float verticalInput;

	protected CharacterController controller;
	protected CharacterMovement characterMovement;
	protected Animator animator;
	protected CharacterCore character;

	protected virtual void Start()
	{
		controller = GetComponent<CharacterController>();
		character = GetComponent<CharacterCore>();
		characterMovement = GetComponent<CharacterMovement>();
		animator = character.CharacterAnimator;//transform.GetChild(0).GetComponent<Animator>();
	}

	protected virtual void Update()
	{
		HandleAbility();
	}

	/// <summary>
	/// Main method. Here we put the logic of each ability
	/// </summary>
	protected virtual void HandleAbility()
	{
		InternalInput();
		HandleInput();
	}

	/// <summary>
	/// Here we get the necessary input we need to perform our actions
	/// </summary>
	protected virtual void HandleInput()
	{

	}

	/// <summary>
	/// Here get the main input we need to control our character
	/// </summary>
	protected virtual void InternalInput()
	{
		if (character.CharacterType == CharacterTypes.Player)
		{
			horizontalInput = Input.GetAxisRaw("Horizontal");
			verticalInput = Input.GetAxisRaw("Vertical");
		}
	}

}
