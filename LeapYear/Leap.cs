namespace LeapYear
{
    public class Leap
    {
        public bool IsLeapYear(int year)
        {
            return (year % 400 == 0) || (year % 100 != 0 && year % 4 == 0);

            //refactored
            //if (year % 400 == 0)
            //    return true;
            //else
            //{
            //    if (year % 100 == 0)
            //        return false;
            //}

            //if (year % 4 == 0)
            //{
            //    if (year % 100 == 0)
            //        return false;
            //    else
            //        return true;
            //}

            //return false;
        }

        public List<int> Leaps(int min, int max)
        {
            List<int> result = new List<int>();
            for (int i = min; i <= max; i++)
            {
                if (IsLeapYear(i))
                    result.Add(i);
            }
            return result;
        }
    }
}
