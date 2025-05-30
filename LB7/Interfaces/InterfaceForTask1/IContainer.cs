namespace LB7;

public interface IContainer
{
    int Count { get; }
    Object this[int index] { get; set; }

    void Add(Device element);
    void Delete(Device element);
}