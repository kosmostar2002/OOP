using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace clas1
{
    class ListOfBools
    {
        private bool[] List;

        private bool sum;

        public ListOfBools(bool[] _list)
        {
            List = _list;

        }
        
        public bool this[int index]
        {
            get
            {
                if (index < List.Length)
                {
                    return !List[index];
                }
                else
                {
                    throw new Exception("Your index is bigger then Length of array");
                }
            }
            set
            {
                if (index < List.Length){
                    List[index] = value;
                }
                else
                {
                    throw new Exception("Your index is bigger then Length of array");
                }
            }
            }

        public bool Sum
        {
            get
            {
                sum = false;
                foreach (bool b in List)
                {
                    if (b)
                        sum = true;


                }
                return sum;
            }
        }
    }
}

