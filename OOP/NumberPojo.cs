using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class NumberPojo
    {
        private double FirstNumber = 0;
        private double SecondNumber = 0;
        private int numberIn = 0;
        private int numberOut = 0;
        private String Operator = null;
        private bool Priority = false;
        private int NumberLength = 0;

        public NumberPojo(double FirstNumber, double SecondNumber,String Operator, int numberIn,int numberOut,int numberLength)
        {
            this.FirstNumber = FirstNumber;
            this.SecondNumber = SecondNumber;
            this.Operator = Operator;
            this.numberIn = numberIn;
            this.numberOut = numberOut;
            this.NumberLength = numberLength;

            if(Operator == "/" || Operator == "*")
            { 
                this.Priority = true;
            }
        }
        public double getFirstNumber()
        {
            return this.FirstNumber;
        }
        public double getSecondNumber()
        {
            return this.SecondNumber;
        }
        public String getOperator()
        {
            return this.Operator;
        }
        public bool getPriority()
        {
            return this.Priority;
        }
        public int getNumberLength()
        {
            return this.NumberLength;
        }
        public double getResult()
        {
            //sonuç değişkeni tanımlanıyor.
            double result = 0;

            if (Operator == null) result = 0;
            else if (Operator.Equals("*")) result = FirstNumber * SecondNumber;
            else if (Operator.Equals("/")) result = FirstNumber / SecondNumber;
            else if (Operator.Equals("-")) result = FirstNumber - SecondNumber;
            else if (Operator.Equals("+")) result = FirstNumber + SecondNumber;
            
            return result;
        }
    }
}
