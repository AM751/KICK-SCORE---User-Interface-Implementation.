using UnityEngine;
using UnityEngine.SceneManagement;

public class Stats : MonoBehaviour
{
    [SerializeField] private AudioSource _buttonClickSound;
    public void PauseGame()
    {
        _buttonClickSound.Play();
        SceneManager.LoadScene("PauseMenu");
    }
}
