using System.Collections.Generic;

public class SimpleService : ISimpleService
{
    public string[] Get() => new string[] { "val 1", "val 2", "val 3" };

    public IEnumerable<SimpleClass> GetClasses() => new SimpleClass[] {
        new SimpleClass {
            Id = 1,
            Name = "Class 1",
            Properties = new SimpleProperty[] {
                new SimpleProperty {Id = 1, PropertyName = "Property 1 from Class 1", PropertyValue = "Class 1 Value 1"},
                new SimpleProperty {Id = 2, PropertyName = "Property 2 from Class 1", PropertyValue = "Class 1 Value 2"}
            }},
        new SimpleClass {
            Id = 2,
            Name = "Class 2",
            Properties = new SimpleProperty[] {
                new SimpleProperty {Id = 1, PropertyName = "Property 1 from Class 2", PropertyValue = "Class 2 Value 1"},
                new SimpleProperty {Id = 2, PropertyName = "Property 2 from Class 2", PropertyValue = "Class 2 Value 2"}
            }},
        new SimpleClass {
            Id = 3,
            Name = "Class 3",
            Properties = new SimpleProperty[] {
                new SimpleProperty {Id = 1, PropertyName = "Property 1 from Class 3", PropertyValue = "Class 3 Value 1"},
                new SimpleProperty {Id = 2, PropertyName = "Property 2 from Class 3", PropertyValue = "Class 3 Value 2"}
            }},
    };
}