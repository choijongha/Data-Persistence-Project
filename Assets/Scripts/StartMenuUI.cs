using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif


public class StartMenuUI : MonoBehaviour
{
    public static StartMenuUI saveScript;
    public TMP_InputField inputField;

    public string playerName;

    private void Awake()
    {
        if (saveScript == null)
        {
            saveScript = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void StartNew()
    {
        playerName = inputField.text;
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
