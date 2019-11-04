using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsPanel : MonoBehaviour
{
    public Button optionsButton;

    [SerializeField]
    private GameObject[] panels;

    void OnEnable()
    {
        //Register Button Events
        optionsButton.onClick.AddListener(() => buttonCallBack(panels));
    }

    private void buttonCallBack(GameObject[] panels)
    {
        panels[0].SetActive(true);
        panels[1].SetActive(false);
    }

    void OnDisable()
    {
        //Un-Register Button Events
        optionsButton.onClick.RemoveAllListeners();
    }
}
