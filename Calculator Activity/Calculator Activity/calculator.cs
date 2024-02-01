using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Activity
{
    public class calculator
    {
        //the datatypes will be under a private setting to hide all the numerical contents inputted by thr user
        private double num1;
        private double num2;

        //using the constructor ith an arrgument 
        public calculator(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        //using access modifier oe the getters format
        public double getNum1()
        {
            return num1;
        }

        public double getNum2()
        {
            return num2;
        }

        //program will compute the 2 numbers inputted by the user
        
        //sum or addition
        public double sum()
        {
            double sum = getNum1() + getNum2();
            return sum; 
        }
        //subtraction
        public double sub()
        {
            double sub = getNum1() - getNum2();
            return sub; 
        }
        //multiplication

        public double multi()
        {
            double multi = getNum1() * getNum2();
            return multi;
        }

        //divide
        public double divide()
        {
            double divide = getNum1() / getNum2();
            return divide; 
        }
        //end of program
    }
}
