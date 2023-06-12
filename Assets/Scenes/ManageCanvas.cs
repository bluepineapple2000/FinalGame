using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageCanvas : MonoBehaviour
{
    public GameObject Inventory;
    public GameObject Map;
    public GameObject Chat;
    public bool hasMap; 


    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Inventory.SetActive(!Inventory.activeSelf);
            print("I pressed");
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Chat.SetActive(!Chat.activeSelf);
            print("C pressed");
        }
        if (hasMap)
        {
            if (Input.GetKeyDown(KeyCode.M))
            {
                Map.SetActive(!Map.activeSelf);
                print("M pressed");
            }
        }
    }
}
