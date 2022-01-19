using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    
	public GameObject spawnItem;
	public GameObject spawnItemParent;
	private int spawnItemSize = 100;
    
    void Start()
    {
	    int j = 0;
	    while(j <= spawnItemSize)
	    {
	    	var inst = Instantiate(spawnItem);
	    	var jinst = inst.transform.GetChild(1);
	    	jinst.GetComponent<Text>().text = "Элемент" + j.ToString();
	    	inst.transform.SetParent(spawnItemParent.transform);
	    	j++;
	    }
    }

}
