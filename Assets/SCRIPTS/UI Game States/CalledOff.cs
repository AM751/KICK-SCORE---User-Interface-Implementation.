using UnityEngine;
using UnityEngine.SceneManagement;

public class CalledOff : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void AgainGamePaused()
    {
        SceneManager.LoadScene("PauseMenu");
    }
}
