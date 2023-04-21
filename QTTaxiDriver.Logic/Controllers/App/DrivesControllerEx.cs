namespace QTTaxiDriver.Logic.Controllers.App
{
    partial class DrivesController
    {
        internal override IEnumerable<string> Includes => new string[] { nameof(Entities.App.Drive.Vehicle), nameof(Entities.App.Drive.Driver) };
    }
}
