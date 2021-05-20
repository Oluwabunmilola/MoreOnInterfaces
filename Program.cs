using System;

namespace _17_MAY_2021_CLASS
{
    class Program
    {
        static void Main(string[] args)
        {
            ///-- The functionality/ set of functionalities are related
            /// - used to create a documentation comment in c#
            ///- How do we know when to use an interface
            /// the functionalities/ methods / set of functionalities are reusable
            /// -- each functionality can take on different forms of implementation even though the idea of the method is the same
            ///an interface helps you to build loosely coupled applications
            ///---> it helps us provide many forms for a feature
            ///--> it helps us to implement design patterns.. It is the key behind many important design patterns 



            /// create in your own understanding an interface
            /// that represents a Vehicle. And then create
            /// two or three concrete classes that implement this interface
            ///you have 15 minutes   
            IVehicle myBenz = new GLA_SUV();
            myBenz.NameOfVehicle();
            myBenz.MakeOfVehicle();
            myBenz.YearOfRelease();

            IVehicle myBenz1 = new GLB_SUV();
            myBenz1.NameOfVehicle();
            myBenz1.MakeOfVehicle();
            myBenz1.YearOfRelease();

            IVehicle myBenz2 = new GLC_SUV();
            myBenz2.NameOfVehicle();
            myBenz2.MakeOfVehicle();
            myBenz2.YearOfRelease();

        }

       
        
    }
}
