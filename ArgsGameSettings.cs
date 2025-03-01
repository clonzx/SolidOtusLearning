namespace Solid;

/// <summary>
/// Реализация настроек, через список аргументов командной строки.
/// Если аргументы не переданы, используются настройки базового класса.
/// Предполагается, что переданы 3 числа: число попыток и границы диапазона. 
/// </summary>
public class ArgsGameSettings : StaticGameSettings, IArgsParser
{
    public void Parse(string[] args)
    {
        if (args.Length > 2)
        {
            if (int.TryParse(args[0], out int maxAttepts))
                MaxAttempts = maxAttepts;
            if (int.TryParse(args[1], out int minValue) && int.TryParse(args[2], out int maxValue))
                Range = (minValue, maxValue);
        }
    }
}
