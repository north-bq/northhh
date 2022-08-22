using System;

namespace PowerCalc
{
    public class PowerCalc
    {
        public float GetTowerpowerRadius(float h1, float h2)
        {
            return Convert.ToSingle(Math.Sqrt(h1 + h2) * 4.12)*1000;
        }
    }
}
