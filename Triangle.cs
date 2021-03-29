using System;

namespace classes
{

    public class Triangle
    {
        private int l1, l2, l3;

        public Triangle(int l1, int l2, int l3)
        {
            if (!this.isValidTriangle(l1, l2, l3))
                throw "Invalid values for triangle";

            this.l1 = l1;
            this.l2 = l2;
            this.l3 = l3;
        }

        private Boolean isValidTriangle(int l1, int l2, int l3)
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

        public Boolean isScalene()
        {
            return this.l1 != this.l2 && this.l1 != this.l3 && this.l2 != this.l3;
        }

        public Boolean isIsosceles()
        {
            return this.l1 == this.l2 || this.l1 == this.l3 || this.l2 == this.l3;
        }

        public Boolean isEquilateral()
        {
            return this.l1 == this.l2 && this.l1 == this.l3;
        }

        public string getType()
        {
            if (this.isEquilateral()) return "equilatero";
            if (this.isIsosceles()) return "isoceles";
            if (this.isScalene()) return "escaleno";
            return "";
        }
    }
}