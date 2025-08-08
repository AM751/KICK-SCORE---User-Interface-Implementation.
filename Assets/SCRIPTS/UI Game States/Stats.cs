using UnityEngine;
using UnityEngine.SceneManagement;

public class Stats : MonoBehaviour
{
    public void PauseGame()
    {
        SceneManager.LoadScene("PauseMenu");
    }
}
