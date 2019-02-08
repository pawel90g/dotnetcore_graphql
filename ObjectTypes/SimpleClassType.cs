using HotChocolate.Types;

public class SimpleClassType : ObjectType<SimpleClass>
{
    protected override void Configure(IObjectTypeDescriptor<SimpleClass> descriptor)
    {
        descriptor.Field<SimpleClassResolver>(t => t.GetProperty(default, default, default));
        descriptor.Field<SimpleClassResolver>(t => t.GetProperties(default, default, default));
    }
}