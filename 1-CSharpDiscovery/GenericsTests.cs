namespace CSharpDiscovery
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using NFluent;
    using NUnit.Framework;

    [TestFixture]
    public class GenericsTests
    {
        //[Test]
        //public void UseGenericList()
        //{
        //    var sampleObject = new SampleObject();
        //    var anotherSampleObject = new AnotherSampleObject();
        //    // use ArrayList (non-generic basic collection) and add the two objects
            
        //    // Have a look at the type of IsEqualTo type (should be object)
        //    Check.That(list.ToArray()[0]).IsEqualTo(sampleObject);
        //    var derivedSampleObject = new DerivedSampleObject();
        //    // use List<SampleObject> (generic basic collection) and add the two previous objects (compiler should complains about the second one not being a SampleObject) and the derivedSampleObject (this one is SampleObject by inheritance)

        //    // Have a look at the type of IsEqualTo type (should be object)
        //    Check.That(genericList.ElementAt(0)).IsEqualTo(sampleObject);
        //    // Have a look at interfaces of these collection classes : IList, ICollection, IEnumerable and the same with generic definition : IList<T>, ICollection<T>, IEnumerable<T>
        //}

        //[Test]
        //public void UseGenericDictionary()
        //{
        //    var sampleObject = new SampleObject();
        //    var derivedSampleObject = new DerivedSampleObject();
        //    // use Dictionary<int, SampleObject> and add the two object (Add method), then get (with indexer : dictionary[index])
            
        //    Check.That(elementIndexedWith1).Equals(sampleObject);
        //    Check.That(elementIndexedWith23).Equals(derivedSampleObject);
            
        //    // use TryGetValue to get a index that does not exist
            
        //    Check.That(valueFound).IsFalse();
        //}

        //[Test]
        //public void DefineACustomGenericCollection()
        //{
        //    var sampleObject = new SampleObject();
        //    var customGenericCollection = new GenericCollection<SampleObject>();
        //    customGenericCollection.Add(sampleObject);
        //    Check.That(customGenericCollection.ElementAt(0)).IsEqualTo(sampleObject);
        //    var anotherSampleObject = new AnotherSampleObject();
        //    var customGenericCollection2 = new GenericCollection<AnotherSampleObject>();
        //    customGenericCollection2.Add(anotherSampleObject);
        //    Check.That(customGenericCollection2.ElementAt(0)).IsEqualTo(anotherSampleObject);
        //}

        //[Test]
        //public void DefineAnEventPublisherRegisteringSomeInterfaceIHandlesImplementationToHandleEvents()
        //{
        //    var someEvent = new SomethingHappened();
        //    var anotherEvent = new AnotherThingHappened();
        //    var eventHandler = new ThingsHappenedHandler();
        //    var eventPublisher = new EventPublisher();
        //    eventPublisher.Register<SomethingHappened>(eventHandler);
        //    eventPublisher.Register<AnotherThingHappened>(eventHandler);
        //    eventPublisher.Publish(someEvent);
        //    eventPublisher.Publish(anotherEvent);
        //    Check.That(eventHandler.HandledEvents).ContainsExactly<object>(someEvent, anotherEvent);
        //    // Add a type constraint on T generic parameter to allow only IDomainEvent interface implementation
        //}
    }
}
