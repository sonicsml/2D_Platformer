using System;

public class Coin : BaseItem
{
    public event Action<Coin> OnCollectedCoin;

    protected override void OnAccept(IVisitor visitor)
    {
        OnCollectedCoin?.Invoke(this);
        visitor.Collect(this);
    }
}