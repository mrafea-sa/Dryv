using System;
using System.Linq.Expressions;

namespace Dryv
{
    partial class DryvRules<TModel>
    {

		public DryvRules<TModel> Rule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, DryvResult>> rule)
        {
			this.Add(rule,
				new[] { property1, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, DryvResult>> rule)
        {
			this.AddServer(rule,
				new[] { property1, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, DryvResult>> rule)
        {
			this.AddClient(rule,
				new[] { property1, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, DryvResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, DryvResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, DryvResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, DryvResult>> rule)
        {
			this.Add(rule,
				new[] { property1, property2, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, DryvResult>> rule)
        {
			this.AddServer(rule,
				new[] { property1, property2, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, DryvResult>> rule)
        {
			this.AddClient(rule,
				new[] { property1, property2, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, DryvResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, DryvResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, DryvResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, DryvResult>> rule)
        {
			this.Add(rule,
				new[] { property1, property2, property3, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, DryvResult>> rule)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, DryvResult>> rule)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, DryvResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, DryvResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, DryvResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, DryvResult>> rule)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, DryvResult>> rule)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, DryvResult>> rule)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, DryvResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, DryvResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, DryvResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, DryvResult>> rule)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, DryvResult>> rule)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, DryvResult>> rule)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, DryvResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, DryvResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, DryvResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, DryvResult>> rule)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, DryvResult>> rule)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, DryvResult>> rule)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, DryvResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, DryvResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, DryvResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule(
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
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, DryvResult>> rule)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, DryvResult>> rule)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, DryvResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, DryvResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, DryvResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule(
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
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(
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
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(
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
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, DryvResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, DryvResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, DryvResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule(
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
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(
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
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(
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
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, DryvResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, DryvResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, DryvResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }

	}
}
