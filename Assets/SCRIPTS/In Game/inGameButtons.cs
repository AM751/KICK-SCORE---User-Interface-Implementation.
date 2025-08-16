using UnityEngine;

public class inGameButtons : MonoBehaviour
{
    [SerializeField] public Canvas _playerSprintCanvas;
    [SerializeField] private Canvas _playerDribbleCanvas;
    [SerializeField] private Canvas _playerShootCanvas;
    public void PlayerSprints()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _playerSprintCanvas.enabled = true;
        }

        else
        {
            _playerSprintCanvas.enabled = false;
        }
        Debug.Log("PlayerSprints");
    }

    public void PlayerDribblingSkill()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _playerDribbleCanvas.enabled = true;
        }

        else
        {
            _playerDribbleCanvas.enabled = false;
        }
        Debug.Log("That’s a skilled dribble by the player to outplay the opponent..");
    }

    public void PowerShot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _playerShootCanvas.enabled = true;
        }

        else
        {
            _playerShootCanvas.enabled = false;
        }
        Debug.Log("Its a powerful shot by the player..");
    }
}
