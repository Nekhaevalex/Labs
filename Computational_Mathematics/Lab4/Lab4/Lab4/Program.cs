using System;
using System.Text;
using TaskDatas;
using Solvers;

namespace Lab4
{
    class Program
    {
        public static int points = 11; //кол-во точек сетки
        
        public static double[] MakeNet()
        {
            double[] result = new double[points];
            double step = 1.0 / (points-1);
            double currentX = 0.0;
            for (int i = 0; i < points; i++)
            {
                result[i] = currentX;
                currentX += step;
            }
            return result;
        }

        public static void PrintEvaluatedValues(double[,] values)
        {
            for (int i = 0; i<values.Length/2; i++)
            {
                    Console.WriteLine(values[0, i] + "\t" + values[1, i]);
            }
        }

        public static void PrintEvaluatedValues(double[] values)
        {
            for (int i = 0; i<values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }
        }

        public static void PrintEvaluatedValues(string[] labels, params double[][] vs)
        {
            for (int i = 0; i < labels.Length; i++)
            {
                Console.Write(labels[i] + "\t");
            }
            Console.WriteLine();
            for (int j = 0; j<vs[0].Length; j++)
            {
                for (int i = 0; i<vs.Length; i++)
                {
                    Console.Write(vs[i][j] + "\t");
                }
                Console.WriteLine();
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
            Console.WriteLine("Solutions");
            DifferModelSolver differModelSolver = new DifferModelSolver(inputs)
            {
                Knots = points
            };
            VariableCoefsNumericalSolver variableCoefsNumerical = new VariableCoefsNumericalSolver(inputs)
            {
                Knots = points
            };
            double[] analyticSolve = analyticSolver.GetSolution(points);
            double[] differSolve = differModelSolver.GetSolution();
            double[] variableSolve = variableCoefsNumerical.GetSolution();
            double[] differ = new double[points];
            for (int i = 0; i<points; i++)
            {
                differ[i] = (analyticSolve[i] - differSolve[i]);
            }
            double maxDiffer = differ[0];
            for(int i = 1; i<points; i++)
            {
                if (maxDiffer<differ[i])
                {
                    maxDiffer = differ[i];
                }
            }
            double[] answer = new double[points];
            for(int i = 0; i<points; i++)
            {
                answer[i] = maxDiffer + variableSolve[i];
            }
            PrintEvaluatedValues(new string[] { "X", "Analytic Solution", "Thomas algorithm", "Variable Coeffitients", "Differ Analytic-Thomas", "Answer"}, MakeNet(), analyticSolve, differSolve, variableSolve, differ, answer);
            Console.WriteLine("Max differ: " + maxDiffer);
            Console.ReadLine();
        }
    }
}
