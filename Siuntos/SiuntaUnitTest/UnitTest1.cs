using System;
using Siuntos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SiuntaUnitTest
{
    [TestClass]
    public class SiuntosDydzioSkaiciukleUnitTest
    {
        [TestMethod]
        public void SiuntosDydzioSkaiciuokle_CheckArGeraiAtpazystaSiuntosDydi_SiusimLSiunta_KainaBus10()
        {
            Siunta testuojamaSiunta = new Siunta("", new FakeTestClass());
            Preke fakePreke = new Preke(1, "", 5);
            testuojamaSiunta.PrekiuSarasas.Add(fakePreke);
            testuojamaSiunta.SiuntosDydzioSkaiciukle();
            Assert.AreEqual(10, testuojamaSiunta.Kaina);
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void SiuntosDydzioSkaiciuokle_Check_Result()
        {
            Siunta testuojamaSiunta = new Siunta("", new FakeExceptionClass());
            Preke fakePreke = new Preke(1, "", 1000000000000);
            testuojamaSiunta.PrekiuSarasas.Add(fakePreke);
            testuojamaSiunta.SiuntosDydzioSkaiciukle();
        }

        public class FakeExceptionClass : ISiuntosTaisykles
        {
            public bool IsSent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public void SiuntosKainosSkaiciuokle(Siunta siunta)
            {
                throw new NotImplementedException();
            }
        }

        public class FakeTestClass : ISiuntosTaisykles
        {
            public bool IsSent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public void SiuntosKainosSkaiciuokle(Siunta siunta)
            {
                if (siunta.SiuntosDydis == "L")
                {
                    siunta.Kaina = 10;
                }
            }
        }
    }
}