

[System.Flags]    
public enum Dir
    {
        Up = 1,
        Down = 2,
        Left = 4,
        Right = 8,

        LU = Left | Up,
        LD = Left | Down,
        RU = Right | Up,
        RD = Right | Down
    }

