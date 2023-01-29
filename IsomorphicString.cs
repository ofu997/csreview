using System.Collections.Generic; 

namespace CSharpIntermediate 
{
  public class Isomorphic
  {
    public static string IsomorphicFunction()
    {
      var s = "egg";
      var t = "adq"; 
      var sArray = s.ToCharArray();
      var tArray = t.ToCharArray(); 
      
      Dictionary<char, char> myDict = new Dictionary<char, char>();
      

      for (int i=0; i<s.Length; i++) 
      {
          // dictionaries can't add the same key twice
          // 1st if: make a dictionary if key-item isn't there
          // else: compare values
          if (!myDict.ContainsKey(sArray[i])) 
          {
            myDict.Add(sArray[i], tArray[i]);
            // var dValue = myDict[sArray[i]];
            // var currentValue = tArray[i];
            
            
            // if (dValue != currentValue) 
            // {
            //   return "false";
            // }
          }
          else 
          {
            if(tArray[i] != myDict[tArray[i]])
            {
              return "false"; 
            }
          }
      }
      return "true"; 
    }
  }
}
  