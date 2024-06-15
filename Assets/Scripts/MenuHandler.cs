using System.Collections;
using System.Collections.Generic;
using TMPro;

#if UNITY_2017_1_OR_NEWER
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    public TMP_InputField inputField;

    public void StartNew()
    {
        Player.Instance.name = inputField.text;
        Debug.Log(Player.Instance.name);
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_2017_1_OR_NEWER
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
