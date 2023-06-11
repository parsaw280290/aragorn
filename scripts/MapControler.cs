using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapControler : MonoBehaviour
{
    [SerializeField] GameObject mapPanel;
    [SerializeField] GameObject pausePanel;
    state state;


    private void Update()
    {
    }
    public void PausePanel()
    {
        pausePanel.SetActive(true);
    }
    public void PausePanelClose()
    {
        pausePanel.SetActive(false);
    }
    public void GameExit()
    {
        Application.Quit();
    }
    public void MapOpen()
    {
        mapPanel.SetActive(true);
    }
    public void MapClose()
    {
        mapPanel.SetActive(false);
    }

}
