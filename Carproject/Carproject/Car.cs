using Carproject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carproject
{
    



    public class Car
    {
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public string Color { get; set; }


    }
}
public class Audi : CarBuilder
{
    public override void CreateBrandName()
    {
        Car.BrandName = "Audi";
    }

    public override void CreateColor()
    {
        Car.Color = "Jet Black";
    }

    public override void CreateModelName()
    {
        Car.ModelName = "L634";
    }




}


public class BMW : CarBuilder
{
    public override void CreateBrandName()
    {
        Car.BrandName = "BMW";
    }

    public override void CreateColor()
    {
        Car.Color = "Dark Green";
    }

    public override void CreateModelName()
    {
        Car.ModelName = "TTr760";
    }
}
public class Mercedes : CarBuilder
{
    public override void CreateBrandName()
    {
        Car.BrandName = "Mercedes";
    }

    public override void CreateColor()
    {
        Car.Color = "Night Blue";
    }

    public override void CreateModelName()
    {
        Car.ModelName = "U77";
    }
}
