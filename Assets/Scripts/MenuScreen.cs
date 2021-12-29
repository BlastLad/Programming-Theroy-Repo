using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class MenuScreen : MonoBehaviour
{
    public void BeginGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitApplication()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

}
