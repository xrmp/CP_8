public abstract class HotdogDecorator : Hotdog
{
    protected Hotdog decoratedHotdog;

    public HotdogDecorator(Hotdog hotdog, string decoratorName) : base(hotdog.GetName() + " " + decoratorName)
    {
        decoratedHotdog = hotdog;
    }

    public override string GetName()
    {
        return decoratedHotdog.GetName();
    }

    public override int GetCost()
    {
        return decoratedHotdog.GetCost();
    }

    public override int GetWeight()
    {
        return decoratedHotdog.GetWeight();
    }
}