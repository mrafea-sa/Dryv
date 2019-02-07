﻿using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Dryv.Configuration;
using Dryv.Utils;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Dryv.TagHelpers
{
    [HtmlTargetElement("input", Attributes = "dryv-for")]
    [HtmlTargetElement("input", Attributes = "asp-for")]
    [HtmlTargetElement("textarea", Attributes = "asp-for")]
    public class DryvTagHelper : TagHelper
    {
        private readonly IOptions<DryvOptions> options;

        private string name;

        public DryvTagHelper(IOptions<DryvOptions> options)
        {
            this.options = options;
        }

        public ModelExpression AspFor { get; set; }

        public ModelExpression DryvFor { get; set; }

        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var aspFor = this.AspFor ?? this.DryvFor;
            if (aspFor == null || this.ViewContext == null)
            {
                return Task.CompletedTask;
            }

            var modelType = this.ViewContext.ViewData.ModelMetadata.ModelType
                            ?? aspFor.Metadata.ContainerType;
            var property = aspFor.GetProperty();
            var modelPath = this.ViewContext.GetModelPath(aspFor);
            var httpContext = this.ViewContext.HttpContext;

            var clientValidation = httpContext.RequestServices.GetService<IDryvClientModelValidator>().GetValidationAttributes(
                modelType,
                modelPath,
                property,
                this.ViewContext.HttpContext.RequestServices.GetService,
                this.options.Value);

            if (clientValidation == null)
            {
                return Task.CompletedTask;
            }

            this.ViewContext.StoreValidationCode(clientValidation.Name, clientValidation);
            output.Attributes.AddRange(clientValidation.ElementAttribute.Select(i => new TagHelperAttribute(i.Key, i.Value)));

            if (!output.Attributes.ContainsName("name"))
            {
                output.Attributes.Add("name", this.GetName(modelPath, property));
            }

            if (!output.Attributes.ContainsName("id"))
            {
                output.Attributes.Add("id", this.GetName(modelPath, property));
            }

            return Task.CompletedTask;
        }

        private string GetName(string modelPath, MemberInfo property)
        {
            var prefix = this.DryvFor == null ? string.Empty : "_";
            return this.name ?? (this.name = modelPath + (string.IsNullOrWhiteSpace(modelPath) ? string.Empty : ".") + prefix + property.Name);
        }
    }
}