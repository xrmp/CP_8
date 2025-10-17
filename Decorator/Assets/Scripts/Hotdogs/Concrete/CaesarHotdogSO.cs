public class CaesarHotdogSO : HotdogSO
{
    public CaesarHotdogSO(HotdogData data) : base(data.caesarHotdog.name, data)
    {
        cost = data.caesarHotdog.baseCost;
        weight = data.caesarHotdog.baseWeight;
    }
}