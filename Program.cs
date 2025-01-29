using System;


class CPU
{
    public string Model { get; }
    public int Cores { get; }
    public double Frequency { get; } // в ГГц

    public CPU(string model, int cores, double frequency)
    {
        Model = model;
        Cores = cores;
        Frequency = frequency;
    }

    public void Start()
    {
        Console.WriteLine($"CPU {Model} запущен с {Cores} ядрами и частотой {Frequency} ГГц.");
    }

    public void Shutdown()
    {
        Console.WriteLine("CPU выключен.");
    }
}

class RAM
{
    public int Size { get; } // в ГБ
    public int Speed { get; } // в МГц

    public RAM(int size, int speed)
    {
        Size = size;
        Speed = speed;
    }

    public void Load()
    {
        Console.WriteLine($"RAM {Size}GB загружена на {Speed} МГц.");
    }

    public void Clear()
    {
        Console.WriteLine("RAM очищена.");
    }
}


class GPU
{
    public string Model { get; }
    public int Memory { get; } // в ГБ

    public GPU(string model, int memory)
    {
        Model = model;
        Memory = memory;
    }

    public void Render()
    {
        Console.WriteLine($"GPU {Model} с {Memory}GB памяти выполняет рендеринг.");
    }

    public void Shutdown()
    {
        Console.WriteLine("GPU выключена.");
    }
}


class Computer
{
    private CPU _cpu;
    private RAM _ram;
    private GPU _gpu;

    public Computer(CPU cpu, RAM ram, GPU gpu)
    {
        _cpu = cpu;
        _ram = ram;
        _gpu = gpu;
    }

    public void PowerOn()
    {
        Console.WriteLine("Запуск компьютера...");
        _cpu.Start();
        _ram.Load();
        _gpu.Render();
        Console.WriteLine("Компьютер включен и готов к работе!");
    }

    public void PowerOff()
    {
        Console.WriteLine("Выключение компьютера...");
        _gpu.Shutdown();
        _ram.Clear();
        _cpu.Shutdown();
        Console.WriteLine("Компьютер выключен.");
    }
}

class Program
{
    static void Main()
    {
        CPU cpu = new CPU("Intel i7", 8, 3.6);
        RAM ram = new RAM(16, 3200);
        GPU gpu = new GPU("NVIDIA RTX 3080", 10);

        Computer pc = new Computer(cpu, ram, gpu);
        pc.PowerOn();

        Console.WriteLine("\nНажмите Enter для выключения...");
        Console.ReadLine();

        pc.PowerOff();
    }
}
