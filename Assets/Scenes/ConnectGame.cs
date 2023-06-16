using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;
using TMPro;

public class ConnectGame : MonoBehaviourPunCallbacks
{
    public TMP_Text ConnectionStatus;
    public TMP_InputField UserNameInput;
    public GameObject UserConnectButton;

    void Start()
    {
        UserNameInput.gameObject.SetActive(false);
        UserConnectButton.SetActive(false);


        // AppId와 GameVersion의 버전은 앱 사이에 동일해야 함
        PhotonNetwork.GameVersion = "0.1";
        PhotonNetwork.AutomaticallySyncScene = true;
        // 접속 시작
        print("Starting Connect Process...");
        ConnectionStatus.text = "Starting Connect Process...";
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        print("Connected To Master");
        ConnectionStatus.text = "Connected To Master";

        // 로비에 접속함. 이후 OnJoinedLobby()가 자동 호출됨
        PhotonNetwork.JoinLobby(TypedLobby.Default);
    }

    public override void OnJoinedLobby()
    {
        print("Joined Lobby");
        ConnectionStatus.text = "Input User Name";

        UserNameInput.gameObject.SetActive(true);
        UserConnectButton.SetActive(true);
    }

    public void OnClick_JoinOrCreateRoom()
    {
        if (string.IsNullOrEmpty(UserNameInput.text) || UserNameInput.text == "이름을 입력하세요.")
        {
            UserNameInput.text = "이름을 입력하세요.";
        }
        else
        {
            print("User Name:" + UserNameInput.text);
            RoomOptions ro = new RoomOptions()
            {
                IsVisible = true,
                IsOpen = true,
                MaxPlayers = 2
            };

            PhotonNetwork.NickName = UserNameInput.text;
            print("사용자의 이름은 " + PhotonNetwork.NickName + "입니다.");
            // 게임 서버에 접속함. 성공하면 OnJoinedRoom()가 자동 호출됨
            PhotonNetwork.JoinOrCreateRoom("Room", ro, TypedLobby.Default);
        }
    }

    public override void OnJoinedRoom()
    {
        print(PhotonNetwork.NickName + " has joined Room");

        string MazeScene = "Maze";
        PhotonNetwork.LoadLevel(MazeScene); // string or int. not object.name.ToString
    }
}
