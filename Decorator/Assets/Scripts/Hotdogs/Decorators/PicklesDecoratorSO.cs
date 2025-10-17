public class PicklesDecoratorSO : HotdogDecorator
{
    private HotdogData hotdogData;

    public PicklesDecoratorSO(Hotdog hotdog, HotdogData data) : base(hotdog, data.picklesDecorator.name)
    {
        hotdogData = data;
    }

    public override string GetName()
    {
        return decoratedHotdog.GetName() + " " + hotdogData.picklesDecorator.name;
    }

    public override int GetCost()
    {
        return decoratedHotdog.GetCost() + hotdogData.picklesDecorator.additionalCost;
    }

    public override int GetWeight()
    {
        return decoratedHotdog.GetWeight() + hotdogData.picklesDecorator.additionalWeight;
    }
}