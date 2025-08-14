using UnityEngine;

public class SettingsLastScene : MonoBehaviour
{
    [SerializeField] private Canvas _midSettingsScene;
    //[SerializeField] private Canvas _lastSettingsScene;

    void Start()
    {
        //_lastSettingsScene.enabled = true;
        _midSettingsScene.enabled = false;
    }
    
    public void ToMidSettingsScene()
    {
        _midSettingsScene.enabled = true;
    }
}
