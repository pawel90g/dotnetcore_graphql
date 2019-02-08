using System.Collections.Generic;

public class SimpleClass
{
    public int Id { get; set; }
    public string Name { get; set; }
    public IEnumerable<SimpleProperty> Properties { get; set; }
}