using System;
using System.Numerics;

namespace Examples.ContinuationPassingStyle
{
    public class QuadraticEquationSolver
    {
        public WorkflowResult Start(double a, double b, double c, out Tuple<Complex, Complex> result)
        {
            var disc = b * b - 4 * a * c;
            if (disc < 0)
            {
                result = null;
                return WorkflowResult.Failure;
            }
            // return SolveComplex(a, b, c, disc);
            else
            {
                return SolveSimple(a, b, disc, out result);
            }

            WorkflowResult SolveSimple(double a, double b, double disc,
                out Tuple<Complex, Complex> result)
            {
                var rootDisc = Math.Sqrt(disc);
                result = Tuple.Create(
                    new Complex((-b + rootDisc) / (2 * a),0),
                    new Complex((-b - rootDisc) / (2 * a),0)
                );
                return WorkflowResult.Success;
            }

            Tuple<Complex, Complex> SolveComplex(double a, double b, double c, double disc)
            {
                var rootDisc = Complex.Sqrt(new Complex(disc, 0));
                return Tuple.Create(
                    (-b + rootDisc) / (2 * a),
                    (-b - rootDisc) / (2 * a)
                );
            }
        }
    }
}