using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void ViewStore()
    {
        SceneManager.LoadScene("Store");
    }

    public void ViewSettings()
    {
        SceneManager.LoadScene("Settings");
    }
}
