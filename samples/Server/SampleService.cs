using Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Server
{
    public class SampleService : ISampleService
    {
        public string Ping(string s)
        {
            Console.WriteLine("Exec ping method");
            return s;
        }

        public ComplexModelResponse PingComplexModel(ComplexModelInput inputModel)
        {
            Console.WriteLine("Input data. IntProperty: {0}, StringProperty: {1}", inputModel.IntProperty, inputModel.StringProperty);

            return new ComplexModelResponse
            {
                FloatProperty = float.MaxValue / 2,
                StringProperty = inputModel.StringProperty,
                ListProperty = inputModel.ListProperty,
                DateTimeOffsetProperty = inputModel.DateTimeOffsetProperty
            };
        }

        public List<KeyValuePair<string, object>> VoidMethod()
        {
            var test = new KeyValuePair<string, object>("test", "value");
            var test1 = new KeyValuePair<string, object>("test1", "value1");
            var testList = new List<KeyValuePair<string, object>>()
            {
                test,
                test1
            };
            return testList;
            //return new List<string>
            //{
            //    "test",
            //    "test1"
            //};
        }

        public object Test()
        {
            return "Test123133";
        }

        public Task<int> AsyncMethod()
        {
            return Task.Run(() => 42);
        }

        public KeyValuePair<int, object> NullableMethod(bool? arg)
        {
            var test = new KeyValuePair<int, object>(1, "asdfasda");

            return test;
        }

        public object XmlMethod()
        {
            var test = new KeyValuePair<string, object>("test", "value");
            var test1 = new KeyValuePair<string, object>("test1", "value1");
            return new List<KeyValuePair<string, object>>()
            {
                test,
                test1
            };
        }
    }
}
