public class SweetOnionDecoratorSO : HotdogDecorator
{
    private HotdogData hotdogData;

    public SweetOnionDecoratorSO(Hotdog hotdog, HotdogData data) : base(hotdog, data.sweetOnionDecorator.name)
    {
        hotdogData = data;
    }

    public override string GetName()
    {
        return decoratedHotdog.GetName() + " " + hotdogData.sweetOnionDecorator.name;
    }

    public override int GetCost()
    {
        return decoratedHotdog.GetCost() + hotdogData.sweetOnionDecorator.additionalCost;
    }

    public override int GetWeight()
    {
        return decoratedHotdog.GetWeight() + hotdogData.sweetOnionDecorator.additionalWeight;
    }
}