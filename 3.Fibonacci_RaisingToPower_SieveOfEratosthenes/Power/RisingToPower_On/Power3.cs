using System;
using System.Linq;
using Tester;

namespace RisingToPower
{
    public class Power3 : ITask
    {
        private double _number;
        private double _power;
        private double _result=1;
    
        public string Run(string[] data)
        {
            _number = Double.Parse(data[0]);
            _power = Double.Parse(data[1]);
            
    
            var res = Math.Round(RisingPower(_number, _power), 11).ToString();
    
            return res;
        }
        
        public double RisingPower(double number, double power)
        {
            _number = number;
            _power = power;

            var binaryArrayPower = Convert.ToString((int) _power, 2)
                .ToCharArray()
                .Select(x => Int32.Parse(x.ToString()))
                .ToArray();
    
            return MultipleRecursive(binaryArrayPower,0);
        }
    
        private double MultipleRecursive(int[] binaryArrayPower, int index)
        {
            if (index == binaryArrayPower.Length-1)
            {
                _result = _result * Math.Pow(_number, binaryArrayPower[index]);
                return _result;
            }
    
            _result = Math.Pow(_result * Math.Pow(_number, binaryArrayPower[index]), 2);
            index += 1;
    
            return MultipleRecursive(binaryArrayPower, index);
        }
    }
}