// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Globalization;
using Xunit;

namespace System.Globalization.Tests
{
    public class TextInfoToUpper1
    {
        // PosTest1: uppercase character
        [Fact]
        public void TestEnUSUppercaseCharacter()
        {
            char ch = 'A';
            char expectedChar = ch;
            TextInfo textInfo = new CultureInfo("en-US").TextInfo;

            char actualChar = textInfo.ToUpper(ch);
            Assert.Equal(expectedChar, actualChar);
        }

        // PosTest2: lowercase character
        [Fact]
        public void TestEnUSLowercaseCharacter()
        {
            char ch = 'a';
            char expectedChar = 'A';
            TextInfo textInfo = new CultureInfo("en-US").TextInfo;

            char actualChar = textInfo.ToUpper(ch);
            Assert.Equal(expectedChar, actualChar);
        }

        // PosTest3: non-alphabetic character
        [Fact]
        public void TestNonAlphabeticCharacter()
        {
            for (int i = 0; i <= 9; i++)
            {
                char ch = Convert.ToChar(i);
                char expectedChar = ch;
                TextInfo textInfo = new CultureInfo("en-US").TextInfo;

                char actualChar = textInfo.ToUpper(ch);
                Assert.Equal(expectedChar, actualChar);
            }
        }

        // PosTest4: uppercase character and TextInfo is french CultureInfo's
        [Fact]
        public void TestFrFRUpperCaseCharacter()
        {
            char ch = 'G';
            char expectedChar = ch;
            TextInfo textInfo = new CultureInfo("fr-FR").TextInfo;
            char actualChar = textInfo.ToUpper(ch);
            Assert.Equal(expectedChar, actualChar);
        }

        // PosTest5: lowercase character and TextInfo is french(France) CultureInfo's
        [Fact]
        public void TestFrFRLowerCaseCharacter()
        {
            char ch = 'g';
            char expectedChar = 'G';
            TextInfo textInfo = new CultureInfo("fr-FR").TextInfo;

            char actualChar = textInfo.ToUpper(ch);
            Assert.Equal(expectedChar, actualChar);
        }

        // PosTest6: uppercase character for Turkish Culture
        [Fact]
        public void TestTrTRUppercaseCharacter()
        {
            char ch = '\u0130';
            char expectedChar = ch;
            TextInfo textInfo = new CultureInfo("tr-TR").TextInfo;

            char actualChar = textInfo.ToUpper(ch);
            Assert.Equal(expectedChar, actualChar);
        }

        // PosTest7: lowercase character for Turkish Culture
        [Fact]
        public void TestTrTRLowercaseCharacter()
        {
            char ch = 'i';
            char expectedChar = '\u0130';
            TextInfo textInfo = new CultureInfo("tr-TR").TextInfo;

            char actualChar = textInfo.ToUpper(ch);
            Assert.Equal(expectedChar, actualChar);
        }
    }
}

