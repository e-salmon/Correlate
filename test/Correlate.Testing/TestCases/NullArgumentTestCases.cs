﻿namespace Correlate.Testing.TestCases;

public class NullArgumentTestCases : List<DelegateTestCase>
{
    public IEnumerable<object[]> Flatten()
    {
        return this
            .SelectMany(tc => tc.GetNullArgumentTestCases())
            .ToList();
    }
}
