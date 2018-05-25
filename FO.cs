﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FactFinder
{
    class FO
    {


        IWebDriver driver;


        [SetUp]
        public void startBrowser()
        {




            var browser = System.Configuration.ConfigurationManager.AppSettings["Browser"];
            var Path = System.Configuration.ConfigurationManager.AppSettings["Path"];

            switch (browser)
            {
                case "IE":


                    driver = new InternetExplorerDriver(Path);
                    break;

                case "FF":

                    driver = new FirefoxDriver(Path);
                    break;


                case "CR":


                    driver = new ChromeDriver(Path);
                    break;
            }



            var url = System.Configuration.ConfigurationManager.AppSettings["url"];
            Console.WriteLine(string.Format("URL is : ", url));
            driver.Navigate().GoToUrl(url);






            IWebElement element = driver.FindElement(By.XPath(".//*[@id='ctl00_memberslogin_Login1_UserName']"));




            string Str1 = System.Configuration.ConfigurationManager.AppSettings["Usename"];
            driver.FindElement(By.XPath("//*[@id='ctl00_memberslogin_Login1_UserName']")).Clear();
            driver.FindElement(By.XPath("//*[@id='ctl00_memberslogin_Login1_UserName']")).SendKeys(Str1);



            string Str2 = System.Configuration.ConfigurationManager.AppSettings["Password"];
            driver.FindElement(By.XPath("//*[@id='ctl00_memberslogin_Login1_Password']")).Clear();
            driver.FindElement(By.XPath("//*[@id='ctl00_memberslogin_Login1_Password']")).SendKeys(Str2);


            //  wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[contains(@id, 'Name')]")));




            Thread.Sleep(1000);
            IWebElement element2 = driver.FindElement(By.XPath(".//*[@id='ctl00_memberslogin_Login1_LoginButton']"));
            element2.Click();
            //  driver.Navigate().GoToUrl("stellar11/User/dashboard.aspx");





            String A = driver.FindElement(By.XPath("//*[@id='ctl00_rwAgreement_C']/div")).Text;
            Console.WriteLine(A);

            if (!String.IsNullOrEmpty(A))
            {
                driver.FindElement(By.XPath(" //*[@id='ctl00_rwAgreement_C_btnAgree']")).Click();
            }




        }
        // }
        [Test]
        public void FO_Fields__Mandatory()
        {
            // IWebDriver driver;
            Thread.Sleep(2000);

            driver.Manage().Window.Maximize();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            // Thread.Sleep(1000);


            //  driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_AdminLink']")).Click();
            driver.FindElement(By.XPath(".//*[@id='aspnetForm']/section[2]/section[1]/nav")).Click();
            Console.WriteLine("Black Ribbon");
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//a[contains(@title, 'Search client')]")).Click();

            //  wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(@title, 'Management')]")));
            Console.WriteLine("Search client");

            Thread.Sleep(1000);

            Console.WriteLine("Clicked Search");



            //  driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_HyperLinkAdminPlanners']")).Click();
            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_btnSearch']")).Click();
            Console.WriteLine("sEARCH");

            Thread.Sleep(1000);

            IWebElement element = driver.FindElement(By.Id("ctl00_ctl00_cph1_cph1_ClientName"));


            var C_USERNAME = System.Configuration.ConfigurationManager.AppSettings["C_USERNAME"];


            Console.WriteLine(string.Format("Given Name is : ", C_USERNAME));
            element.SendKeys(C_USERNAME);

            //  driver.FindElement(By.Id("ctl00_ctl00_cph1_cph1_ClientName")).SendKeys("Jeff1");

            Console.WriteLine("Enter Search");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_btnSearch']")).Click();

            Console.WriteLine("Click on Search button");


            for (int i = 0; i <= 20; i++)
            {


                //    String ss = driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_rgManageAR_ctl00__" + i + "']/td[2]")).Text;
                String gn = driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_rgUsers_ctl00__" + i + "']/td[4]")).Text;




                string s = System.Configuration.ConfigurationManager.AppSettings["C_USERNAME"];
                if (!String.IsNullOrEmpty(s))
                {

                    Console.WriteLine("C_Given Name is:" + gn);
                    String sn = driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_rgUsers_ctl00__" + i + "']/td[5]")).Text;


                    string s1 = System.Configuration.ConfigurationManager.AppSettings["C_GIVEN NAME"];
                    if (!String.IsNullOrEmpty(s1))

                    {

                        Console.WriteLine("Given Name is:" + sn);


                        Console.WriteLine("Into Loop i is +" + i);


                        var im1 = driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_rgUsers_ctl00__" + i + "']/td[7]"));


                        Console.WriteLine("i value chk is +" + i);

                        im1.Click();

                        break;
                    }
                }
            }

            Thread.Sleep(1000);



            driver.FindElement(By.XPath("//*[@id='hlFacts']")).Click();




            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_CfactsExpressControl_hlFinancialObjectives']")).Click();


            //    Thread.Sleep(2000);
            string S268 = System.Configuration.ConfigurationManager.AppSettings["C_FO_Type"];
            SelectElement oSelection268 = new SelectElement(driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_CfactsExpressControl_FinancialObjectivesControl_ClientFinancialObjectiveRow_0_ddlFinancialObjectiveType']")));
            oSelection268.SelectByText(S268);
                                                                                         //*[@id="ctl00_ctl00_cph1_cph1_CfactsExpressControl_FinancialObjectivesControl_PartnerFinancialObjectiveRow_0_ddlFinancialObjectiveType"]
            string S269 = System.Configuration.ConfigurationManager.AppSettings["C_FO_Prio"];
            SelectElement oSelection269 = new SelectElement(driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_CfactsExpressControl_FinancialObjectivesControl_ClientFinancialObjectiveRow_0_ddlPriorityType']")));
            oSelection269.SelectByText(S269);



            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_CfactsExpressControl_FinancialObjectivesControl_ClientFinancialObjectiveRow_0_txtShortTerm']")).Clear();

   //         driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_CfactsExpressControl_FinancialObjectivesControl_ClientFinancialObjectiveRow_0_txtShortTerm']")).SendKeys("Test Immediate");

            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_CfactsExpressControl_FinancialObjectivesControl_ClientFinancialObjectiveRow_0_txtMediumTerm']")).Clear();

     //       driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_CfactsExpressControl_FinancialObjectivesControl_ClientFinancialObjectiveRow_0_txtMediumTerm']")).SendKeys("Test Medium-Long Term ");

            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_CfactsExpressControl_FinancialObjectivesControl_ClientFinancialObjectiveRow_0_txtLongTerm']")).Clear();

            //       driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_CfactsExpressControl_FinancialObjectivesControl_ClientFinancialObjectiveRow_0_txtLongTerm']")).SendKeys("Test Ongoing ");


            /*        driver.FindElement(By.XPath("//*[@id='aspnetForm']/section[2]/section[2]/section[1]/section/section/section/section[1]/div[3]/div[3]/div[1]/div[3]/div[2]/ul/li[2]/a")).Click();*/
            //*[@id="aspnetForm"]/section[2]/section[2]/section[1]/section/section/section/section[1]/div[3]/div[3]/div[2]/div/div[1]/a
            //*[@id="aspnetForm"]/section[2]/section[2]/section[1]/section/section/section/section[1]/div[3]/div[3]/div[1]/div[3]/div[2]/ul/li[2]/a
            //      String add = driver.FindElement(By.XPath("//*[@id='ctl00_trfinancialobjectiverow']")).Text;
            //      Console.WriteLine("Add FO is available or not" + add);
            //      if(add!="Add Financial Objective")
            driver.FindElement(By.XPath("//*[@id='aspnetForm']/section[2]/section[2]/section[1]/section/section/section/section[1]/div[3]/div[3]/div[1]/div[3]/div[2]/ul/li[2]/a")).Click();
          //  driver.FindElement(By.XPath("//*[@id='aspnetForm']/section[2]/section[2]/section[1]/section/section/section/section[1]/div[3]/div[3]/div[1]/div[3]/div[2]/div/div[2]/div/a")).Click();
            //*[@id="aspnetForm"]/section[2]/section[2]/section[1]/section/section/section/section[1]/div[3]/div[3]/div[1]/div[3]/div[2]/div
            //*[@id="aspnetForm"]/section[2]/section[2]/section[1]/section/section/section/section[1]/div[3]/div[3]/div[1]/div[3]/div[2]/div/div[2]/div
            string S270 = System.Configuration.ConfigurationManager.AppSettings["P_FO_Type"];
            SelectElement oSelection270 = new SelectElement(driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_CfactsExpressControl_FinancialObjectivesControl_PartnerFinancialObjectiveRow_0_ddlFinancialObjectiveType']")));
            oSelection270.SelectByText(S270);


           string S2700 = System.Configuration.ConfigurationManager.AppSettings["P_FO_Prio"];
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_CfactsExpressControl_FinancialObjectivesControl_PartnerFinancialObjectiveRow_0_trfinancialobjectiverow']/div[1]")));
            //*[@id="ctl00_ctl00_cph1_cph1_CfactsExpressControl_FinancialObjectivesControl_PartnerFinancialObjectiveRow_0_ddlPriorityType"]
            //SelectElement oSelection2711 = new SelectElement(driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_CfactsExpressControl_FinancialObjectivesControl_PartnerFinancialObjectiveRow_0_ddlFinancialPriorityType']]")));
            SelectElement oSelection2700 = new SelectElement(driver.FindElement(By.XPath(".//*[@id='ctl00_ctl00_cph1_cph1_CfactsExpressControl_FinancialObjectivesControl_PartnerFinancialObjectiveRow_0_ddlPriorityType']")));
            oSelection2700.SelectByText(S2700);
            //*[@id="ctl00_ctl00_cph1_cph1_CfactsExpressControl_FinancialObjectivesControl_ClientFinancialObjectiveRow_0_ddlPriorityType"]
            //*[@id="ctl00_ddlPriorityType"]
            //*[@id="ctl00_ctl00_cph1_cph1_CfactsExpressControl_FinancialObjectivesControl_PartnerFinancialObjectiveRow_0_ddlPriorityType"]
            //*[@id="ctl00_ctl00_cph1_cph1_CfactsExpressControl_FinancialObjectivesControl_PartnerFinancialObjectiveRow_0_ddlFinancialObjectiveType"]

            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_CfactsExpressControl_FinancialObjectivesControl_PartnerFinancialObjectiveRow_0_txtShortTerm']")).Clear();


        //    driver.FindElement(By.XPath("//*[@id='ctl00_txtShortTerm']")).SendKeys("Partner Immediate");

            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_CfactsExpressControl_FinancialObjectivesControl_PartnerFinancialObjectiveRow_0_txtMediumTerm']")).Clear();

       //     driver.FindElement(By.XPath("//*[@id='ctl00_txtMediumTerm']")).SendKeys("Partner Medium-Long Term ");

            driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_cph1_cph1_CfactsExpressControl_FinancialObjectivesControl_PartnerFinancialObjectiveRow_0_txtLongTerm']")).Clear();

       //     driver.FindElement(By.XPath("//*[@id='ctl00_txtLongTerm']")).SendKeys("Partner Ongoing ");



            Console.WriteLine("Add FO is available OK");
            driver.FindElement(By.XPath("//*[@id='aspnetForm']/section[2]/section[2]/section[1]/section/section/section/section[1]/div[3]/div[3]/div[2]/div/div[1]/a")).Click();



        }
    }

}



//  }
// }

