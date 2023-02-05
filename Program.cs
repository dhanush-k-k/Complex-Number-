/***********************************************************************************
 * Project Name :             Complex number to support additional features        *
 * Name:                      Dhanush Kumar Komalapura Kumar                       *
 * Source File Name:          main.cs                                              *                                         
 **********************************************************************************/

/********************************USINGS********************************************/
//System namespace defines commonly-used values and reference data types
using System;

/********************************NAMESPACE*****************************************/
namespace Assignment_5
{
    /********************************CLASS*********************************************/
    /*==================================================================================
     * Identifier:                ComplexNumber                                        *
     * Purpose:                   To calculate result of two complex type matrix       *
     * Description:               The class reference type initialises the complex type*
     *                            values to two matrix and calculates the final result *
     *                            using addition and multiplication function. The final*
     *                            output is displayed.                                 *
     * ===============================================================================*/
    class ComplexNumber
    {
        //Variable declaration
        public double real, imaginary, absoluteValue, phaseValue;

        /********************************GETTER METHOD***************************************/
        /*===================================================================================*
        * Method Name:               GetAbsoluteValue, GetPhaseValue                         *
        * Arguments:                 Two ComplexNumber is passed as input                    *
        * Purpose:                   To return the absoluteValue and phaseValue              *
        * Returns:                   Absolute and Phase Value                                *
        ====================================================================================*/
        public double GetAbsoluteValue
        {
            get { return absoluteValue; }
        }
        public double GetPhaseValue
        {
            get { return phaseValue; }
        }

        /********************************CONSTRUCTOR*****************************************/
        /*===================================================================================*
        * Function:                  ComplexNumber                                           *
        * Arguments:                 Special Function of class that invokes when instance of *
        *                            a class is created.                                     *
        * Purpose:                   Assign initial values to data members real and imaginary*
        * Returns:                   Constructors don't have return type                     *
        ====================================================================================*/
        public ComplexNumber()
        {
            Console.WriteLine("Constructed");
        }

        /********************************CONSTRUCTOR*****************************************/
        /*===================================================================================*
        * Function:                  ComplexNumber                                           *
        * Arguments:                 Special Function of class that invokes when instance of *
        *                            a class is created.                                     *
        * Purpose:                   Assign initial values to data members real and imaginary*
        * Returns:                   Constructors don't have return type                     *
        ====================================================================================*/
        public ComplexNumber(double _real, double _imaginary)
        {
            real = _real; 
            imaginary = _imaginary;
        }

        /********************************DESTRUCTOR*****************************************/
        /*===================================================================================*
        * Function:                  ComplexNumber                                           *
        * Arguments:                 When the object goes out of scope or is explicitly      *
        *                            destroyed                                               * 
        * Purpose:                   To delete class after its use                           *
        * Returns:                   Constructors don't have return type                     *
        ====================================================================================*/
        ~ComplexNumber()
        {
            bool isDebug = false;
            System.Diagnostics.Debug.Assert(isDebug = true);
            if (isDebug is true)
            {
                Console.WriteLine(" we are in debug mode" +
                    "\n Destructor class is called and Class object is destroyed");
            }
            else
            {
                Console.WriteLine(" We are not debugging");
            }
        }

        /*************************CONVERTING TO POLAR FORM METHOD****************************/
        /*===================================================================================*
        * Method Name:               GetPolarCoordinates                                     *
        * Arguments:                 ComplexNumber is passed as input                        *
        * Purpose:                   To calculate the polar form of complex number           *
        * Returns:                   Polar form of complex number                            *
        ====================================================================================*/
        public (double, double) GetPolarCoordinates(ComplexNumber comp1)
        {
            //return the absolute value(r) and theta
            return (System.Math.Sqrt(comp1.real * comp1.real + comp1.imaginary * comp1.imaginary),
                    System.Math.Atan2(comp1.imaginary, comp1.real));
        }

        /*********************************TO STRING METHOD***********************************/
        /*===================================================================================*
        * Method Name:               ToString()                                              *
        * Arguments:                 ComplexNumber is passed as input                        *
        * Purpose:                   To return string representation of object               *
        * Returns:                   returns the real and imaginary value of complex number  *                     
        ====================================================================================*/
        public override string ToString()
        {
            if (real == 0 && imaginary == 0)

                return "0";

            else if (real == 0)

                return ($"{imaginary}" + "i");

            else if (imaginary == 0)

                return ($"{real}");

            else if (imaginary < 0)

                return ($"{real}" + $"{imaginary}" + "i");

            else

                return this.real + " + " + this.imaginary + "i";
        }

