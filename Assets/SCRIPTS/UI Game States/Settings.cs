using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    [SerializeField] private Canvas _firstSettingsScene;
    [SerializeField] private Canvas _midSettingsScene;
    [SerializeField] private Canvas _lastSettingsScene;

    void Start()
    {
        _firstSettingsScene.enabled = true;
        _midSettingsScene.enabled = false;
        _lastSettingsScene.enabled = false;
    }
    
    
    public void ToFirstSettingsScene()
    {
        _firstSettingsScene.enabled = true;
        _midSettingsScene.enabled = false;
        _lastSettingsScene.enabled = false;
    }

    public void ToMidSettingsScene()
    {
        _midSettingsScene.enabled = true;
        _firstSettingsScene.enabled = false;
        _lastSettingsScene.enabled = false;
    }

    public void ToLastSettingsScene()
    {
        _lastSettingsScene.enabled = true;
        _midSettingsScene.enabled = false;
        _firstSettingsScene.enabled = false;
    }
    public void toMainMenu()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
