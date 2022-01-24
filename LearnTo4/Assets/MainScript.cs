using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
	public static MainScript objMenu;
	public GameObject objParent;
	public GameObject objChild;
	
	public string sceneLoad;
	public string sceneNameView;
	public Sprite sceneSprite;
    
	void Awake()
	{
		objMenu = this;
	}
    
}
