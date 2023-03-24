﻿using BooksSharing.Application.Repositories.Common;
using BooksSharing.Domain.Models;

namespace BooksSharing.Application.Repositories
{
    public interface IReservationQueueRepository : IGenereicRepositoryAsync<ReservationQueueEntity>
    {
    }
}
