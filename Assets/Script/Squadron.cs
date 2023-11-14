using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squadron : MonoBehaviour
{
    public Soldier[] soldiers;

    public Vector3[][] grid;

    private MoveCommand currentCommand;

    private void Start()
    {
        for (int i = 0; i < soldiers.Length; i++)
        {
            for(int j = 0; j < grid.Length; j++) { }
        }
    }

    public void GiveCommand(MoveCommand command)
    {
        currentCommand = command;

        for(int i = 0; i < soldiers.Length; i++)
        {
            soldiers[i].RecievingCommand(currentCommand);
        }
    }
}
