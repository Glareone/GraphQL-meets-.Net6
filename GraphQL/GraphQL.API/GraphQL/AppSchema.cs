using GraphQL.GraphQL.Queries;
using GraphQL.Types;

namespace GraphQL.GraphQL;

public class AppSchema: Schema, ISchema
{
    public AppSchema(CourseQuery courseQuery)
    {
        Query = courseQuery;
    }
}