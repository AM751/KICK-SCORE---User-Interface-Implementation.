using UnityEngine;
using UnityEngine.SceneManagement;

public class TeamChoosingManager : MonoBehaviour
{
    [SerializeField] private Canvas _teamChoosingCanvas;
    [SerializeField] private Canvas _conformationCanvas;
    [SerializeField] private AudioSource _buttonClickSound;
    [SerializeField] private AudioSource _whistleClickSound;

    void Start()
    {
        _teamChoosingCanvas.enabled = true;
        _conformationCanvas.enabled = false;
    }
    public void MainMenuScene()
    {
        _buttonClickSound.Play();
        SceneManager.LoadScene("SampleScene");
    }

    public void KickOff()
    {
        _whistleClickSound.Play();
        _conformationCanvas.enabled = true;
        _teamChoosingCanvas.enabled = false;
    }

    public void BackatKickOff()
    {
        
        _buttonClickSound.Play();
        _teamChoosingCanvas.enabled = true;
        _conformationCanvas.enabled = false;
    }

    public void PlayGame()
    {
        _whistleClickSound.Play();
        SceneManager.LoadScene("GamePlay");
    }
}
