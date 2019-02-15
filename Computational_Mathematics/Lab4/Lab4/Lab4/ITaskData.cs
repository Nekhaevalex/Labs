namespace Lab4
{
    interface ITaskData
    {
        double B1 { get; set; }
        double B2 { get; set; }
        double E1 { get; set; }
        double E2 { get; set; }
        double Mfx { get; set; }
        double Mkx { get; set; }
        double Mqx { get; set; }

        double EvaluateFx(double x);
        double EvaluateQx(double x);
        double EvaluteKx(double x);
        void PrintTask();
    }
}