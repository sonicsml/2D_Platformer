public interface ICollectible 
{
    void Accept(IVisitor visitor);
}