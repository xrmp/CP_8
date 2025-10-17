public class SweetOnionDecorator : HotdogDecorator
{
    private int onionCost = 30;
    private int onionWeight = 10;

    public SweetOnionDecorator(Hotdog hotdog) : base(hotdog, "�� ������� �����")
    {
    }

    public override string GetName()
    {
        return decoratedHotdog.GetName() + " �� ������� �����";
    }

    public override int GetCost()
    {
        return decoratedHotdog.GetCost() + onionCost;
    }

    public override int GetWeight()
    {
        return decoratedHotdog.GetWeight() + onionWeight;
    }
}