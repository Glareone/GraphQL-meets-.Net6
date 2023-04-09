using GraphQL.Types;

namespace GraphQL.GraphQL.Types;

public sealed class ReviewInputType: InputObjectGraphType
{
    public ReviewInputType()
    {
        Name = "ReviewInputType";
        
        Field<IntGraphType>("Rate");
        Field<StringGraphType>("Comment");
    }
}