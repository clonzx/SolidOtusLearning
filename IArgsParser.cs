namespace Solid
{
    /// <summary>
    /// Интерфейс обработчика аргументов командной строки
    /// </summary>
    public interface IArgsParser
    {
        void Parse(string[] args);
    }
}
