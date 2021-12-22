namespace TestProject1
{
    interface ISomeInterface
            {
                void Firstmethod();

                void Secondmethod();
            }
        
            class Class : ISomeInterface
            {
        
                public void Firstmethod()
                {
                    throw new System.NotImplementedException();
                }
        
                public void Secondmethod()
                {
                    throw new System.NotImplementedException();
                }
            }
        
            interface ITestClass
            {
                void Firstmth();
        
                void Secondmth();
            }
        
            class TestClass : ITestClass
            {
                public ISomeInterface isomeInterface;
        
                public TestClass(ISomeInterface isomeInterface)
                {
                    this.isomeInterface = isomeInterface;
                }
        
                public void Firstmth()
                {
                    throw new System.NotImplementedException();
                }
        
                public void Secondmth()
                {
                    throw new System.NotImplementedException();
                }
            }
        
            class TestClass2 : ITestClass
            {
                public ISomeInterface isomeInterface;
        
                public TestClass2(ISomeInterface isomeInterface)
                {
                    this.isomeInterface = isomeInterface;
                }
        
                public void Firstmth()
                {
                    throw new System.NotImplementedException();
                }
        
                public void Secondmth()
                {
                    throw new System.NotImplementedException();
                }
            }
        
            class Class2 : ISomeInterface
            {
                public void Firstmethod()
                {
                    throw new System.NotImplementedException();
                }
        
                public void Secondmethod()
                {
                    throw new System.NotImplementedException();
                }
            }

            public interface IA
            {
        
            }
            public interface IB
            {
        
            }
            public  class ClassA : IA
            {
                public IB ib;
                public ClassA(IB ib)
                {
                    this.ib = ib;
                }
            }
           public class ClassB : IB
            {
                public IA ia;
                public ClassB(IA ia)
                {
                    this.ia = ia;
                }
            }
           public class ClassWithA : IA
           {
               public IA ia;
               public ClassWithA(IA ia)
               {
                   this.ia = ia;
               }
           }
            
}