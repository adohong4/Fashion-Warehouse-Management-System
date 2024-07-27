using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyKhoHang1
{
    [Serializable]
    public class PlanData
    {
        private List<PlanCaSang> job;

        public List<PlanCaSang> Job { get => job; set => job = value; }
    }
}
