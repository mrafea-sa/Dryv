using System;
using System.Linq.Expressions;

namespace Dryv
{
    partial class Rules<TModel>
    {

		public Rules<TModel> Rule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, });
			return this;
        }
		public Rules<TModel> Rule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, });
			return this;
        }
		public Rules<TModel> Rule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, });
			return this;
        }
		public Rules<TModel> Rule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, });
			return this;
        }
		public Rules<TModel> Rule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, });
			return this;
        }
		public Rules<TModel> Rule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, property6, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, property6, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, property6, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, property6, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, property6, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, property6, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, property6, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, property6, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, property6, });
			return this;
        }
		public Rules<TModel> Rule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, property6, property7, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, property6, property7, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, property6, property7, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, property6, property7, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, property6, property7, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, property6, property7, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, property6, property7, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, property6, property7, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, property6, property7, });
			return this;
        }
		public Rules<TModel> Rule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, });
			return this;
        }
		public Rules<TModel> Rule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, });
			return this;
        }
		public Rules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResult>> rule)
        {
			this.Add(rule, 
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, });
			return this;
        }

	}
}
