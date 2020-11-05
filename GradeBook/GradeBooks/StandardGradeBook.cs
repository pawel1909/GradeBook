using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool x) : base(name, x) //Added bool to standardGB
        {
            Type = Enums.GradeBookType.Standard;

        }
    }
}
