using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrimaryGameManager : MonoBehaviour
{
    public static PrimaryGameManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }


    public void EndGame()
    {
        SceneManager.LoadScene(0);
    }
}
