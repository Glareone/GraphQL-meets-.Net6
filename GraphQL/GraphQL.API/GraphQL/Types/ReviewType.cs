using GraphQL.Data.Models;
using GraphQL.Types;

namespace GraphQL.GraphQL.Types;

public sealed class ReviewType: ObjectGraphType<Review>
{
    public ReviewType()
    {
        Field(x => x.Id, type: typeof(IntGraphType)).Description("Review Id property");
        Field(x => x.Rate, type: typeof(IntGraphType)).Description("Course Rate");
        Field(x => x.Comment, type: typeof(StringGraphType)).Description("Rate's comment");
    }
}