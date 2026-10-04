const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

//getting the 5000
const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = input.IndexOf(openSpan);
int closingPosition = input.IndexOf(closeSpan);

openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;

quantity = input.Substring(openingPosition, length);

//getting the output   
const string openDiv = "<div>";
const string closeDiv = "</div>";

openingPosition = input.IndexOf(openDiv);
closingPosition = input.IndexOf(closeDiv);

openingPosition += openDiv.Length;
length = closingPosition - openingPosition;

output = input.Substring(openingPosition, length);

Console.WriteLine(quantity);
Console.WriteLine(output);