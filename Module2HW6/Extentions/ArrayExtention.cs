﻿using Module2HW6.Models;

namespace Module2HW6.Extentions
{
    public static class ArrayExtention
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
