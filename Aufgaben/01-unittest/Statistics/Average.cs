using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Average
    {
        public double Mean(List<int> numbers)
        {
            if (numbers.Count == 0) { throw new ArgumentException(); }
            int sum = 0;
            double mean = 0.0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            mean = (double)sum / numbers.Count;
            return mean;
        }

        public double Median(List<int> numbers)
        {
            if (numbers.Count % 2 == 1)
            {
                return numbers[Convert.ToInt32(Math.Ceiling(Convert.ToDouble(numbers.Count) / 2)) - 1];
            } else if (numbers.Count != 0)
            {
                int first = numbers.Count / 2 - 1;
                int second = numbers.Count / 2;
                return Convert.ToDouble((numbers[first] + numbers[second])) / 2;
            } else
            {
                throw new ArgumentException();
            }
        } 
    }
}
