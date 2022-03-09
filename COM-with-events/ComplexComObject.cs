﻿namespace COM_obj_with_events
{
    using System;
    using System.Runtime.InteropServices;

    [ComVisible(true)]
    [Guid(AssemblyInfo.ComObjClassGuid)]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("ComplexComObject")]
    public class ComplexComObject : IComplexComObject
    {
        public IResult Addition(double firstValue, double secondValue)
        {
            return new Result(firstValue + secondValue);
        }

        public string HelloWorld()
        {
            return "Hello World!";
        }
    }
}