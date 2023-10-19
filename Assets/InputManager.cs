using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager
{
    private static NewControls _gameControls;
    public static void Init(PlayerMovement myPlayer)
    {
        _gameControls = new NewControls();

        //_gameControls.Permanent.Enable();

        _gameControls.InGame.Movement.performed += ctx =>
        {
            myPlayer.SetMovementDirection(ctx.ReadValue<Vector3>());
        };


        SetGameControls();
    }


    public static void SetGameControls()
    {
        _gameControls.InGame.Enable();

    }
}
