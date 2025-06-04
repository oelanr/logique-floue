namespace logiquefloue
{
    class FuzzySet
    {
        private double a, b, c;

        public FuzzySet(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Membership(double x)
        {
            if (x <= a || x >= c) return 0; // en dehors de l'ensemble
            if (a < x && x <= b) return (x - a) / (b - a); // moyenne basse
            if (x < c && b < x) return (c - x) / (c - b);// moyenne haute
            return 0;
        }
    }
}