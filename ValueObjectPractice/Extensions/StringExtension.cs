using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObjectPractice.Extensions;

public static class StringExtension
{
    public static bool is_not_empty(this string string_to_check) => !String.IsNullOrWhiteSpace(string_to_check);
}

public class CheckConstraint
{
    private readonly bool _assertion;

    public CheckConstraint(bool assertion)
    {
        _assertion = assertion;
    }

    public void on_constraint_failure(Action onFailure)
    {
        if (!_assertion)
        {
            onFailure();
        }
    }
}

public sealed class Check
{
    public static CheckConstraint that(bool assertion) => new CheckConstraint(assertion);
}