using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr_17
{
    public abstract class Array
    {
        public int[] data;

        public Array(int[] inputData)
        {
            data = inputData;
        }

        public virtual int[] Add(Array other)
        {
            throw new NotImplementedException();

        }

        public virtual void ForEach(Action<int> action)
        {
            foreach (int element in data)
            {
                action(element);
            }
        }
    }

        public class Andarray : Array
        {
            public Andarray(int[] inputData) : base(inputData)
            {
            }

            public override int[] Add(Array other)
            {
                int[] otherData = other.data;
                List<int> intersection = new List<int>();

                foreach (int element in data)
                {
                    if (otherData.Contains(element))
                    {
                        intersection.Add(element);
                    }
                }

                return intersection.ToArray();
            }
            public override void ForEach(Action<int> action)
            {
                foreach (int element in data)
                {
                    action((int)Math.Sqrt(element));
                }
            }
        }

        public class Onarray: Array
    {
        public Onarray(int[] inputData) : base(inputData)
        {

        }

        public override int[] Add(Array other)
        {
            int[] otherData = other.data;
            List<int> union = new List<int>(data);


            foreach ( int element in otherData)
            {
                if (!union.Contains(element))
                {
                    union.Add(element);
                }


            }

            return union.ToArray();
        }

        public override void ForEach(Action<int> action)
        {
            foreach(int element in data)
            {
                action((int)Math.Log(element));
            }
        }
    }
    
}

