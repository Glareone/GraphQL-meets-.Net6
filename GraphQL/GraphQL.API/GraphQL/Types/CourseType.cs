using GraphQL.Data.Models;
using GraphQL.Types;

namespace GraphQL.GraphQL.Types;

public class CourseType: ObjectGraphType<Course>
{
    public CourseType()
    {
        Field(x => x.Id, type: typeof(IdGraphType)).Description("Course Id property");
        Field(x => x.Name, type: typeof(StringGraphType)).Description("Course Name");
        Field(x => x.Description, type: typeof(StringGraphType)).Description("Course Description");
        Field(x => x.Review, type: typeof(IntGraphType)).Description("Course Review");
        Field(x => x.DateAdded, type: typeof(DateTimeGraphType)).Description("Date when course was added");
        Field(x => x.DateUpdated, type: typeof(DateTimeGraphType)).Description("Date when course was updated");
    }
}