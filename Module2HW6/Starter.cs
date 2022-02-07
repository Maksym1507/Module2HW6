using Module2HW6.Enums;
using Module2HW6.Exceptions;
using Module2HW6.Extensions;
using Module2HW6.Interfaces;
using Module2HW6.Models;

namespace Module2HW6
{
    public class Starter
    {
        public Starter(INotificationService message, IMaintenanceStationService maintenanceStationService)
        {
            Message = message;
            MaintenanceStationService = maintenanceStationService;
        }

        private INotificationService Message { get; set; }

        private IMaintenanceStationService MaintenanceStationService { get; set; }

        public void Run()
        {
            var bmwM8 = new BMW("BMW M8", new (2020, 10, 15), GearboxType.Automatic, 5.3, 1.4, 92, 0);
            var mercedesGLC123 = new Mercedes("MercedesGLC123", new (2003, 02, 18), GearboxType.Automatic, 4.2, 2.0, 70, 3);
            var bmwM3Competition = new BMW(" ", new (2017, 09, 05), GearboxType.Automatic, 4.8, 1.8, 83, 2);
            var mercedesE124 = new Mercedes("Mercedes E124", new (1989, 07, 11), GearboxType.Manual, 7.2, 3.5, 75, 1);
            var bmwM5 = new BMW("BMW M5", new (2008, 12, 15), GearboxType.Automatic, 3.7, 1.2, 100, 5);

            Car[] cars = { bmwM8, mercedesGLC123, bmwM3Competition, mercedesE124, bmwM5 };
            var car = ArrayExtension.SearchByMaxEngineCapacity(cars);

            Message.ShowMessage("Enter car which has the biggest capacity engine:");
            Message.ShowMessage(car.ToString());

            try
            {
                MaintenanceStationService.ChangeEngineCapacity(mercedesGLC123, 6);
                MaintenanceStationService.ChangeEngineCapacity(bmwM8, 3.5);
                MaintenanceStationService.ChangeEngineCapacity(mercedesE124, 8.5);
            }
            catch (BusinessException ex)
            {
                Message.ShowMessage($"{ex.Message}. Uncorrect value {ex.Value}\n");
            }

            car = ArrayExtension.SearchByMaxEngineCapacity(cars);

            Message.ShowMessage("Enter car which has the biggest capacity engine:");
            Message.ShowMessage(car.ToString());

            Message.ShowMessage(mercedesGLC123.ToString());

            Message.ShowMessage(bmwM8.ToString());

            Message.ShowMessage(mercedesE124.ToString());
        }
    }
}
