using System;
using System.Collections.Generic;

namespace LearnCSharp
{
    public class JsonParser
    {
        public Boolean parseJsonArray()
        {
            // load json from file
            //string json = System.IO.File.ReadAllText(@"D:\Working-SDG\VBPractice\VBPractice\LearnCSharp\Jsons\Ecomm-captures.txt");
            //string json = System.IO.File.ReadAllText(@"D:\Working-SDG\VBPractice\VBPractice\LearnCSharp\Jsons\Moto-Captures.txt");
            //string json = System.IO.File.ReadAllText(@"D:\Working-SDG\VBPractice\VBPractice\LearnCSharp\Jsons\Moto-Captures-5961.txt");
            try
            {

                string json = System.IO.File.ReadAllText(@"D:\Working-SDG\VBPractice\VBPractice\LearnCSharp\Jsons\ecomm-authcodes.json");

                var ResponseArray = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Response>>(json);

                foreach (Response response in ResponseArray)
                {
                    //System.Console.WriteLine(response.xAuthCode); //+ "{tab}" + response.xAuthCode
                    System.Console.WriteLine(response.xRefNum);

                }
            }
            catch (Exception)
            {
               return false;
            }

            System.Console.ReadKey();

            return true;
        }
    }

    public class Response
    {
        public String xAuthCode = "";
        public String xRefNum = "";
    }
}
