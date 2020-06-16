using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CheckSearch : MonoBehaviour
{
    string Url = "https://en.wikipedia.org/wiki/";
    public WebViewObject webViewObject;
    public WebViewObject webViewObjectObj;

    public InputField InputText;
    public GameObject SearchBox;
    public GameObject SearchBoxCanvas;
    public GameObject sampleWebView;
    public GameObject CameraPanel;
    public GameObject SearchPanel;
    public GameObject SearchPanel2;
    public OnWebViewLoad onWebViewLoad;
    Animation animSearchBox;

    int flag = 1;
    public static string searchItemName;
    public GameObject augmentOnSearch;
    public GameObject GroundPlaneStage;
    public GameObject PlaneFinder;

    void Start()
    {
        animSearchBox = SearchBox.GetComponent<Animation>();
        InputText.text = "Taj Mahal";
    }

    public void OnSearch()
    {
        webViewObject.SetVisibility(true);
        searchItemName = InputText.text;

        if (flag == 1)
        {
            flag = 0;
            

            //Change Scene
            SceneManager.LoadSceneAsync("WebView");
            CameraPanel.SetActive(true);
            SearchPanel.SetActive(false);
            SearchPanel2.SetActive(true);
            sampleWebView.SetActive(true);

            //PlayAnimation
            animSearchBox.Play("GoUp");

            //Reload
            Debug.Log("---------------------------------------------------" + Url + searchItemName.Replace(" ", "%20"));
            onWebViewLoad.LoadSampleWebView(searchItemName);
        }
        else if (flag != 1)
        {

            //Reload
            Debug.Log("---------------------------------------------------" + Url + searchItemName.Replace(" ", "%20"));
            onWebViewLoad.LoadSampleWebView(searchItemName);
        }
    }

    public void OnBack()
    {
        flag = 1;

        //changeScene
        SceneManager.LoadSceneAsync("Search");
        CameraPanel.SetActive(false);
        SearchPanel.SetActive(true);
        SearchPanel2.SetActive(false);
        sampleWebView.SetActive(false);
        webViewObject.SetVisibility(false);

        //playReverseAnimation
        animSearchBox.Play("GoDown");

        //DeAugment
        augmentOnSearch.GetComponent<AugmentOnSearch>().DeActivateAll();
    }
}
