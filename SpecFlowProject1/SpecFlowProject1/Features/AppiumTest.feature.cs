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
namespace SpecFlowMarketplaceMobileProject.Features
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
 testRunner.When("el usuario selecciona imagen de voucher", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 9
 testRunner.Then("Verificar el monto y boton de descuento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
#line 13
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
#line 14
 testRunner.Given("Selecciona opcion parking", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 15
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
#line 18
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
#line 19
 testRunner.Given("Selecciona opcion parking", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 20
 testRunner.When("el usuario selecciona imagen de voucher", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 21
 testRunner.When("Selecciona opcion Aplicar un descuento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 22
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
#line 25
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
#line 26
 testRunner.Given("Selecciona opcion parking", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 27
 testRunner.When("el usuario selecciona imagen de voucher", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 28
 testRunner.When("Selecciona boton Pagar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 29
 testRunner.Then("Visualiza boton Pagar deshabilitado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
#line 32
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
#line 33
 testRunner.Given("Selecciona opcion parking", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 34
 testRunner.When("el usuario selecciona imagen de voucher", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 35
 testRunner.When("Selecciona boton Pagar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 36
 testRunner.When("Marca checkbox de terminos y condiciones", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 37
 testRunner.Then("Visualiza boton Pagar habilitado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
#line 40
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
#line 41
 testRunner.Given("Selecciona opcion parking", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 42
 testRunner.When("el usuario selecciona imagen de voucher", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 43
 testRunner.When("Selecciona opcion Aplicar un descuento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 44
 testRunner.And("Selecciona boton Aplicar descuento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
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
 testRunner.And("Aplicar Codigo de Error \"62\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 52
 testRunner.Given("Selecciona opcion parking", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 53
 testRunner.When("el usuario selecciona imagen de voucher", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 54
 testRunner.When("Selecciona opcion Aplicar un descuento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 55
 testRunner.And("Selecciona boton Aplicar descuento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 56
 testRunner.Then("Verificar error de pantalla", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
 testRunner.When("el usuario selecciona imagen de voucher", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 62
 testRunner.When("Selecciona opcion Aplicar un descuento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 63
 testRunner.And("Selecciona boton Aplicar descuento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 64
 testRunner.Then("Verificar error de pantalla", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Error de servicio al aplicar descuento")]
        [NUnit.Framework.CategoryAttribute("TC17")]
        public void ErrorDeServicioAlAplicarDescuento()
        {
            string[] tagsOfScenario = new string[] {
                    "TC17"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error de servicio al aplicar descuento", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 67
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
#line 68
 testRunner.Given("Selecciona opcion parking", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 69
 testRunner.When("el usuario selecciona imagen de voucher", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 70
 testRunner.When("Selecciona opcion Aplicar un descuento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 71
 testRunner.And("Selecciona boton Aplicar descuento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 72
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
#line 75
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
#line 76
 testRunner.Given("Selecciona opcion parking", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 77
 testRunner.When("el usuario selecciona imagen de voucher", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 78
 testRunner.When("Selecciona opcion Aplicar un descuento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 79
 testRunner.And("Selecciona boton Aplicar descuento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 80
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
#line 83
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
#line 84
 testRunner.Given("Selecciona opcion parking", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 85
 testRunner.When("el usuario selecciona imagen de voucher", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 86
 testRunner.When("Selecciona opcion Aplicar un descuento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 87
 testRunner.And("Selecciona boton Aplicar descuento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 88
 testRunner.Then("Verificar error de pantalla", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
