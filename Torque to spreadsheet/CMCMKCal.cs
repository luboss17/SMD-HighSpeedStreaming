using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    
    class CMCMKCal
    {
        private double USL, LSL;
        
        //return a double type standard dev from List of readings
        public double calculate_stand_deviation(List<float> samplesList)
        {
            double average = 0;
            double sd = 0;
            if (samplesList.Count > 0)
                average = samplesList.Average();
            double tempSum = 0;
            foreach(float sample in samplesList)
            {
                tempSum += Math.Pow(average - sample,2);
            }
            sd = Math.Sqrt(tempSum / (samplesList.Count - 1));
            return sd;
        }

        //calculate and return CM value, double type
        public double calculate_CM(float LSL, float USL,List<float>samplesList)
        {
            double CM;
            CM = (USL - LSL) / (6 * calculate_stand_deviation(samplesList));
            return CM;
        }

        //calculate CMK value
        public double calculate_CMK(float LSL, float USL, List<float> sampleList)
        {
            double CMK;
            double val1,val2;
            double min;
            val1 = ((USL - sampleList.Average()) / (3 * calculate_stand_deviation(sampleList)));
            val2= ((sampleList.Average()-LSL) / (3 * calculate_stand_deviation(sampleList)));
            min = Math.Min(val1, val2);
            return min;
        }
    }
}
