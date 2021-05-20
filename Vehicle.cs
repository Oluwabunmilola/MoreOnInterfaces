using System;
namespace _17_MAY_2021_CLASS
{
      public interface IVehicle
    {
        void NameOfVehicle();
        void MakeOfVehicle();
        void YearOfRelease();
    }
    public class GLA_SUV : IVehicle
    {
        public void NameOfVehicle()
        {
            Console.WriteLine("Name of vehicle-- GLA SUV");
        }

        public void MakeOfVehicle()
        {
            Console.WriteLine("Make of vehicle--Jeep");
        }

        public void YearOfRelease()
        {
            Console.WriteLine("Year of release--2018");
        }
    }

    public class GLB_SUV : IVehicle
    {

        public void NameOfVehicle()
        {
            Console.WriteLine("Name of vehicle-- GLB SUV");
        }

        public void MakeOfVehicle()
        {
            Console.WriteLine("Make of vehicle--Salon Car");
        }

        public void YearOfRelease()
        {
            Console.WriteLine("Year of release--2019");
        }
    }

    public class GLC_SUV : IVehicle
    {
        public void NameOfVehicle()
        {
            Console.WriteLine("Name of vehicle-- GLC SUV");
        }

        public void MakeOfVehicle()
        {
            Console.WriteLine("Make of vehicle--Sports Car");
        }

        public void YearOfRelease()
        {
            Console.WriteLine("Year of release--2020");
        }
    }
}