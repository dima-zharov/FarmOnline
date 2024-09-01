using Photon.Pun;
using UnityEngine;

public class NetworkMovement : MonoBehaviour
{
    private PhotonView _view;
    private PlayerMovement _playerMovement;

    private void Start()
    {
        _view = GetComponent<PhotonView>();
        _playerMovement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        if(_view.IsMine)
            _playerMovement.MoveMethod();
    }
}
