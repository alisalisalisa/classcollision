using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class SceneChange : MonoBehaviour
{
    //emri i skenes
    public string sceneName;


    void OnTriggerEnter()
    {
        //skripti per rilancimin
        EditorSceneManager.LoadScene(sceneName);
    }
}
