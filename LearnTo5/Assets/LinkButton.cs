using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LinkButton : MonoBehaviour
{
    
	string url;
	[SerializeField] Text text;
	
	public void SetData(string name, string url)
	{
		this.url = url;
		text.text = name;
	}
	
	public void BrowserExecute()
	{
		Application.OpenURL(url);
	}
	
}
