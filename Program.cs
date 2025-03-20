using System.ComponentModel.Design.Serialization;
using System.Globalization;

class SimpleDataBase<T> { 
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
    public void PrintAllData() {
        int i;
       for(i =0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data {i+1} berisi {storedData[i]}, yang disimpan pada waktu UTC: {inputDates[i]}");
        }
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
    }
}