using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    
	public UIScrollElement elementPrefab;
	public Transform elementContainer;
	public InputField searchInput;
	
	public string[] spawnList;
	private List<UIScrollElement> elements = new List<UIScrollElement>();
	

    
    void Start()
    {
	    CreateList();
    }
	
	public void CreateList()
	{
		foreach(var elem in elements)
		{
			Destroy(elem.gameObject);
		}
		
		elements.Clear();
		
		foreach(var item in spawnList)
		{
			
			var inst = Instantiate(elementPrefab,elementContainer);
			inst.SetItem(item);
			elements.Add(inst);
			
		}
	}
	public void Search() 
	{
		foreach(var elem in elements) 
		{
			var finded = elem.title.Contains(searchInput.text.ToLower());
			elem.gameObject.SetActive(finded);
		}
	}
	
}












