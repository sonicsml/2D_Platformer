public interface IItem : ICollectible
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    void PlayCollectSound();

    void Pickup();

    void Use();
}
