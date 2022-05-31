using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GAMEMANAGER : MonoBehaviour
{
    private int coinCount;
    private void Start()
    {
        coinCount = 0;
        Application.targetFrameRate = 60;
    }
    public void sceneReset()
        {
            string activeSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(activeSceneName);
        }
    public void ChangeScene(string nextscene)
    {
        SceneManager.LoadScene(nextscene);
    }
    public void AddcoinCount()
    {
        coinCount++;
        Debug.Log("coinCount:" + coinCount);
    }
}
