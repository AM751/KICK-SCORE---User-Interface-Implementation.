using UnityEngine;

public class SettingsMidScene : MonoBehaviour
{
    [SerializeField] private Canvas _firstSettingsScene;
    [SerializeField] private Canvas _lastSettingsScene;

    void Start()
    {
        // _firstSettingsScene.enabled = false;
        // _lastSettingsScene.enabled = false;
    }

    public void ToFirstSettingsScene()
    {
        _firstSettingsScene.enabled = true;
        _lastSettingsScene.enabled = false;
    }
    
    public void ToLastSettingsScene()
    {
        _lastSettingsScene.enabled = true;
        _firstSettingsScene.enabled = false;
    }
    
}
