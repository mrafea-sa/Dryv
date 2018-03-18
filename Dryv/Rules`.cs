﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace Dryv
{
    public partial class Rules<TModel> : DryvRules
    {
        internal Rules()
        {
        }

        internal Rules(Expression<Func<TModel, DryvResult>> rule)
        {
            this.ModelRules.Add(rule);
        }

        public Rules<TModel> Rule(Expression<Func<TModel, DryvResult>> rule)
        {
            this.ModelRules.Add(rule);
            return this;
        }

        private void Add<TProperty>(
            Expression<Func<TModel, TProperty>> property,
            Expression rule)
        {
            if (!(property.Body is MemberExpression memberExpression) ||
                !(memberExpression.Member is PropertyInfo propertyInfo))
            {
                return;
            }

            var expressions = this.PropertyRules.GetOrAdd(propertyInfo.Name, _ => new List<Expression>());
            expressions.Add(rule);
        }

        private void Add<TProperty>(
            Expression rule,
            IEnumerable<Expression<Func<TModel, TProperty>>> properties)
        {
            foreach (var property in properties)
            {
                this.Add(property, rule);
            }
        }
    }
}