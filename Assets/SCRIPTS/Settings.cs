using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    public void toMainMenu()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
