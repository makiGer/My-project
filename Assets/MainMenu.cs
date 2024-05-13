using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadSceneAsync(0);
    }
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void Menu()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void TriVector()
    {
        SceneManager.LoadSceneAsync(3);
    }
    public void ParaAddition()
    {
        SceneManager.LoadSceneAsync(4);
    }
    public void VecSub()
    {
        SceneManager.LoadSceneAsync(5);
    }
    public void Ortho()
    {
        SceneManager.LoadSceneAsync(6);
    }
    public void Compo()
    {
        SceneManager.LoadSceneAsync(7);
    }
}
