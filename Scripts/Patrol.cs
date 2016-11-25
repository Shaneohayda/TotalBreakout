﻿using UnityEngine;
using System.Collections;


public class Patrol : MonoBehaviour
{

    public Transform[] points;
    private int currectNode = 0;
    private NavMeshAgent agent;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        // Disabling auto-braking allows for continuous movement
        // between points (ie, the agent doesn't slow down as it
        // approaches a destination point).
        agent.autoBraking = false;

        GotoNextNode();
    }


    void GotoNextNode()
    {
        // Returns if no points have been set up
        if (points.Length == 0)
            return;

        // Set the agent to go to the currently selected destination.
        agent.destination = points[currectNode].position;

        // Choose the next point in the array as the destination,
        // cycling to the start if necessary.
        currectNode = (currectNode + 1) % points.Length;
    }


    void Update()
    {
        // Choose the next destination point when the agent gets
        // close to the current one.
        if (agent.remainingDistance < 5.0f)
            GotoNextNode();
    }
}