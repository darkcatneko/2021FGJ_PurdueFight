using UnityEngine;

public class Spell : MonoBehaviour {
    enum State {
        Useable,
        Put,
        Disapper,
        CD
    }
    State state = State.Useable;
}
