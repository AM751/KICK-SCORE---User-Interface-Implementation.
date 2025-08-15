using UnityEngine;

public class PlayerLowOnHealth : MonoBehaviour
{
    [SerializeField] public Canvas playerLowOnHealthDUI;

    void Start()
    {
        playerLowOnHealthDUI.enabled = true;
    }

    // private void PlayerLowOnHealthShow()
    // {
    //     if (Input.GetKeyDown(KeyCode.L))
    //     {
    //         playerLowOnHealthDUI.enabled = true;
    //     }
    //
    //     if (Input.GetKeyUp(KeyCode.L))
    //     {
    //         playerLowOnHealthDUI.enabled = false;
    //     }
    // }
    //
    // // Update is called once per frame
    // void Update()
    // {
    //     PlayerLowOnHealthShow();
    // }
    
}
