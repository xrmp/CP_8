public class PicklesDecorator : HotdogDecorator
{
    private int picklesCost = 50;
    private int picklesWeight = 20;

    public PicklesDecorator(Hotdog hotdog) : base(hotdog, "� ������������� ��������")
    {
    }

    public override string GetName()
    {
        return decoratedHotdog.GetName() + " � ������������� ��������";
    }

    public override int GetCost()
    {
        return decoratedHotdog.GetCost() + picklesCost;
    }

    public override int GetWeight()
    {
        return decoratedHotdog.GetWeight() + picklesWeight;
    }
}