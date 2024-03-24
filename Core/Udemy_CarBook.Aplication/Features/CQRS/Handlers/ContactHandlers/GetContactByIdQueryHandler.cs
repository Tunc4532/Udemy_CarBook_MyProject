using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.CQRS.Queries.ContactQueries;
using Udemy_CarBook.Aplication.Features.CQRS.Results.ContactResults;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.CQRS.Handlers.ContactHandlers
{
    public class GetContactByIdQueryHandler
    {
        private readonly IRepostory<Contact> _repostory;
        public GetContactByIdQueryHandler(IRepostory<Contact> repostory)
        {
            _repostory = repostory;
        }

        public async Task<GetContactByIdQueryResult> Handle(GetContactByIdQuery query)
        {
            var values = await _repostory.GetByIdAsync(query.Id);
            return new GetContactByIdQueryResult
            {
                ContactID = values.ContactID,
                Email = values.Email,
                Message = values.Message,
                Name = values.Name,
                SendDate = values.SendDate,
                Subjact = values.Subjact
            };
        }

    }
}
