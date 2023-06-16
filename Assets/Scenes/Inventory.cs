using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance; 

    private List<Item> InventoryList = new List<Item>();

    public GameObject MiniMap; 

    public GameObject[] InventoryDisplay;

    //public Transform ItemContent; 
   // public GameObject InventoryItem;
    //public Sprite newSprite;

    void Start()
    {
        Instance = this;
        //Image imageComponent = InventoryItem.GetComponent<Image>();
        // Set the source image
        //imageComponent.sprite = newSprite;
    }

    public void Add(Item item)
    {
        InventoryList.Add(item);
        foreach(Item itemone in InventoryList)
        {
            print(itemone);
        }
        DisplayItems();
    }

    public void Remove(Item item)
    {
        InventoryList.Remove(item);
    }

    public void DisplayItems()
    {
        foreach (var item in InventoryList)
        {
            if(item.name == "Flashlight")
            {
                InventoryDisplay[0].SetActive(true);

            }
            if (item.name == "Map")
            {
                InventoryDisplay[1].SetActive(true);
                MiniMap.SetActive(true);
            }

        }

    }

   
}
