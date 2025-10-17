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

    [Header("������� ���-����")]
    public HotdogConfig classicHotdog = new HotdogConfig
    {
        name = "���-��� ������������",
        baseCost = 210,
        baseWeight = 150
    };

    public HotdogConfig caesarHotdog = new HotdogConfig
    {
        name = "���-��� ������",
        baseCost = 290,
        baseWeight = 165
    };

    public HotdogConfig meatHotdog = new HotdogConfig
    {
        name = "���-��� ������",
        baseCost = 330,
        baseWeight = 188
    };

    [Header("�������������� �����������")]
    public DecoratorConfig picklesDecorator = new DecoratorConfig
    {
        name = "� ������������� ��������",
        additionalCost = 50,
        additionalWeight = 20
    };

    public DecoratorConfig sweetOnionDecorator = new DecoratorConfig
    {
        name = "�� ������� �����",
        additionalCost = 30,
        additionalWeight = 10
    };
}