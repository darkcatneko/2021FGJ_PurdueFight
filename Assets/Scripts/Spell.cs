using UnityEngine;

public class Spell : MonoBehaviour {
    public float timePut;
    public float timeAttack;
    public float timeDisappear;
    public float timeCD;

    SpriteRenderer spriteRenderer;

    enum State {
        Useable,
        Put,
        Attack,
        Disappear,
        CD
    }
    State state = State.Useable;

    float time = 0f;

    void Awake() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update() {
        switch (state) {
        case State.Useable:
            break;
        case State.Put:
            break;
        case State.Attack:
            break;
        case State.Disappear:
            if (Time.time >= time + timeDisappear) {
                EndUse();
            }
            break;
        case State.CD:
            if (Time.time >= time + timeCD) {
                spriteRenderer.enabled = true;
                Next(State.Useable);
            }
            break;
        }
    }

    void Next(State next) {
        time = Time.time;
        state = next;
    }

    public void EndUse() {
        spriteRenderer.enabled = false;
        Next(State.CD);
    }
}
