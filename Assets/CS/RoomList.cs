using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;
using Photon.Pun.UtilityScripts;

public class RoomList : MonoBehaviourPunCallbacks
{
    public static RoomList Instance;

    [Header("UI")] public Transform roomListParent;
    public GameObject roomListItemPrefab;

    public RoomMan RoomMan;
    public GameObject RoomManG;

    private List<RoomInfo> cachedRoomList = new List<RoomInfo>();


    private void Awake()
    {
        Instance = this;
    }

    public void ChangeRoomName(string _name)
    {
        RoomMan.roomName = _name;
    }

    IEnumerator Start()
    {
        if (PhotonNetwork.InRoom)
        {
            PhotonNetwork.LeaveRoom();
            PhotonNetwork.Disconnect();
        }

        yield return new WaitUntil(() => !PhotonNetwork.IsConnected);

        Debug.Log("Connecting...");

        PhotonNetwork.ConnectUsingSettings();
    }


    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();

        PhotonNetwork.JoinLobby();

        Debug.Log("Connected");
    }


    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        base.OnRoomListUpdate(roomList);
        if (cachedRoomList.Count <= 0)
        {
            cachedRoomList = roomList;
        }
        else
        {
            foreach (var Room in roomList)
            {
                for (int i = 0; i < cachedRoomList.Count; i++)
                {
                    if (cachedRoomList[i].Name == Room.Name)
                    {
                        List<RoomInfo> newList = cachedRoomList;

                        if (Room.RemovedFromList)
                        {
                            newList.Remove(newList[i]);
                        }
                        else
                        {
                            newList[i] = Room;
                        }

                        cachedRoomList = newList;
                    }
                }
            }
        }
        UpdateUI();
    }



    private void UpdateUI()
    {
        foreach (Transform roomItem in roomListParent)
        {
            Destroy(roomItem.gameObject);
        }

        foreach (var Room in cachedRoomList)
        {
            GameObject roomItem = Instantiate(roomListItemPrefab, roomListParent);

            roomItem.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = Room.Name;
            roomItem.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = Room.PlayerCount + "/16";

            roomItem.GetComponent<RoomItemButton>().RoomName = Room.Name;
        }
    }



    public void JoinRoomByName(string name)
    {
        RoomMan.roomName = name;
        RoomMan.JoinButtonPressed();
        gameObject.SetActive(false);
    }
}
