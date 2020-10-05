﻿//using Cinemachine;
using Photon.Pun;
using UnityEngine;

namespace PhotonTutorial
{
    public class PlayerSpawner : MonoBehaviour
    {
        private GameObject currentPlayer;

        private void Start()
        {
            // instantiate user avatar locally and spawns in remote instances
            currentPlayer = PhotonNetwork.Instantiate("Player", new Vector3(0, 2.88f, Random.Range(0f, -7f)), Quaternion.identity, 0);
            currentPlayer.GetComponent<PlayerController>().isControllable = true;

        }
       
        
    }
}
