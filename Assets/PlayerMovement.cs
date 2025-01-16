using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [Range(0,3)]
    public float speed = 1.5f;
    private float sprintMultiplier = 2;
    private bool isSprint = false;
    private Vector2 _move;

    void Update() {
        if(isSprint) {
            transform.Translate(_move * Time.deltaTime * speed * sprintMultiplier);
        }
        else {
            transform.Translate(_move * Time.deltaTime * speed);
        }

        // Async & Sync Programming
        // CoRoutines
    }

    void OnMove(InputValue inputValue) {
        _move = inputValue.Get<Vector2>();
        print(_move);
    }

    void OnSprint() {
        isSprint = true;
    }

    void OnCancel() {
        isSprint = false;
    }
}
