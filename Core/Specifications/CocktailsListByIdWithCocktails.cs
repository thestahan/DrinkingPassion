﻿using Core.Entities;

namespace Core.Specifications
{
    public class CocktailsListByIdWithCocktails : BaseSpecification<CocktailsList>
    {
        public CocktailsListByIdWithCocktails(int id) : base(l => l.Id == id)
        {
            AddInclude(l => l.Cocktails);
        }
    }
}
