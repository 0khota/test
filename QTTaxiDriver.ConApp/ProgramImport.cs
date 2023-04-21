namespace QTTaxiDriver.ConApp
{
    partial class Program
    {
        static string FileName = "TaxiDriver.csv";
        static partial void AfterRun()
        {
            Task.Run(async () => await CreateDataByFileAsync(FileName)).Wait();
        }

        static Task CreateDataByFileAsync(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
