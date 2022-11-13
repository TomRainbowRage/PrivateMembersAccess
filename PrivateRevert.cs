using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using UnityEngine;
using System.IO;
using System.Collections;



    
public class PrivateRevert : MonoBehaviour
{
        


        

        public static FieldInfo GetField(Type classtypetochange, string fieldName)
        {
            
            return classtypetochange.GetField(fieldName, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            
        }

        public static object GetPrivateVarible(Type classtypetochange, string fieldName, GameObject container)
        {
            FieldInfo field = classtypetochange.GetField(fieldName, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

            Debug.Log(field);
            Debug.Log(field.GetValue(container.GetComponent(classtypetochange)));
            object obj = field.GetValue(container.GetComponent(classtypetochange));

            return obj;
        }

        public static void SetPrivateVarible(Type classtypetochange, string fieldName, object changeto, GameObject container)
        {
            FieldInfo field = classtypetochange.GetField(fieldName, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

            //Debug.Log(field);
            //Debug.Log(field.GetValue(container.GetComponent(classtypetochange)));

            field.SetValue(container.GetComponent(classtypetochange), changeto); //1 Instance of Script // changeto
        }

        public static object RunPrivateFunction(Type classtypetochange, string methodName, object[] arguments)
        {
            MethodInfo mi = classtypetochange.GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Instance);//.Invoke(classtypetochange, null);
            //Debug.Log(mi);

            var instance = Activator.CreateInstance(classtypetochange, null);
            //Debug.Log(instance);
            object o = new object();
            try
            {
                
                
                
                o = mi.Invoke(instance, arguments);
                
                
            } 
            catch
            {
                Debug.LogError("wrong arguments");
            }

            return o;
        }


        public static object SpecialCases(int cas, object[] arguments)
        {
            if(cas == 0)
            {
                GameManager gm = FindObjectOfType<GameManager>();
                object o = new object();

                Debug.Log("Game");


                Type type = gm.GetType();
                Debug.Log("Type = " + type);

                MethodInfo methodInfo = type.GetMethod("MovePlayer", BindingFlags.NonPublic | BindingFlags.Instance);

                Debug.Log("mothod = " + methodInfo.Name);
                o = gm.StartCoroutine(methodInfo.Name, arguments);

                return o;
            }
            else
            {
                return new object();
            }
        }
        

}
