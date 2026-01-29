using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFields.TechnicalData
{
    public interface IInfoDateTimeCreate
    {
        /// <summary>
        /// LOGS => DateTime.Now
        /// </summary>
        /// <returns></returns>
        public DateTime InfoDateTimeCreate { get; }
    }
}
