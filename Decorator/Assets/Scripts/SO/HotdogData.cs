using UnityEngine;

[CreateAssetMenu(fileName = "HotdogData", menuName = "Hotdog/Hotdog Data")]
public class HotdogData : ScriptableObject
{
    [System.Serializable]
    public class HotdogConfig
    {
        public string name;
        public int baseCost;
        public int baseWeight;
    }

    [System.Serializable]
    public class DecoratorConfig
    {
        public string name;
        public int additionalCost;
        public int additionalWeight;
    }

    [Header("Базовые хот-доги")]
    public HotdogConfig classicHotdog = new HotdogConfig
    {
        name = "Хот-Дог Классический",
        baseCost = 210,
        baseWeight = 150
    };

    public HotdogConfig caesarHotdog = new HotdogConfig
    {
        name = "Хот-Дог Цезарь",
        baseCost = 290,
        baseWeight = 165
    };

    public HotdogConfig meatHotdog = new HotdogConfig
    {
        name = "Хот-Дог мясной",
        baseCost = 330,
        baseWeight = 188
    };

    [Header("Дополнительные ингредиенты")]
    public DecoratorConfig picklesDecorator = new DecoratorConfig
    {
        name = "с маринованными огурцами",
        additionalCost = 50,
        additionalWeight = 20
    };

    public DecoratorConfig sweetOnionDecorator = new DecoratorConfig
    {
        name = "со сладким луком",
        additionalCost = 30,
        additionalWeight = 10
    };
}