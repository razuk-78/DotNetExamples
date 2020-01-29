using System;

namespace AbstructFactory
{
    public class chair : IProduct
    {
        public string GetName()
        {
            return "iam chair";
        }


    }
    public class sofa : IProduct
    {

        public string GetName()
        {
            return "iam sofa";
        }

     
    }
}