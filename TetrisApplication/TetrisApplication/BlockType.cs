namespace TetrisApplication
{
    // ミノの型
    public enum MinoType
    {
        None,
        T,
        O,
        J,
        L,
        I,
        S,
        Z
    };

    public enum BlockState
    {
        // 空のブロック
        None,
        // 何かしらのブロック
        Occupied
    };
}
