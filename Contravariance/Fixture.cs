

using System;
using NUnit.Framework;

namespace GameOfCodes.Contravariance
{
    public interface INotContravariantGenericType<T> { }
    public interface IContravariantGenericType<in T> { }
    public class GenericType<T> : IContravariantGenericType<T>, INotContravariantGenericType<T> { }
    public class BaseType { }
    public class DerivedType : BaseType { }

    public class Fixture
    {
        [Test]
        public void Contravariance_Test()
        {
            var foo = new GenericType<BaseType>();

            //-- contravariance only applies to interfaces
            Assert.That(foo, Is.AssignableTo(typeof(GenericType<BaseType>)));
            Assert.That(foo, Is.Not.AssignableTo(typeof(GenericType<DerivedType>)));

            //-- this should work
            Assert.That(foo, Is.AssignableTo(typeof(IContravariantGenericType<BaseType>)));
            Assert.That(foo, Is.AssignableTo(typeof(IContravariantGenericType<DerivedType>)));
            //-- it's actually an instance of
            Assert.That(foo, Is.InstanceOf(typeof(IContravariantGenericType<DerivedType>)));

            //-- the types are actually related
            Assert.That(typeof(IContravariantGenericType<DerivedType>).IsInstanceOfType(foo), Is.True);
            Assert.That(typeof(IContravariantGenericType<DerivedType>).IsAssignableFrom(typeof(GenericType<BaseType>)), Is.True);

            // this should not work
            Assert.That(foo, Is.AssignableTo(typeof(INotContravariantGenericType<BaseType>)));
            Assert.That(foo, Is.Not.AssignableTo(typeof(INotContravariantGenericType<DerivedType>)));
        }
    }

    public class Tuples {

        [Test]
        public void Tuples_Test()
        {
            (string a, string b) namedLetters = ("a", "b");
            Console.WriteLine(namedLetters);
            Console.WriteLine(namedLetters.a);
            Console.WriteLine(namedLetters.b);
            Assert.Pass();
        }
    }
}