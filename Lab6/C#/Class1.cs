using System; 

namespace Exception_
{
    class Class1
    {
        private float A;
        private float C;
        private float D;

        public Class1(float a, float c, float d )
        {
            if (MathF.Abs(A) != 1)
            {
                A = a;
            }
            else
            {
                throw new Exception("Dominator == 0");
            }
            C = c;
            if (D > 0)
            {   
                D = d;
            }
            else
            {
                throw new Exception("D should be more 0");
            }
        }

        private float numerator()
        {
            if (D > 0)
            {
                float res = 2 * C - MathF.Log(D);
                return res;
            }
            else
            {
                throw new Exception("D should be more 0");
            }
            
        }
        private float dominator()
        {
            float res = MathF.Pow(A, 2) - 1;
            if (res != 0)
            {
                return res;
            }
            else
            {
                throw new Exception("Dominator == 0");
            }
        }
        public float getRes()
        {
            return numerator() / dominator();      
        }
    }

    
}