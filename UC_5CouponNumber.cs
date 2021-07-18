using System;
using System.Collections.Generic;
using System.Text;

namespace Day6assignment_LogicalPrograms
{
    class UC_5CouponNumber
    {
        public void Coupon()
        { 

        Console.WriteLine("Enter the number of distinct coupons needs to be generated :");

            int N = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();

            int[] couponCollection = new int[N];

            for (int i = 0; i <= N - 1;)
            {
                int coupon = random.Next(101,2001);

                if ((coupon.CompareTo(couponCollection[i])) == 0)
                {
                    continue;
                }
                else if ((coupon.CompareTo(couponCollection[i])) != 0)
                {
                    int[] coupunCollection = new int[i];
                          couponCollection[i] = coupon;
                    i++;
                }
}
           foreach (int i in couponCollection)
           {
              Console.WriteLine("Coupons Collection Count : " + i + " ");
           }
        }
    }
}
