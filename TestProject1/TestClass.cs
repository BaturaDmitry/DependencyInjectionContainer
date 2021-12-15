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
}