using System;
using System.Text;

namespace Lab4
{
    class Program
    {
        public static int points = 11; //кол-во точек сетки

        public static void PrintEvaluatedValues(double[,] values)
        {
            for (int i = 0; i<values.Length/2; i++)
            {
                    Console.WriteLine(values[0, i] + "\t" + values[1, i]);
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Computational Lab 4. Variant 1. Task 2. (c) 2019 Nekhaev Alexander\n");
            //Берем начальные данные
            TaskData inputs = new TaskData();
            inputs.PrintTask();
            AnalyticSolver analyticSolver = new AnalyticSolver(inputs);
            Console.WriteLine("Analytic solution");
            analyticSolver.PrintEquation();
            Console.WriteLine();
            Console.WriteLine("Analytic solution evaluated points");
            PrintEvaluatedValues(analyticSolver.GetSolutions(points));
            NumericalSolver numericalSolver = new NumericalSolver(inputs);
            Console.ReadLine();
        }
    }
}
