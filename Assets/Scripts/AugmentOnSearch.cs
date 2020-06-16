using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AugmentOnSearch : MonoBehaviour
{
    public InputField InputText;
    public string monuments;

    public GameObject TajMahal;
    public GameObject Colosseum;
    public GameObject ChristRedeemer;
    public GameObject LotusTemple;
    public GameObject ErrorPlane;

    void Start()
    {
        DeActivateAll();
    }

    public void AugmentOnClick()
    {
        monuments = InputText.text.ToLower();

        if(monuments == "tajmahal" || monuments == "taj mahal")
        {
            Debug.Log("TajMahal");
            DeActivateAll();
            TajMahal.SetActive(true);
        }
        else if (monuments == "colosseum")
        {
            DeActivateAll();
            Colosseum.SetActive(true);
        }
        else if (monuments == "christredeemer" || monuments == "christ redeemer" || monuments == "christ the redeemer" || monuments == "christtheredeemer")
        {
            DeActivateAll();
            ChristRedeemer.SetActive(true);
        }
        else if (monuments == "lotustemple" || monuments == "lotus temple")
        {
            DeActivateAll();
            LotusTemple.SetActive(true);
        }
        else
        {
            DeActivateAll();
            ErrorPlane.SetActive(true);
        }
    }

    public void DeActivateAll()
    {
        TajMahal.SetActive(false);
        Colosseum.SetActive(false);
        ChristRedeemer.SetActive(false);
        LotusTemple.SetActive(false);
        ErrorPlane.SetActive(false);
    }
}
