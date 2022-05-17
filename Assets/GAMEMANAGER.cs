using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GAMEMANAGER : MonoBehaviour
{
   
        public void sceneReset()
        {
            string activeSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(activeSceneName);
        }
    public void ChangeScene(string nextscene)
    {
        SceneManager.LoadScene(nextscene);
    }

}
