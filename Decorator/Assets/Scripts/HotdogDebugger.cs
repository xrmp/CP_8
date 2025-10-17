using UnityEngine;

public class HotdogDebugger : MonoBehaviour
{
    [SerializeField] private HotdogData hotdogData;

    void Start()
    {
        DebugHotdogs();
    }

    private void DebugHotdogs()
    {
        // ������������ ������� ���-�����
        DebugBasicHotdogs();

        // ������������ � SO
        DebugHotdogsWithSO();
    }

    private void DebugBasicHotdogs()
    {
        Debug.Log("=== ������� ���-���� ===");

        Hotdog classic = new ClassicHotdog();
        Debug.Log($"{classic.GetName()} ({classic.GetWeight()}�) � {classic.GetCost()}�.");

        Debug.Log("�������������� ����������:");

        Hotdog classicWithPickles = new PicklesDecorator(new ClassicHotdog());
        Debug.Log($"{classicWithPickles.GetName()} ({classicWithPickles.GetWeight()}�) � {classicWithPickles.GetCost()}�.");

        Hotdog classicWithOnion = new SweetOnionDecorator(new ClassicHotdog());
        Debug.Log($"{classicWithOnion.GetName()} ({classicWithOnion.GetWeight()}�) � {classicWithOnion.GetCost()}�.");

        Debug.Log("");
    }

    private void DebugHotdogsWithSO()
    {
        if (hotdogData == null)
        {
            Debug.LogError("HotdogData �� �������� � ����������!");
            return;
        }

        Debug.Log("=== ���-���� � SCRIPTABLE OBJECTS ===");

        Hotdog classicSO = new ClassicHotdogSO(hotdogData);
        Debug.Log($"{classicSO.GetName()} ({classicSO.GetWeight()}�) � {classicSO.GetCost()}�.");

        Debug.Log("�������������� ����������:");

        Hotdog classicWithPicklesSO = new PicklesDecoratorSO(new ClassicHotdogSO(hotdogData), hotdogData);
        Debug.Log($"{classicWithPicklesSO.GetName()} ({classicWithPicklesSO.GetWeight()}�) � {classicWithPicklesSO.GetCost()}�.");

        Hotdog classicWithOnionSO = new SweetOnionDecoratorSO(new ClassicHotdogSO(hotdogData), hotdogData);
        Debug.Log($"{classicWithOnionSO.GetName()} ({classicWithOnionSO.GetWeight()}�) � {classicWithOnionSO.GetCost()}�.");

        Debug.Log("");

        // ������������ ������ ���-�����
        Hotdog caesarSO = new CaesarHotdogSO(hotdogData);
        Hotdog meatSO = new MeatHotdogSO(hotdogData);

        Debug.Log($"{caesarSO.GetName()} ({caesarSO.GetWeight()}�) � {caesarSO.GetCost()}�.");
        Debug.Log($"{meatSO.GetName()} ({meatSO.GetWeight()}�) � {meatSO.GetCost()}�.");

        // � ������������
        Hotdog caesarWithPickles = new PicklesDecoratorSO(new CaesarHotdogSO(hotdogData), hotdogData);
        Debug.Log($"{caesarWithPickles.GetName()} ({caesarWithPickles.GetWeight()}�) � {caesarWithPickles.GetCost()}�.");
    }
}