using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Module1 : MonoBehaviour
{
    public SceneFader sceneFader;
    public GameObject ui;
    public GameObject end;
    public Behaviour equipement;
    public AudioSource buttonAudioSource;

    public void Next()
    {
        buttonAudioSource.Play();
        ui.SetActive(false);
        equipement.enabled = true;
    }
    public void EndUI()
    {
        buttonAudioSource.Play();
        end.SetActive(true);
    }

    public void End()
    {
        buttonAudioSource.Play();
        sceneFader.FadeTo("MainMenu");
    }
}
