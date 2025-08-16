using UnityEngine;

public class SettingsMidScene : MonoBehaviour
{
    [SerializeField] private Canvas _firstSettingsScene;
    [SerializeField] private Canvas _lastSettingsScene;
    [SerializeField] private AudioSource _buttonClick;

    void Start()
    {
        // _firstSettingsScene.enabled = false;
        // _lastSettingsScene.enabled = false;
    }

    public void ToFirstSettingsScene()
    {
        _buttonClick.Play();
        _firstSettingsScene.enabled = true;
        _lastSettingsScene.enabled = false;
    }
    
    public void ToLastSettingsScene()
    {
        _buttonClick.Play();
        _lastSettingsScene.enabled = true;
        _firstSettingsScene.enabled = false;
    }
    
}
