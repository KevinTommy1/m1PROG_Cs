
public class PlayerContext
{
Schrijf nu in deze textfile:
    - alle `Types` op die je ziet in deze `codefile`    public Room room;
    public PlayerSprite player;
    internal bool noDoor = false;
    internal int camX;
    internal int camY;
    internal readonly KeyBind[] keysdown = new KeyBind[5];
    internal int lastKeyDown;
    internal Bitmap buffer;
    internal Graphics g;
    internal int totalGoldPicked;
    internal readonly int index;
    internal string name;
    internal float runTime = 3;
}