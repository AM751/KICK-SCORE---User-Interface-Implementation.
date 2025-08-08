using UnityEngine;

public class PlayerInformationPanel : MonoBehaviour
{
    [SerializeField] public Canvas playerHealthSUI;

    void Start()
    {
        playerHealthSUI.enabled = false;
    }
    private void PlayerHealthShow()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            playerHealthSUI.enabled = true;
        }
        if (Input.GetKeyUp(KeyCode.I))
        {
            playerHealthSUI.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        PlayerHealthShow();
    }
}
