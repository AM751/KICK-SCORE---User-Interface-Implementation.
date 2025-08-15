using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameplay : MonoBehaviour
{
    public void GamePaused()
    {
        SceneManager.LoadScene("PauseMenu");
    }
}
