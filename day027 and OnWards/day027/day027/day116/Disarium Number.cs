using System;


namespace CodeWards7Kata
{
    class Disarium_Number
    {
        public static string DisariumNumber(int number)
        {
            int sum = 0;
            int[] numberAr = Array.ConvertAll(number.ToString().ToCharArray(), x => Convert.ToInt32(x) - 48);
            
            for (int i = 0; i < numberAr.Length; i++)
            {
               sum+= (int) Math.Pow(numberAr[i],(i+1));
            }
            return sum == number ? "Disarium !!" : "Not !!";
        }
    }
}
