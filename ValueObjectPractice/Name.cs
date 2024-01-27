using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObjectPractice.Extensions;

namespace ValueObjectPractice;
public class Name : ValueObject<Name>
{
    protected readonly string FirstName;
    protected readonly string LastName;
    private Name() : this(string.Empty, string.Empty)
    {
    }
    private Name(string firstName, string lastName)
    {
        Validate(firstName, lastName);

        FirstName = firstName;
        LastName = lastName;
    }
    public static Name Create(string firstName, string lastName)
    {
        return new Name(firstName, lastName);
    }

    private void Validate(string firstName, string lastName)
    {
        Check.that(firstName.is_not_empty()).on_constraint_failure(() => throw new ApplicationException("You must specify a first name."));
        Check.that(lastName.is_not_empty()).on_constraint_failure(() => throw new ApplicationException("You must specify a last name."));
    }   
    protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
    {
        return new object[] { FirstName, LastName };
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}
