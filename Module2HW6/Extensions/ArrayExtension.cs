using Module2HW6.Models;

namespace Module2HW6.Extensions
{
    public static class ArrayExtension
    {
        public static Car SearchByMaxEngineCapacity(this Car[] cars)
        {
            var car = cars[0];

            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].EngineCapacity > car.EngineCapacity)
                {
                    car = cars[i];
                }
            }

            return car;
        }
    }
}
