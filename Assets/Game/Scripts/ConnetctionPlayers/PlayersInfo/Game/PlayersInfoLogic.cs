using Photon.Pun;
using Photon.Realtime;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class PlayersInfoLogic : MonoBehaviour
{

    [SerializeField] protected GameObject _spawnPlaceObject, _playerInfoPrefab;
    [SerializeField] private Sprite _isConectedImage;
    [SerializeField] private FindUniqueGameObjects _findUniqueGameObjects;

    protected string _uniqueGameObjectTag = "playerInfoPrefab";
    protected List<GameObject> _uniqueGameObjects = new List<GameObject>();
    protected int _requestPlayersCount;

    protected Requests _requests = new Requests();





    public void UpdateListOfPlayers()
    {
        _uniqueGameObjects = _findUniqueGameObjects.FindObjectWithTag(_uniqueGameObjectTag);
        UpdateData();
    }


    private void CheckPlayersMatch()
    {
        foreach (GameObject networkPlayer in _uniqueGameObjects)
        {
            foreach (Player serverPlayer in PhotonNetwork.PlayerList)
            {
                if (serverPlayer.NickName.Equals(networkPlayer.GetComponentInChildren<PlayersInfoPrefabData>().Nickname))
                {
                    networkPlayer.GetComponentInChildren<Image>().sprite = _isConectedImage;
                }
            }
        }
    }

    private void UpdateData()
    {
        var requestData = GetRequestData();

        for (int i = 0; i < _uniqueGameObjects.Count; i++)
        {
            _uniqueGameObjects[i].GetComponentInChildren<TextMeshProUGUI>().text = requestData.nickNames[i];
            _uniqueGameObjects[i].GetComponentInChildren<PlayersInfoPrefabData>().SetNickname(requestData.nickNames[i]);
        }

        CheckPlayersMatch();
    }

    protected (int length, List<string> nickNames) GetRequestData()
    {
        string symbols = _requests.UwrMessage;
        var ids = new List<int>();
        var nickNames = new List<string>();

        string[] data = symbols.Split('/');
        int length = data.Length;

        foreach (var item in data)
        {
            string[] values = item.Replace("\"", "").Split(',');
            
            nickNames.Add(values[0]);
        }

        return (length, nickNames);
    }
}
