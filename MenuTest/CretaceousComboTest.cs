/*  CretaceousComboTest.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest
{
    /// <summary>
    /// The tests for the Cretaceous Combo class.
    /// </summary>
    public class CretaceousComboTest
    {

        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            Brontowurst bw = new Brontowurst();
            CretaceousCombo cc = new CretaceousCombo(bw);
            Assert.Equal((bw.ToString() + " Combo"), cc.Description);
        }
    }
}
