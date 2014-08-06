using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace SD.CLR.ArrayTestProject
{
    [TestClass]
    public class CollectionAddTest
    {
        private const int n = 200000;

        [TestMethod]
        public void ArrayTest()
        {
            string[] list = new string [n];
            for (int i = 0; i < n; i++)
            {
                list[i] = "C";
            }
        }

        [TestMethod]
        public void ArrayListTest()
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < n; i++)
            {
                list.Add("B");
            }
        }

        [TestMethod]
        public void GenericListTest()
        {
            List<string> list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                list.Add("A");
            }
        }
    }
}
