using System;
using System.Collections.Generic;

using System.Text;

namespace ClassTemperature
{
    public class ClassTemp
    {
        public float SourceTemp, TargetTemp;
        //摄氏温度转华氏温度
        public float DegreeS2H()
        {
            TargetTemp =(float)(32 + SourceTemp * 1.8);
            return TargetTemp;
        }
        //华氏温度转摄氏温度
        public float DegreeH2S()
        {
            TargetTemp = (float)((SourceTemp - 32) / 1.8);
            return TargetTemp;
        }
    }
}
