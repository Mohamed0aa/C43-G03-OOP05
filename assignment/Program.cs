namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region project 1
            ////1
            //_3DPoint p =new _3DPoint(0,0,0);

            //2
            //Console.WriteLine(p);


            ////3
            //p.X=double.Parse(Console.ReadLine());
            //p.Y=double.Parse(Console.ReadLine());
            //p.Z = double.Parse(Console.ReadLine());

            ////4
            //_3DPoint p = new _3DPoint(0, 0, 0);
            //_3DPoint p1 = new _3DPoint(0, 0, 0);

            //if (p == p1)
            //{
            //    Console.WriteLine("p1=p2");
            //}
            //else
            //{
            //    Console.WriteLine("p1!=p2");
            //}

            ////5
            //_3DPoint[] POINTS = new _3DPoint[3];
            //POINTS[0] = new _3DPoint(1, 2, 3);
            //POINTS[1] = new _3DPoint(2, 3, 3);
            //POINTS[2] = new _3DPoint(0, 0, 0);

            //Array.Sort(POINTS);

            //for (int i = 0; i < POINTS.Length; i++)
            //{
            //    Console.WriteLine(POINTS[i]);
            //}

            //_3DPoint p = new _3DPoint(1, 2, 3);
            //_3DPoint p2 = p;




            #endregion

            #region project 2
            //Console.WriteLine( math.sum(2 ,1));
            //Console.WriteLine(math.Subtract(2, 1));
            //Console.WriteLine(math.Multiply(2, 1));
            //Console.WriteLine(math.Divide(2, 1));
            #endregion

            #region project 3
            decimal price=decimal.Parse(Console.ReadLine());
            int quantity =int.Parse(Console.ReadLine());
            string name=Console.ReadLine();
            string user=Console.ReadLine();
            User user1;
            if (user == "Regular")
            {
                user1 = new RegularUser();
            }
            else if (user == "Premium")
            {
                user1 = new PremiumUser();
            }
            else
            {
                user1 = new GuestUser();
            }
            user1.name = name;
            Discount discount = user1.GetDiscount();
            if (discount == null)
            {
                Console.WriteLine("No discount is applied");
            }
            else
            {
                discount.CalculateDiscount(price, quantity);
                double total_discout = discount.discount;
                Console.WriteLine($"total discount ={total_discout }");
                Console.WriteLine($"final price = {(double)(quantity * price) -total_discout}");
            }
            #endregion
        }
    }
}
