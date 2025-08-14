using UnityEngine;
using UnityEngine.SceneManagement;

public class TeamChoosingManager : MonoBehaviour
{
    [SerializeField] private Canvas _teamChoosingCanvas;
    [SerializeField] private Canvas _conformationCanvas;

    void Start()
    {
        _teamChoosingCanvas.enabled = true;
        _conformationCanvas.enabled = false;
    }
    public void MainMenuScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void KickOff()
    {
        _conformationCanvas.enabled = true;
        _teamChoosingCanvas.enabled = false;
    }

    public void BackatKickOff()
    {
        _teamChoosingCanvas.enabled = true;
        _conformationCanvas.enabled = false;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("GamePlay");
    }
}
