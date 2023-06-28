﻿using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace SpecFlowMarketplaceMobileProject.PageObjects.Parking
{
    public class ScannerQR
    {
        [FindsBy(How = How.Id, Using = "com.android.permissioncontroller:id/permission_allow_foreground_only_button")]
        private IWebElement botonWhileUseApp;
        
        [FindsBy(How = How.Id, Using = "com.android.permissioncontroller:id/permission_allow_one_time_button")]
        private IWebElement botonOnlyThisTime;
        
        [FindsBy(How = How.Id, Using = "com.android.permissioncontroller:id/permission_deny_button")]
        private IWebElement botonDontAllow;
        
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup")]
        private IWebElement botonQR;
        
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.widget.TextView[1]")]
        private IWebElement botonQRGaleria;

        [FindsBy(How = How.XPath, Using = "//android.widget.ImageButton[@content-desc=\"Show roots\"]")]
        private IWebElement botonBuscarRuta;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.drawerlayout.widget.DrawerLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.ListView/android.widget.LinearLayout[2]/android.widget.LinearLayout/android.widget.TextView")]
        private IWebElement botonSeleccionarRuta;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.drawerlayout.widget.DrawerLayout/android.widget.ScrollView/android.widget.FrameLayout/android.widget.FrameLayout[2]/android.widget.LinearLayout/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.widget.LinearLayout[1]/android.widget.LinearLayout/android.widget.LinearLayout")]
        private IWebElement imagenQR_999_19;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.drawerlayout.widget.DrawerLayout/android.widget.ScrollView/android.widget.FrameLayout/android.widget.FrameLayout[2]/android.widget.LinearLayout/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.widget.LinearLayout[2]/android.widget.LinearLayout/android.widget.LinearLayout")]
        private IWebElement imagenQR_999_20;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.drawerlayout.widget.DrawerLayout/android.widget.ScrollView/android.widget.FrameLayout/android.widget.FrameLayout[2]/android.widget.LinearLayout/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.widget.LinearLayout[3]/android.widget.LinearLayout/android.widget.LinearLayout")]
        private IWebElement imagenQR_999_21;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.drawerlayout.widget.DrawerLayout/android.widget.ScrollView/android.widget.FrameLayout/android.widget.FrameLayout[2]/android.widget.LinearLayout/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.widget.LinearLayout[4]/android.widget.LinearLayout/android.widget.LinearLayout")]
        private IWebElement imagenQR_999_22;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.drawerlayout.widget.DrawerLayout/android.widget.ScrollView/android.widget.FrameLayout/android.widget.FrameLayout[2]/android.widget.LinearLayout/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.widget.LinearLayout[5]/android.widget.LinearLayout/android.widget.LinearLayout")]
        private IWebElement imagenQR_999_23;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.drawerlayout.widget.DrawerLayout/android.widget.ScrollView/android.widget.FrameLayout/android.widget.FrameLayout[2]/android.widget.LinearLayout/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.widget.LinearLayout[6]/android.widget.LinearLayout/android.widget.LinearLayout")]
        private IWebElement imagenQR_999_24;

        public AndroidDriver<AppiumWebElement> Driver;
        private readonly WebDriverWait _wait;

        public ScannerQR(AndroidDriver<AppiumWebElement> driver)
        {
            Driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            PageFactory.InitElements(driver, this);
        }
        public void ClickWhileUseAppntinuar()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(botonWhileUseApp));
            botonWhileUseApp.Click();
        }
        public void ClickOnlyThisTime()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(botonOnlyThisTime));
            botonOnlyThisTime.Click();
        }
        public void ClickDontAllow()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(botonDontAllow));
            botonOnlyThisTime.Click();
        }

        public void ClickQR()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(botonQR)); 
            botonQR.Click();
        }
        public void ClickbotonQRGaleria()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(botonQRGaleria));
            botonQRGaleria.Click();
        }
        public void ClickBuscarRuta()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(botonBuscarRuta));
            botonBuscarRuta.Click();
        }
        public void ClickRutaDownloand()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(botonSeleccionarRuta));
            botonSeleccionarRuta.Click();
        }
        public void ClickImagenQR_999_19()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(imagenQR_999_19));
            imagenQR_999_19.Click();
        }
        public void ClickImagenQR_999_20()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(imagenQR_999_20));
            imagenQR_999_20.Click();
        }
        public void ClickImagenQR_999_21()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(imagenQR_999_21));
            imagenQR_999_21.Click();
        }
        public void ClickImagenQR_999_22()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(imagenQR_999_22));
            imagenQR_999_22.Click();
        }
        public void ClickImagenQR_999_23()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(imagenQR_999_23));
            imagenQR_999_23.Click();
        }
        public void ClickImagenQR_999_24()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(imagenQR_999_24));
            imagenQR_999_24.Click();
        }

    }
}