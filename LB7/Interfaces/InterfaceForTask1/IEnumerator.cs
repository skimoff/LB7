namespace LB7;

public interface IEnumerator
{
    bool MoveNext();
    void Reset();
    object Current { get; }
}