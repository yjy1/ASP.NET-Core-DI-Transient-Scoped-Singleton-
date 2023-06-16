using ASP.NET_Core依赖注入_DI_讲解.Context;
using ASP.NET_Core依赖注入_DI_讲解.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core依赖注入_DI_讲解
{
    public class Startup
    {
        //参考资料：
        //作者：Ruby_Lu  
        //博客地址：https://www.jb51.net/article/244316.htm
        //来源：脚本之家


        // ASP.NET Core依赖注入(DI)讲解(Transient、Scoped和Singleton生命周期服务)
        // 更新时间：2022年04月13日 11:14:21   作者：Ruby_Lu
        //本文详细讲解了ASP.NET Core依赖注入(DI)，文中通过示例代码介绍的非常详细。对大家的学习或工作具有一定的参考借鉴价值，需要的朋友可以参考下

        //ASP.NET Core的底层设计支持和使用依赖注入。ASP.NET Core 应用程序可以利用内置的框架服务将服务注入到启动类的方法中，并且应用程序服务也可以配置注入。由ASP.NET Core 提供的默认服务容器提供了最小功能集，并不是取代其他容器。

        //1.浅谈依赖注入
        //依赖注入(Dependency injection, DI) 是一种实现对象和依赖者之间松耦合的技术，将类用来执行其操作的这些对象以注入的方式提供给该类，而不是直接实例化依赖项或者使用静态引用。一般情况，类会通过构造函数声明器2依赖关系，允许他们遵循显示依赖原则。这种方法称为“构造函数注入”。

        //当类的设计使用DI思想时，他们的耦合更加松散，因为他们没有对他们的合作者直接硬编码的依赖。这遵循“依赖倒置原则”，其中指出，高层模块不应该依赖于底层模块：两者都依赖于抽象。


        //类要求在他们构造时向其提供抽象（通常是接口），而不是引用特定的实现。提取接口的依赖关系和提供接口的实现作为参数也是“策略设计模式”的一个示例。

        //当一个类被用来创建类及其相关的依赖关系时，这个成为容器（containers），或者称为控制反转(Inversion of Control, IoC)容器，或者依赖注入容器。容器本质上是一个工厂，负责提供向它请求的类型的实例。如果一个给定类型声明它具有依赖关系，并且容器已经被配置为其提供依赖关系，那么它将把创建依赖关系作为创建请求实例的一部分。除了创建对象的依赖关系外，容器通常还会管理应用程序中对象的生命周期。

        //ASP.NET Core 包含一个默认支持构造函数注入的简单内置容器，ASP.NET 的容器指的是它管理的类型services, 可以在Startup类的ConfigureServices方法中配置内置容器的服务。

        //2. 使用ASP.NET Core提供的服务
        //Startup类的ConfigureServices方法负责定义应用程序将使用的服务，包括平台自带的功能，比如，Entity Framework Core 和 ASP.NET Core MVC。除了IServiceCollection提供的几个服务之外，可以使用一些扩展方法（AddDbContext，AddMvc，AddTransient等）向容器添加和注册额外服务：

        // ASP.NET Core 提供的功能和中间件，遵循约定使用一个单一的AddService扩展方法来注册所有该功能所需的服务。

        //3.注册自己的服务
        //我们可以按照 services.AddTransient<ICompanyServices, CompanyServices>(); 这种写法注册自己的服务。第一个范型类型表示将要从容器中请求的类型（通常是一个接口）。第二个范型类型表示将由容器实例化并且用于完成请求的具体类型。

        //AddTransient 方法用于将抽象类型映射到为每一个需要它的对象分别实例化的具体服务。为注册的每一个服务选择合适的生命周期很重要，后面会介绍到。

        //下面是示例是注册自己的服务：

        //1.接口

        //2.实现类

        //3.在ConfigureServices中注册自定义的服务和EF上下文AccessManagementContext 

        //4.在Controller构造函数中依赖注入

        //4.服务的生命周期和注册选项
        //ASP.NET 服务生命周期：

        //1.Transient 瞬时
        //Transient 生命周期服务 在他们每次请求时被创建。适合轻量级，无状态 的服务。 
        //39a64ed2-2c92-459a-9817-a8e8d658aced c468002d-4c32-4796-ba92-647844ba3c4e   不相同
        //31c553e5-4313-4d56-9c99-8f70ad7b590a  344ab333-a231-47bd-9601-89a81f57aed5  不相同
        //4个都不一样

        //2.Scoped 作用域
        //Scoped生命周期 在每次请求时 创建一次。
        //b4247ee3-969d-423c-af8a-ef74ca54cdf2  b4247ee3-969d-423c-af8a-ef74ca54cdf2    相同
        //2ce69a1c-aca3-4ae9-bd73-59b8de16076e 2ce69a1c-aca3-4ae9-bd73-59b8de16076e    相同

        //3.Singleton 单例
        //Singleton 生命周期服务 在它们第一次请求时创建，并且 每个后续请求 使用相同的实例。
        //d38acb23-8bfc-46bd-86de-2445fdfc5392  d38acb23-8bfc-46bd-86de-2445fdfc5392 并且每个后续请求使用相同的实例。

        //服务可以用多种方式在容器中注册，除了之前的注册方法，还可以指定一个工厂，它将被用来创建需要的实例。后面会详细介绍其他的注册方法。

        //下面用一个简单的示例介绍每个生命周期：

        //1.创建接口：

        //2.实现类
        /// <summary>
        /// 实现所有接口
        /// </summary>

        //3.注册到容器


        //4.上面还注册了 OperationServices ，用来测试单例模式（单例生命周期服务中所有请求使用第一次实例化的服务）和 作用域生命周期服务在每次请求时只创建一次，不管几个地方用到实例

        //5.在Controller中使用

        //6.Index显示

        // 7.运行结果


        //可以看到，单例生命周期服务每一次请求的标识一样。作用域生命周期的服务，在一次请求中使用的同一个实例，第二次请求创建新的实例。

        //5.请求服务
        //来自HttpContext的一次ASP.NET 请求中，可用的服务是通过RequestServices集合公开的。

        //请求服务将你配置的服务和请求描述为应用程序的一部分。在子的对象指定依赖之后，这些满足要求的对象可通过查找RequestServices中对应的类型得到，而不是ApplicationServices。

        //6.设计依赖注入服务
        //在自定义的服务中，避免使用静态方法和直接实例化依赖的类型，而是通过依赖注入请求它。（New is Glue）

        //如果类有太多的依赖关系被注入时，通常表明你的类试图做的太多（违反了单一职责原则），需要转移一些职责。

        //同样，Controller类应该重点关注UI，因此业务逻辑和数据访问等细节应该在其他类中。

        //7.使用Autofac容器
        //Autofac

        //到此这篇关于ASP.NET Core依赖注入(DI)的文章就介绍到这了。希望对大家的学习有所帮助，也希望大家多多支持脚本之家。


        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        /*   public void ConfigureServices(IServiceCollection services)
           {
               services.AddMvc();
               services.AddDbContext<AccessManagementContext>(options =>
                   options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),
                   providerOptions => providerOptions.EnableRetryOnFailure()));
               services.AddTransient<IAccountServices, AccountServices>();
           }
   */
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IOperationTransient, Operation>();
            services.AddScoped<IOperationScoped, Operation>();
            services.AddSingleton<IOperationSingleton, Operation>();
            services.AddSingleton<IOperationInstance, Operation>();
            services.AddTransient<OperationServices, OperationServices>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
