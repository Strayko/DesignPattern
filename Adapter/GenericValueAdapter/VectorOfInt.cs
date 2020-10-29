﻿namespace Adapter.GenericValueAdapter
{
    public class VectorOfInt<D> : VectorGene<VectorOfInt<D>, int, D> where D : IInteger, new()
    {
        public VectorOfInt()
        {
            
        }

        public VectorOfInt(params int[] values) : base(values)
        {
            
        }

        public static VectorOfInt<D> operator +(VectorOfInt<D> lhs, VectorOfInt<D> rhs)
        {
            var result = new VectorOfInt<D>();
            var dim = new D().Value;
            for (int i = 0; i < dim; i++)
            {
                result[i] = lhs[i] + rhs[i];
            }

            return result;
        }
    }
}