        /***************************MULTIPLICATION METHOD************************************/
        /*===================================================================================*
        * Method Name:               operator *                                              *
        * Arguments:                 Two ComplexNumber is passed as input                    *
        * Purpose:                   To carry out multiplication of two complex number       *
        * Returns:                   Multiplied value of two complex number                  *
        ====================================================================================*/
        public static ComplexNumber operator *(ComplexNumber comp1, ComplexNumber comp2)
        {
            //result array
            ComplexNumber result = new ComplexNumber(0, 0);

            //The formula for complex number multiplication is implemented here
            result.real = (comp1.real * comp2.real) - (comp1.imaginary * comp2.imaginary);
            result.imaginary = (comp1.imaginary * comp2.real) + (comp1.real * comp2.imaginary);

            return result;
        }

        /********************************ADDITION METHOD*************************************/
        /*===================================================================================*
        * Method Name:               operator +                                              *
        * Arguments:                 Two ComplexNumber is passed as input                    *
        * Purpose:                   To carry out addition of two complex number             *
        * Returns:                   Added value of two complex numbers                      *
        ====================================================================================*/
        public static ComplexNumber operator +(ComplexNumber Comp1, ComplexNumber Comp2)
        {
            //result array
            ComplexNumber result = new ComplexNumber(0, 0);

            //The formula for complex number Addition is implemented here
            result.real = Comp1.real + Comp2.real;
            result.imaginary = Comp1.imaginary + Comp2.imaginary;

            return result;
        }

        /********************************SUBTRACTION METHOD**********************************/
        /*===================================================================================*
        * Method Name:               operator -                                              *
        * Arguments:                 Two ComplexNumber is passed as input                    *
        * Purpose:                   To carry out subtraction of two complex number          *
        * Returns:                   Subtracted value of two complex numbers                 *
        ====================================================================================*/
        public static ComplexNumber operator -(ComplexNumber Comp1, ComplexNumber Comp2)
        {
            //result array
            ComplexNumber result = new ComplexNumber(0, 0);

            //The formula for complex number Subtraction is implemented here
            result.real = Comp1.real - Comp2.real;
            result.imaginary = Comp1.imaginary - Comp2.imaginary;

            return result;
        }

        /********************************READ COMPLEX NUMBER METHOD**************************/
        /*===================================================================================*
        * Method Name:               ReadComplexNumMatrix                                    *
        * Arguments:                 Complex number is read from console.                    *
        * Purpose:                   Read complex number from console.                       *
        * Returns:                   Complex number                                          *
        ====================================================================================*/
        public ComplexNumber[,] ReadComplexNumMatrix()
        {
            Console.WriteLine("Enter the rows and columns of the Complex Number Matrix \n" +
        "\n Note : \n1.The number of columns of first matrix must be equal to number of rows of second " +
        " matrix. \n2.The value of each row and column must be either 1 or 2 \n");

            //read the row and column of the Matrix
            int row = Convert.ToInt32(Console.ReadLine());
            int col = Convert.ToInt32(Console.ReadLine());

            //Complex num matrix initialization
            ComplexNumber[,] matrix = new ComplexNumber[2, 2];
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    matrix[i, j] = new ComplexNumber(0, 0);

            //Read values of the matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine("Enter the real value of the Element in Position Row : " + (i + 1) + " Column : " + (j + 1));
                    matrix[i, j].real = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the imaginary value of the Element in Position Row : " + (i + 1) + " Column : " + (j + 1));
                    matrix[i, j].imaginary = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\n");
                }

            }

