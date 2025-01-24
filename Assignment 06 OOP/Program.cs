using Assignment_06_OOP.First_Project;
using Assignment_06_OOP.Second_Project;
using Assignment_06_OOP.Third_Project;


namespace Assignment_06_OOP
{
    internal class Program


    {

       


        static void Main(string[] args)
        {
            #region FirstProject
            //Point3D point = new Point3D(10, 10, 10);
            //Console.WriteLine(point.ToString());

            //Point3D P1;
            //Point3D P2;

            //Console.WriteLine("Please Enter P1 and P2");
            //double result;


            //P1 = new Point3D(Convert.ToDouble(Console.ReadLine()??"0"),
            //   double.Parse(Console.ReadLine()??"0"),
            //   double.TryParse(Console.ReadLine(), out result) ? result : 0);

            //P2 = new Point3D(Convert.ToDouble(Console.ReadLine() ?? "0"),
            //   double.Parse(Console.ReadLine() ?? "0"),
            //   double.TryParse(Console.ReadLine(), out result) ? result : 0);

            //Console.WriteLine($"P1 => {P1}");
            //Console.WriteLine($"P2 => {P2}");

            //P1 = new Point3D(1, 2, 3);
            //P2 = new Point3D(1, 2, 3);

            //if(P1 == P2)
            //{
            //    Console.WriteLine("P1 and P2 are equal");
            //}
            //else
            //{
            //    Console.WriteLine("P1 and P2 are not equal");
            //}
            //P1 and P2 are not equal because the default implementation of the == operator compares the references of the objects, not the values of the objects.

            //Point3D[] P1= new Point3D[]
            //    {
            //    new Point3D(3,4,5),
            //    new Point3D(5,6,9),
            //    new Point3D(1,2,8)

            //    };

            //Array.Sort(P1);
            //foreach (Point3D item in P1)
            //{
            //    Console.WriteLine(item);
            //}

            //Point3D p1 = new Point3D(1, 2, 3);  
            //Point3D p2;
            //p2 = (Point3D)p1.Clone();
            //Console.WriteLine(p2);




            #endregion
            #region SecondProject
            //Console.WriteLine(Maths.Add(10, 20));
            //Console.WriteLine(Maths.Subtract(10, 5));
            //Console.WriteLine(Maths.Multiply(10, 5));
            //Console.WriteLine(Maths.Divide(10, 0));
            //Console.WriteLine(Maths.Divide(10, 5));

            #endregion
            #region ThirdProject

            //decimal discountAmount;
            //decimal finalPrice;
            //decimal price;
            //int quantity;
            //Console.WriteLine("Please Enter Your user type (Regular, Premium, Guest):");
            //string userType = Console.ReadLine() ?? "0";
            //if (userType == "Regular")
            //{
            //    RegularUser user = new RegularUser();
            //   // Console.WriteLine(user.GetDiscount().CalculateDiscount(100, 2));
            //    Console.WriteLine("please enter product details (price and quantity).");
            //     price = decimal.Parse(Console.ReadLine()?? "0");

            //     quantity = int.Parse(Console.ReadLine()??"0");

            //    discountAmount = user.GetDiscount().CalculateDiscount(price, quantity);
            //    finalPrice = (price * quantity) - discountAmount;
            //    Console.WriteLine($"FinalPrice Is: {finalPrice}");
            //    Console.WriteLine($"Total Discount Is: {discountAmount}");

            //}

            //else if (userType == "Premium")
            //{
            //    PremiumUser user01 = new PremiumUser();
            //    //Console.WriteLine(user01.GetDiscount().CalculateDiscount(100, 2));
            //    Console.WriteLine("please enter product details (price and quantity).");
            //    price = decimal.Parse(Console.ReadLine() ?? "0");
            //    quantity = int.Parse(Console.ReadLine() ?? "0");


            //    discountAmount = user01.GetDiscount().CalculateDiscount(price, quantity);
            //    finalPrice = (price * quantity) - discountAmount;
            //    Console.WriteLine($"FinalPrice Is: {finalPrice}");
            //    Console.WriteLine($"Total Discount Is: {discountAmount}");


            //}
            //else if (userType == "Guest")
            //{
            //    GuestUser user02 = new GuestUser();

            //    Console.WriteLine("No discount applied");

            //}


            #endregion

        }
    }
}
