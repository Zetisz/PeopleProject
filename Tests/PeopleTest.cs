using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleProject.Tests
{
    [TestFixture]
    internal class PeopleTest
    {
        People people;

        [SetUp]
        public void Setup()
        {
            people = new People();
        }

        [Test]
        public void AtlagEletkor()
        {
            people.UjSzemely(20);
            people.UjSzemely(40);
            Assert.That(people.AtlagEletkor(10, 50), Is.EqualTo(30));
        }

        [Test]
        public void AtlagEletkorUresLista()
        {
            Assert.That(() => people.AtlagEletkor(10, 50), Throws.TypeOf<InvalidOperationException>());
        }

        [Test]
        public void AtlagEletkorErvenytelenSzamokkal()
        {
            people.UjSzemely(20);
            people.UjSzemely(40);
            Assert.That(() => people.AtlagEletkor(-10, -20), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void AtlagEletkorMinEletkorNagyobbMintMax()
        {
            people.UjSzemely(20);
            people.UjSzemely(40);
            Assert.That(() => people.AtlagEletkor(20, 10), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void Kategoria()
        {
            people.UjSzemely(20);
            people.UjSzemely(40);
            Assert.That(people.Kategoria(people.AtlagEletkor(10, 50)), Is.EqualTo("felnott"));
        }
    }
}
