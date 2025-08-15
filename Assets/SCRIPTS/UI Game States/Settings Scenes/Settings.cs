using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    [SerializeField] private Canvas _firstSettingsScene;
    [SerializeField] private Canvas _midSettingsScene;
    [SerializeField] private AudioSource _buttonSound;

    void Start()
    {
        _firstSettingsScene.enabled = true;
        _midSettingsScene.enabled = false;
    }
    
    
    public void ToFirstSettingsScene()
    {
        _buttonSound.Play();
        _firstSettingsScene.enabled = true;
        _midSettingsScene.enabled = false;
    }

    public void ToMidSettingsScene()
    {
        _buttonSound.Play();
        _midSettingsScene.enabled = true;
        _firstSettingsScene.enabled = false;
    }
    
    public void toMainMenu()
    {
        _buttonSound.Play();
        SceneManager.LoadScene("SampleScene");
    }
}
