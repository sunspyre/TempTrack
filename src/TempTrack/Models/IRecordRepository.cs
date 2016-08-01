using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempTrack.Models
{
    public interface IRecordRepository
    {
        IEnumerable<Record> GetAllRecords();
    }
}
