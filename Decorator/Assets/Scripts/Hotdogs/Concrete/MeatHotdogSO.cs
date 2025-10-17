public class MeatHotdogSO : HotdogSO
{
    public MeatHotdogSO(HotdogData data) : base(data.meatHotdog.name, data)
    {
        cost = data.meatHotdog.baseCost;
        weight = data.meatHotdog.baseWeight;
    }
}