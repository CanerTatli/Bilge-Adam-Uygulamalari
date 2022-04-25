using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carproject
{

    public abstract class CarBuilder
    {

        protected Car _car;
        public Car Car
        {
            get
            {
                return _car;
            }


        }



        public abstract void CreateBrandName();
        public abstract void CreateModelName();
        public abstract void CreateColor();


    }
}
