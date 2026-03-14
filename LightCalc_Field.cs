// See https://aka.ms/new-console-template for more information
//Initialize globally accessible variables:
//navigation:
string editParam = "m";//e for irr/exp, d for distance, m for main menu
int tablePause = 84;//amount of time to wait in millis after overwrites (such as to table).  Ensures that cursor is where it needs to be and everything in sync
string printDir = @"C:\Users\" + System.Environment.UserName + @"\knights_who_say_NI\";
byte printDirOpt = 0;
byte dirConfirmation = 0;
string fileName = "wut";
string[] printOutput = {"somebody", "once", "told me", "the world", "is gonna roll me"};

//display settings://NOT YET IMPLEMENTED, W.I.P.
byte colorModeValIn = 0;//0 for normal white/gray/darkGray/black, 1 for warm yellow/DarkYellow/DarkRed/black, 2 for inverted Black/darkGray/Gray/White
string colorBright = "ConsoleColor.White";//switches to Yellow
string colorMid = "ConsoleColor.Gray";//switches to DarkYellow
string colorDark = "ConsoleColor.DarkGray";//switches to DarkRed
string colorWarning = "ConsoleColor.Yellow";//switches to Cyan or smth idk
byte colorCondition = 0;//was user changing color setting before redraw? If true(1)(set after color change, before auto redraw), go to editParam = "c" after redraw, then reset colorCondition to false(0)
//irradiance:
byte irrUnitIn = 2;
string irrUnitOut = "Lux";
double irrValIn = 0.0;
double luxOut = 0.0;
double altIrrVal = 0.0;
string altIrrUnit = "fc";
//exp:
byte expCondition = 0;//Does user want to calculate from exposure?

//track user progress entering exposure params 1 for iso, 2 for shutter, 4 for f-stop, 0 if none.
//Add for multiple.(e.g:1+2, or 3 is iso and shutter)
//For this to work, set has to be a "set with distinct subset sums"--no possible combination of param codes can equal a param code by itself or a combination comprised of other param codes
//Powers of 2 is an easy way to do this, so that's what we'll go with
//Numbers are of course prevented from being added to themselves like so: if(expCompleted != x){expCompleted += x}else{skip}
byte expCompleted = 0;

double isoIn = 0.0;
double shutterIn = 0.0;
double FnumIn = 0.0;
double expStops = 0.0;
string expPrefix = "+";

//Distance:
byte distUnitIn = 2;
string distUnitOut = "meters";
double distValIn = 0.0;
double meterOut = 0.0;
double altDistVal = 0.0;
string altDistUnit = "feet";

byte exitCondition = 1;

