using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArray
{
    public class BitArray
    {
        private int size;
        private int[] bitArray;

        public BitArray(int size)
        {
            this.Size = size;
            bitArray = new int[size];
        }
        public int Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if(value<=0 || value>100000)
                {
                    throw new ArgumentOutOfRangeException("The size should be in the range [0 - 100 000]");
                }
                else
                {
                    this.size = value;
                }
            }
        }

        public int this[int pos]
        {
            get
            {
                if (pos < 0 || pos > bitArray.Length - 1)
                {
                    throw new IndexOutOfRangeException("Index is out of bounds of the bitArray");
                }
                else
                {
                    return this.bitArray[pos];
                }
            }
            set
            {
                if (pos < 0 || pos > bitArray.Length - 1)
                {
                    throw new IndexOutOfRangeException("Index is out of bounds of the bitArray");
                }
                else if (value != 0 && value != 1)
                {
                    throw new ArgumentException("The bits are only 0 and 1 ! You cannot set diffrent number or character");
                }
                else
                {
                    this.bitArray[pos] = value;
                }
            }
        }

        public override string ToString()
        {
            string output = "";
            for (int i = bitArray.Length-1; i >= 0; i--)
            {
                output += bitArray[i];
            }
            int base10 = 0;
            int pow=1;
            for (int j = output.Length-1; j >= 0; j--)
            {
                if (output[j] == '1')
                {
                    base10 += pow;
                }
                pow*=2;
            }

            return base10.ToString();
        }
    }
}
