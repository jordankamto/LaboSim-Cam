using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    //pour la musique
    [Header("Sounds")]
    public AudioSource audioSource;
    public Slider audioSlider;
    public Text VolumeAudioText;

    // Panel pour le SceneFader, coming soon et le Setting
    [Header("Fader Panel")]
    public SceneFader sceneFader;
    public GameObject settingUI;
    public GameObject comingSoonPanel;

    //pour la gestion du NameTag
    [Header("User Name")]
    [SerializeField]
    private Text userName;
    TouchScreenKeyboard clavier; //pour le clavier 
    public static string NameTag; //le pseudo du joueur 

    void Start()
    {
        VolumeAudioChange();
        NameTag = PlayerPrefs.GetString("nameTag", "User");
    }

    private void Update()
    {
        userName.text = "Hello, " + PlayerPrefs.GetString("nameTag", "User");

        if (!TouchScreenKeyboard.visible && clavier != null) //lorsque le clavier est visible et qu'il y'a une saisi 
        {
            if (clavier.done) //si on valide la saisi
            {
                PlayerPrefs.SetString("nameTag", clavier.text);//On concerve la saisi
                //NameTag.text = clavier.text; //On concerve la saisi comme étant le Name tag 
                clavier = null; //on vide le clavier 
            }
        }
    }


    //fonction pour gérer l'ouverture du clavier
    public void OpenKeyboard()
    {
        clavier = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default); //ouverture du clavier par defaut du téléphone 
    }

    //fonction pour modifier la valeur de la music
    public void VolumeAudioChange()
    {
        audioSource.volume = audioSlider.value;
        VolumeAudioText.text = "Audio " + (audioSource.volume * 100).ToString("00") + "%";
    }

    public void DilutionAcide()
    {
        audioSource.Play();
        sceneFader.FadeTo("SceneDilution");
    }
    public void Oxydoréduction()
    {
        audioSource.Play();
        sceneFader.FadeTo("SceneOxyRed");
    }
    public void TitrageAcidoBasique()
    {
        audioSource.Play();
        sceneFader.FadeTo("SceneTitrage");
    }

    public void Settings()
    {
        audioSource.Play();
        settingUI.SetActive(true);
    }

    public void QuitSettings()
    {
        audioSource.Play();
        settingUI.SetActive(false);
    }
    public void Panel()
    {
        audioSource.Play();
        comingSoonPanel.SetActive(true);
    }

    public void QuitPanel()
    {
        audioSource.Play();
        comingSoonPanel.SetActive(false);
    }

    public void Quit()
    {
        audioSource.Play();
        Debug.Log("Quitter le jeu !");
        Application.Quit();
    }
}
