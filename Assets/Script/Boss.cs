using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour {
    public float timeOneTwoThree;
    public float timeWood;
    public float timeAtteck;
    public float timeCD;

    SpriteRenderer spriteRenderer;

    enum State {
        Normal,
        OneTwoThree,
        Wood,
        Attack,
        CD
    }
    State state = State.Normal;

    float time = 0f;

    void Awake() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update() {
        switch (state) {
        case State.Normal:
            if (Input.GetMouseButtonDown(0)) {
                spriteRenderer.color = Color.yellow;
                time = Time.time;
                state = State.OneTwoThree;
            }
            break;
        case State.OneTwoThree:
            if (Input.GetMouseButtonUp(0)) {
                spriteRenderer.color = Color.blue;
                time = Time.time;
                state = State.CD;
            } else if (Time.time >= time + timeOneTwoThree) {
                spriteRenderer.color = new Color(1f, 0.5f, 0f);
                time = Time.time;
                state = State.Wood;
            }
            break;
        case State.Wood:
            if (Input.GetMouseButtonUp(0)) {
                spriteRenderer.color = Color.blue;
                time = Time.time;
                state = State.CD;
            } else if (Time.time >= time + timeWood) {
                spriteRenderer.color = Color.red;
                state = State.Attack;
            }
            break;
        case State.Attack:
            if (Time.time >= time + timeAtteck) {
                spriteRenderer.color = Color.blue;
                time = Time.time;
                state = State.CD;
            }
            break;
        case State.CD:
            if (Time.time >= time + timeCD) {
                spriteRenderer.color = Color.white;
                state = State.Normal;
            }
            break;
        }
    }
}
