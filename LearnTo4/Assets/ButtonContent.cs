using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonContent : MonoBehaviour
{
    
	public string valueInput;
	public string valueNameInput;
	public Image valueImg;
    
	public GameObject objParent;
	public GameObject objChild;

	
	public void ButtonExe()
	{
		
		//MainScript.objMenu.sceneLoad = valueInput;
		MainScript.objMenu.sceneNameView = valueNameInput;
		MainScript.objMenu.sceneSprite = valueImg.sprite;
		objParent.SetActive(false);
		objChild.SetActive(true);
		
	}
	public void ButtonOut()
	{	
		
		objParent.SetActive(true);
		objChild.SetActive(false);

	}
	public void SceneLoad()
	{
		DontDestroyOnLoad(MainScript.objMenu);
		SceneManager.LoadScene("Lvl1");
	}
	public void SceneLoadMenu()
	{
		SceneManager.LoadScene("SampleScene");
	}
    
}
