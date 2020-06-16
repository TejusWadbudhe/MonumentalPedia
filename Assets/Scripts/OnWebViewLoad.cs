using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OnWebViewLoad : MonoBehaviour
{
    public SampleWebView sampleWebView;
    public GameObject sampleWebViewGO;

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "WebView")
        {
            sampleWebViewGO.SetActive(true);
            LoadSampleWebView(CheckSearch.searchItemName);
        }
    }

    // called when the game is terminated
    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    public void LoadSampleWebView(string search)
    {
        sampleWebView.LoadWebView(search);
    }
}
