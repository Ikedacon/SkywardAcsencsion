using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{
    public Button level1Button;
    public Button level2Button;
    public Button level3Button;
    public Button level4Button;
    public Button level5Button;
    public Button level6Button;
    public Button level7Button;
    public Button level8Button;
    public Button level9Button;
    public Button exitButton;

    // Start is called before the first frame update
    void Start()
    {
        level1Button.onClick.AddListener(LoadLevel1);
        level2Button.onClick.AddListener(LoadLevel2);
        level3Button.onClick.AddListener(LoadLevel3);
        level4Button.onClick.AddListener(LoadLevel4);
        level5Button.onClick.AddListener(LoadLevel5);
        level6Button.onClick.AddListener(LoadLevel6);
        level7Button.onClick.AddListener(LoadLevel7);
        level8Button.onClick.AddListener(LoadLevel8);
        level9Button.onClick.AddListener(LoadLevel9);

        exitButton.onClick.AddListener(QuitGame);
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Easy 1");
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("Easy 2");
    }

    public void LoadLevel3()
    {
        SceneManager.LoadScene("Easy 3");
    }

    public void LoadLevel4()
    {
        SceneManager.LoadScene("Easy 4");
    }

    public void LoadLevel5()
    {
        SceneManager.LoadScene("Medium 1");
    }

    public void LoadLevel6()
    {
        SceneManager.LoadScene("Medium 2");
    }

    public void LoadLevel7()
    {
        SceneManager.LoadScene("Medium 3");
    }

    public void LoadLevel8()
    {
        SceneManager.LoadScene("Hard 1");
    }

    public void LoadLevel9()
    {
        SceneManager.LoadScene("Ending");
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("Main Menu");    }
    }
