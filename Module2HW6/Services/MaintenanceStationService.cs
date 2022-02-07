using Module2HW6.Exceptions;
using Module2HW6.Interfaces;
using Module2HW6.Models;

namespace Module2HW6.Services
{
    public class MaintenanceStationService : IMaintenanceStationService
    {
        public MaintenanceStationService(INotificationService message)
        {
            Message = message;
        }

        private INotificationService Message { get; set; }

        public void ChangeEngineCapacity(Car car, double engineCapacity)
        {
            if (engineCapacity > 0.8 && engineCapacity < 8.4)
            {
                car.EngineCapacity = engineCapacity;
                Message.ShowMessage("Engine capacity was changed\n");
            }
            else
            {
                throw new BusinessException($"No such engine exists", engineCapacity);
            }
        }
    }
}
