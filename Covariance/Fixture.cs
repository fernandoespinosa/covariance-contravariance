

using System;
using NUnit.Framework;

namespace GameOfCodes.Covariance
{
    public interface INotCovariantGenericType<T> { }
    public interface ICovariantGenericType<out T> { }
    public class GenericType<T> : ICovariantGenericType<T>, INotCovariantGenericType<T> { }
    public class BaseType { }
    public class DerivedType : BaseType { }

    public class Fixture
    {
        [Test]
        public void Covariance_Test()
        {
            var foo = new GenericType<DerivedType>();

            Assert.That(foo, Is.Not.AssignableTo(typeof(GenericType<BaseType>)));
            Assert.That(foo, Is.AssignableTo(typeof(GenericType<DerivedType>)));

            Assert.That(foo, Is.AssignableTo(typeof(ICovariantGenericType<BaseType>)));
            Assert.That(foo, Is.AssignableTo(typeof(ICovariantGenericType<DerivedType>)));
            //-- it's actually an instance of
            Assert.That(foo, Is.InstanceOf(typeof(ICovariantGenericType<BaseType>)));

            //-- the types are actually related
            Assert.That(typeof(ICovariantGenericType<BaseType>).IsInstanceOfType(foo), Is.True);
            Assert.That(typeof(ICovariantGenericType<BaseType>).IsAssignableFrom(typeof(GenericType<DerivedType>)), Is.True);

            Assert.That(foo, Is.Not.AssignableTo(typeof(INotCovariantGenericType<BaseType>)));
            Assert.That(foo, Is.AssignableTo(typeof(INotCovariantGenericType<DerivedType>)));
        }
    }

}