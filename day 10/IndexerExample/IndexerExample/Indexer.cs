using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExample
{
    public class array
    {
        float[] arr = new float[] { 12.5f, 34.3f, 5.2f, 6.1f, 7.5f, 88.8f, 22.9f };
        public float this[ int index]
        {
            get { 
            return arr[index];  }
            set {
                arr[index] = value;}
        }

    }
}
