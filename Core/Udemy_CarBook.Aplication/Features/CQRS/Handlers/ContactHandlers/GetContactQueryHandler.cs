using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.CQRS.Results.ContactResults;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.CQRS.Handlers.ContactHandlers
{
    public class GetContactQueryHandler
    {
        private readonly IRepostory<Contact> _repostory;

        public GetContactQueryHandler(IRepostory<Contact> repostory)
        {
            _repostory = repostory;
        }
        
        public async Task<List<GetContactByIdQueryResult>> Handle()
        {
            var values = await _repostory.GetAllAsync();
            return values.Select(x => new GetContactByIdQueryResult
            {
                ContactID = x.ContactID,
                Email = x.Email,
                Message = x.Message,
                Name = x.Name,
                SendDate = x.SendDate,
                Subjact = x.Subjact
            }).ToList();
        }
    }
}
