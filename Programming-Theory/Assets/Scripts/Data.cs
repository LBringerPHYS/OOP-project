using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Data : MonoBehaviour
{

    public void StartButton()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("SampleScene");
    }
}
