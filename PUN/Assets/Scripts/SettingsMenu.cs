using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    [SerializeField] TMP_Dropdown drop;

    public void SetVolume(float volume)
    {
        Debug.Log(volume);
    }

    public void GetOption(int value)
    {
        Debug.Log("Resolution : " + drop.options[value].text);
    }

    public void GetToogle(bool value)
    {
        if (value)
        {
            Debug.Log("State true");
        }
        else
        {
            Debug.Log("State false");
        }
    }
}
