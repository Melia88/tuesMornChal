using System;
using System.Collections.Generic;
using System.Linq;

namespace tuesMornChal
{
  class authenticator
  {
    private Dictionary<string, string> Credentials = new Dictionary<string, string>();
    public authenticator()
    {
      //username and password
      Credentials.Add("melia", "password1");
      Credentials.Add("elena", "password2");
    }

    public bool ValidateCredentials(string username, string password)
    {
      return Credentials.Any(entry => entry.Key == username && entry.Value == password);
    }
  }

  class Program
  {
    static private authenticator auth = new authenticator();
    static void Main(string[] args)
    {
      Console.WriteLine("Enter username : ");
      var username = Console.ReadLine();
      Console.WriteLine("Enter password : ");
      var password = Console.ReadLine();

      var isvalid = auth.ValidateCredentials(username, password);
      Console.WriteLine("Your are{0} authenticated!", isvalid ? string.Empty : " NOT");
      Console.ReadLine();
    }
  }
}


// SECTION DICTIONARIES  (NO POCO Plain ol C# Objects)
// takes in key type and value type
//   Dictionary<string, string> staffRoles = new Dictionary<string, string>(){
//       {"Mark", "Instructor"}
//   };
//   staffRoles.Add("Justin", "TA");
//   staffRoles.Add("Jake", "CEO");


//   if (staffRoles.ContainsKey("Jake"))
//   {

//     Console.WriteLine(staffRoles["Jake"]);
//   }


//   Dictionary<string, User> users = new Dictionary<string, User>();
//   User mark = new User("Mark", 32);
//   users.Add(mark.Name, mark);
//   System.Console.WriteLine(mark.Age);
//   mark.Birthday();
//   System.Console.WriteLine(mark.Age);