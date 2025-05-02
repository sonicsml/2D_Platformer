using System;

public class Coin : BaseItem
{
    public static Action<float> OnItemCollected;

    public void Pickup() {}

    public override void Use() {}
}