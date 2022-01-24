using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuInit : MonoBehaviour
{

	public Text menuNameView;
	public Image menuImg;
	
	void Start()
	{
		menuNameView.text = MainScript.objMenu.sceneNameView;
		menuImg.sprite = MainScript.objMenu.sceneSprite;
	}
}
