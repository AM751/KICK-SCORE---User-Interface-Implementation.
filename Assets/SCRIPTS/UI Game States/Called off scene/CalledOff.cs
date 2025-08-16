using UnityEngine;
using UnityEngine.SceneManagement;

public class CalledOff : MonoBehaviour
{
    [SerializeField] public AudioSource buttonClick;
    public void MainMenu()
    {
        buttonClick.Play();
        SceneManager.LoadScene("SampleScene");
    }

    public void AgainGamePaused()
    {
        buttonClick.Play();
        SceneManager.LoadScene("PauseMenu");
    }
}
