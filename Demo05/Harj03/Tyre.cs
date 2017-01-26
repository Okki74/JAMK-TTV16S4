using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj03
{
    class Tyre
    {
        
        public string brand;
        public string model;
        public string size;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Size
        {
            get { return size; }
            set { size = value; }
        }

        //Construktor
        public Tyre(){}
        public Tyre (string _brand, string _model, string _size)
        {
            Brand = _brand;
            Model = _model;
            Size = _size;
        }
        //methods
        public override string ToString()
        {
            return (" " +Brand+ ": " +Model+": " +Size);
        }
    }
}