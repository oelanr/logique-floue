
namespace logiquefloue
{
    public static class FuzzyOperations
    {
        public static double Complement(FuzzySet set, double x)
        {
            return 1.0 - set.Membership(x);
        }

        public static double Intersection(FuzzySet set1, FuzzySet set2, double x)
        {
            return Math.Min(set1.Membership(x), set2.Membership(x));
        }

        public static double Union(FuzzySet set1, FuzzySet set2, double x)
        {
            return Math.Max(set1.Membership(x), set2.Membership(x));
        }

        public static bool Inclusion(FuzzySet set1, FuzzySet set2, double start, double end, double step)
        {
            for (double x = start; x <= end; x += step)
            {
                if (set1.Membership(x) > set2.Membership(x))
                {
                    return false;
                }
            }
            return true;

        }


        public static bool Equality(FuzzySet set1, FuzzySet set2, double start, double end, double step)
        {
            for (double x = start; x <= end; x += step)
            {
                if ((set1.Membership(x) - set2.Membership(x)) != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}