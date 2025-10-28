using System.Runtime.InteropServices;
using webapi.common.domain;

namespace webapi.features.pizza.domain;

public class Ingredient : Entity
{
    protected Ingredient(Guid id, string name,decimal cost) : base(id)
    {
        Name = name;
        Cost = cost;
    }

    public string Name { get; protected set; }
    public decimal Cost { get; protected set; }

    public void Update(string name, decimal cost)
    {
        Name = name;
        Cost = cost;
    }
    public static Ingredient Create(Guid id, string name,decimal cost)
    {
        return new Ingredient(id, name, cost);
    }
    
}