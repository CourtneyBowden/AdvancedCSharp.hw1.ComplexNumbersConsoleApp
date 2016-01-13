using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1.Bowden
{
    public class Complex
    {
        //Default constructor.  Sets values to zero.
        public Complex()
        {
            //set properties to zero because the class was created without defining the values
            Real = 0;
            Imaginary = 0;

        }//end Default constructor
        
        //Constructor whcih sets the initial values of the Complex class
        public Complex(double real, double imag)
        {
            //set the values of the properties
            Real = real;
            Imaginary = imag;

        }//end constructor

        //read-only property that holds the value of the real number
        public double Real { get; private set;}

        //read-only property that hold the value of the imaginary number
        public double Imaginary { get; private set;}

        public static Complex operator +(Complex c1, Complex c2)
        {
            //Calculate the value of each part of the Complex Number
            double real = c1.Real + c2.Real;
            double imaginary = c1.Imaginary + c2.Imaginary;

            //Return the operator value
            return new Complex(real, imaginary);

        }//end operator +
        public static Complex operator - (Complex c1, Complex c2)
        {
            //Calculate the value of each part of the Complex Number
            double real = c1.Real - c2.Real;
            double imaginary = c1.Imaginary - c2.Imaginary;

            //Return the operator value
            return new Complex(real, imaginary);
        }//end operator -
        public static Complex operator * (Complex c1, Complex c2)
        {
            //Calculate the value of each part of the Complex Number
            double real = (c1.Real * c2.Real) - (c1.Imaginary * c2.Imaginary);
            double imaginary = (c1.Real * c2.Imaginary) + (c1.Imaginary * c2.Real);

            //Return the operator value
            return new Complex(real, imaginary);

        }//end operator *

        public static Complex operator / (Complex c1, Complex c2)
        {
            //Calculate the value of each part of the Complex Number
            double real = (c1.Real * c2.Real + c1.Imaginary * c2.Imaginary) / (Math.Pow(c2.Real,c1.Imaginary) + Math.Pow(c2.Imaginary, c1.Imaginary));
            double imaginary = (c1.Imaginary * c2.Real - c1.Real * c2.Imaginary) / (Math.Pow(c2.Real, c1.Imaginary) + Math.Pow(c2.Imaginary, c1.Imaginary));

            //Return the operator value
            return new Complex(real, imaginary);

        }//end operator /

        public override string ToString()
        {
            //local variables
            string RetVal = "0";

            //return the string value in the simplest terms so that a 0i is not displayed to the user
            if(Imaginary == 0)
            {
                //display the real value only
                RetVal = Real.ToString();
            }
            else
            {
                if(Real == 0)
                {
                    //display the imaginary value only
                    RetVal = Imaginary.ToString() + "i";
                }
                else
                {
                    //display both parts
                    RetVal = string.Format("({0} {1} {2}i)", Real, (Imaginary < 0 ? "-" : "+"), Math.Abs(Imaginary));
                }
            }
            
            //return our function value
            return RetVal;

        }//end method ToString
            
    }

}
