using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innkapsling
{
    internal class Stats
    {
        
        private int _numberCount;
        private int _sum;
        public void AddNumber(int number)
        {
            _sum += number;
            _numberCount++;
        }

        public void Show()
        {
            var sum = _sum;
            Console.WriteLine(
                $"Antall tall: {_numberCount} " +
                $"Sum: {sum} " +
                $"snitt: {GetMean()}");
        }

        private float GetMean()
        {
            return (float)_sum / _numberCount;
        }
    }
}
