using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using System;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    public GameObject PlayerPrefab;
    //public Camera CamerPrefab; 

    void Start()
    {
        Screen.SetResolution(2000, 1500, false);
        if (PhotonNetwork.IsConnectedAndReady)
        {
            Vector3 newPosition = new Vector3(54, 0, -38);
            GameObject player = PhotonNetwork.Instantiate(PlayerPrefab.name, newPosition, Quaternion.identity);

            Camera playerCamera = player.GetComponentInChildren<Camera>();

            if (player.GetComponent<PhotonView>().IsMine)
            {
                playerCamera.gameObject.SetActive(true);
            }
            else
            {
                playerCamera.gameObject.SetActive(false); // Activate the camera for the local player
            }
        }

    }

    public override void OnJoinedRoom()
    {
        print(PhotonNetwork.NickName + " has joined Room");

        // Instantiate the player prefab
        //Vector3 newPosition = new Vector3(54, 0, -38);
        // GameObject player = PhotonNetwork.Instantiate(PlayerPrefab.name, newPosition, Quaternion.identity);

       // Camera playerCamera = PlayerPrefab.GetComponentInChildren<Camera>();

       // playerCamera.gameObject.SetActive(true); // Activate the camera for the local player
    }
}