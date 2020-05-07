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
        //PropertyInfo[] pList = t.GetProperties();
        //MethodInfo[] mList = t.GetMethods();
        StringBuilder sb = new StringBuilder();
           
        sb.Append(t.Name +" Properties:"+"\n");
        foreach (PropertyInfo p in pList)
        {
            sb.Append(p.Name+"\n");
        }
        sb.Append(t.Name +" Methods:"+"\n");
        foreach (MethodInfo m in mList)
        {
            sb.Append(m.Name+"\n");
        }
            
        Console.WriteLine(sb.ToString());

       
    }
}