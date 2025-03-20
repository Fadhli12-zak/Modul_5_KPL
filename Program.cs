using System.ComponentModel.Design.Serialization;
using System.Globalization;

class PemrosesData {
    public T DapatkanNilaiTerbesar<T>(T input1, T input2, T input3)
    {
        dynamic max = input1;
        dynamic max2 = input2;
        dynamic max3 = input3;
        if (max > input2 && max > input3)
        {
            max = input1;
        }
        else if (max2 > input1 && max2 > input3)
        {
            max = input2;
        }
        else 
        {
            max = input3;
        }
        return max;
    }
}
public class Program
{
    public static void Main()
    {
        PemrosesData pemrosesData = new PemrosesData();
        int x1, x2, x3;   
        x1 = Int32.Parse(Console.ReadLine());
        x2 = Int32.Parse(Console.ReadLine());
        x3 = Int32.Parse(Console.ReadLine());
        Console.WriteLine($"Nilai terbesar adalah {pemrosesData.DapatkanNilaiTerbesar(x1, x2, x3)}");
    }
}