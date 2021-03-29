using System;

namespace classes
{

    public class Triangle
    {
        private int l1, l2, l3;

        public Triangle(int l1, int l2, int l3)
        {
            if (!isValidTriangle(l1, l2, l3))
                throw new ArgumentException("Invalid values for triangle");

            this.l1 = l1;
            this.l2 = l2;
            this.l3 = l3;
        }

        private bool isValidTriangle(int l1, int l2, int l3)
        {
            int mod1 = Math.Abs(l2 - l3);
            int sum1 = l2 + l3;
            int mod2 = Math.Abs(l1 - l3);
            int sum2 = l1 + l3;
            int mod3 = Math.Abs(l1 - l2);
            int sum3 = l1 + l2;

            if (l1 > mod1 && l1 < sum1) return true;
            if (l2 > mod2 && l2 < sum2) return true;
            if (l3 > mod3 && l3 < sum3) return true;
            return false;
        }

        public bool isScalene()
        {
            return l1 != l2 && l1 != l3 && l2 != l3;
        }

        public bool isIsosceles()
        {
            return l1 == l2 || l1 == l3 || l2 == l3;
        }

        public bool isEquilateral()
        {
            return l1 == l2 && l1 == l3;
        }

        public string getType()
        {
            if (isEquilateral()) return "equilatero";
            if (isIsosceles()) return "isosceles";
            if (isScalene()) return "escaleno";
            return "";
        }
    }
}