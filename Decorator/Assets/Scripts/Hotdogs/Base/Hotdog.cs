using UnityEngine;

public abstract class Hotdog
{
    protected string name;
    protected int cost;
    protected int weight;

    public Hotdog(string name)
    {
        this.name = name;
    }

    public virtual string GetName()
    {
        return name;
    }

    public virtual int GetCost()
    {
        return cost;
    }

    public virtual int GetWeight()
    {
        return weight;
    }
}