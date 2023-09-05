using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{   
    public static MenuManager instance;
    
    [Header("Referances")]
    public GameObject settings;
    public GameObject loadScreen;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }    

    #region settings
    public void EnterSettings()
    {
        settings.SetActive(true);
    }
    public void ExitSettings()
    {
        settings.SetActive(false);
    }
    #endregion
    #region loadgamescreen
    public void EnterLoadScreen()
    {
        loadScreen.SetActive(true);
    }
    public void ExitLoadScreen()
    {
        loadScreen.SetActive(false);
    }
    #endregion

    public void ExitGame()
    {
        Application.Quit();
    }

}
