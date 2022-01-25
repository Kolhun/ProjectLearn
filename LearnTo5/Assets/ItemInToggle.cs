using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemInToggle : MonoBehaviour
{
	[SerializeField]
	Toggle toggleInGroup;
	[SerializeField]
	int toogleIndex;
	[SerializeField]
	MainMenu menu;
	
	void Start()
	{

		if(toggleInGroup.isOn)
		{
			ToogleToPress();
		}
	}
	
	public void ToogleToPress()
	{
		menu.OpenTab(toogleIndex);
	}
}
