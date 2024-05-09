using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class PlayersInfoLogic: PlayersInfoPrefabData
{
    [SerializeField] protected GameObject _playerInfoPrefab;
    [SerializeField] protected string _playerPrefabsTag;
    [SerializeField] protected GameObject _spawnPlaceObject;
    [SerializeField] protected List<GameObject> _uniqueGameObjects = new List<GameObject>();
    protected List<GameObject> _allGameObjects;
    protected Requests _requests = new Requests();
    protected int _requestPlayersCount;

    protected void UpdateListOfPlayers()
    {
        _allGameObjects = FindObjectsOfType<GameObject>().ToList();

        foreach (GameObject gameObject in _allGameObjects)
        {
            if (gameObject.tag == _playerPrefabsTag)
            {
                if (!_uniqueGameObjects.Contains(gameObject))
                {
                    _uniqueGameObjects.Add(gameObject);
                }
            }
        }

        UpdateData();
    }



    private void UpdateData()
    {
        var requestData = GetRequestData("length");

        for (int i = 0; i < _uniqueGameObjects.Count; i++)
        {
            _id = requestData.ids[i];
            _uniqueGameObjects[i].GetComponentInChildren<TextMeshProUGUI>().text = requestData.emails[i];
        }
    }

    protected (int length, List<int> ids, List<string> emails) GetRequestData(string parameter)
    {
        string symbols = _requests.uwr.downloadHandler.text;
        var ids = new List<int>();
        var emails = new List<string>();

        string[] data = symbols.Split('/');
        int length = data.Length;

        foreach (var item in data)
        {
            string[] values = item.Replace("\"", "").Split(',');

            ids.Add(int.Parse(values[1]));
            emails.Add(values[0]);
        }

        return (length, ids, emails);
    }
}
