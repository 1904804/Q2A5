using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2A5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4 by 4 * 4 by 4 matrix
            //provide guidance and layout of matrix`s 
            Console.WriteLine("Matrix A \n");
            Console.WriteLine("A01 \tA02 \tA03 \tA04");
            Console.WriteLine("A05 \tA06 \tA07 \tA08");
            Console.WriteLine("A09 \tA10 \tA11 \tA12");
            Console.WriteLine("A13 \tA14 \tA15 \tA16");

            Console.WriteLine("\n");

            Console.WriteLine("Matrix B \n");
            Console.WriteLine("B01 \tB02 \tB03 \tB04");
            Console.WriteLine("B05 \tB06 \tB07 \tB08");
            Console.WriteLine("B09 \tB10 \tB11 \tB12");
            Console.WriteLine("B13 \tB14 \tB15 \tB16");

            //create and assign the size to the arrays that will be used to store the values
            double[] matrixA = new double[16];
            double[] matrixB = new double[16];
            double[] matrixResults = new double[16];
            
            //prompt and store the values for matrix A , loops through and assigns a value to the correct postion in the array
            Console.WriteLine("Please enter the values for Matrix A -");

            for (int i = 0; i < 16; i++)
            {
                int postion = i + 1;
                Console.WriteLine("Enter the value for postion A" + postion);
                matrixA[i] = Convert.ToDouble(Console.ReadLine());
            }

            //prompt and store the values for matrix B ,loops through and assigns a value to the correct postion in the array
            Console.WriteLine("Please enter the values for Matrix B -");

            for (int j = 0; j < 16; j++)
            {
                int postion = j + 1;
                Console.WriteLine("Enter the value for postion B" + postion);
                matrixB[j] = Convert.ToDouble(Console.ReadLine());
            }





            //Display matrix a
            Console.WriteLine("Matrix A values\n");
            Console.WriteLine(matrixA[0]+ "\t"+ matrixA[1]+ "\t"+ matrixA[2]+"\t"+ matrixA[3]);
            Console.WriteLine(matrixA[4] + "\t" + matrixA[5] + "\t" + matrixA[6] + "\t" + matrixA[7]);
            Console.WriteLine(matrixA[8] + "\t" + matrixA[9] + "\t" + matrixA[10] + "\t" + matrixA[11]);
            Console.WriteLine(matrixA[12] + "\t" + matrixA[13] + "\t" + matrixA[14] + "\t" + matrixA[15]);

            //Display matrix B
            Console.WriteLine("Matrix B values\n");
            Console.WriteLine(matrixB[0] + "\t" + matrixB[1] + "\t" + matrixB[2] + "\t" + matrixB[3]);
            Console.WriteLine(matrixB[4] + "\t" + matrixB[5] + "\t" + matrixB[6] + "\t" + matrixB[7]);
            Console.WriteLine(matrixB[8] + "\t" + matrixB[9] + "\t" + matrixB[10] + "\t" + matrixB[11]);
            Console.WriteLine(matrixB[12] + "\t" + matrixB[13] + "\t" + matrixB[14] + "\t" + matrixB[15]);

            //4 by 4 * 4 by 4 calculation
            //row1
            matrixResults[0] = matrixA[0] * matrixB[0] + matrixA[1] * matrixB[4] + matrixA[2] * matrixB[8] + matrixA[3] * matrixB[12];
            matrixResults[1] = matrixA[0] * matrixB[1] + matrixA[1] * matrixB[5] + matrixA[2] * matrixB[9] + matrixA[3] * matrixB[13];
            matrixResults[2] = matrixA[0] * matrixB[2] + matrixA[1] * matrixB[6] + matrixA[2] * matrixB[10] + matrixA[3] * matrixB[14];
            matrixResults[3] = matrixA[0] * matrixB[3] + matrixA[1] * matrixB[7] + matrixA[2] * matrixB[11] + matrixA[3] * matrixB[15];

            //row 2
            matrixResults[4] = matrixA[4] * matrixB[0] + matrixA[5] * matrixB[4] + matrixA[6] * matrixB[8] + matrixA[7] * matrixB[12];
            matrixResults[5] = matrixA[4] * matrixB[1] + matrixA[5] * matrixB[5] + matrixA[6] * matrixB[9] + matrixA[7] * matrixB[13];
            matrixResults[6] = matrixA[4] * matrixB[2] + matrixA[5] * matrixB[6] + matrixA[6] * matrixB[10] + matrixA[7] * matrixB[14];
            matrixResults[7] = matrixA[4] * matrixB[3] + matrixA[5] * matrixB[7] + matrixA[6] * matrixB[11] + matrixA[7] * matrixB[15];

            //row 3
            matrixResults[8] = matrixA[8] * matrixB[0] + matrixA[9] * matrixB[4] + matrixA[10] * matrixB[8] + matrixA[11] * matrixB[12];
            matrixResults[9] = matrixA[8] * matrixB[1] + matrixA[9] * matrixB[5] + matrixA[10] * matrixB[9] + matrixA[11] * matrixB[13];
            matrixResults[10] = matrixA[8] * matrixB[2] + matrixA[9] * matrixB[6] + matrixA[10] * matrixB[10] + matrixA[11] * matrixB[14];
            matrixResults[11] = matrixA[8] * matrixB[3] + matrixA[9] * matrixB[7] + matrixA[10] * matrixB[11] + matrixA[11] * matrixB[15];

            //row 4
            matrixResults[12] = matrixA[12] * matrixB[0] + matrixA[13] * matrixB[4] + matrixA[14] * matrixB[8] + matrixA[15] * matrixB[12];
            matrixResults[13] = matrixA[12] * matrixB[1] + matrixA[13] * matrixB[5] + matrixA[14] * matrixB[9] + matrixA[15] * matrixB[13];
            matrixResults[14] = matrixA[12] * matrixB[2] + matrixA[13] * matrixB[6] + matrixA[14] * matrixB[10] + matrixA[15] * matrixB[14];
            matrixResults[15] = matrixA[12] * matrixB[3] + matrixA[13] * matrixB[7] + matrixA[14] * matrixB[11] + matrixA[15] * matrixB[15];



            //Display matrix results
            Console.WriteLine("Matrix B values\n");
            Console.WriteLine(matrixResults[0] + "\t" + matrixResults[1] + "\t" + matrixResults[2] + "\t" + matrixResults[3]);
            Console.WriteLine(matrixResults[4] + "\t" + matrixResults[5] + "\t" + matrixResults[6] + "\t" + matrixResults[7]);
            Console.WriteLine(matrixResults[8] + "\t" + matrixResults[9] + "\t" + matrixResults[10] + "\t" + matrixResults[11]);
            Console.WriteLine(matrixResults[12] + "\t" + matrixResults[13] + "\t" + matrixResults[14] + "\t" + matrixResults[15]);

        }
    }
}
