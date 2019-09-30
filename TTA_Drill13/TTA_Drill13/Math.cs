using System;


namespace TTA_Drill13
{
    class Math
    {
        public int num1;
        public int num2;
        public decimal num3;
        public decimal num4;
        public string num5;
        public string num6;
        // constructors
        public Math(int num1, int num2, decimal num3, decimal num4, int num7, int num8)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public Math(string num5, string num6)
        {
            this.num5 = num5;
            this.num6 = num6;
        }

        public Math(decimal num3, decimal num4)
        {
            this.num3 = num3;
            this.num4 = num4;
        }
        // methods
        public int MathMethod(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        public int MathMethod(decimal num3 , decimal num4)
        {
            decimal product = num3 * num4;
            int TotalProduct = Convert.ToInt32(product);
            return TotalProduct;
        }
        

        public int MathMethod(string num5, string num6)
        {
            int num7 = Convert.ToInt32(num5);
            int num8 = Convert.ToInt32(num6);
            int Division = num7 / num8;
            return Division;
            
        }
        
        
    }
}
