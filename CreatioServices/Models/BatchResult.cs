using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatioServices.Models
{
    public class BatchResult
    {
        public BatchResult()
        {
            Responses = new List<BatchResponse>();
        }
        public List<BatchResponse> Responses { get; set; }
    }
}
