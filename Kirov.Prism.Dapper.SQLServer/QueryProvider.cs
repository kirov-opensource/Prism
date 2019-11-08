using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;

namespace Kirov.Prism.Dapper.SQLServer
{
    public class QueryProvider : IQueryProvider
    {

        private IDbConnection dbConnection;

        public QueryProvider(IDbConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public IQueryable CreateQuery(Expression expression)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
        {
            throw new NotImplementedException();
        }

        public object Execute(Expression expression)
        {
            throw new NotImplementedException();
        }

        public TResult Execute<TResult>(Expression expression)
        {
            throw new NotImplementedException();
        }
    }
}