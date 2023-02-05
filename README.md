# Project Title : "Complex Number Version 5.0"

## Developer Details
* <b>Author : </b>Dhanush Kumar Komalapura Kumar

## Purpose of Project
The user can choose between polar, complex and vector multiplication and input the values from console. Which is then displayed aesthetically.

## Dependencies
* The project is developed using Visual Studio 2019.

## Prerequisites
* Project requires .NET 3.5 to .NET 5

## Installation steps
* Please click on <a herf = "https://visualstudio.microsoft.com/downloads/">Visual Studio</a> to download the specified version and follow the instructions on screen.

## Steps to Execute
* Unzip the Myproject_Assignment5.zip
* Unzip the app.zip and run the executable .exe file

## Steps to retrieve the source code
* Unzip the souce.zip
* Results in the Main.cs file which contains the logic.

## Usage
```C#

# Change the variables in the source code to get resultant matrix for your custom imput matrix values

# Select option 1 to calculate Vector multiplication. 
  Input -First enter the number of rows and then enter the real value, imaginary values. 
  Output - The below function calculates vector multiplied values and later printed on screen.

  Function : public void VectorMultiplication(ComplexNumber[,] Vector1, ComplexNumber[,] Vector2)

# Select option 2 to calculate Complex Matrix multiplication. 
  Input - First enter the number of rows and columns. Enter the real value, imaginary values.
  Output - The below function calculates vector multiplied values and later printed on screen.

  Function : public ComplexNumber[,] MatrixMultiplication(ComplexNumber[,] m1, ComplexNumber[,] m2)

# Select option 3 to calculate polar coordinates. 
  Input - First enter the real value and then enter the imaginary value.
  Output - Absolute and phase value are calculated and printed on screen.

  Function : (AbsoluteValue, PhaseValue) = GetPolarCoordinates(new ComplexNumber(, )):

  ```

## Screenshots
* Random values were inputted for both matrix and result were obtained. 
* The initilization values are saved as 'screenshot_input_ComplexNumber'and respective results are saved as
   'screenshot_output' that has both polar form and matrix multplication results.

## Expected Output

* Depending on option chosen their respective calculated values are displayed on output screen.



