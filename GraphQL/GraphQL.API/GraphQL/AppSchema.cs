using GraphQL.GraphQL.Mutations;
using GraphQL.GraphQL.Queries;
using GraphQL.Types;

namespace GraphQL.GraphQL;

public sealed class AppSchema: Schema
{
    public AppSchema(CourseQuery courseQuery, CourseMutation courseMutation)
    {
        Query = courseQuery;
        Mutation = courseMutation;
    }
}