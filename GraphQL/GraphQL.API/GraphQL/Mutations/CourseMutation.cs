using GraphQL.Data.Models;
using GraphQL.Data.Repository;
using GraphQL.GraphQL.Types;
using GraphQL.Types;

namespace GraphQL.GraphQL.Mutations;

public sealed class CourseMutation: ObjectGraphType
{
    public CourseMutation(CoursesRepository repository)
    {
        Field<CourseType>(
            "addCourse",
            "is used to add a new course to the database",
            arguments: new QueryArguments(
                new QueryArgument<NonNullGraphType<CourseInputType>>
                    { Name = "course", Description = "Course input parameter" }
            ),
            resolve: context =>
            {
                var course = context.GetArgument<Course>("course");
                
                // we return course here because in Repository method we return Course as result.
                return repository.AddCourse(course);
            });
        
        Field<CourseType>(
            "updateCourse",
            "Is used to update an existing course",
            arguments: new QueryArguments(
                new QueryArgument<NonNullGraphType<IntGraphType>>
                    { Name = "id", Description = "Id of the course you want to update. Should be int" },
                new QueryArgument<NonNullGraphType<CourseInputType>>
                    { Name = "course", Description = "Updated course Values" }
            ),
            resolve: context =>
            {
                var id = context.GetArgument<int>("id");
                var course = context.GetArgument<Course>("course");

                return repository.UpdateCourse(id, course);
            }
        );
        
        Field<BooleanGraphType>()
            .Name("deleteCourse")
            .Description("Is used to delete course by course Id")
            .Argument<NonNullGraphType<IntGraphType>>(Name = "id", Description = "course Id. Input should has Int type")
            .Resolve(context => {
                    var id = context.GetArgument<int>("id");
                    return repository.DeleteCourse(id);
            });
    }
}