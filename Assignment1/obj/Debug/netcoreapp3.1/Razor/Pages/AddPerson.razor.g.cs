#pragma checksum "D:\DNP\DNP-Assignment1\Assignment1\Pages\AddPerson.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8160ace98d59baa84df7b758784ac1ba5df82560"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\DNP\DNP-Assignment1\Assignment1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DNP\DNP-Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DNP\DNP-Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DNP\DNP-Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DNP\DNP-Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DNP\DNP-Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DNP\DNP-Assignment1\Assignment1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\DNP\DNP-Assignment1\Assignment1\_Imports.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\DNP\DNP-Assignment1\Assignment1\_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DNP\DNP-Assignment1\Assignment1\Pages\AddPerson.razor"
using Assignment1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DNP\DNP-Assignment1\Assignment1\Pages\AddPerson.razor"
using Assignment1.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddPerson")]
    public partial class AddPerson : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Policy", "GuestAndMember");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.AddMarkupContent(4, "<h3>UnAuthorized Access, Please Log In to gain access to this page.</h3>\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(6);
            __builder.AddAttribute(7, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n");
#nullable restore
#line 13 "D:\DNP\DNP-Assignment1\Assignment1\Pages\AddPerson.razor"
         if (Int16.Parse(context.User.FindFirst(claim => claim.Type.Equals("Level")).Value) > 4)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(9, "            ");
                __builder2.AddMarkupContent(10, "<h3>\r\n                UnAuthorized Access, Please Log In to gain access to this page.\r\n            </h3>\r\n");
#nullable restore
#line 18 "D:\DNP\DNP-Assignment1\Assignment1\Pages\AddPerson.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(11, "    ");
            }
            ));
            __builder.AddAttribute(12, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.AddMarkupContent(14, "<h3>\r\n            UnAuthorized Access, Please Log In to gain access to this page.\r\n        </h3>\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(16);
            __builder.AddAttribute(17, "Policy", "SecurityLevel4");
            __builder.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((form) => (__builder2) => {
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.AddMarkupContent(20, "<h3>AddAdult</h3>\r\n\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(21);
                __builder2.AddAttribute(22, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 30 "D:\DNP\DNP-Assignment1\Assignment1\Pages\AddPerson.razor"
                          newAdult

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 30 "D:\DNP\DNP-Assignment1\Assignment1\Pages\AddPerson.razor"
                                                    AddNewAdult

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(25, "\r\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(26);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\r\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(28);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(29, "\r\n\r\n            ");
                    __builder3.OpenElement(30, "div");
                    __builder3.AddAttribute(31, "class", "form-group");
                    __builder3.AddMarkupContent(32, "\r\n                First Name:<br>\r\n                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(33);
                    __builder3.AddAttribute(34, "rows", "1");
                    __builder3.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "D:\DNP\DNP-Assignment1\Assignment1\Pages\AddPerson.razor"
                                                     newAdult.FirstName

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(36, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.FirstName = __value, newAdult.FirstName))));
                    __builder3.AddAttribute(37, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdult.FirstName));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(39, "\r\n            ");
                    __builder3.OpenElement(40, "div");
                    __builder3.AddAttribute(41, "class", "form-group");
                    __builder3.AddMarkupContent(42, "\r\n                Last Name:<br>\r\n                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(43);
                    __builder3.AddAttribute(44, "rows", "1");
                    __builder3.AddAttribute(45, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "D:\DNP\DNP-Assignment1\Assignment1\Pages\AddPerson.razor"
                                                     newAdult.LastName

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(46, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.LastName = __value, newAdult.LastName))));
                    __builder3.AddAttribute(47, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdult.LastName));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(48, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(49, "\r\n            ");
                    __builder3.OpenElement(50, "div");
                    __builder3.AddAttribute(51, "class", "form-group");
                    __builder3.AddMarkupContent(52, "\r\n                Hair Color:<br>\r\n                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(53);
                    __builder3.AddAttribute(54, "rows", "1");
                    __builder3.AddAttribute(55, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "D:\DNP\DNP-Assignment1\Assignment1\Pages\AddPerson.razor"
                                                     newAdult.HairColor

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(56, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.HairColor = __value, newAdult.HairColor))));
                    __builder3.AddAttribute(57, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdult.HairColor));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(58, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(59, "\r\n            ");
                    __builder3.OpenElement(60, "div");
                    __builder3.AddAttribute(61, "class", "form-group");
                    __builder3.AddMarkupContent(62, "\r\n                Eye Color:<br>\r\n                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(63);
                    __builder3.AddAttribute(64, "rows", "1");
                    __builder3.AddAttribute(65, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 48 "D:\DNP\DNP-Assignment1\Assignment1\Pages\AddPerson.razor"
                                                     newAdult.EyeColor

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(66, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.EyeColor = __value, newAdult.EyeColor))));
                    __builder3.AddAttribute(67, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdult.EyeColor));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(68, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(69, "\r\n            ");
                    __builder3.OpenElement(70, "div");
                    __builder3.AddAttribute(71, "class", "form-group");
                    __builder3.AddMarkupContent(72, "\r\n                Age:<br>\r\n                ");
                    __Blazor.Assignment1.Pages.AddPerson.TypeInference.CreateInputNumber_0(__builder3, 73, 74, "1", 75, 
#nullable restore
#line 52 "D:\DNP\DNP-Assignment1\Assignment1\Pages\AddPerson.razor"
                                                   newAdult.Age

#line default
#line hidden
#nullable disable
                    , 76, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.Age = __value, newAdult.Age)), 77, () => newAdult.Age);
                    __builder3.AddMarkupContent(78, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(79, "\r\n            ");
                    __builder3.OpenElement(80, "div");
                    __builder3.AddAttribute(81, "class", "form-group");
                    __builder3.AddMarkupContent(82, "\r\n                Height:<br>\r\n                ");
                    __Blazor.Assignment1.Pages.AddPerson.TypeInference.CreateInputNumber_1(__builder3, 83, 84, "1", 85, 
#nullable restore
#line 56 "D:\DNP\DNP-Assignment1\Assignment1\Pages\AddPerson.razor"
                                                   newAdult.Height

#line default
#line hidden
#nullable disable
                    , 86, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.Height = __value, newAdult.Height)), 87, () => newAdult.Height);
                    __builder3.AddMarkupContent(88, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(89, "\r\n            ");
                    __builder3.OpenElement(90, "div");
                    __builder3.AddAttribute(91, "class", "form-group");
                    __builder3.AddMarkupContent(92, "\r\n                Weight:<br>\r\n                ");
                    __Blazor.Assignment1.Pages.AddPerson.TypeInference.CreateInputNumber_2(__builder3, 93, 94, "1", 95, 
#nullable restore
#line 60 "D:\DNP\DNP-Assignment1\Assignment1\Pages\AddPerson.razor"
                                                   newAdult.Weight

#line default
#line hidden
#nullable disable
                    , 96, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.Weight = __value, newAdult.Weight)), 97, () => newAdult.Weight);
                    __builder3.AddMarkupContent(98, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(99, "\r\n            ");
                    __builder3.OpenElement(100, "div");
                    __builder3.AddAttribute(101, "class", "form-group");
                    __builder3.AddMarkupContent(102, "\r\n                Sex:<br>\r\n                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(103);
                    __builder3.AddAttribute(104, "rows", "1");
                    __builder3.AddAttribute(105, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 64 "D:\DNP\DNP-Assignment1\Assignment1\Pages\AddPerson.razor"
                                                     newAdult.Sex

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(106, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.Sex = __value, newAdult.Sex))));
                    __builder3.AddAttribute(107, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdult.Sex));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(108, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(109, "\r\n            ");
                    __builder3.OpenElement(110, "div");
                    __builder3.AddAttribute(111, "class", "form-group");
                    __builder3.AddMarkupContent(112, "\r\n                Job:<br>\r\n                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(113);
                    __builder3.AddAttribute(114, "rows", "1");
                    __builder3.AddAttribute(115, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 68 "D:\DNP\DNP-Assignment1\Assignment1\Pages\AddPerson.razor"
                                                     newAdult.JobTitle

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(116, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.JobTitle = __value, newAdult.JobTitle))));
                    __builder3.AddAttribute(117, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdult.JobTitle));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(118, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(119, "\r\n            ");
                    __builder3.AddMarkupContent(120, "<p class=\"actions\">\r\n                <button class=\"btn btn-outline-dark\" type=\"submit\">Create</button>\r\n            </p>\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(121, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "D:\DNP\DNP-Assignment1\Assignment1\Pages\AddPerson.razor"
           
        private readonly Adult newAdult = new Adult();

        private void AddNewAdult()
        {
            AdultService.AddAdult(newAdult);
            NavigationManager.NavigateTo("/Persons", true);
        }



    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService AdultService { get; set; }
    }
}
namespace __Blazor.Assignment1.Pages.AddPerson
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "rows", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "rows", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "rows", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
