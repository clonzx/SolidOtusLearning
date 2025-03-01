namespace Solid;

/// <summary>
/// Вввод-вывод с консоли
/// </summary>
public class ConsoleGameIO : IGameIO
{
    public void WriteMessage(string message)
    {
        Console.WriteLine(message);
    }

    public int ReadNumber()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                return result;
            }
            WriteMessage("Пожалуйста, введите корректное число");
        }
    }
}
