namespace Solid;

/// <summary>
/// Интерфейс ввода-вывода
/// </summary>
public interface IGameIO
{
    void WriteMessage(string message);
    int ReadNumber();
}
