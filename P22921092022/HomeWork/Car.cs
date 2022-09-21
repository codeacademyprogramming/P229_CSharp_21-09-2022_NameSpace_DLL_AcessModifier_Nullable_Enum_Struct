using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class Car : Vehicle
    {
        public string Brand;
        public string Model;
        private double _fuelCapacity;
        public double FuelCapacity
        {
            get => _fuelCapacity;
            set
            {
                while (value < 10 || value > 150)
                {
                    Console.WriteLine("Duzgun Deyer Daxil Et Minimum 10 Maksimum 150 Ola Biler");
                    double.TryParse(Console.ReadLine(), out value);
                }
                _fuelCapacity = value;
            }
        }
        public double FuelFor1km;
        private double _currentFuel;
        public double CurrentFuel
        {
            get => _currentFuel;
            set
            {
                while (value < 0 || value > _fuelCapacity)
                {
                    Console.WriteLine($"Duzgun Deyer Daxil Minimu 0 Maksimum {_fuelCapacity} qeder Ola Biler");
                    double.TryParse(Console.ReadLine(), out value);
                }

                _currentFuel = value;
            }
        }
        public Car(int year, string brand, string model, double fuelCapacity, double fuelFor1Km) : base(year)
        {
            Brand = brand;
            Model = model;
            FuelCapacity = fuelCapacity;
            FuelFor1km = fuelFor1Km;
        }

        public override string ShowInfo()
        {
            return $"{base.ShowInfo()}\nBrand: {Brand}\nModel: {Model}\nFuelCapacity: " +
                $"{_fuelCapacity}\nFuelFor1Km: {FuelFor1km}\nCurrentFuel: {_currentFuel}";
        }

        public void AddFuel(double fuel)
        {
            double canAddedFuel = _fuelCapacity - _currentFuel;
            if (canAddedFuel >= fuel)
            {
                _currentFuel += fuel;
            }
            else
            {
                Console.WriteLine($"Maksimum Elave Edeceyniz Benzin Miqdari {canAddedFuel} Qederdir");
            }
        }

        public void Drive(double km)
        {
            double canDriveKm = _currentFuel / FuelFor1km;
            if (canDriveKm >= km)
            {
                _currentFuel -= (km * FuelFor1km);
            }
            else
            {
                Console.WriteLine($"maksimum Gede Bileceyin Yol {canDriveKm} Qederdir");
            }
        }
    }
}
