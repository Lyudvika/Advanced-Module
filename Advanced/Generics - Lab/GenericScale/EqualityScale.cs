namespace GenericScale;
public class EqualityScale<T>
{
    //fields
    private T left;
    private T right;

    //constructor
    public EqualityScale(T left, T right)
    {
        this.left = left;
        this.right = right;
    }

    //method
    public bool AreEqual()
    {
        return left.Equals(right);
    }
}