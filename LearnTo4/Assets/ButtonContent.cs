using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonContent : MonoBehaviour
{
    
	public string valueInput;
    
	public GameObject objParent;
	public GameObject objChild;
	public MainScript objMenu;
	
	public void ButtonExe()
	{
		
		objMenu.sceneLoad = valueInput;
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
		SceneManager.LoadScene(objMenu.sceneLoad);
	}
	public void SceneLoadMenu()
	{
		SceneManager.LoadScene("SampleScene");
	}
    
}
