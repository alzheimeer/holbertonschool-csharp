using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Globalization;
using System.Text;

/// <summary>class</summary>
class Obj
{
    ///<summary>prints the names of the available properties and methods of an object</summary>
    /// <returns> not </returns>
    public static void Print(object myObj)
    {
        Type tt = myObj.GetType();
        TypeInfo t = tt.GetTypeInfo();
        IEnumerable<PropertyInfo> pList = t.GetProperties();
        IEnumerable<MethodInfo> mList = t.GetMethods();

        //IEnumerable<PropertyInfo> pList = t.DeclaredProperties;
        //IEnumerable<MethodInfo> mList = t.DeclaredMethods;
        
        //PropertyInfo[] pList = t.GetProperties();
        //MethodInfo[] mList = t.GetMethods();
        
        //StringBuilder sb = new StringBuilder();
           
        System.Console.WriteLine("{0} Properties:", t.Name);
        foreach (PropertyInfo p in pList)
        {
            System.Console.WriteLine(p.Name);
        }
        
        System.Console.WriteLine("{0} Methods:", t.Name);
        foreach (MethodInfo m in mList)
        {
            System.Console.WriteLine(m.Name);
        }

       
    }
}