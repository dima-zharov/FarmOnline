using UnityEngine;

[RequireComponent(typeof(PlayersSpawner))]
public class ConnectPlayer : MonoBehaviour
{

    [SerializeField] private Initializer _initializer;
    private PlayersSpawner _playerSpawner;
    private void Start()
    {

        _playerSpawner.SpawnPlayer();

        _initializer.InitializeObjects();
    }
    private void Awake()
    {
        _playerSpawner = GetComponent<PlayersSpawner>();
    }


}
