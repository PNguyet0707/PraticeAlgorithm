namespace PraticeAlgorithm.Interfaces
{
    public interface IProblem<TInput, TResult>
    {
        TResult Solve(TInput input);
    }

}
