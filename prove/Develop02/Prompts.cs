using System;
using System.Collections.Generic;


public class Prompts
{
   public string RandomPrompts()
   {
      var prompts = new List<string> {"Who was someone you spoke to today? What did you talk about?", 
                                    "What is something fun you did today?", 
                                    "What was your favorite animal as a kid and why?", 
                                    "Who do you feel looks up to you in your life?", 
                                    "Who do you consider to be your best friend? Write about them."};
      int count = prompts.Count;
      var random = new Random();
      int _listIndex = random.Next(count);
      string _prompt = prompts[_listIndex];
      return _prompt;
   }
   
   
   
} 

   

