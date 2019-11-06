using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private GameObject activePanel;
    public GameObject soundManager;

    public void OptionsClick(GameObject panel)
    {
        activePanel.SetActive(false);
        panel.SetActive(true);
        activePanel = panel;
    }
    public void BackClick(GameObject panel)
    {
        activePanel.SetActive(false);
        panel.SetActive(true);
        activePanel = panel;
    }

    public void SinglePlayerButtonClick(string sceneToLoad)
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ButtonClick() {
        soundManager.GetComponent<SoundManager>().PlayButtonSound();
    }

    public void Exit() {
        Application.Quit();
    }
}
