using Dapper;
using Demo.Core.Model;
using Demo.Core.Queries;
using Demo.Infrastructure.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.Infrastructure.QueryHandler
{
    public class GetPersonListQueryHandler : IRequestHandler<GetPersonListQuery, List<PersonViewModel>>
    {
        private readonly ISqlConnectionFactory sqlConnectionFactory;

        public GetPersonListQueryHandler(ISqlConnectionFactory sqlConnectionFactory)
        {
            this.sqlConnectionFactory = sqlConnectionFactory;
        }
        public async Task<List<PersonViewModel>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
        {
            using IDbConnection db = this.sqlConnectionFactory.GetOpenConnection();
            var personlist = await db.QueryAsync<PersonViewModel>("Select * From Person");
            return personlist.ToList();

        }
    }
}