while(true){
Console.Clear();
Console.CursorVisible = false;
Console.WriteLine("");
int setFrameRate = (1000/24);

Console.Write("        -");
Console.Write("                                                         -");
Thread.Sleep(setFrameRate*2);

Console.SetCursorPosition(11, Console.CursorTop);
Console.Write("-");
Console.SetCursorPosition(62, Console.CursorTop);
Console.Write("-");
Thread.Sleep(setFrameRate*2);

Console.SetCursorPosition(13, Console.CursorTop);
Console.Write("-");
Console.SetCursorPosition(60, Console.CursorTop);
Console.Write("-");
Thread.Sleep(setFrameRate);

Console.SetCursorPosition(14, Console.CursorTop);
Console.Write("--");
Console.SetCursorPosition(58, Console.CursorTop);
Console.Write("--");
Thread.Sleep(setFrameRate);

Console.SetCursorPosition(16, Console.CursorTop);
Console.Write("==");
Console.SetCursorPosition(56, Console.CursorTop);
Console.Write("==");
Thread.Sleep(setFrameRate);

Console.SetCursorPosition(18, Console.CursorTop);
Console.Write("≡[");
Console.SetCursorPosition(54, Console.CursorTop);
Console.Write("]≡");
Thread.Sleep(setFrameRate);

int millisCounter = 0;
int counterDuration = 4;
Thread.Sleep(84);

while(millisCounter<counterDuration)//1:3 darkgrey to 0
{
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.SetCursorPosition(20, Console.CursorTop);
    Console.Write("Exposure-to-Light Field Calculator");
    Thread.Sleep(1);

    Console.SetCursorPosition(20, Console.CursorTop);
    Console.Write("                                  ");
    Thread.Sleep(3);
    millisCounter+=4;
}
millisCounter = 0;
while(millisCounter<counterDuration)//1:1 darkgrey to 0
{
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.SetCursorPosition(20, Console.CursorTop);
    Console.Write("Exposure-to-Light Field Calculator");
    Thread.Sleep(1);

    Console.SetCursorPosition(20, Console.CursorTop);
    Console.Write("                                  ");
    Thread.Sleep(1);
    millisCounter+=2;
}
millisCounter = 0;
while(millisCounter<counterDuration)//3:1 darkgrey to 0
{
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.SetCursorPosition(20, Console.CursorTop);
    Console.Write("Exposure-to-Light Field Calculator");
    Thread.Sleep(2);

    Console.SetCursorPosition(20, Console.CursorTop);
    Console.Write("                                  ");
    Thread.Sleep(1);

    Console.SetCursorPosition(20, Console.CursorTop);
    Console.Write("Exposure-to-Light Field Calculator");
    Thread.Sleep(1);
    millisCounter+=4;
}
millisCounter = 0;
while(millisCounter<counterDuration)//1:3 gray to darkgray
{
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.SetCursorPosition(20, Console.CursorTop);
    Console.Write("Exposure-to-Light Field Calculator");
    Thread.Sleep(2);
    
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.SetCursorPosition(20, Console.CursorTop);
    Console.Write("Exposure-to-Light Field Calculator");
    Thread.Sleep(1);

    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.SetCursorPosition(20, Console.CursorTop);
    Console.Write("Exposure-to-Light Field Calculator");
    Thread.Sleep(1);
    millisCounter+=4;
}
millisCounter = 0;
while(millisCounter<counterDuration)//1:1 gray to darkgray
{
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.SetCursorPosition(20, Console.CursorTop);
    Console.Write("Exposure-to-Light Field Calculator");
    Thread.Sleep(1);

    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.SetCursorPosition(20, Console.CursorTop);
    Console.Write("Exposure-to-Light Field Calculator");
    Thread.Sleep(1);
    millisCounter+=2;
}
millisCounter = 0;
while(millisCounter<counterDuration)//3:1 gray to darkgray
{
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.SetCursorPosition(20, Console.CursorTop);
    Console.Write("Exposure-to-Light Field Calculator");
    Thread.Sleep(2);

    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.SetCursorPosition(20, Console.CursorTop);
    Console.Write("Exposure-to-Light Field Calculator");
    Thread.Sleep(1);

    Console.ForegroundColor = ConsoleColor.Gray;
    Console.SetCursorPosition(20, Console.CursorTop);
    Console.Write("Exposure-to-Light Field Calculator");
    Thread.Sleep(1);
    millisCounter+=4;
}
millisCounter = 0;
while(millisCounter<counterDuration)//1:3 white to gray
{   
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.SetCursorPosition(19, Console.CursorTop);
    Console.Write("[Exposure-to-Light Field Calculator]");
    Thread.Sleep(2);

    Console.ForegroundColor = ConsoleColor.White;
    Console.SetCursorPosition(19, Console.CursorTop);
    Console.Write("[Exposure-to-Light Field Calculator]");
    Thread.Sleep(1);

    Console.ForegroundColor = ConsoleColor.Gray;
    Console.SetCursorPosition(19, Console.CursorTop);
    Console.Write("[Exposure-to-Light Field Calculator]");
    Thread.Sleep(1);
    millisCounter+=4;
}
millisCounter = 0;
while(millisCounter<counterDuration)//1:1 white to gray
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.SetCursorPosition(18, Console.CursorTop);
    Console.Write("≡[Exposure-to-Light Field Calculator]≡");
    Thread.Sleep(1);

    Console.ForegroundColor = ConsoleColor.Gray;
    Console.SetCursorPosition(18, Console.CursorTop);
    Console.Write("≡[Exposure-to-Light Field Calculator]≡");
    Thread.Sleep(1);
    millisCounter+=2;
}
millisCounter = 0;
while(millisCounter<counterDuration)//3:1 white to gray
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.SetCursorPosition(18, Console.CursorTop);
    Console.Write("≡[Exposure-to-Light Field Calculator]≡");
    Thread.Sleep(2);

    Console.ForegroundColor = ConsoleColor.Gray;
    Console.SetCursorPosition(18, Console.CursorTop);
    Console.Write("≡[Exposure-to-Light Field Calculator]≡");
    Thread.Sleep(1);

    Console.ForegroundColor = ConsoleColor.White;
    Console.SetCursorPosition(17, Console.CursorTop);
    Console.Write("=≡[Exposure-to-Light Field Calculator]≡=");
    Thread.Sleep(1);
    millisCounter+=4;
}
Console.ForegroundColor = ConsoleColor.White;
Console.SetCursorPosition(17, Console.CursorTop);
Console.Write("=≡[Exposure-to-Light Field Calculator]≡=\n");
Thread.Sleep(setFrameRate);

Console.SetCursorPosition(61, Console.CursorTop);
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("by Mak");
Thread.Sleep(setFrameRate*4);
Console.ResetColor();

int winDemCheckCount=0;
int maxWinDemCheck=50;
while(Console.WindowHeight<17||Console.WindowWidth<92||winDemCheckCount<maxWinDemCheck)
{
    while(Console.WindowHeight<17)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("PLEASE INCREASE WINDOW HEIGHT TO CONTINUE");
            Thread.Sleep(1);
            Console.SetCursorPosition(23, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("HEIGHT");
            Thread.Sleep(1);
            Console.SetCursorPosition(23, Console.CursorTop);
            Console.Write("______\r");
            Thread.Sleep(1);
            Console.ResetColor();
            Console.Write("                                         \r");
        }
    while(Console.WindowWidth<92)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("PLEASE INCREASE WINDOW WIDTH TO CONTINUE");
            Thread.Sleep(1);
            Console.SetCursorPosition(23, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("WIDTH");
            Thread.Sleep(1);
            Console.SetCursorPosition(23, Console.CursorTop);
            Console.Write("_____\r");
            Thread.Sleep(1);
            Console.ResetColor();
            Console.Write("                                        \r");
        }
    Console.ResetColor();
    Thread.Sleep(1);        
    winDemCheckCount++;
}
Console.WriteLine("Where a light meter measures irradiance and can be used to determine optimal");
Console.WriteLine("exposure parameters, this tool takes input of either irradiance or target ");
Console.WriteLine("exposure settings--and, when given distance from source, outputs the radiance,");
Console.WriteLine("in lumens (lux@1m/fc@1ft), required of the light source.\n");
Console.WriteLine("Parameters update live and can be freely edited, so the relationship between");
Console.WriteLine("exposure, distance, and lighting can be observed and adjusted in realtime.");

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.SetCursorPosition(2, Console.CursorTop);
Console.Write("╔═[NOTE:]════════════════════════════════════════════════════════════════╗\n");
Console.SetCursorPosition(2, Console.CursorTop);
Console.Write("║");
Console.Write(" This just performs a basic inverse square calculation, and assumes a   ");
Console.Write("║\n");

