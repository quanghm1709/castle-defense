using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
	#region Test_Code
	[SerializeField] private GameObject selectCharacter;
	[SerializeField] private GameObject characterSource;
	
	public GameObject SelectCharacter { get { return characterSource; } }

	public void SelectCharacterButton()
	{
		selectCharacter = characterSource;
	}

	private void Update()
	{
		if (selectCharacter != null)
		{
			if(Input.GetMouseButtonDown(0))
			{
				Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

				pos = new Vector3((int)Mathf.Round(pos.x), (int)Mathf.Round(pos.y+.5f), characterSource.transform.position.z);
				Instantiate(selectCharacter, pos, Quaternion.identity);
				//selectCharacter= null;
			}
		}
	}
	#endregion
}
