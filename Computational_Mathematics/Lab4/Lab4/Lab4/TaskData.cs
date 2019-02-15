using System;

namespace Lab4
{
    class TaskData : ITaskData
    {
        public double B1 { get; set; }
        public double E1 { get; set; }
        public double B2 { get; set; }
        public double E2 { get; set; }
        public double Mqx { get; set; }
        public double Mkx { get; set; }
        public double Mfx { get; set; }

        public TaskData()
        {
            B1 = 1.0;
            B2 = 1.0;
            E1 = 0.0;
            E2 = 1.0;
            Mkx = Math.Sqrt(Math.Exp(1.0));
            Mqx = Math.Sqrt(Math.Exp(1.0));
            Mfx = Math.Cos(0.5);
        }

        public double EvaluteKx(double x) => Math.Exp(x);
        public double EvaluateQx(double x) => Math.Exp(x);
        public double EvaluateFx(double x) => Math.Cos(x);

        public void PrintTask()
        {
            Console.WriteLine("Найти решение краевой задачи для одномерного стационарного уравнения теплопроводности");
            Console.WriteLine("d/dx[k(x)du/dx]-q(x)=-f(x)");
            Console.WriteLine("в одиннадцати равноудаленных точках отрезка [0,1] с относительной точностью 0,0001. Отладку программы произвести на модельной задаче с постоянными коэффициентами.");
            Console.WriteLine("Краевые условия задачи:");
            string value1 = "k(0) * ux'(0) =" + B1 + "* u(0) - " + E1;
            Console.WriteLine(value1);
            string value2 = "-k(1) * ux'(0) = " + B2 + " * u(0) - " + E2;
            Console.WriteLine(value2);
        }
    }
}