Console.SetCursorPosition(2, Console.CursorTop);
Console.Write("║");
Console.Write(" simple emissive or diffuse bounce surface as the source.  Spot lenses  ");
Console.Write("║\n");

Console.SetCursorPosition(2, Console.CursorTop);
Console.Write("║");
Console.Write(" and eggcrates may result in under or overestimation, respectively, as  ");
Console.Write("║\n");

Console.SetCursorPosition(2, Console.CursorTop);
Console.Write("║");
Console.Write(" these affect falloff. Something, something, spherical cows or whatever.");
Console.Write("║\n");

Console.SetCursorPosition(2, Console.CursorTop);
Console.Write("╚════════════════════════════════════════════════════════════════════════╝\n");
Console.ResetColor();

while(!Console.KeyAvailable)//continue animation
{
    millisCounter=0;
    counterDuration=11;
    while(millisCounter<counterDuration&&!Console.KeyAvailable)//3:1 darkgray-black
        {   
            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("strike any key to begin>>   ");
            Thread.Sleep(2);

            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("strike any key to begin>>   ");
            Thread.Sleep(1);

            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("strike any key to begin>>   ");
            Thread.Sleep(1);
            millisCounter+=4;
        }
        millisCounter=0;
        while(millisCounter<counterDuration&&!Console.KeyAvailable)//darkgray
        {
            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("strike any key to begin >>  ");
            Thread.Sleep(1);

            millisCounter++;
        }
        millisCounter=0;
        while(millisCounter<counterDuration&&!Console.KeyAvailable)//3:1 darkgray-gray
        {
            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("strike any key to begin  >> ");
            Thread.Sleep(1);

            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("strike any key to begin  >> ");
            Thread.Sleep(1);

            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("strike any key to begin  >> ");
            Thread.Sleep(2);

            millisCounter+=4;
        }
        millisCounter=0;
        while(millisCounter<counterDuration&&!Console.KeyAvailable)//1:1 darkgray-gray
        {
            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("strike any key to begin   >>");
            Thread.Sleep(1);

            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("strike any key to begin   >>");
            Thread.Sleep(1);

            millisCounter+=2;
        }
        millisCounter=0;
        while(millisCounter<counterDuration&&!Console.KeyAvailable)//3:1 gray-darkgray
        {
            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("strike any key to begin    >");
            Thread.Sleep(2);

            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("strike any key to begin    >");
            Thread.Sleep(1);

            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("strike any key to begin    >");
            Thread.Sleep(1);
            millisCounter+=4;
        }
        millisCounter=0;
        while(millisCounter<counterDuration&&!Console.KeyAvailable)//gray
        {
            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("strike any key to begin   ");
            Thread.Sleep(1);

            millisCounter++;
        }
        millisCounter=0;
        while(millisCounter<counterDuration&&!Console.KeyAvailable)//3:1 gray-white
        {
            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("strike any key to begin>    ");
            Thread.Sleep(2);
           
            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("strike any key to begin>    ");
            Thread.Sleep(1);

            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("strike any key to begin>    ");
            Thread.Sleep(1);

            millisCounter+=4;
        }
        millisCounter=0;
        while(millisCounter<counterDuration&&!Console.KeyAvailable)//1:1 gray-white
        {
            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("strike any key to begin>>   ");
            Thread.Sleep(1);
            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("strike any key to begin>>   ");
            Thread.Sleep(1);
            millisCounter+=2;
        }
        millisCounter=0;
        while(millisCounter<counterDuration&&!Console.KeyAvailable)//3:1 white-gray
        {
            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("strike any key to begin >>  ");
            Thread.Sleep(1);
            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("strike any key to begin >>  ");
            Thread.Sleep(1);
            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("strike any key to begin >>  ");
            Thread.Sleep(2);
            millisCounter+=4;
        }
        millisCounter=0;

            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("strike any key to begin  >> ");
            Thread.Sleep(84);

            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("strike any key to begin   >>");
            Thread.Sleep(84);

            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("strike any key to begin    >");
            Thread.Sleep(84);

            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("strike any key to begin     ");
            Thread.Sleep(84);

            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("strike any key to begin>    ");
            Thread.Sleep(84);

            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("strike any key to begin>>   ");
            Thread.Sleep(84);

            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("strike any key to begin >>  ");
            Thread.Sleep(84);

            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("strike any key to begin  >> ");
            Thread.Sleep(84);

        //pong->
        while(millisCounter<counterDuration&&!Console.KeyAvailable)//3:1 white-gray
        {
            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("strike any key to begin   >>");
            Thread.Sleep(1);
            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("strike any key to begin   >>");
            Thread.Sleep(1);
            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("strike any key to begin   >>");
            Thread.Sleep(2);
            millisCounter+=4;
        }
        millisCounter=0;
        while(millisCounter<counterDuration&&!Console.KeyAvailable)//1:1 gray-white
        {
            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("strike any key to begin    >");
            Thread.Sleep(1);
            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("strike any key to begin    >");
            Thread.Sleep(1);
            millisCounter+=2;
        }
        millisCounter=0;
        while(millisCounter<counterDuration&&!Console.KeyAvailable)//gray
        {
            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("strike any key to begin     ");
            Thread.Sleep(1);
            millisCounter++;
        }
        millisCounter=0;
        while(millisCounter<counterDuration&&!Console.KeyAvailable)//1:1 darkgray-gray
        {
            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("strike any key to begin>    ");
            Thread.Sleep(1);
            Console.SetCursorPosition(44, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("strike any key to begin>    ");
            Thread.Sleep(1);
            millisCounter+=2;
        }
        millisCounter=0;
}
Console.CursorVisible = true;
Console.ReadKey(true);
//////////////////////////////////////////////////////////////////////
//moved init to top
exitCondition = 0;//initialized on first line before title page
//solve:
double lumensCalc = 0.0/0.0;//NaN by default

while(exitCondition == 0)
{//////////////////////////////////////////////////////////////////////////////main menu:
if(irrValIn != 0 && !double.IsNaN(irrValIn) && distValIn != 0 && !double.IsNaN(distValIn))//quick calculate and display lumensCalc if there's valid data, else NaN
        {
            lumensCalc = luxOut*Math.Pow(meterOut, 2);
        }else{lumensCalc = 0.0/0.0;}
    Console.ResetColor();
    Console.Clear();
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write("        -  - ---==≡[Exposure-to-Light Field Calculator]≡==--- -  -        ");
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("  by Mak");
    Console.WriteLine("Select parameter from below to start.  These can be edited at any time.");
    Console.ResetColor();
    Console.WriteLine("[e] Edit Irradiance/Exposure      [d] Edit Distance      [p] Print to .txt");
    Console.WriteLine("--------------------------------------------------------------------------");    
    Console.WriteLine("EXPOSURE INFO:                                    [t] Return to Title Page");
    //|_____ISO_____|__SHUTTER__|__f/STOP__|  ╚══╗      stops╞══════════╧══════════╛
            Console.WriteLine(" ____________________________________ ");
                Console.Write("║_____________|___________|__________|\n");
            Console.WriteLine("║             |           |          |");
            Console.WriteLine("╚═════════════╧═══════════╧══════════╛");
   
        //how complete should table be based on user progress?
        if(expCondition == 1)
        {
            if(expCompleted == 1 || expCompleted == 1+2 || expCompleted == 1+4 || expCompleted == 7)//if iso completed
            {   
                Console.SetCursorPosition(6, Console.CursorTop-3);
                Console.Write("ISO");
                Console.SetCursorPosition(1, Console.CursorTop+1);
                Console.Write(isoIn);
                Console.SetCursorPosition(0, Console.CursorTop+2);
            }
            if(expCompleted == 2 || expCompleted == 2+1 || expCompleted == 2+4 || expCompleted == 7)//if shutter completed
             {
                Console.SetCursorPosition(17, Console.CursorTop-3);
                Console.Write("SHUTTER");
                Console.SetCursorPosition(15, Console.CursorTop+1);
                Console.Write("1/" + shutterIn + "s");
                Console.SetCursorPosition(0, Console.CursorTop+2);
            }
            if(expCompleted == 4|| expCompleted == 4+1 || expCompleted == 4+2 || expCompleted == 7)//if f/stop completed
            {
                Console.SetCursorPosition(29, Console.CursorTop-3);
                Console.Write("ƒ/STOP");
                Console.SetCursorPosition(27, Console.CursorTop+1);
                Console.Write("ƒ/" + FnumIn);
                Console.SetCursorPosition(0, Console.CursorTop+2);
            }
            if(expStops != 0)//if user wants to push/pull by some number of stops
            {
                Console.SetCursorPosition(11-Math.Min((expPrefix + Convert.ToString(expStops)).Length+5-2, 10), Console.CursorTop-1);//set cursor to write prefix (-/+) and expStops, right-justified from "stops"(calculated from length)
                Console.Write("╗" + expPrefix + expStops + "stops╞");
                Console.SetCursorPosition(0, Console.CursorTop+1);
            }
        }
        
    if(expCondition == 0 || expCompleted == 1+2+4)//if user wants to use irr or if exposure is complete (and thus irr calculated), display irr
    {
    Console.WriteLine("IRRADIANCE: " + irrValIn + " " + irrUnitOut + " (" + altIrrVal + altIrrUnit + ")");
    }else{Console.WriteLine("IRRADIANCE: ");}

    Console.WriteLine("DISTANCE: " + distValIn + " " + distUnitOut + " (" + altDistVal + altDistUnit + ")");
    Console.WriteLine("LUMENS REQUIRED: " + lumensCalc + " Lumens");
    if(editParam!="e"&& editParam!="d")//if edit parameter not already decided at loop restart, use readline.
    {
        editParam = Console.ReadLine();
    }else{Console.WriteLine("");}
/////////////////////////////////////////////////////////////////////////////////main menu.
if(editParam == "t"){exitCondition = 1;}
while(editParam == "e")
    {   
        Console.SetCursorPosition(50, Console.CursorTop-9);//go to option [t]
        Console.Write("                        ");//erase option [t]
        Console.SetCursorPosition(0, Console.CursorTop+9);//return to prompt line
        Console.WriteLine("Choose Unit: [1] Footcandles   [2] Lux   [3] Calculate");//prompt line  
        Console.Write("                                                             [m] redraw main menu      \r");//clear input line and CR
        string irrUnitStringput;                                                                    
        //set to 3 automatically if already expCondition to trigger overwrite prompt line w exp stuff:
        if(expCondition == 0){irrUnitStringput = Console.ReadLine();}else{irrUnitStringput = "3"; Console.WriteLine("");}//also input line

        switch(irrUnitStringput)
        {
            case "1":
            irrUnitIn = 1;
            irrUnitOut = "Footcandles";
            altIrrUnit = "Lux";
            break;

            case "2":
            irrUnitIn = 2;
            irrUnitOut = "Lux";
            altIrrUnit = "fc";
            break;

            case "3":
            irrUnitIn = 1;
            irrUnitOut = "Footcandles";
            altIrrUnit = "Lux";
            expCondition = 1;//trigger exposure params
            break;

            case "":
            //no change, move on to value
            break;

            case "d"://user is trying to edit distance, trigger break out of irradiance loop
            Console.SetCursorPosition(0, Console.CursorTop-1);
            Console.Write("                                            ");
            Console.SetCursorPosition(0, Console.CursorTop-1);
            Console.Write("                                                                                          \r");
            editParam = "d";
            break;

            case "m"://user trying to get to main menu
            editParam = "m";
            break;

            case "p"://user trying to print
            Console.SetCursorPosition(0, Console.CursorTop-1);//go to input line
            Console.Write("                                                                                          \r");//clear input line and CR
            Console.SetCursorPosition(0, Console.CursorTop-1);//go to prompt line
            Console.Write("                                                                                          \r");//clear prompt line and CR
            editParam = "p";
            break;
        }
        if(irrUnitStringput == "1" || irrUnitStringput == "2")
        {
            Console.Write("Enter IRRADIANCE in " + irrUnitOut + ": ");
            irrValIn = Convert.ToDouble(Console.ReadLine());
            //unit conversions and change of editParam to m moved from here, to AFTER Exposure tests, since exp calculation is in fc.
        }

        //Exposure stuff:
        if(expCondition == 1)
        {
            Console.SetCursorPosition(0, Console.CursorTop-2);//move cursor up to prompt line to overwrite
            Console.Write("                                                      \r");//clear line and CR
            Console.WriteLine("Edit: [4] ISO   [5] Shutter   [6] f/stop   [+] -/+ Stops   [c] clear all exp calc");
            Console.Write("                                                             [m] redraw main menu      \r");//clear input line and CR
            string expEditStringput = Console.ReadLine();
            
            //tablePause init moved to top
            switch(expEditStringput)
            {
                case "m":
                editParam = "m";
                break;

                case "d"://user wants distance.  set cursor to prompt line and clear before setting exit condition from e to d param edit.
                Console.SetCursorPosition(0, Console.CursorTop-2);
                Console.Write("                                                                                          ");
                editParam = "d";
                break;

                case "p"://user trying to print
                Console.SetCursorPosition(0, Console.CursorTop-1);//go to input line
                Console.Write("                                                                                          \r");//clear input line and CR
                Console.SetCursorPosition(0, Console.CursorTop-1);//go to prompt line
                Console.Write("                                                                                          \r");//clear prompt line and CR
                editParam = "p";
                break;

                case "c":
                Console.SetCursorPosition(0, Console.CursorTop-2);//go to prompt line to overwrite with primary irr menu
                Console.Write("                                                                                          \r");//clear line
                expStops = 0;//reset exposure rating
                expCompleted = 0;//user wants to leave or start over exposure calc
                expCondition = 0;//user no longer wants to be in exposure mode
                break;

                case "4"://set iso and move cursor up to update table.
                    //input:
                Console.Write("Enter Value: ");
                isoIn = Convert.ToDouble(Console.ReadLine());
                    //overwrite UI:
                Console.SetCursorPosition(0, Console.CursorTop-1);
                Console.Write("                              ");//clear input line
                Console.SetCursorPosition(12, Console.CursorTop-6);//Go to IRRADIANCE readout
                Console.Write("                                                                                          ");//overwrite with zeroes
                Console.SetCursorPosition(1, Console.CursorTop-2);//Go to data cell
                Console.Write("             ");//clear ISO cell
                Console.SetCursorPosition(1, Console.CursorTop);//Return to start of cell
                Console.Write(isoIn);//write to iso cell
                Console.SetCursorPosition(6, Console.CursorTop-1);//Go to table header
                Console.Write("ISO");
                Console.SetCursorPosition(0, Console.CursorTop+7);
                Thread.Sleep(tablePause);
                if (expCompleted != 1 && expCompleted != 3 && expCompleted != 5 && expCompleted != 7){expCompleted += 1;}//All scenarios where user already entered iso have to by untrue for expCompleted code to be updated
                break;

                case "5"://'5' looks like 's'
                case "s":
                case "S":
                    //input:
                Console.Write("Enter Exp Time, Denom of 1 sec:  1/");
                shutterIn = Convert.ToDouble(Console.ReadLine());
                    //overwrite UI:
                Console.SetCursorPosition(0, Console.CursorTop-1);
                Console.Write("                                       ");//clear input line
                Console.SetCursorPosition(12, Console.CursorTop-6);//Go to IRRADIANCE readout
                Console.Write("                                                                                          ");//overwrite with zeroes
                Console.SetCursorPosition(15, Console.CursorTop-2);//Go to shutter data cell
                Console.Write("           ");//clear shutter cell
                Console.SetCursorPosition(15, Console.CursorTop);//Return to start of cell
                Console.Write("1/" + shutterIn + "s");//write to shutter cell
                Console.SetCursorPosition(17, Console.CursorTop-1);//Go to table header
                Console.Write("SHUTTER");
                Console.SetCursorPosition(0, Console.CursorTop+7);
                Thread.Sleep(tablePause);
                if(expCompleted != 2 && expCompleted != 2+1 && expCompleted != 2+4 && expCompleted !=7){expCompleted += 2;}//can't equal ANY of these shutter-previously-entered scenarios   
                break;

                case "6"://'6' looks like 'G'
                case "g":
                case "G":
                    //input:
                Console.Write("Enter ƒ/stop:  ƒ/");
                FnumIn = Convert.ToDouble(Console.ReadLine());
                    //overwrite UI:
                Console.SetCursorPosition(0, Console.CursorTop-1);
                Console.Write("                                       ");//clear input line
                Console.SetCursorPosition(12, Console.CursorTop-6);//Go to IRRADIANCE readout
                Console.Write("                                                                                          ");//overwrite with zeroes
                Console.SetCursorPosition(27, Console.CursorTop-2);//Go to f/stop data cell
                Console.Write("          ");//clear f/stop cell
                Console.SetCursorPosition(27, Console.CursorTop);//Return to start of cell
                Console.Write("ƒ/" + FnumIn);//write to f/stop cell
                Console.SetCursorPosition(29, Console.CursorTop-1);//Go to table header
                Console.Write("ƒ/STOP");
                Console.SetCursorPosition(0, Console.CursorTop+7);
                Thread.Sleep(tablePause);
                if(expCompleted != 4 && expCompleted != 4+1 && expCompleted != 4+2 && expCompleted != 7){expCompleted += 4;}
                break;

                case "+": 
                    //input:
                Console.Write("Rate ISO +x stops: x =         ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("(Negative values yield brighter exposure.  Enter zero(0) to skip)");
                Console.ResetColor();
                Console.SetCursorPosition(23, Console.CursorTop);//set cursor back to "x=" field
                expStops = Convert.ToDouble(Console.ReadLine());
                if(expStops > 0){expPrefix = "+";}else{expPrefix = "";}
                    //overwrite UI:
                Console.SetCursorPosition(0, Console.CursorTop-1);
                Console.Write("                                                                                          ");//clear input line
                Console.SetCursorPosition(12, Console.CursorTop-6);//Go to IRRADIANCE readout
                Console.Write("                                                                                          ");//overwrite with zeroes
                Console.SetCursorPosition(0, Console.CursorTop-1);//Go to table floor
                Console.Write("╚═════════════╧═══════════╧══════════╛");//redraw default floor
                if(expStops != 0)//only overwrite table if stops other than zero
                {
                    Console.SetCursorPosition(11-Math.Min((expPrefix + Convert.ToString(expStops)).Length+5-2, 10), Console.CursorTop);//set cursor to write prefix (-/+) and expStops, right-justified from "stops"(calculated from length)
                    Console.Write("╗" + expPrefix + expStops + "stops╞");
                 }   
                Console.SetCursorPosition(0, Console.CursorTop+5);
                
                Thread.Sleep(tablePause);
                break;
            }//end of exposure editing switchcase

            if(expCompleted == 1+2+4)//if exposure table completed, calculate irradiance in footcandles.  Unit fc already assigned.
            {//based on base params of 100 ISO, 1/48s, f/4 => 160*sqrt(2)fc
                double expGain = Math.Pow(2, expStops); //convert added stops of exposure to gain factor
                irrValIn = (160*Math.Sqrt(2)) / (  (isoIn/100) * ((1.0/shutterIn)/(1.0/48.0)) * Math.Pow(4.0/FnumIn, 2) * expGain);
                //redraw IRRADIANCE readout:
                Console.SetCursorPosition(12, Console.CursorTop-4);//set cursor at IRRADIANCE field
                Console.Write("                                                                                 ");//clear Irradiance
                Console.SetCursorPosition(12, Console.CursorTop);//set cursor back to start of IRRADIANCE field
                Console.Write(irrValIn + " Footcandles" + " (" + Math.Pow(1/0.3048, 2)*irrValIn + "Lux)");
                Console.SetCursorPosition(0, Console.CursorTop+4);
                Thread.Sleep(tablePause);
            }
        }//exposure if statement end

        //UNIT CONVERSIONS--convert if fc, else keep.  Then return value and units before breaking out of irr/exp edit loop:
        switch(irrUnitIn)
            {
                case 1://fc
                luxOut = Math.Pow(1/0.3048, 2)*irrValIn;
                altIrrVal = luxOut;
                break;

                case 2://lux
                luxOut = irrValIn;
                altIrrVal = irrValIn/Math.Pow(1/0.3048, 2);
                break;
            }
        if(irrUnitStringput == "1" || irrUnitStringput == "2")
        {
            editParam = "m";//condition to escape irr/exp edit loop to main menu
        }
        //calculate lumens here if distance data exists and measurements are non-zero and a number, then write to field:
        if(irrValIn != 0 && !double.IsNaN(irrValIn) && distValIn != 0 && !double.IsNaN(distValIn))
        {
            lumensCalc = luxOut*Math.Pow(meterOut, 2);
            Console.SetCursorPosition(17, Console.CursorTop-2);
            Console.Write("                                                                         ");//clear line
            Console.SetCursorPosition(17, Console.CursorTop);
            Console.Write(lumensCalc + " Lumens");
            Console.SetCursorPosition(0, Console.CursorTop+2);
        }else{lumensCalc = 0.0/0.0;}

    }//editParam e (irradiance/exposure) loop end

while(editParam == "d")
    {   Console.SetCursorPosition(50, Console.CursorTop-9);//go to option [t]
        Console.Write("                        ");//erase option [t]
        Console.SetCursorPosition(0, Console.CursorTop+9);//return to prompt line
        Console.WriteLine("Choose Unit: [1] feet   [2] meters   [m] redraw main menu ");//prompt line
        Console.Write("                                                                                 \r");//clear input line and CR
        string distUnitStringput;
        distUnitStringput = Console.ReadLine();

        switch (distUnitStringput)
        {
            case "1":
            distUnitIn = 1;
            distUnitOut = "feet";
            altDistUnit = "meters";
            break;

            case "2":
            distUnitIn = 2;
            distUnitOut = "meters";
            altDistUnit = "feet";
            break;

            case "":
            //no change, move on to value
            break;

            case "e"://user is trying to edit irr/exp, trigger break out of dist loop
            Console.SetCursorPosition(0, Console.CursorTop-1);
            Console.Write("                                            ");
            Console.SetCursorPosition(0, Console.CursorTop-1);
            Console.Write("                                                                             \r");
            editParam = "e";
            break;

            case "m"://user trying to get to main menu
            editParam = "m";
            break;

            case "p"://user trying to print
            Console.SetCursorPosition(0, Console.CursorTop-1);//go to input line
            Console.Write("                                                                                          \r");//clear input line and CR
            Console.SetCursorPosition(0, Console.CursorTop-1);//go to prompt line
            Console.Write("                                                                                          \r");//clear prompt line and CR
            editParam = "p";
            break;
        }//end of distunit case switch
        if(distUnitStringput == "1" || distUnitStringput == "2")
        {
            Console.Write("Enter DISTANCE, in " + distUnitOut + ": ");
            distValIn = Convert.ToDouble(Console.ReadLine());
            switch(distUnitIn)//unit conversions for distance:
            {
                case 1://if feet
                meterOut = 0.3048*distValIn;
                altDistVal = meterOut;
                break;

                case 2://if meters
                meterOut = distValIn;
                altDistVal = distValIn/0.3048;
                break;
            }
            editParam = "m";//exit distance to menu
        }
        
    }//editParam d (distance) loop end

while(editParam=="p" && dirConfirmation == 0)
    {
        Console.WriteLine("Choose Dir:  [1] " + System.Environment.UserName + "'s Downloads  [2] " + System.Environment.UserName + "'s Documents  [3] Manual Input");
        string dirStringput = Console.ReadLine();
        switch(dirStringput)
        {   
            case "1":
            printDirOpt = 1;
            printDir = @"C:\Users\" + System.Environment.UserName + @"\Downloads";
            break;

            case "2":
            printDirOpt = 2;
            printDir = @"C:\Users\" + System.Environment.UserName + @"\Documents";
            break;

            case "3":
            printDirOpt = 3;
            Console.SetCursorPosition(0, Console.CursorTop-1);//go to input line
            Console.Write("                                                                                          \r");//clear prompt line and CR
            Console.Write("Enter Dir: ");
            printDir = Console.ReadLine();
            break;

            case "d"://user is trying to edit distance, trigger break out of print loop
            Console.SetCursorPosition(0, Console.CursorTop-1);
            Console.Write("                                                                       ");
            Console.SetCursorPosition(0, Console.CursorTop-1);
            Console.Write("                                                                                          \r");
            editParam = "d";
            break;

            case "e"://user is trying to edit irr, trigger break out of print loop
            Console.SetCursorPosition(0, Console.CursorTop-1);
            Console.Write("                                                                       ");
            Console.SetCursorPosition(0, Console.CursorTop-1);
            Console.Write("                                                                                          \r");
            editParam = "e";
            break;

            case "m":
            editParam = "m";
            break;

            default:
            printDirOpt = 0;
            Console.SetCursorPosition(0, Console.CursorTop-2);
            break;
        }
        if(printDirOpt!=0)//naming
        {
            Console.SetCursorPosition(0, Console.CursorTop-1);//go to input line
            Console.Write("                                                                                          \r");//clear line and CR
            Console.SetCursorPosition(0, Console.CursorTop-1);//go to prompt line
            Console.Write("                                                                                          \r");//clear line and CR
            Console.WriteLine(printDir + " <-Is this correct? [y][Entr] yes / [n] no :");
            string folderConfirmStringput = Console.ReadLine();
            switch(folderConfirmStringput)
                {
                    case "n":
                    case "no":
                    Console.SetCursorPosition(0, Console.CursorTop-1);//go to input line
                    Console.Write("                                                                                          \r");//clear line and CR
                    Console.SetCursorPosition(0, Console.CursorTop-1);//go to prompt line
                    Console.Write("                                                                                          \r");//clear line and CR
                    printDirOpt = 0;
                    break;

                    case "y":
                    case "yes":
                    case "":
                    Console.SetCursorPosition(printDir.Length, Console.CursorTop-2);
                    Console.Write("                                            \r");
                    Console.SetCursorPosition(0, Console.CursorTop+1);//go to input line
                    Console.Write("                                                                                          \r");//clear input line and CR
                    Console.WriteLine("Enter a Filename: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("                                   Any .txt w/ same name+dir will be overwritten.");
                    Console.ResetColor();
                    Console.SetCursorPosition(18, Console.CursorTop-1);
                    fileName = Console.ReadLine() + "_LightCalc.txt";
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.Write("                                                                                          \r");//clear warning line and CR
                    Console.SetCursorPosition(0, Console.CursorTop-1);//go to input line
                    Console.Write("                                                                                          \r");//clear input line and CR
                    Console.SetCursorPosition(0, Console.CursorTop-1);//go to prompt line
                    Console.Write("                                                                                          \r");//clear prompt line and CR
                    Console.WriteLine(printDir + @"\" + fileName + " <-Confirm save?");
                    Console.Write("[y][Entr] Yes / [n] No, go back: ");
                    string finalConfirmStringput = Console.ReadLine();
                    if(finalConfirmStringput=="y"||finalConfirmStringput=="yes"||finalConfirmStringput=="")
                        {
                            Console.SetCursorPosition(0, Console.CursorTop-1);//go to input line
                            Console.Write("                                                                                          \r");//clear input line and CR
                            dirConfirmation=1;
                        }else{
                            Console.SetCursorPosition(0, Console.CursorTop-1);//go to input line
                            Console.Write("                                                                                          \r");//clear input line and CR
                            Console.SetCursorPosition(0, Console.CursorTop-1);//go to prompt line
                            Console.Write("                                                                                          \r");//clear prompt line and CR
                            printDirOpt=0;
                            }
                    break;

                    default:
                    Console.Write("Something went wrong.              ");
                    printDirOpt = 0;
                    editParam = "m";
                    break;
                }

        }
    }//end of print dir and confirm loop
    if(editParam == "p"&&dirConfirmation==1)
        {
            //print logic
            fileName = fileName.Remove(fileName.Length-14);//remove file suffix and extension
            string infoBoxLn1 = "ISO: " + isoIn + " " + expPrefix + expStops + "stops";
            if(expStops == 0){infoBoxLn1 = "ISO: " + isoIn;}
            string infoBoxLn2 = "SHUTTER: " + @"1/" + shutterIn + "s";
            string infoBoxLn3 = @"ƒ/STOP: " + @"ƒ/" + FnumIn;
            if(expCondition==0)
            {
                infoBoxLn1 = @"║\ | _   ║\  _ ___ _ ";
                infoBoxLn2 = @"║ \|| |  ║ ||-| | |-|";
                infoBoxLn3 = @"║  ||_|  ║/ | | | | |";
            }
            printOutput = new string[]{fileName,
                                   "by " + System.Environment.UserName,"",
                                   "EXPOSURE INFO:",
                                   "   " + infoBoxLn1,
                                   "   " + infoBoxLn2,
                                   "   " + infoBoxLn3,"-",
                                   "IRRADIANCE: " + irrValIn + " " + irrUnitOut + " (" + altIrrVal + altIrrUnit + ")",
                                   "DISTANCE: " + distValIn + " " + distUnitOut + " (" + altDistVal + altDistUnit + ")","══════════════════",
                                   "LUMENS REQUIRED: " + lumensCalc + " " + "Lm","════════════════════════════════════════════════════════════════════",
                                   "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", 
                                   "                                    Generated using Exposure-to-Light Field Calculator v1.1",
                                   "                                                               Written by Michael Kreitzman",
                                   "                                                                                        || ",
                                  @"                                                                                        \/ ","","",
                                   "                                                                    github.com/FlyingGoatFX",
                                   "                                                                  instagram.com/flyinggoa7/",
                                   "                                                                  youtube.com/@FlyingGoatFX",
                                   "                                                                     FlyingGoatFX@gmail.com","","",
                                   "(c)MMXXVI FlyingGoatFX                                                                     "
                                   };
            fileName = fileName + "_LightCalc.txt";//re-add file suffix and extension
            File.WriteAllLines(printDir + @"\" + fileName, printOutput);
            byte animCounter = 0;
            while(animCounter<4)
            {
                Console.Write("Doing the print to " + printDir + @"\" + fileName + @" ─" + "\r");
                Thread.Sleep(setFrameRate*2);
                Console.Write("Doing the print to " + printDir + @"\" + fileName + @" \" + "\r");
                Thread.Sleep(setFrameRate*2);
                Console.Write("Doing the print to " + printDir + @"\" + fileName + @" |" + "\r");
                Thread.Sleep(setFrameRate*2);
                Console.Write("Doing the print to " + printDir + @"\" + fileName + @" /" + "\r");
                Thread.Sleep(setFrameRate*2);
                animCounter++;
            }
            Console.Write("Clearing Print info...                  ");
            Thread.Sleep(500);
        printDirOpt=0;//reset print directory option
        dirConfirmation = 0;//reset dir confirmation to false
        editParam = "m";//go back to menu
        }
}//exitcond loop
}//master loop