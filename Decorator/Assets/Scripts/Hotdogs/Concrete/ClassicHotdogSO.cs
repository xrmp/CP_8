public class ClassicHotdogSO : HotdogSO
{
    public ClassicHotdogSO(HotdogData data) : base(data.classicHotdog.name, data)
    {
        cost = data.classicHotdog.baseCost;
        weight = data.classicHotdog.baseWeight;
    }
}