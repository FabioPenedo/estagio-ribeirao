using System;

class Program
{
    static void Main()
    {
        // Sequência a)
        int[] sequenciaA = { 1, 3, 5, 7 };
        int proximoA = sequenciaA[sequenciaA.Length - 1] + 2;
        Console.WriteLine($"Próximo elemento da sequência a): {proximoA}");

        // Sequência b)
        int[] sequenciaB = { 2, 4, 8, 16, 32, 64 };
        int proximoB = sequenciaB[sequenciaB.Length - 1] * 2;
        Console.WriteLine($"Próximo elemento da sequência b): {proximoB}");

        // Sequência c)
        int[] sequenciaC = { 0, 1, 4, 9, 16, 25, 36 };
        int proximoC = (int)Math.Pow(Math.Sqrt(sequenciaC[sequenciaC.Length - 1]) + 1, 2);
        Console.WriteLine($"Próximo elemento da sequência c): {proximoC}");

        // Sequência d)
        int[] sequenciaD = { 4, 16, 36, 64 };
        int ultimoPar = (int)Math.Sqrt(sequenciaD[sequenciaD.Length - 1]);
        int proximoD = (ultimoPar + 2) * (ultimoPar + 2);
        Console.WriteLine($"Próximo elemento da sequência d): {proximoD}");

        // Sequência e)
        int[] sequenciaE = { 1, 1, 2, 3, 5, 8 };
        int proximoE = sequenciaE[sequenciaE.Length - 1] + sequenciaE[sequenciaE.Length - 2];
        Console.WriteLine($"Próximo elemento da sequência e): {proximoE}");

        // Sequência f)
        int[] sequenciaF = { 2, 10, 12, 16, 17, 18, 19 };
        int proximoF = sequenciaF[sequenciaF.Length - 1] + 1;
        Console.WriteLine($"Próximo elemento da sequência f): {proximoF}");
    }
}
