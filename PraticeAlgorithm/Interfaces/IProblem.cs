using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeAlgorithm.Interfaces
{
    public interface IProblem<TInput, TResult>
    {
        TResult Solve(TInput input);
    }

}
