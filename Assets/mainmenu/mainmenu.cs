using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    [SerializeField]
    GameObject levels;
   public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void LevelButton()
    {
        levels.SetActive(true);
    }

    public void Level1()
    {
        SceneManager.LoadScene(1);

    }
     public void Level2()
    {
        SceneManager.LoadScene(2);

    }
     public void Level3()
    {
        SceneManager.LoadScene(3);

    }
    

}
