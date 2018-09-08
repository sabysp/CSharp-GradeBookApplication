using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook: BaseGradeBook
    {
	    public RankedGradeBook(string name):base(name)
	    {
		    Type = GradeBookType.Ranked;
	    }

	    public override char GetLetterGrade(double averageGrade)
	    {
		    if (Students.Count < 5)
		    {
			    throw new InvalidOperationException("Not enough students");
		    }

		    if (averageGrade > 80)
			    return 'A';
		    if (averageGrade > 60)
			    return 'B';
		    if (averageGrade > 40)
			    return 'C';
		    if (averageGrade > 20)
			    return 'D';
		    return 'F';
	    }

	}
}
