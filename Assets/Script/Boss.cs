using UnityEngine;

public class Boss : MonoBehaviour {
    const int SPEEL_NUM = 3;

    public float timeOneTwoThree;
    public float timeWood;
    public float timeAtteck;
    public float timeCD;

    public AudioClip seOneTwoThree;
    public AudioClip seWood;
    public AudioClip seAttack;

    PlayerGen playerGen;
    SpriteRenderer spriteRenderer;
    AudioSource audioSource;
    Transform[] spellPoses = new Transform[SPEEL_NUM];
    Spell[] spells = new Spell[SPEEL_NUM];

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
        playerGen = transform.parent.GetComponent<PlayerGen>();
        spriteRenderer = transform.Find("Sprite").GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
        for (int i = 0; i < SPEEL_NUM; i++) {
            spellPoses[i] = transform.Find("SpellPos" + i);
            spells[i] = Instantiate(Resources.Load<Spell>("Spell"), spellPoses[i]);
            if (i >= 2)
                spells[i].EndUse();
        }
    }

    void Update() {
        switch (state) {
        case State.Normal:
            if (Input.GetMouseButtonDown(0)) {
                audioSource.PlayOneShot(seOneTwoThree);
                Next(State.OneTwoThree);
            }
            break;
        case State.OneTwoThree:
            if (Input.GetMouseButtonUp(0)) {
                audioSource.Stop();
                Next(State.CD);
            } else if (Time.time >= time + timeOneTwoThree) {
                Next(State.Wood);
            }
            break;
        case State.Wood:
            if (Input.GetMouseButtonUp(0)) {
                audioSource.Stop();
                audioSource.PlayOneShot(seWood);
                Next(State.Attack);
            } else if (Time.time >= time + timeWood) {
                Next(State.CD);
            }
            break;
        case State.Attack:
            if (Time.time >= time + timeAtteck) {
                Next(State.CD);
            }
            break;
        case State.CD:
            if (Time.time >= time + timeCD) {
                Next(State.Normal);
            }
            break;
        }
    }

    void Next(State next) {
        time = Time.time;
        
        // 實際上是換圖、先用顏色代替
        switch (next) {
        case State.Normal:
            spriteRenderer.color = Color.white;
            break;
        case State.OneTwoThree:
            spriteRenderer.color = Color.yellow;
            break;
        case State.Wood:
            spriteRenderer.color = new Color(1f, 0.5f, 0f);
            break;
        case State.Attack:
            spriteRenderer.color = Color.red;
            break;
        case State.CD:
            spriteRenderer.color = Color.blue;
            break;
        }

        state = next;
    }

    void Attack() {
        for (int i = 0; i < PlayerGen.PLAYER_NUM; i++) {
            if (PlayerChoose.playerchoose[i] == i + 1) {
                if (playerGen.players[i].IfEating)
                    playerGen.players[i].Ifgethit = true;
            }
        }
        Next(State.CD);
    }
}
