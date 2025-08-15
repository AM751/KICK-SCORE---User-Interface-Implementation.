using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    [SerializeField] public AudioSource animationButtonClick;
    public void StartGame()
    {
        animationButtonClick.Play();
        SceneManager.LoadScene("TeamChoosingScene");
    }

    public void ViewStore()
    {
        animationButtonClick.Play();
        SceneManager.LoadScene("Store");
    }

    public void ViewSettings()
    {
        animationButtonClick.Play();
        SceneManager.LoadScene("Settings");
    }
    
}
