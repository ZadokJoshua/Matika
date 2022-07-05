using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Converter.Angle
{
    public class Angle
    {
        private double _output;

        // Degrees and Radians
        private double DegreeTORadian(double _angle)
        {
            _output = _angle * (Math.PI /180);
            return Math.Round(_output, 2);
        }

        private double RadianToDegree(double _angle)
        {
            _output = _angle * (180 / Math.PI);
            return Math.Round(_output, 2);
        }

        // Gradians and Radians
        private double GradianToRadian(double _angle)
        {
            _output = _angle * 0.0157018;
            return Math.Round(_output, 2);
        }

        private double RadianToGradian(double _angle)
        {
            _output = _angle / 0.0157018;
            return Math.Round(_output, 2);
        }

        // Degrees and Gradians
        private double DegreesToGradians(double _angle)
        {
            _output = RadianToGradian(DegreeTORadian(_angle));
            return Math.Round(_output, 2);
        }

        private double GradiansToDegrees(double _angle)
        {
            _output = RadianToDegree(GradianToRadian(_angle));
            return Math.Round(_output);
        }

        //public string AnglesConverter()
        //{

        //}
    }
}
