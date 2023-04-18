using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SMContext : MonoBehaviour
{
    public State CurrentState { get; private set; }

    private bool _isTransitioning;
    public Stack<State> history = new Stack<State>();

    public void HandleInput()
    {
        CurrentState.HandleInput();
    }

    public void CheckState()
    {
        CurrentState.CheckState();
    }

    public void ChangeStateTo(State newState)
    {
        StartCoroutine(StateTransition(newState));
    }

    private IEnumerator StateTransition(State newState)
    {
        if (_isTransitioning || CurrentState == newState)
        {
            yield break;
        }

        _isTransitioning = true;

        if (!history.Contains(newState))
        {
            history.Push(newState);
        }

        if (CurrentState != null)
        {
            yield return StartCoroutine(CurrentState.Exit());
        }

        CurrentState = newState;
        StartCoroutine(CurrentState.Enter());

        _isTransitioning = false;
    }
}