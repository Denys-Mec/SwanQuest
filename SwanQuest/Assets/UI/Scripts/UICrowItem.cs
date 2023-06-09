using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UICrowItem : MonoBehaviour, IPointerDownHandler
{
	[SerializeField] private UIInventory uiinventory;
	[SerializeField] private InventoryItemInfo itemInfo;
	//private IInventory inventory;

	
	public void OnPointerDown (PointerEventData pointerEventData)
	{	
		Debug.Log("Add item to inventory");
	

		var inventory = uiinventory.getInventory();
	   	IInventoryItem item;
		item =  new PartOfCrow(itemInfo);
        item.state.amount = 1;
		inventory.TryToAdd(this, item);
		
	}
}
