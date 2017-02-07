using System.Collections.Generic;

namespace dealership.Objects
{
    public class Car
    {
        private string _makeModel;
        private int _cost;
        private int _miles;
        private static List<Car> carList = new List<Car>() { };

        public Car (string makeModel, int cost, int miles)
        {
            _makeModel = makeModel;
            _cost = cost;
            _miles = miles;
        }

        public void Save()
        {
            carList.Add(this);
        }

        public static List<Car> GetCars()
        {
            return carList;
        }

        public void SetMakeModel(string makeModel)
        {
            _makeModel = makeModel;
        }

        public void SetCost(int cost)
        {
            _cost = cost;
        }

        public void SetMiles(int miles)
        {
            _miles = miles;
        }

        public string GetMakeModel()
        {
            return _makeModel;
        }

        public int GetCost()
        {
            return _cost;
        }

        public int GetMiles()
        {
            return _miles;
        }
    }
}
