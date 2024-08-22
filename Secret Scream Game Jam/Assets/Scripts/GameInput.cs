using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{
    private PlayerInputActions playerInputActions;
    private PlayerInputActions.PlayerActions player;
    private PlayerController playerController;

    void Awake()
    {
        playerInputActions = new PlayerInputActions();
        player = playerInputActions.Player;
        playerController = GetComponent<PlayerController>();
    }

    void FixedUpdate()
    {
        playerController.OnMovement(player.Movement.ReadValue<Vector2>()); 
    }

    public void OnEnable()
    {
        player.Enable();
    }

    public void OnDisable()
    {
        player.Disable();
    }
}
