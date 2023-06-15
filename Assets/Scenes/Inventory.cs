using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance; 

    private List<Item> InventoryList = new List<Item>();
    public Scrollbar InventoryDisplay;

   // public Transform ItemContent; 
    public Transform InventoryItem;
    public Sprite newSprite;

    void Start()
    {
        Instance = this;
        Image imageComponent = InventoryItem.GetComponent<Image>();
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
        //foreach(var item in InventoryList)
        //{
        //    GameObject obj = Instantiate(InventoryItem);
        //    var ItemName = obj.transform.Find("ItemName").GetComponent<Text>();
        //    var itemIcon = obj.transform.Find("Icon").GetComponent<Image>();


        //    ItemName.text = item.itemName;
        //    itemIcon.sprite = item.icon; 

        //}

        // Get the Image component of the target GameObject

        foreach (var item in InventoryList)
        {
           
            

        }

       
    }

   
}
