# PrivateMembersAccess
This Repository is Functions I have made with System.Reflection in C# that call, set and gets private members so modding can be easier

This Script can be used for getting, setting, returning any varible even your own script!

Usage:

Put the script inside your modding project.

  For Getting Varibles:
    
    string st = (string)PrivateRevert.GetPrivateVarible(typeof(ScriptFrom), "name of varible", GameObjectThatScriptIsOnInstance);
    
  For Setting Varibles:
    
    string seter = (string)PrivateRevert.SetPrivateVarible(typeof(ScriptFrom), "name of varible", "change it to", GameObjectThatScriptIsOnInstance);
  
  For Calling Functions:
    
    No Return Value:
      
      PrivateRevert.RunPrivateFunction(typeof(ScriptFrom), "function name", new object[] { });
      
    Return Value:
      
      string returnvalue = PrivateRevert.RunPrivateFunction(typeof(Class), "FunctionName", new object[] { });
    
