using MyFirstProgram;
using static System.Formats.Asn1.AsnWriter;
//starts here, hosts a few variables that'll be used in other places
var menu = new Menu();

var date = DateTime.UtcNow;

var games = new List<string>();

string name = Helpers.GetName();
//invokes the menu which gets all the good shit going
menu.ShowMenu(name, date);





