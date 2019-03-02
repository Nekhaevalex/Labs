namespace Solvers
{
    interface INumericalSolver
    {
        int Knots { get; set; }

        double[] GetSolution();
    }
}