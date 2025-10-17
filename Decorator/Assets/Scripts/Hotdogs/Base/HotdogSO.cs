public abstract class HotdogSO : Hotdog
{
    protected HotdogData hotdogData;

    public HotdogSO(string name, HotdogData data) : base(name)
    {
        hotdogData = data;
    }
}