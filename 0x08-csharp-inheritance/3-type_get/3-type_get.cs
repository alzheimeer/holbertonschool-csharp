using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Globalization;
using System.Text;


class Obj
{
    ///<summary>prints the names of the available properties and methods of an object</summary>
    public static void Print(object myObj)
    {
        Type tt = myObj.GetType();
        TypeInfo t = tt.GetTypeInfo();
        IEnumerable<PropertyInfo> pList = t.DeclaredProperties;
        IEnumerable<MethodInfo> mList = t.DeclaredMethods;

        StringBuilder sb = new StringBuilder();
           
        sb.Append( tt.Name +" Properties:");
        foreach (PropertyInfo p in pList)
        {
            sb.Append("\n" + p.Name);
        }
        sb.Append("\n"+ tt.Name +" Methods:");
        foreach (MethodInfo m in mList)
        {
            sb.Append("\n" + m.Name);
        }
            
        Console.WriteLine(sb.ToString());

       
    }
}