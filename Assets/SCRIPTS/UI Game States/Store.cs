using UnityEngine;
using UnityEngine.SceneManagement;

public class Store : MonoBehaviour
{
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
