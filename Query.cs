using System.Collections.Generic;
using System.Linq;
using HotChocolate;

namespace GraphQL
{
    public class Query
    {
        public string[] Get([Service] ISimpleService simpleService) => simpleService.Get();

        public SimpleClass GetSimpleClass(int id, [Service] ISimpleService simpleService)
        {
            return simpleService.GetClasses().FirstOrDefault(x => x.Id == id);
        }
        public IEnumerable<SimpleClass> GetSimpleClasses([Service] ISimpleService simpleService)
        {
            return simpleService.GetClasses();
        }
    }
}
