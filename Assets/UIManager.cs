using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject menuPanel;
    [SerializeField] PlayerCtrl playerController;
   public void PlayGame()
    {
        menuPanel.SetActive(false);
        playerController.enabled = true;
    }
    public void QuitGame()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
