using SepSampleCodeBase.Application.Common.Interfaces;
using System;

namespace SepSampleCodeBase.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
