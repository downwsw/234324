using System;

// Интерфейс для управления пристроями
interface IRemoteControl
{
    void TurnOn();
    void TurnOff();
    void SetChannel(int channel);
}

// Класс для управления телевизором
class TvRemoteControl : IRemoteControl
{
    public void TurnOn()
    {
        Console.WriteLine("Телевизор включен");
    }

    public void TurnOff()
    {
        Console.WriteLine("Телевизор выключен");
    }

    public void SetChannel(int channel)
    {
        Console.WriteLine("Канал телевизора установлен на: " + channel);
    }
}

// Класс для управления радио
class RadioRemoteControl : IRemoteControl
{
    public void TurnOn()
    {
        Console.WriteLine("Радио включено");
    }

    public void TurnOff()
    {
        Console.WriteLine("Радио выключено");
    }

    public void SetChannel(int channel)
    {
        Console.WriteLine("Радиостанция установлена на: " + channel);
    }
}

// Главный класс программы
class Program
{
    static void Main()
    {
        // Создаем пульт для телевизора
        IRemoteControl tvRemote = new TvRemoteControl();
        Console.WriteLine("=== Управление телевизором ===");
        tvRemote.TurnOn();
        tvRemote.SetChannel(5);
        tvRemote.TurnOff();

        Console.WriteLine();

        // Создаем пульт для радио
        IRemoteControl radioRemote = new RadioRemoteControl();
        Console.WriteLine("=== Управление радио ===");
        radioRemote.TurnOn();
        radioRemote.SetChannel(101);
        radioRemote.TurnOff();
    }
}
