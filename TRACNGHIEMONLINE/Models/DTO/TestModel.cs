using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TRACNGHIEMONLINE.Models.DTO
{
    public class TestModel
    {
        public int subId;
        public int typeExId;
        public List<ExamModel> listExams = new List<ExamModel>();
    }
}
