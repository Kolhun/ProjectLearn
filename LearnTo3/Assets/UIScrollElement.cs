using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScrollElement : MonoBehaviour
{
    
	public string title;
	public Text text;
	
	public void SetItem(string name)
	{
		text.text = name;
		title = name.ToLower();
	}
    
}
