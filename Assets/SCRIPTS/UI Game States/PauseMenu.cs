using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public void BackToGame()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void ViewStats()
    {
        SceneManager.LoadScene("Stats");
    }

    public void CallOff()
    {
        SceneManager.LoadScene("CalledOffWarning");
    }
}
