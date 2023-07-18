﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace MKPMobileProject.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("AppiumTest")]
    public partial class AppiumTestFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "AppiumTest.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "AppiumTest", null, ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 2
#line hidden
#line 3
 testRunner.Given("El usuario se logea al app", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Boton aplicar descuento y monto")]
        [NUnit.Framework.CategoryAttribute("TC32")]
        public void BotonAplicarDescuentoYMonto()
        {
            string[] tagsOfScenario = new string[] {
                    "TC32"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Boton aplicar descuento y monto", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 6
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 2
this.FeatureBackground();
#line hidden
#line 7
 testRunner.Given("Selecciona opcion parking", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 8
 testRunner.When("Selecciona opcion continuar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 9
 testRunner.When("el usuario selecciona imagen de voucher", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 10
 testRunner.Then("Visualiza opcion Aplicar un descuento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 11
 testRunner.And("Visualiza monto a pagar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Validar boton ver mi historial de pagos")]
        [NUnit.Framework.CategoryAttribute("PRIORITARIOTC1")]
        public void ValidarBotonVerMiHistorialDePagos()
        {
            string[] tagsOfScenario = new string[] {
                    "PRIORITARIOTC1"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validar boton ver mi historial de pagos", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 14
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 2
this.FeatureBackground();
#line hidden
#line 15
 testRunner.Given("Selecciona opcion parking", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 16
 testRunner.Then("Verificar la visualizacion del boton Ver mi historial de pagos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Validar al dar click en boton muestre el historial de pagos")]
        [NUnit.Framework.CategoryAttribute("PRIORITARIOTC2")]
        public void ValidarAlDarClickEnBotonMuestreElHistorialDePagos()
        {
            string[] tagsOfScenario = new string[] {
                    "PRIORITARIOTC2"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validar al dar click en boton muestre el historial de pagos", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 19
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 2
this.FeatureBackground();
#line hidden
#line 20
 testRunner.Given("Selecciona opcion parking", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 21
 testRunner.Then("Verificar la visualizacion del boton Ver mi historial de pagos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 22
 testRunner.Given("Selecciona opcion Ver mi historial de pagos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 23
 testRunner.Then("Visualiza Historial de pagos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Validar paginacion en historial de pagos")]
        [NUnit.Framework.CategoryAttribute("PRIORITARIOTC9")]
        public void ValidarPaginacionEnHistorialDePagos()
        {
            string[] tagsOfScenario = new string[] {
                    "PRIORITARIOTC9"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validar paginacion en historial de pagos", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 26
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 2
this.FeatureBackground();
#line hidden
#line 27
 testRunner.Given("Selecciona opcion parking", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 28
 testRunner.Then("Verificar la visualizacion del boton Ver mi historial de pagos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 29
 testRunner.Given("Selecciona opcion Ver mi historial de pagos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 30
 testRunner.Then("Verificar la paginacion en historial de pagos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Error de servicios al aplicar descuento")]
        [NUnit.Framework.CategoryAttribute("TC17")]
        public void ErrorDeServiciosAlAplicarDescuento()
        {
            string[] tagsOfScenario = new string[] {
                    "TC17"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error de servicios al aplicar descuento", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 33
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 2
this.FeatureBackground();
#line hidden
#line 34
 testRunner.And("Aplicar Codigo de Error \"62\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
 testRunner.Given("Selecciona opcion parking directo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 36
 testRunner.When("Selecciona opcion continuar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 37
 testRunner.When("el usuario selecciona imagen de voucher", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 38
 testRunner.When("Selecciona opcion Aplicar un descuento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 39
 testRunner.And("Selecciona boton Aplicar descuento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
 testRunner.Then("Verificar error de pantalla", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Historial Pago Error de servicio desde mi cuenta")]
        [NUnit.Framework.CategoryAttribute("PRIORITARIOTC12")]
        public void HistorialPagoErrorDeServicioDesdeMiCuenta()
        {
            string[] tagsOfScenario = new string[] {
                    "PRIORITARIOTC12"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Historial Pago Error de servicio desde mi cuenta", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 43
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 2
this.FeatureBackground();
#line hidden
#line 44
 testRunner.And("Aplicar Codigo de Error \"12\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.Given("Selecciona opcion Mi cuenta directo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 46
 testRunner.When("Selecciona Mis pagos de estacionamiento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 47
 testRunner.Then("Visualiza Error en el Historial de pagos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Historial Pago Error de servicio desde parking")]
        [NUnit.Framework.CategoryAttribute("PRIORITARIOTC13")]
        public void HistorialPagoErrorDeServicioDesdeParking()
        {
            string[] tagsOfScenario = new string[] {
                    "PRIORITARIOTC13"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Historial Pago Error de servicio desde parking", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 50
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 2
this.FeatureBackground();
#line hidden
#line 51
 testRunner.And("Aplicar Codigo de Error \"12\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 52
 testRunner.Given("Selecciona opcion parking directo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 53
 testRunner.Given("Selecciona opcion Ver mi historial de pagos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 54
 testRunner.Then("Visualiza Error en el Historial de pagos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Subir imagen incorrecta desde galeria")]
        [NUnit.Framework.CategoryAttribute("TC26")]
        public void SubirImagenIncorrectaDesdeGaleria()
        {
            string[] tagsOfScenario = new string[] {
                    "TC26"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Subir imagen incorrecta desde galeria", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 59
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 2
this.FeatureBackground();
#line hidden
#line 60
 testRunner.Given("Selecciona opcion parking", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 61
 testRunner.When("Selecciona opcion continuar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 62
 testRunner.When("el usuario selecciona imagen Erronea de voucher", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verificar Modal al hacer clic en aplicar descuento")]
        [NUnit.Framework.CategoryAttribute("TC2")]
        public void VerificarModalAlHacerClicEnAplicarDescuento()
        {
            string[] tagsOfScenario = new string[] {
                    "TC2"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verificar Modal al hacer clic en aplicar descuento", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 65
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 2
this.FeatureBackground();
#line hidden
#line 66
 testRunner.Given("Selecciona opcion parking", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 67
 testRunner.When("Selecciona opcion continuar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 68
 testRunner.When("el usuario selecciona imagen de voucher", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 69
 testRunner.When("Selecciona opcion Aplicar un descuento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 70
 testRunner.Then("Verificar modal con imagen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verificar al no seleccionar terminos y condiciones no se activar el boton pagar")]
        [NUnit.Framework.CategoryAttribute("TC38")]
        public void VerificarAlNoSeleccionarTerminosYCondicionesNoSeActivarElBotonPagar()
        {
            string[] tagsOfScenario = new string[] {
                    "TC38"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verificar al no seleccionar terminos y condiciones no se activar el boton pagar", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 73
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 2
this.FeatureBackground();
#line hidden
#line 74
 testRunner.Given("Selecciona opcion parking", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 75
 testRunner.When("Selecciona opcion continuar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 76
 testRunner.When("el usuario selecciona imagen de voucher", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 77
 testRunner.When("Selecciona boton Pagar estacionamiento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 78
 testRunner.Then("Visualiza boton Pagar deshabilitado de estacionamiento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verificar al  seleccionar terminos y condiciones se active el boton pagar")]
        [NUnit.Framework.CategoryAttribute("TC8")]
        public void VerificarAlSeleccionarTerminosYCondicionesSeActiveElBotonPagar()
        {
            string[] tagsOfScenario = new string[] {
                    "TC8"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verificar al  seleccionar terminos y condiciones se active el boton pagar", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 81
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 2
this.FeatureBackground();
#line hidden
#line 82
 testRunner.Given("Selecciona opcion parking", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 83
 testRunner.When("Selecciona opcion continuar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 84
 testRunner.When("el usuario selecciona imagen de voucher", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 85
 testRunner.And("Selecciona boton Pagar estacionamiento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 86
 testRunner.When("Marca checkbox de terminos y condiciones", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 87
 testRunner.Then("Visualiza boton Pagar habilitado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 88
 testRunner.When("Selecciona boton Pagar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Aplicar descuento a voucher y verificar descuento aplicado")]
        [NUnit.Framework.CategoryAttribute("TC5")]
        public void AplicarDescuentoAVoucherYVerificarDescuentoAplicado()
        {
            string[] tagsOfScenario = new string[] {
                    "TC5"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Aplicar descuento a voucher y verificar descuento aplicado", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 92
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 2
this.FeatureBackground();
#line hidden
#line 93
 testRunner.Given("Selecciona opcion parking", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 94
 testRunner.When("Selecciona opcion continuar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 95
 testRunner.When("el usuario selecciona imagen de voucher", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 96
 testRunner.When("Selecciona opcion Aplicar un descuento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 97
 testRunner.And("Selecciona boton Aplicar descuento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 98
 testRunner.Then("Verificar que el descuento se aplique", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Error al Aplicar descuento a voucher")]
        [NUnit.Framework.CategoryAttribute("TC11")]
        public void ErrorAlAplicarDescuentoAVoucher()
        {
            string[] tagsOfScenario = new string[] {
                    "TC11"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error al Aplicar descuento a voucher", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 103
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 2
this.FeatureBackground();
#line hidden
#line 104
 testRunner.Given("Selecciona opcion parking", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 105
 testRunner.When("Selecciona opcion continuar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 106
 testRunner.When("el usuario selecciona imagen de voucher", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 107
 testRunner.When("Selecciona opcion Aplicar un descuento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 108
 testRunner.And("Selecciona boton Aplicar descuento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 109
 testRunner.When("Marca checkbox de terminos y condiciones", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 110
 testRunner.And("Selecciona boton Pagar luego de aplicar descuento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Desde pantalla de \"no se aplico la promocion en aplicar descuento \" muestra modal" +
            " de establecimientos validos")]
        [NUnit.Framework.CategoryAttribute("TC14")]
        public void DesdePantallaDeNoSeAplicoLaPromocionEnAplicarDescuentoMuestraModalDeEstablecimientosValidos()
        {
            string[] tagsOfScenario = new string[] {
                    "TC14"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Desde pantalla de \"no se aplico la promocion en aplicar descuento \" muestra modal" +
                    " de establecimientos validos", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 119
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 2
this.FeatureBackground();
#line hidden
#line 120
 testRunner.Given("Selecciona opcion parking", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 121
 testRunner.When("el usuario selecciona imagen de voucher", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 122
 testRunner.When("Selecciona opcion Aplicar un descuento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 123
 testRunner.And("Selecciona boton Aplicar descuento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 124
 testRunner.Then("Verificar error de pantalla", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Pantalla de monto a pagar muestre mensaje de conoce los establecimientos validos " +
            "aquí y al dar click muestre modal informativo")]
        [NUnit.Framework.CategoryAttribute("TC20")]
        public void PantallaDeMontoAPagarMuestreMensajeDeConoceLosEstablecimientosValidosAquiYAlDarClickMuestreModalInformativo()
        {
            string[] tagsOfScenario = new string[] {
                    "TC20"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Pantalla de monto a pagar muestre mensaje de conoce los establecimientos validos " +
                    "aquí y al dar click muestre modal informativo", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 127
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 2
this.FeatureBackground();
#line hidden
#line 128
 testRunner.Given("Selecciona opcion parking", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 129
 testRunner.When("el usuario selecciona imagen de voucher", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 130
 testRunner.When("Selecciona opcion Aplicar un descuento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 131
 testRunner.And("Selecciona boton Aplicar descuento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 132
 testRunner.Then("Verificar error de pantalla", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verificar un pago realizado con descuento se muestre en el historial de pagos")]
        [NUnit.Framework.CategoryAttribute("TC23")]
        public void VerificarUnPagoRealizadoConDescuentoSeMuestreEnElHistorialDePagos()
        {
            string[] tagsOfScenario = new string[] {
                    "TC23"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verificar un pago realizado con descuento se muestre en el historial de pagos", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 135
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 2
this.FeatureBackground();
#line hidden
#line 136
 testRunner.Given("Selecciona opcion parking", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 137
 testRunner.When("el usuario selecciona imagen de voucher", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 138
 testRunner.When("Selecciona opcion Aplicar un descuento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 139
 testRunner.And("Selecciona boton Aplicar descuento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 140
 testRunner.Then("Verificar error de pantalla", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
