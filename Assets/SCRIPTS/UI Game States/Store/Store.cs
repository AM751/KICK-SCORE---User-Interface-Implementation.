using UnityEngine;
using UnityEngine.SceneManagement;

public class Store : MonoBehaviour
{
    [SerializeField] private Canvas _playersCanvas;
    [SerializeField] private Canvas _stadiumCanvas;
    [SerializeField] private Canvas _kitsCanvas;

    void Start()
    {
        _playersCanvas.enabled = true;
        _stadiumCanvas.enabled = false;
        _kitsCanvas.enabled = false;
    }

    public void PlayersCanvas()
    {
        _playersCanvas.enabled = true;
        _stadiumCanvas.enabled = false;
        _kitsCanvas.enabled = false;
    }

    public void StadiumCanvas()
    {
        _stadiumCanvas.enabled = true;
        _kitsCanvas.enabled = false;
        _playersCanvas.enabled = false;
    }

    public void KitsCanvas()
    {
        _kitsCanvas.enabled = true;
        _stadiumCanvas.enabled = false;
        _playersCanvas.enabled = false;
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
