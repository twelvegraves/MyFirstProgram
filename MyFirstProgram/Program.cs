﻿using MyFirstProgram;
using static System.Formats.Asn1.AsnWriter;
//ep 18
var menu = new Menu();

var date = DateTime.UtcNow;

var games = new List<string>();

string name = Helpers.GetName();

menu.ShowMenu(name, date);





