using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
using UnityEngine.SceneManagement;

public class ConnectManager : MonoBehaviourPunCallbacks
{
    [SerializeField] TMP_InputField usernameInput;
    [SerializeField] TMP_Text feedbackText;
    public void ClickConnect()
    {
        if (usernameInput.text.Length < 3)
        {
            feedbackText.text = "Username min 3 characters!";
            return;
        }

        else
        {
            // simpan username
            PhotonNetwork.NickName = usernameInput.text;
            PhotonNetwork.AutomaticallySyncScene = true;

            // connect ke server
            PhotonNetwork.ConnectUsingSettings();
            feedbackText.text = "Connecting...";
        }
    }

    // dijalankan ketika sudah connect
    public override void OnConnectedToMaster()
    {
        feedbackText.text = "Connected to Master";
        Debug.Log("Connected to master");
        SceneManager.LoadScene("Lobby");
        StartCoroutine(LoadLevelAfterConnectedAndReady());
    }

    IEnumerator LoadLevelAfterConnectedAndReady()
    {
        while (PhotonNetwork.IsConnectedAndReady == false)
        {
            yield return null;
        }
    }
}
