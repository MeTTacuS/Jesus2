using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonController : MonoBehaviour
{
    public void SinglePlayerButtonOnClick(GameObject menuPanel)
    {
        menuPanel.SetActive(false);
        SceneManager.LoadScene("SampleScene");
    }

    public void OptionsButtonOnClick(GameObject[] panels)
    {
        //menu panel
        panels[0].SetActive(false);
        //options panel
        panels[1].SetActive(true);
    }
}
