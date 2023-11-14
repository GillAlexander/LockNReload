using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Soldier : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent = null;
    private Vector3 currentDestination;


    public void RecievingCommand(MoveCommand command)
    {
        currentDestination = command.destination;

        
        agent.SetDestination(currentDestination);
        Debug.LogError(currentDestination);
        
    }
}
