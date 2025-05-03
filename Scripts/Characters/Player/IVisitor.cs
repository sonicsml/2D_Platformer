public interface IVisitor
{
    void Collect(Coin coin);
    void Collect(MedKit medkit);
}