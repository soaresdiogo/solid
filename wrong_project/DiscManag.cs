namespace wrong_project
{
    public class DiscManag
    {
        public decimal Calculate(decimal value, int type, int years)
        {
            decimal result = 0;
            decimal disc = (years > 5) ? (decimal) 5 / 100 : (decimal) years / 100;

            if (type == 1)
            {
                result = value;
            }
            else if (type == 2)
            {
                result = (value - (0.1m * value)) - disc * (value - (0.1m * value));
            }
            else if (type == 3)
            {
                result = (0.7m * value) - disc * (0.7m * value);
            }
            else if (type == 4)
            {
                result = (value - (0.5m * value)) - disc * (value - (0.5m * value));
            }

            return result;
        }
    }
}