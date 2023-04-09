using GraphQL.Data.Repository;
using GraphQL.GraphQL.Types;
using GraphQL.Types;

namespace GraphQL.GraphQL.Queries;

public sealed class CourseQuery: ObjectGraphType
{
    public CourseQuery(CoursesRepository coursesRepository)
    {
        Field<ListGraphType<CourseType>>(
            "courses",
            "Returns list of courses",
            resolve: context => coursesRepository.GetAllCourses()
        );

        Field<CourseType>(
            "course",
            "Returns exact course by Id",
            new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>>
                { Name = "id", Description = "Course Id" }),
            
            // MinValue is needed because of NonNullGraph type we defined above
            resolve: context => coursesRepository.GetCourseById(context.GetArgument("id", int.MinValue))
        );
    }
}