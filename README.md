<a href="https://dryv-lib.net" target="_new" title="Got to project website"><img src="logo_slogan.svg" title="Dryv - DRY Validation for ASP.NET MVC and ASP.NET Core" width="300"></a>

[![NuGet version](https://badge.fury.io/nu/dryv.svg)](https://badge.fury.io/nu/dryv) [![npm version](https://badge.fury.io/js/dryv-jquery-unobtrusive.svg)](https://badge.fury.io/js/dryv-jquery-unobtrusive)

**Complex model validation for server and client made easy.**

Write complex model validation rules in C# once.
_Dryv_ will generate JavaScript for client-side validation.

## Overview
According to [Rick Anderson](https://twitter.com/RickAndMSFT), 

> "One of the design tenets of MVC is DRY ("Don't Repeat Yourself")"

and

> "The validation support provided by MVC and Entity Framework Core Code First is a good example of the DRY principle in action. 
You can declaratively specify validation rules in one place (in the model class) and the rules are enforced everywhere in the app" ([from Microsoft Docs](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app-xplat/validation)).


While this is the case for simple validation rules, applying complex validations rules is a different story. For instance, see the following model.

```csharp
public class Customer
{
    [Required]
    public string Name { get; set; }

    public string Company { get; set; }

    public string TaxId { get; set; }
}
```

Using the annotation attributes provides by .NET, we can state that the `Name` property must be specified. ASP.NET MVC will render JavaScript code for us that performs model validation in the browser, and it will peroform server-side model validation in the controller. That's cool, certainly. 

Now consider the following case: neither the company nor the tax ID fields are required at first. But if the user enters a company name, the tax ID field becomes required. How would you implement such a validation?

The recommended approach **until now** is to write an own validation attribute that inherits from [ValidationAttribute](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.validationattribute?view=netframework-4.7.1), make it implement [IClientModelValidator](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.modelbinding.validation.iclientmodelvalidator.addvalidation?view=aspnetcore-2.0), implement server side validation and add client-side code to implement a jQuery validator. Real-world application can have lots and lots of different validation rules and implementing them in C# as well as JavaScript can become a cumbersome task.

**That's where Dryv comes in.** The name "Dryv" is derived from the term "DRY Validation". Using Dryv, you define the rules using C# expressions and some inner magic will translate them to JavaScript. Using Dryv, the example above would look like this:

```csharp
public class Customer
{
    public static readonly DryvRules Rules = DryvRules
        .For<Customer>()
        .Rule(m => m.TaxId,
            m => string.IsNullOrWhiteSpace(m.Company) || !string.IsNullOrWhiteSpace(m.TaxId)
                ? DryvResult.Success
                : $"The tax ID for {m.Company} must be specified.");

    [Required]
    public string Name { get; set; }

    public string Company { get; set; }

    [DryvRules]
    public string TaxId { get; set; }
}
```

In the code above, a set of rules for the class `Customer` is defined. This set of rules contains a rule for the property `TaxId`. The property `TaxId` has an attribute `DryvRulesAttributes` that makes Dryv play nicely with the ASP.NET MVC validation framework. On the client, you need to load the appropriate JavaScript implementation of Dryv. Currently, an implementation exists for jQuery unobtrusive. Other implementations (e.g. for VueJS or React) can easily be added (and will be over time). 

## Installation
### ASP.NET Core
On the server, install the NuGet package:
```
Install-Package Dryv.AspNetCore 
```
### ASP.NET MVC 4.5.1 with Unity
On the server, install the NuGet package:
```
Install-Package Dryv.AspNetMvc.Unity 
```

### ASP.NET MVC 4.5.1 with Autofac
On the server, install the NuGet package:
```
Install-Package Dryv.AspNetMvc.Autofac 
```

### ASP.NET MVC 4.5.1 with Ninject
On the server, install the NuGet package:
```
Install-Packag Dryv.AspNetMvc.Ninject 
```

### ASP.NET MVC 4.5.1 with SimpleInjector
On the server, install the NuGet package:
```
Install-Package Dryv.AspNetMvc.SimpleInjector 
```

### Client
On the client, install the NPM package:
```
npm install --save dryv-jquery-unobtrusive 
```
... or download the browser-specific JS file directly [from here](https://raw.githubusercontent.com/mhusseini/dryv-jquery-unobtrusive/master/dist/dryv-jquery-unobtrusive.browser.min.js) into your project and reference it from your page:
```
<script src="js/dryv-jquery-unobtrusive.browser.min.js"></script>
```
## Usage
### ASP.NET Core

In the ASP.NET Core startup class, add Dryv in the ConfigureServices method using the AddDryv extension method:

```csharp
using Dryv;

public class Startup
{
    // ...

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDryv()
                .AddMvc();
    }
}
```
Also in the startup class, use Dryv in the Configure method using the UseDryv extension method:

```csharp
using Dryv;

public class Startup
{
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
        app.UseDryv()
           .UseMvc();
    }

    // ...
}
```

Since version 2.0, Dryv uses TagHelper to add the client-side validation attributes. To activate the Dryv clienbt validation, register the Dryv TagHelpers, for example in *_ViewImports.cshtml*:
```
@addTagHelper *, Dryv.AspNetCore
```

### ASP.NET MVC 4.5.1

In the ASP.NET MVC startup class (startup.cs or global.asax.cs), add Dryv in the startup method. The following sample demonstrates registering Dryv for usage with Ninject in global.asax.cs:

```csharp
using System.Web.Mvc;
using Dryv.AspNetMvc;
using Ninject;
using Ninject.Web.Common;
using Ninject.Web.Mvc;

public class MvcApplication : HttpApplication
{
    protected void Application_Start()
    {
        var kernel = new StandardKernel(new NinjectSettings());
        // The following line is special for Ninject and reactivates the default ASP.NET MVC model validation.
        kernel.Unbind<ModelValidatorProvider>();
		
        // Register Dryv with the IoC framework.
        kernel.RegisterDryv();
		
        DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));

        AreaRegistration.RegisterAllAreas();
        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        RouteConfig.RegisterRoutes(RouteTable.Routes);

        // Startup Dryv
        DependencyResolver.Current.StartDryv();
    }
}
```
### Other IoC Frameworks
Dryv currently supports Unity, Ninject, Autofac and SimpleInjector out of the box. More supported IoC frameworks will subsequently be added. If you need integration with a framework that is not yet supporte, implement the *IDependencyContainer* interface. Here is how the integration for Ninject was implemnented:

```csharp
using System;
using Ninject;

namespace Dryv.AspNetMvc
{
    internal class DependencyContainer : IDependencyContainer
    {
        private readonly IKernel kernel;

        public DependencyContainer(IKernel kernel) 
            => this.kernel = kernel;

        public void AddInstance(Type iface, object implementation) 
            => this.kernel.Bind(iface).ToConstant(implementation).InSingletonScope().Named(Guid.NewGuid().ToString());

        public void AddSingleton(Type iface, Type implementation) 
            => this.kernel.Bind(iface).To(implementation).InSingletonScope().Named(Guid.NewGuid().ToString());

        public void RegisterInstance(Type iface, object implementation) 
            => this.kernel.Bind(iface).ToConstant(implementation).InSingletonScope();

        public void RegisterSingleton(Type iface, Type implementation) 
            => this.kernel.Bind(iface).To(implementation).InSingletonScope();
    }

    public static class NinjectContainerExtensions
    {
        public static IDryvBuilder RegisterDryv(this IKernel kernel)
            => DryvMvc.Configure(new DependencyContainer(kernel));
    }
}
```
### Stand-alone
Dryv can be used without ASP.NET. Using just the base package, Dryv can be used to validate models.
```csharp
using System;
using Dryv;

namespace Demo
{
    internal class Program
    {
        private static void Main()
        {
            var model = new Model5
            {
                Name = "Hello",
                Child = new Model6
                {
                    Name = "World",
                    Child = new Model7()
                },
                Children = new[]
                {
                    new Model8()
                }
            };

            var validator = new DryvValidator();
            var errors = validator.Validate(model);

            foreach (var error in errors)
            {
                Console.WriteLine(error);
            }
        }
    }
}
```

## Examples and Documentation
For detailed information and usage examples, please visit the project website at [https://dryv-lib.net](https://dryv-lib.net).