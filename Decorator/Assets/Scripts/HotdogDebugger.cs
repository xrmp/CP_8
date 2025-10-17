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
        // Демонстрация базовых хот-догов
        DebugBasicHotdogs();

        // Демонстрация с SO
        DebugHotdogsWithSO();
    }

    private void DebugBasicHotdogs()
    {
        Debug.Log("=== БАЗОВЫЕ ХОТ-ДОГИ ===");

        Hotdog classic = new ClassicHotdog();
        Debug.Log($"{classic.GetName()} ({classic.GetWeight()}г) — {classic.GetCost()}р.");

        Debug.Log("Дополнительная информация:");

        Hotdog classicWithPickles = new PicklesDecorator(new ClassicHotdog());
        Debug.Log($"{classicWithPickles.GetName()} ({classicWithPickles.GetWeight()}г) — {classicWithPickles.GetCost()}р.");

        Hotdog classicWithOnion = new SweetOnionDecorator(new ClassicHotdog());
        Debug.Log($"{classicWithOnion.GetName()} ({classicWithOnion.GetWeight()}г) — {classicWithOnion.GetCost()}р.");

        Debug.Log("");
    }

    private void DebugHotdogsWithSO()
    {
        if (hotdogData == null)
        {
            Debug.LogError("HotdogData не назначен в инспекторе!");
            return;
        }

        Debug.Log("=== ХОТ-ДОГИ С SCRIPTABLE OBJECTS ===");

        Hotdog classicSO = new ClassicHotdogSO(hotdogData);
        Debug.Log($"{classicSO.GetName()} ({classicSO.GetWeight()}г) — {classicSO.GetCost()}р.");

        Debug.Log("Дополнительная информация:");

        Hotdog classicWithPicklesSO = new PicklesDecoratorSO(new ClassicHotdogSO(hotdogData), hotdogData);
        Debug.Log($"{classicWithPicklesSO.GetName()} ({classicWithPicklesSO.GetWeight()}г) — {classicWithPicklesSO.GetCost()}р.");

        Hotdog classicWithOnionSO = new SweetOnionDecoratorSO(new ClassicHotdogSO(hotdogData), hotdogData);
        Debug.Log($"{classicWithOnionSO.GetName()} ({classicWithOnionSO.GetWeight()}г) — {classicWithOnionSO.GetCost()}р.");

        Debug.Log("");

        // Демонстрация других хот-догов
        Hotdog caesarSO = new CaesarHotdogSO(hotdogData);
        Hotdog meatSO = new MeatHotdogSO(hotdogData);

        Debug.Log($"{caesarSO.GetName()} ({caesarSO.GetWeight()}г) — {caesarSO.GetCost()}р.");
        Debug.Log($"{meatSO.GetName()} ({meatSO.GetWeight()}г) — {meatSO.GetCost()}р.");

        // С декораторами
        Hotdog caesarWithPickles = new PicklesDecoratorSO(new CaesarHotdogSO(hotdogData), hotdogData);
        Debug.Log($"{caesarWithPickles.GetName()} ({caesarWithPickles.GetWeight()}г) — {caesarWithPickles.GetCost()}р.");
    }
}