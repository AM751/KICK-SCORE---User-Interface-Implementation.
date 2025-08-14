using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    [SerializeField] private Canvas _firstSettingsScene;
    [SerializeField] private Canvas _midSettingsScene;

    void Start()
    {
        _firstSettingsScene.enabled = true;
        _midSettingsScene.enabled = false;
    }
    
    
    public void ToFirstSettingsScene()
    {
        _firstSettingsScene.enabled = true;
        _midSettingsScene.enabled = false;
    }

    public void ToMidSettingsScene()
    {
        _midSettingsScene.enabled = true;
        _firstSettingsScene.enabled = false;
    }
    
    public void toMainMenu()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
