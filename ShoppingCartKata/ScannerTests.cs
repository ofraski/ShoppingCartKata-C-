﻿using System.ComponentModel.Design;
using NUnit.Framework;

namespace ShoppingCartKata
{
    [TestFixture]
    public class ScannerTests
    {
        [TestCase("apple", 1)]
        [TestCase("apple,orange", 2)]
        public void AcceptsItems(string items, int expectedCount)
        {
            var scanner = new Scanner();
            var scannedItems = scanner.Scan(items);
            Assert.That(scannedItems.Length, Is.EqualTo(expectedCount));
        }
    }
}
