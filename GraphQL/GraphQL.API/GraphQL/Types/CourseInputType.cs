using GraphQL.Types;

namespace GraphQL.GraphQL.Types;

public sealed class CourseInputType: InputObjectGraphType
{
    public CourseInputType()
    {
        Name = "CourseInputType";
        
        Field<StringGraphType>("Name");
        Field<StringGraphType>("Description");
        Field<IntGraphType>("Review");
        Field<DateTimeGraphType>("DateAdded");
        Field<DateTimeGraphType>("DateUpdated");
    }
}