using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public void RestartGame()
    {
        Score.score = 0;
        Player.life = 3;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
