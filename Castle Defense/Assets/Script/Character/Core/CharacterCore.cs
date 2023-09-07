using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CharacterTypes
{
	Player,
	Enemy
}

public class CharacterCore : MonoBehaviour
{
	[SerializeField] private CharacterTypes characterType;
	[SerializeField] private GameObject characterSprite;
	[SerializeField] private Animator characterAnimator;

	public CharacterTypes CharacterType => characterType;
	public GameObject CharacterSprite => characterSprite;
	public Animator CharacterAnimator => characterAnimator;

}
