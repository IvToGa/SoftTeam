#pragma checksum "C:\Users\Admin\Documents\UCaldas\Ciclo 3\DS-C3-26\Desarrollos\Veterinaria.App\Veterinaria.App.Presentacion\Pages\RegistroMascotas\RegistroMascotas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a2db788d2bc49b594fa85316b99c6a6347a7581"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Veterinaria.App.Presentacion.Pages.RegistroMascotas.Pages_RegistroMascotas_RegistroMascotas), @"mvc.1.0.razor-page", @"/Pages/RegistroMascotas/RegistroMascotas.cshtml")]
namespace Veterinaria.App.Presentacion.Pages.RegistroMascotas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Admin\Documents\UCaldas\Ciclo 3\DS-C3-26\Desarrollos\Veterinaria.App\Veterinaria.App.Presentacion\Pages\_ViewImports.cshtml"
using Veterinaria.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a2db788d2bc49b594fa85316b99c6a6347a7581", @"/Pages/RegistroMascotas/RegistroMascotas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e0b5ca209e941241f3a7d6f6fefe42ca98442af", @"/Pages/_ViewImports.cshtml")]
    public class Pages_RegistroMascotas_RegistroMascotas : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1>
    <figure class=""text-center"">
        Ahora puedes registrar tu mascota
    </figure>
</h1>

<div id=""accordion"">
    <div class=""card"">
        <div class=""card-header"" id=""headingOne"">
            <h5 class=""mb-0"">
                <button class=""btn btn-link"" data-toggle=""collapse"" data-target=""#collapseOne"" aria-expanded=""true""
                    aria-controls=""collapseOne"">
                    Datos de la mascota
                </button>
            </h5>
        </div>

        <div id=""collapseOne"" class=""collapse show"" aria-labelledby=""headingOne"" data-parent=""#accordion"">
            <div class=""card-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a2db788d2bc49b594fa85316b99c6a6347a75814042", async() => {
                WriteLiteral(@"
                    <div class=""form-group row"">
                        <label for=""Nombre"" class=""col-sm-2 col-form-label"">Nombre</label>
                        <div class=""col-sm-10"">
                            <input type=""text"" class=""form-control"" placeholder=""Nombre"">
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <label for=""FechaDeNacimiento"" class=""col-sm-2 col-form-label"">Fecha de Nacimiento</label>
                        <div class=""col-sm-10"">
                            <input type=""date"" class=""form-control"" placeholder=""dd/mm/aaaa"">
                        </div>
                    </div>

                    <div class=""form-group row"">
                        <label for=""inputEmail3"" class=""col-sm-2 col-form-label"">Edad</label>
                        <div class=""col-sm-10"">
                            <input type=""text"" class=""form-control"" placeholder=""Edad"">
                        <");
                WriteLiteral(@"/div>

                    </div>
                    <fieldset class=""form-group"">
                        <div class=""row"">
                            <legend class=""col-form-label col-sm-2 pt-0"">Tipo</legend>
                            <div class=""col-sm-10"">
                                <div class=""form-check"">
                                    <input class=""form-check-input"" type=""radio"" name=""gridRadios"" id=""gridRadios1""
                                        value=""option1"" checked>
                                    <label class=""form-check-label"" for=""gridRadios1"">
                                        Gato
                                    </label>
                                </div>
                                <div class=""form-check"">
                                    <input class=""form-check-input"" type=""radio"" name=""gridRadios"" id=""gridRadios2""
                                        value=""option2"">
                                    <label class=""form-che");
                WriteLiteral(@"ck-label"" for=""gridRadios2"">
                                        Perro
                                    </label>
                                </div>
                                <div class=""form-check"">
                                    <input class=""form-check-input"" type=""radio"" name=""gridRadios"" id=""gridRadios2""
                                        value=""option2"">
                                    <label class=""form-check-label"" for=""gridRadios2"">
                                        Otro
                                        <label>
                                            <div class=""form-group row"">
                                                <div class=""col-sm-10"">
                                                    <input type=""text"" class=""form-control""
                                                        placeholder=""Digite tipo y/o raza"">
                                                </div>
                                            </div>
    ");
                WriteLiteral(@"                            </div>
                    </fieldset>
                    <div class=""form-group row"">
                        <div class=""col-sm-2"">Acepta terminos y condiciones</div>
                        <div class=""col-sm-10"">
                            <div class=""form-check"">
                                <input class=""form-check-input"" type=""checkbox"" id=""gridCheck1"">
                                <label class=""form-check-label"" for=""gridCheck1"">
                                    Si acepto
                                </label>
                            </div>

                            <div class=""form-check"">
                                <input class=""form-check-input"" type=""checkbox"" id=""gridCheck1"">
                                <label class=""form-check-label"" for=""gridCheck1"">
                                    No acepto
                                </label>
                            </div>

                        </div>
                 ");
                WriteLiteral(@"   </div>
                    <div class=""form-group row"">
                        <div class=""col-sm-10"">
                            <button type=""submit"" class=""btn btn-primary"">Agregar</button>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

            </div>
        </div>
        <div class=""card"">
            <div class=""card-header"" id=""headingTwo"">
                <h5 class=""mb-0"">
                    <button class=""btn btn-link collapsed"" data-toggle=""collapse"" data-target=""#collapseTwo""
                        aria-expanded=""false"" aria-controls=""collapseTwo"">
                        Historia Clinca
                    </button>
                </h5>
            </div>
            <div id=""collapseTwo"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordion"">
                <div class=""card-body"">
                    Aui otro formulario
                </div>
            </div>
        </div>
    </div>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Veterinaria.App.Pages.RegistroMascotasModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Veterinaria.App.Pages.RegistroMascotasModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Veterinaria.App.Pages.RegistroMascotasModel>)PageContext?.ViewData;
        public Veterinaria.App.Pages.RegistroMascotasModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
