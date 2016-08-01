using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempTrack.Models
{
    public class RecordRepository : IRecordRepository
    {
        public IEnumerable<Record> GetAllRecords()
        {
            //test data, should pull from database later
            var ret = new List<Record>()
            {
                new Record {Time = "12:11", Serial = "000001234567", Temp = "35" },
                new Record {Time = "23:44", Serial = "00000EF356DD", Temp = "34" },
                new Record {Time = "12:66", Serial = "00000AB748ED", Temp = "38" },
                new Record {Time = "55:34", Serial = "00000C847DDE", Temp = "42" },
                new Record {Time = "63:78", Serial = "0000098BBCD5", Temp = "18" },
            };

            return ret;
        }
    }
}
