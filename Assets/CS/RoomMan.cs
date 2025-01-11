using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Hashtable = ExitGames.Client.Photon.Hashtable;
using Photon.Realtime;

public class RoomMan : MonoBehaviourPunCallbacks
{
    public static RoomMan instance;
    public GameObject player;

    public GameObject RoomMaker;
    public GameObject JoiningUI;

    public GameObject roomCam;

    public string roomName;

    public Transform[] spawnPoints;
    public int MaxPlayers = 4;
    public bool RoomIsVisible = true;

    private void Awake()
    {
        instance = this;
    }

    public void SetVisible(bool Vis)
    {
        RoomIsVisible = Vis;
    }

    public void JoinButtonPressed()
    {
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.IsVisible = RoomIsVisible;
        roomOptions.MaxPlayers = MaxPlayers;

        PhotonNetwork.JoinOrCreateRoom(roomName, roomOptions, null);
        
        RoomMaker.gameObject.SetActive(false);
        JoiningUI.SetActive(true);
    }

    
    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();

        Debug.Log("In a room!");

        roomCam.SetActive(false);
        JoiningUI.SetActive(false);

        SpawnPlayer();
    }

    public void SpawnPlayer()
    {

        Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
        GameObject _player = PhotonNetwork.Instantiate(player.name, spawnPoint.position, spawnPoint.rotation);

        _player.GetComponent<PlayerSetup>().IsLocalPlayer();
    }
}
