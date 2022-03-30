using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var login = "admin";
            var password = "admin";

            var LoginStatus = Loginclass.Login(login, password);
            Assert.Equals(LoginStatus, false);
        }
    }
}
