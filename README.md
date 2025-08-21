# PrivateMembersAccess

# This project is useless since there is a much better reliable way to do this using HarmonyX library.

This Repository is Functions I have made with System.Reflection in C# that call, set and gets private members so modding can be easier

This Script can be used for getting, setting, returning any varible even your own script!

Usage:


  For Getting Varibles:
    
    string st = (string)PrivateRevert.GetPrivateVarible(typeof(ScriptFrom), "name of varible", ScriptInstance);
    
  For Setting Varibles:
    
    string seter = (string)PrivateRevert.SetPrivateVarible(typeof(ScriptFrom), "name of varible", "change it to", ScriptInstance);
  
  For Calling Functions:
  
    PrivateRevert.RunPrivateFunction(typeof(ScriptFrom), "function name", new object[] { });

    string returnvalue = PrivateRevert.RunPrivateFunction(typeof(Class), "FunctionName", new object[] { });
    
