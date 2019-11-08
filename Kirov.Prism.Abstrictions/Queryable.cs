using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Kirov.Prism.Abstrictions
{
    public class Queryable<T> : IQueryable<T>
    {
        public Type ElementType { get { return typeof(T); } }

        public Expression Expression { get; }

        public IQueryProvider Provider { get; }

        public Queryable(IQueryProvider queryProvider)
        {
            this.Expression = Expression.Constant(this);
            this.Provider = queryProvider;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
