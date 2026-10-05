using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraApp.CalcEntites
{
    public  class CalculadoraEntites
    {

        public int Num1;
        public int Num2;

    }


    public class CalculadoraEntitiesOperations
    {
        public int somar(int num1, int num2) 
        {

            return num1 + num2;
        }

        public int subtrair(int num1, int num2) 
        {
            return num1 - num2;

        }
        public int multiplicar(int num1, int num2) 
        {
            return num1 * num2;
        
        }

        public int dividir (int num1, int num2) 
        {
          if (num2 == 0)
            {
              throw new DivideByZeroException("Não é possível dividir por zero.");
            }
            else
            {
                return num1 / num2;

            }
          
        
        }    
    
    }

}