            return matrix;

        }

        /********************************PRINT COMPLEX NUMBER METHOD**************************/
        /*===================================================================================*
        * Method Name:               PrintComplexNumMatrix                                   *
        * Arguments:                 Complex number is printed to console.                   *
        * Purpose:                   Complex number print on  console.                       *
        * Returns:                   Complex number                                          *
        ====================================================================================*/
        public void PrintComplexNumMatrix(ComplexNumber[,] matrix)
        {
            do
            {
                //printing the final result matrix 
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        //Printing the complex number using the overidden .ToSring() method.
                        Console.Write($"{matrix[i, j].ToString()}\t");
                    }
                    Console.WriteLine();
                }
            } while (matrix != null);

        }

        /**************************MATRIX MULTIPLICATION METHOD******************************/
        /*===================================================================================*
        * Method Name:               MatrixMultiplication                                    *
        * Arguments:                 Two ComplexNumber datatypes of 2*2 matrices is passed   *
        * Purpose:                   To carry out matrix multiplication and addition         *
        * Returns:                   Multiplied value of complex number matrices             *
        ====================================================================================*/
        public ComplexNumber[,] MatrixMultiplication(ComplexNumber[,] m1, ComplexNumber[,] m2)
        {

            //result array
            ComplexNumber[,] result = new ComplexNumber[m1.GetLength(0), m2.GetLength(1)];

            //To fetch the length of 2d array
            double m = m1.GetLength(0);
            double n = m1.GetLength(1);
            double p = m1.GetLength(1);

            if (m1.Length == m2.Length && m1.GetLength(0) == m2.GetLength(0))
            {
                //result array initialization
                for (int i = 0; i < m; i++)
                    for (int j = 0; j < p; j++)
                        result[i, j] = new ComplexNumber(0, 0);

                //Multiplication and addition of two-dimension matrices
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < p; j++)
                    {
                        ComplexNumber MultiplicationComplex = new ComplexNumber(0, 0);
                        ComplexNumber AdditionComplex = new ComplexNumber(0, 0);

                        //matrix multiplication
                        for (int k = 0; k < n; k++)
                        {
                            MultiplicationComplex = m1[i, k] * m2[k, j];
                            AdditionComplex = AdditionComplex + MultiplicationComplex;
                            result[i, j] = AdditionComplex;
                        }
                    }
                }

                return result;
            }
            else
            {
                Console.WriteLine("The matrix multiplication is not possible due to unmatching matrix dimensions" +
                                               " : column of matrix 1 not equal to row of matrix 2");
            }

            return null;
        }

        /**************************READ VECTOR METHOD****************************************/
        /*===================================================================================*
        * Method Name:               ReadVector                                              *
        * Arguments:                 Read vectors from console                               *
        * Purpose:                   Read vectors from console                               *
        * Returns:                   vector                                                  *
        ====================================================================================*/
        public (ComplexNumber[,], ComplexNumber[,]) ReadVector()
        {
            //Read the vector
            Console.WriteLine("Enter the Vector size for multiplication");
            int n = Convert.ToInt32(Console.ReadLine());

            ComplexNumber[,] Vector1 = new ComplexNumber[n, 1];
            ComplexNumber[,] Vector2 = new ComplexNumber[n, 1];

            //Initialise Vector1 and Vector 2
            for (int i = 0; i < Vector1.GetLength(0); i++)
            {
                for (int j = 0; j < Vector1.GetLength(1); j++)
                {
                    Vector1[i, j] = new ComplexNumber(0, 0);
                    Vector2[i, j] = new ComplexNumber(0, 0);
                }
            }

            //Read the Vector 1
            Console.WriteLine("Enter the Values of Vector 1 \n");
            for (int i = 0; i < Vector1.GetLength(0); i++)
            {
                for (int j = 0; j < Vector1.GetLength(1); j++)
                {
                    Console.WriteLine("Enter the Real Value of term {0}", i + 1);
                    Vector1[i, j].real = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the Imaginary Value of term {0}", i + 1);
                    Vector1[i, j].imaginary = Convert.ToDouble(Console.ReadLine());
                }
            }

            //Read the Vector 2
            Console.WriteLine("\nEnter the Values of Vector 2 \n");
            for (int i = 0; i < Vector2.GetLength(0); i++)
            {
                for (int j = 0; j < Vector2.GetLength(1); j++)
                {
                    Console.WriteLine("Enter the Real value of term {0}", i + 1);
                    Vector2[i, j].real = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the Imaginary Value of term {0}", i + 1);
                    Vector2[i, j].imaginary = Convert.ToDouble(Console.ReadLine());
                }
            }

            return (Vector1, Vector2);
        }

        /**************************VECTOR MULTIPLY METHOD*************************************/
        /*===================================================================================*
        * Method Name:               ReadVector                                              *
        * Arguments:                 Read vectors from console                               *
        * Purpose:                   Read vectors from console                               *
        * Returns:                   vector                                                  *
        ====================================================================================*/
        public void VectorMultiplication(ComplexNumber[,] Vector1, ComplexNumber[,] Vector2)
        {
            //Check if both Vector's are of same length

            if (Vector1.Length == Vector2.Length)
            {
                //Perform multiplication of the vector
                ComplexNumber[,] Result = new ComplexNumber[Vector1.GetLength(0), 1];

                for (int i = 0; i < Result.GetLength(0); i++)
                {
                    for (int j = 0; j < Result.GetLength(1); j++)
                    {
                        Result[i, j] = Vector1[i, j] * Vector2[i, j];
                    }
                }

                //Print the Result Vector
                Console.WriteLine("The Result Vector array is\n");
                for (int i = 0; i < Result.GetLength(0); i++)
                {
                    for (int j = 0; j < Result.GetLength(1); j++)
                    {
                        Console.Write($"{Result[i, j].ToString()} \t\n");
                    }
                }

            }
            else
            {
                Console.WriteLine("Cannot perform multiplication on Vector of different dimension");
            }

        }
    }

    /********************************CLASS*********************************************/
    /*==================================================================================
     * Identifier:                Program                                              *
     * Purpose:                   To calculate result of two complex type matrix       *
     * Description:               The class reference type initialises the complex type*
     *                            values to two matrix and calculates the final result *
     *                            using addition and multiplication function. The final*
     *                            output is displayed.                                 *
     * ===============================================================================*/
    class Program
    {

        /********************************FUNCTIONS*****************************************/
        /*==================================================================================
        * Function:                  Main                                                  *
        * Arguments:                 String array is the command line argument             *
        * Purpose:                   To calculate product of two matrices                  *
        * Returns:                   None                                                  *
        ==================================================================================*/
        static void Main(string[] args)
        {
            ComplexNumber a = new ComplexNumber(0, 0);
            try
            {
                //options to print on console
                Console.WriteLine("Please find the below options to choose from \n");
                Console.WriteLine(" 1. Perform Vector Multiplication \n 2. Perform 2D Matrix Multiplication \n 3. Calculate the Polar Co-ordinate of the given Complex Number \n 4. Exit   \n ");

                //read option input
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The selected option is {0} \n", option);

                //switch to perform the selected option
                switch (option)
                {

                    case 1:
                        //Declare two vectors
                        ComplexNumber[,] Vector1;
                        ComplexNumber[,] Vector2;

                        //Read both vectors from console
                        (Vector1, Vector2) = a.ReadVector();

                        //Perform Vector multiplication and print vector
                        a.VectorMultiplication(Vector1, Vector2);

                        break;

                    case 2:
                        //Complex 2D Matrix Number 1 
                        ComplexNumber[,] matrix1 = a.ReadComplexNumMatrix();
                        ComplexNumber[,] matrix2 = a.ReadComplexNumMatrix();

                        //Complex 2D Matrix Result  
                        ComplexNumber[,] result = new ComplexNumber[matrix1.GetLength(0), matrix2.GetLength(1)];

                        // Calculating the complex number matrix multiplication 
                        result = a.MatrixMultiplication(matrix1, matrix2);

                        //Print Matrix 1
                        Console.WriteLine("The Complex Number Matrix 1 is");
                        a.PrintComplexNumMatrix(matrix1);

                        //Print Matrix 2
                        Console.WriteLine("The Complex Number Matrix 2 is");
                        a.PrintComplexNumMatrix(matrix2);

                        //Print the result matrix
                        Console.WriteLine("The Complex Number Matrix Multiplication result is");
                        a.PrintComplexNumMatrix(result);

                        break;

                    case 3:

                        //Return the Polaroid co-ordinates of complex number and print the values on Console
                        double AbsoluteValue = a.GetAbsoluteValue;
                        double PhaseValue = a.GetPhaseValue;

                        //Initialise the Complex Number 
                        ComplexNumber num = new ComplexNumber(0, 0);

                        //Read the real and imaginary value
                        Console.WriteLine("Enter the real and imaginary value of the Complex Number to calculate its polaroid value\n");
                        num.real = Convert.ToDouble(Console.ReadLine());
                        num.imaginary = Convert.ToDouble(Console.ReadLine());

                        //calculate the polar co-ordinates 
                        (AbsoluteValue, PhaseValue) = a.GetPolarCoordinates(num);

                        //print the results
                        Console.WriteLine("\nThe entered Complex Number is " + $"{num.ToString()} \t\n");
                        Console.WriteLine("The polar co-ordinates are " + AbsoluteValue + ", " + PhaseValue + "\n");
                        break;

                    case 4:
                        //Exit
                        return;

                    default:

                        Console.WriteLine("You did not select the correct option");
                        return;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter the input within the given options");
            }
            catch (Exception ex)
            {
                Console.WriteLine("The exception is " + ex);
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}