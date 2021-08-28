using UnityEngine;

public static class InputButtonDown {
    // 1. Button down properties.
    //public static bool example { get { return IsButtonDown(exampleButton); } }

    // 2. Button down repeatedly properties. (Optional)
    //public static bool exampleRepeat { get { return IsButtonDown(exampleButton, true); } }

    class Button {
        public string axis;
        public bool isNegative;
        public bool isPressed;
        public float nextTime;

        public Button(string axis) {
            this.axis = axis;
        }

        public Button(string axis, bool isNegative) {
            this.axis = axis;
            this.isNegative = isNegative;
        }
    }
    // 3. Button objects. Set axis name and is negative here.
    static Button upButton1 = new Button("Vertical_P1");
    static Button downButton1 = new Button("Vertical_P1", true);
    static Button leftButton1 = new Button("Horizontal_P1", true);
    static Button rightButton1 = new Button("Horizontal_P1");
    static Button actButton1 = new Button("Act_P1");
    static Button upButton2 = new Button("Vertical_P2");
    static Button downButton2 = new Button("Vertical_P2", true);
    static Button leftButton2 = new Button("Horizontal_P2", true);
    static Button rightButton2 = new Button("Horizontal_P2");
    static Button actButton2 = new Button("Act_P2");
    static Button upButton3 = new Button("Vertical_P3");
    static Button downButton3 = new Button("Vertical_P3", true);
    static Button leftButton3 = new Button("Horizontal_P3", true);
    static Button rightButton3 = new Button("Horizontal_P3");
    static Button actButton3 = new Button("Act_P3");
    static Button upButton4 = new Button("Vertical_P4");
    static Button downButton4 = new Button("Vertical_P4", true);
    static Button leftButton4 = new Button("Horizontal_P4", true);
    static Button rightButton4 = new Button("Horizontal_P4");
    static Button actButton4 = new Button("Act_P4");

    // 4. Repeat threshold and speed.
    static float threshold = 0f;
    static float speed = 0f;

    public static bool Up(int player) {
        switch (player) {
        case 1:
            return IsButtonDown(upButton1);
        case 2:
            return IsButtonDown(upButton2);
        case 3:
            return IsButtonDown(upButton3);
        case 4:
            return IsButtonDown(upButton4);
        default:
            Debug.LogError("Only 1~4 players, not include " + player + "player!");
            return false;
        }
    }

    public static bool Down(int player) {
        switch (player) {
        case 1:
            return IsButtonDown(downButton1);
        case 2:
            return IsButtonDown(downButton2);
        case 3:
            return IsButtonDown(downButton3);
        case 4:
            return IsButtonDown(downButton4);
        default:
            Debug.LogError("Only 1~4 players, not include " + player + "player!");
            return false;
        }
    }

    public static bool Left(int player) {
        switch (player) {
        case 1:
            return IsButtonDown(leftButton1);
        case 2:
            return IsButtonDown(leftButton2);
        case 3:
            return IsButtonDown(leftButton3);
        case 4:
            return IsButtonDown(leftButton4);
        default:
            Debug.LogError("Only 1~4 players, not include " + player + "player!");
            return false;
        }
    }

    public static bool Right(int player) {
        switch (player) {
        case 1:
            return IsButtonDown(rightButton1);
        case 2:
            return IsButtonDown(rightButton2);
        case 3:
            return IsButtonDown(rightButton3);
        case 4:
            return IsButtonDown(rightButton4);
        default:
            Debug.LogError("Only 1~4 players, not include " + player + "player!");
            return false;
        }
    }

    public static bool Act(int player) {
        switch (player) {
        case 1:
            return IsButtonDown(actButton1);
        case 2:
            return IsButtonDown(actButton2);
        case 3:
            return IsButtonDown(actButton3);
        case 4:
            return IsButtonDown(actButton4);
        default:
            Debug.LogError("Only 1~4 players, not include " + player + "player!");
            return false;
        }
    }

    static bool IsButtonDown(Button button) {
        return IsButtonDown(button, false);
    }

    static bool IsButtonDown(Button button, bool isRepeatedly) {
        if ((button.isNegative && Input.GetAxisRaw(button.axis) < 0f)
            || (!button.isNegative && Input.GetAxisRaw(button.axis) > 0f)) {

            if ((isRepeatedly && Time.unscaledTime > button.nextTime)
                || (!isRepeatedly && !button.isPressed)) {

                if (isRepeatedly) button.nextTime = Time.unscaledTime + (button.isPressed ? speed : threshold);
                button.isPressed = true;
                return true;
            }
        } else {
            if (isRepeatedly) button.nextTime = 0f;
			button.isPressed = false;
        }
        return false;
    }
}
