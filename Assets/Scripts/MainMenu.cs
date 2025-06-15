using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public SceneFader sceneFader;
    public string levelToLoad = "Dilution Acide";

    public AudioSource audioSource;
    public void DilutionAcide()
    {
        audioSource.Play();
        sceneFader.FadeTo(levelToLoad);
    }
    public void Oxydoréduction()
    {
        audioSource.Play();
        sceneFader.FadeTo(levelToLoad);
    }
    public void TitrageAcidoBasique()
    {
        audioSource.Play();
        sceneFader.FadeTo(levelToLoad);
    }

    public void Quit()
    {
        audioSource.Play();
        Debug.Log("Quitter le jeu !");
        Application.Quit();
    }
}
