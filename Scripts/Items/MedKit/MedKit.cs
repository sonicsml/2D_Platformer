using System;

public class MedKit : BaseItem
{
    public event Action<MedKit> OnCollectedMedkit;

    protected override void OnAccept(IVisitor visitor)
    {
        OnCollectedMedkit?.Invoke(this);
        visitor.Collect(this);
    }
}