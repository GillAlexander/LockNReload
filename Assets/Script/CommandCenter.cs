using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandCenter : MonoBehaviour
{
    [SerializeField] private Squadron selectedSquad;

    public void MoveCommand(Vector3 destination)
    {
        MoveCommand command = new MoveCommand();
        command.destination = destination;
        selectedSquad.GiveCommand(command);
    }
}

public class MoveCommand
{
    public Vector3 destination;
}
