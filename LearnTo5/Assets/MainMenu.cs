using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    
	public LinkButton[] buttonList;
	public List<List<LinkData>> links = new List<List<LinkData>>();
	
	void Awake()
	{
		
		for(int t=0;t<5;t++)
		{
			List<LinkData> list = new List<LinkData>();
			for(int i=0;i<10;i++)
			{
				list.Add(new LinkData(){
					name = "VK"+i+t,
					url = "https://vk.com/"+i+t
					});
			}
			links.Add(list);
		}

	}
	
	public void OpenTab(int tabID)
	{
		for(int i=0; i<buttonList.Length;i++)
		{
			
			buttonList[i].SetData(links[tabID][i].name,links[tabID][i].url);
			
		}
	}
	
}

public class LinkData
{
	
	public string name;
	public string url;

} 












