using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

namespace Rustam.WinterFlame.Shooter
{
    public class Launcher : MonoBehaviour
    {
        private string gameVersion = "0.0.1.1";
        
        private void Awake()
        {
            PhotonNetwork.AutomaticallySyncScene = true;
        }
        private void Start()
        {
            Connect();
        }
        public void Connect()
        {
            if (PhotonNetwork.IsConnected)
            {
                PhotonNetwork.JoinRandomRoom();
            }
            else
            {
                PhotonNetwork.ConnectUsingSettings();
                PhotonNetwork.GameVersion = gameVersion;
            }
        }

    }
}
