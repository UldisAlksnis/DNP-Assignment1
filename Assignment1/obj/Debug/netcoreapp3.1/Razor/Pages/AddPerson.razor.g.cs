#pragma checksum "C:\Users\Sam2\Rider Projects\DNP-Assignment1\Assignment1\Pages\AddPerson.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bd471021aee11e162177e457d06f04b6cea4bcb"
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
#line 1 "C:\Users\Sam2\Rider Projects\DNP-Assignment1\Assignment1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sam2\Rider Projects\DNP-Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Sam2\Rider Projects\DNP-Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Sam2\Rider Projects\DNP-Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Sam2\Rider Projects\DNP-Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Sam2\Rider Projects\DNP-Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Sam2\Rider Projects\DNP-Assignment1\Assignment1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Sam2\Rider Projects\DNP-Assignment1\Assignment1\_Imports.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Sam2\Rider Projects\DNP-Assignment1\Assignment1\_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sam2\Rider Projects\DNP-Assignment1\Assignment1\Pages\AddPerson.razor"
using Assignment1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Sam2\Rider Projects\DNP-Assignment1\Assignment1\Pages\AddPerson.razor"
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
            __builder.AddMarkupContent(0, "<h3>AddPerson</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\Sam2\Rider Projects\DNP-Assignment1\Assignment1\Pages\AddPerson.razor"
                  newPerson

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\Sam2\Rider Projects\DNP-Assignment1\Assignment1\Pages\AddPerson.razor"
                                             AddNewPerson

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n   \r\n    ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group");
                __builder2.AddMarkupContent(12, "\r\n       First Name:<br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(13);
                __builder2.AddAttribute(14, "rows", "1");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\Sam2\Rider Projects\DNP-Assignment1\Assignment1\Pages\AddPerson.razor"
                                             newPerson.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.FirstName = __value, newPerson.FirstName))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newPerson.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n    ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group");
                __builder2.AddMarkupContent(22, "\r\n        Last Name:<br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(23);
                __builder2.AddAttribute(24, "rows", "1");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\Sam2\Rider Projects\DNP-Assignment1\Assignment1\Pages\AddPerson.razor"
                                             newPerson.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.LastName = __value, newPerson.LastName))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newPerson.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n    ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-group");
                __builder2.AddMarkupContent(32, "\r\n        Hair Color:<br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(33);
                __builder2.AddAttribute(34, "rows", "1");
                __builder2.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\Sam2\Rider Projects\DNP-Assignment1\Assignment1\Pages\AddPerson.razor"
                                             newPerson.HairColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.HairColor = __value, newPerson.HairColor))));
                __builder2.AddAttribute(37, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newPerson.HairColor));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n    ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group");
                __builder2.AddMarkupContent(42, "\r\n        Eye Color:<br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(43);
                __builder2.AddAttribute(44, "rows", "1");
                __builder2.AddAttribute(45, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\Sam2\Rider Projects\DNP-Assignment1\Assignment1\Pages\AddPerson.razor"
                                             newPerson.EyeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.EyeColor = __value, newPerson.EyeColor))));
                __builder2.AddAttribute(47, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newPerson.EyeColor));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n    ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "form-group");
                __builder2.AddMarkupContent(52, "\r\n        Age:<br>\r\n        ");
                __Blazor.Assignment1.Pages.AddPerson.TypeInference.CreateInputNumber_0(__builder2, 53, 54, "1", 55, 
#nullable restore
#line 29 "C:\Users\Sam2\Rider Projects\DNP-Assignment1\Assignment1\Pages\AddPerson.razor"
                                           newPerson.Age

#line default
#line hidden
#nullable disable
                , 56, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.Age = __value, newPerson.Age)), 57, () => newPerson.Age);
                __builder2.AddMarkupContent(58, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n    ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "form-group");
                __builder2.AddMarkupContent(62, "\r\n        Height:<br>\r\n        ");
                __Blazor.Assignment1.Pages.AddPerson.TypeInference.CreateInputNumber_1(__builder2, 63, 64, "1", 65, 
#nullable restore
#line 33 "C:\Users\Sam2\Rider Projects\DNP-Assignment1\Assignment1\Pages\AddPerson.razor"
                                           newPerson.Height

#line default
#line hidden
#nullable disable
                , 66, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.Height = __value, newPerson.Height)), 67, () => newPerson.Height);
                __builder2.AddMarkupContent(68, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n    ");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "form-group");
                __builder2.AddMarkupContent(72, "\r\n        Weight:<br>\r\n        ");
                __Blazor.Assignment1.Pages.AddPerson.TypeInference.CreateInputNumber_2(__builder2, 73, 74, "1", 75, 
#nullable restore
#line 37 "C:\Users\Sam2\Rider Projects\DNP-Assignment1\Assignment1\Pages\AddPerson.razor"
                                           newPerson.Weight

#line default
#line hidden
#nullable disable
                , 76, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.Weight = __value, newPerson.Weight)), 77, () => newPerson.Weight);
                __builder2.AddMarkupContent(78, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n     ");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "form-group");
                __builder2.AddMarkupContent(82, "\r\n                                    Sex:<br>\r\n                                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(83);
                __builder2.AddAttribute(84, "rows", "1");
                __builder2.AddAttribute(85, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "C:\Users\Sam2\Rider Projects\DNP-Assignment1\Assignment1\Pages\AddPerson.razor"
                                                                         newPerson.Sex

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(86, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.Sex = __value, newPerson.Sex))));
                __builder2.AddAttribute(87, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newPerson.Sex));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(88, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n    ");
                __builder2.AddMarkupContent(90, "<p class=\"actions\">\r\n        <button class=\"btn btn-outline-dark\" type=\"submit\">Create</button>\r\n    </p>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\Sam2\Rider Projects\DNP-Assignment1\Assignment1\Pages\AddPerson.razor"
       
    private readonly Person newPerson = new Person();

    private void AddNewPerson()
    {
        PersonService.AddPerson(newPerson);
        NavigationManager.NavigateTo("/Persons",true);
    }

   


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPersonService PersonService { get; set; }
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