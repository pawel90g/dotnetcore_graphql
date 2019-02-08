using System.Collections.Generic;

public interface ISimpleService
{
    string[] Get();
    IEnumerable<SimpleClass> GetClasses();
}