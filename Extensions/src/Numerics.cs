using System;

namespace Extensions
{
    public static class Numerics
    {
        public static double Rounding(double val, double rel_err)
        {
            var abs_err = RoundError(val * (rel_err / 100));

            int zeroCnt = (int)Math.Floor(Math.Log10(Math.Abs(abs_err)));

            if (zeroCnt < 0)
                return abs_err * Math.Pow(10, -zeroCnt) < 3 ? Math.Round(val, Math.Abs(zeroCnt) + 1) : Math.Round(val, Math.Abs(zeroCnt));


            double scale = Math.Pow(10, Math.Floor(Math.Log10(Math.Abs(abs_err))) + 1);

            if ((abs_err / scale) < 0.3) // for value 248.34 and rounded error 130 should return 250
                return (val / Math.Pow(10, zeroCnt - 1)) - Math.Floor((val / Math.Pow(10, zeroCnt - 1))) < 0.5 ? Math.Floor((val / Math.Pow(10, zeroCnt - 1))) * Math.Pow(10, zeroCnt - 1) : Math.Ceiling((val / Math.Pow(10, zeroCnt - 1))) * Math.Pow(10, zeroCnt - 1);


            return (val / Math.Pow(10, zeroCnt)) - Math.Floor((val / Math.Pow(10, zeroCnt))) < 0.5 ? Math.Floor((val / Math.Pow(10, zeroCnt))) * Math.Pow(10, zeroCnt) : Math.Ceiling((val / Math.Pow(10, zeroCnt))) * Math.Pow(10, zeroCnt);
        }

        private static double RoundError(double abs_err)
        {
            int digits = 1;

            if (abs_err == 0)
                return 0;

            double scale = Math.Pow(10, Math.Floor(Math.Log10(Math.Abs(abs_err))) + 1);

            if ((abs_err / scale) < 0.3)
                digits = 2;

            return scale * Math.Round(abs_err / scale, digits);
        }
    }
}
