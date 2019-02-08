using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate;

public class SimpleClassResolver
{
    public Task<SimpleProperty> GetProperty(SimpleClass simpleClass, int id, [Service] ISimpleService simpleService)
    {
        return Task.Factory.StartNew(() => simpleClass.Properties.FirstOrDefault(x => x.Id == id));
    }

    public Task<IEnumerable<SimpleProperty>> GetProperties(SimpleClass simpleClass, string name, [Service] ISimpleService simpleService)
    {
        return Task.Factory.StartNew(() => simpleClass.Properties.Where(x => x.PropertyName.Contains(name, StringComparison.InvariantCultureIgnoreCase)));
    }
}