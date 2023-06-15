using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageCanvas : MonoBehaviour
{
    public GameObject Inventory;
    public GameObject Map;
    public GameObject Chat;
    public bool hasMap;
    private bool isMouseLookEnabled = true;

    void Start()
    {

        Cursor.visible = true;
        //if (isMouseLookEnabled)
        //{
        //    // Enable mouse look
        //    Cursor.lockState = CursorLockMode.Locked;
        //    Cursor.visible = false;
        //}
        //else
        //{
        //    // Disable mouse look
        //    Cursor.lockState = CursorLockMode.None;
        //    Cursor.visible = true;
        //}

    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.I))
        {
            Inventory.SetActive(!Inventory.activeSelf);
            print("I pressed");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Chat.SetActive(!Chat.activeSelf);
            print("C pressed");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        if (hasMap)
        {
            if (Input.GetKeyDown(KeyCode.M))
            {
                Map.SetActive(!Map.activeSelf);
                print("M pressed");
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
    }
}
