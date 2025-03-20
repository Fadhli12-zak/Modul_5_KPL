using System.ComponentModel.Design.Serialization;
using System.Globalization;

class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;
    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }
    public void PrintAllData()
    {
        int i;
        for (i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data {i + 1} berisi {storedData[i]}, yang disimpan pada waktu UTC: {inputDates[i]}");
        }
    }
}
class PemrosesData
{
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
class program
{
    static void Main()
    {
        SimpleDataBase<int> db = new SimpleDataBase<int>();
        db.AddNewData(10);
        db.AddNewData(30);
        db.AddNewData(22);
        db.PrintAllData();

        PemrosesData pemrosesData = new PemrosesData();
        int x1, x2, x3;
        x1 = Int32.Parse(Console.ReadLine());
        x2 = Int32.Parse(Console.ReadLine());
        x3 = Int32.Parse(Console.ReadLine());
        Console.WriteLine($"Nilai terbesar adalah {pemrosesData.DapatkanNilaiTerbesar(x1, x2, x3)}");
    }
}