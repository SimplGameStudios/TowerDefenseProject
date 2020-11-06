using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake() 
    {
        if (FindObjectsOfType<SceneLoader>().Length <= 1)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        if(SceneManager.GetActiveScene().buildIndex == 0)
        {
            StartCoroutine(SplashScreen());
        }
    }

    private IEnumerator SplashScreen()
    {
        yield return new WaitForSeconds(3);
        LoadNextLevelAfterTime(0);
    }

    private void LoadNextLevelAfterTime(float seconds)
    {
        StartCoroutine(LoadNextLevel(seconds));
    }

    private IEnumerator LoadNextLevel(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void LoadLevelAfterTime(string sceneName, float seconds)
    {
        StartCoroutine(LoadLevel(sceneName, seconds));
    }

    private IEnumerator LoadLevel(string sceneName, float seconds)
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(sceneName);
    }
}