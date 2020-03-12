using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SummarizeTempsObjects
{
    public class TempCalculationEngine
    {
        List<int> _temperatures;
        public TempCalculationEngine(List<int> temperatures)
        {
            _temperatures = temperatures;
        }

        public int AverageTemperature()
        {
            // add logic to calculate the average
            int sumOfTemps = 0;
            // loop through all of the temps in the list
            foreach (int temp in _temperatures)
                // add each temp to my sum variable
                sumOfTemps += temp;
            // divide sum variable by the list command
            int averageTemps = sumOfTemps / _temperatures.Count;
            return averageTemps; // <-- Replace this with the actual average
        }

        public int TempsAboveThreshold(int threshold)
        {
            // add logic to calculate temps above the threshold
            int TempsAboveThreshold = 0;
            // loop through all of the temps in the list
            foreach (int temp in _temperatures)
            {
                if (temp > threshold)
                {
                    TempsAboveThreshold++;
                }
            }
            // count all numbers above threshold
            
            return TempsAboveThreshold; // <-- Replace this with the number
        }

        public int TempsBelowThreshold(int threshold)
        {
            // add logic to calculate and return temps below the threshold
            int TempsBelowThreshold = 0;
            // loop through all of the temps in list
            foreach (int temp in _temperatures)
            {
                if (temp < threshold)
                {
                    TempsBelowThreshold++;
                }
            }
            
            return TempsBelowThreshold; // <-- Replace this with the number
        }

        public int TempsAtThreshold(int threshold)
        {
            // add logic to calculate and return temps at the threshold
            int TempsAtThreshold = 0;
            // loop throuhg all of the temps in list
            foreach (int temp in _temperatures)
            {
                if (temp == threshold)
                {
                    TempsAtThreshold++;
                }
            }
            return TempsAtThreshold; // <-- Replace this with the number
        }

        public int NumberOfTemperatures()
        {
            // add logic to return the number of temparature readings
            int tempsTotal = 0;
            // just add previous 3
            foreach (int temps in _temperatures)
            {
                tempsTotal++;
            }
            return tempsTotal; // <-- Replace this with the number
        }
    }
}
