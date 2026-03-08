// See https://aka.ms/new-console-template for more information

//Title Page:
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.Write(" - - "); 
Console.ForegroundColor = ConsoleColor.Gray;
Console.Write("----==");
Console.ForegroundColor = ConsoleColor.White;
Console.Write("====[ Exposure-to-Light Calculator v1.0 ]====");
Console.ForegroundColor = ConsoleColor.Gray;
Console.Write("==----");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine(" - - ");

//Author anim:
int authorAnimSpeed = 42;//~1000/24
Thread.Sleep(84);
Console.Write("                    -");
Thread.Sleep(authorAnimSpeed*3);
Console.Write("-");
Thread.Sleep(authorAnimSpeed*2);
Console.Write("-");
Thread.Sleep(authorAnimSpeed);
Console.Write("-");
Thread.Sleep(authorAnimSpeed);
Console.Write("-");
Thread.Sleep(authorAnimSpeed);
Console.Write("-");
Thread.Sleep(authorAnimSpeed);
Console.Write("-");
Thread.Sleep(authorAnimSpeed);
Console.Write("-");
Thread.Sleep(authorAnimSpeed);
Console.Write("-");
Thread.Sleep(authorAnimSpeed);
Console.Write("-");
Thread.Sleep(authorAnimSpeed);
Console.Write("-");
Thread.Sleep(authorAnimSpeed/2);
Console.Write("-");
Thread.Sleep(authorAnimSpeed/2);
Console.Write("--");
Thread.Sleep(authorAnimSpeed/2);
Console.Write("--");
Thread.Sleep(authorAnimSpeed/2);
Console.Write("---");
Thread.Sleep(authorAnimSpeed/2);
Console.Write("----");
Thread.Sleep(authorAnimSpeed/2);
Console.Write("----");
Thread.Sleep(authorAnimSpeed/2);
Console.Write(" Written by");
Thread.Sleep(authorAnimSpeed);
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine(" Mak, FlyingGoatFX");
Console.WriteLine("");
Console.ResetColor();


Thread.Sleep(150);
Console.WriteLine("Calculate power of light required and relevant unit conversions,");
Console.WriteLine("for a given exposure reading and distance from source.");
Console.WriteLine("");
Thread.Sleep(125);
Console.WriteLine("This program only accepts numerical input unless otherwise stated.");
Console.WriteLine("Follow instructions on the next page to get started.");
Console.WriteLine("");
Console.Write("");
Thread.Sleep(300);
Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write("\r                                                 Strike any key to continue-->   ");
while(!Console.KeyAvailable)
{Console.CursorVisible = false;
    Thread.Sleep(authorAnimSpeed*2);
    Console.Write("\r                                                 Strike any key to continue--->   ");
    Thread.Sleep(authorAnimSpeed*2);
    Console.Write("\r                                                 Strike any key to continue---->  ");
    Thread.Sleep(authorAnimSpeed*2);
    Console.Write("\r                                                 Strike any key to continue ----> ");
    Thread.Sleep(authorAnimSpeed*2);
    Console.Write("\r                                                 Strike any key to continue  ---->");
    Thread.Sleep(authorAnimSpeed*2);
    Console.Write("\r                                                 Strike any key to continue   ----");
    Thread.Sleep(authorAnimSpeed*2);
    Console.Write("\r                                                 Strike any key to continue    ---");
    Thread.Sleep(authorAnimSpeed*2);
    Console.Write("\r                                                 Strike any key to continue>    --");
    Thread.Sleep(authorAnimSpeed*2);
    Console.Write("\r                                                 Strike any key to continue->    -");
    Thread.Sleep(authorAnimSpeed*2);
    Console.Write("\r                                                 Strike any key to continue-->    ");
}
Console.CursorVisible = true;
Console.ResetColor();
        // Wait for user to strike any key
        Console.ReadKey(true); // 'true' prevents the key character from appearing
        // Clear the console
        Console.Clear();

//Header:
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine(" - - ----======[ Exposure-to-Light Calculator v1.0 ]======---- - - ");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("                    --------------------------- Written by Mak, FlyingGoatFX");
Console.ResetColor();
Console.WriteLine("");

//Decide Irradiance Units:
Console.Write("Select units for ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("IRRADIANCE ");
Console.ResetColor();
Console.WriteLine("by entering item number from below, or ? for help:");
Console.WriteLine("   [1] Footcandles");
Console.WriteLine("     [2] Lux");
Console.WriteLine("       [3] Calculate from ISO, Shutter, Lens Speed, Exposure");
Console.WriteLine("         [?] Help");
string irrUserInput = Console.ReadLine();
byte irrUnitIn;
string irrUnitOut;
string irrSecUserInput = "ERROR";
if(irrUserInput == "?")
{
    Console.WriteLine("Footcandles-> 1 fc = irradiance from a candle at 1 foot");
    Console.WriteLine("       Lux-> 1 Lux = irradiance from a candle at 1 meter");
    Console.WriteLine("");
    Console.WriteLine("Irradiance can also be calculated as amount of light needed to");
    Console.WriteLine("photograph a surface of known reflectance, given camera/lens/film"); 
    Console.WriteLine("parameters.");
    Console.WriteLine("");
    Console.WriteLine("Make selection to continue: [1]fc, [2]Lux, [3]Calculate");
    irrSecUserInput = Console.ReadLine();
    if(irrSecUserInput == "?")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.Write("\r                     Goodbye.                                                           ");
            Thread.Sleep(1000);
            Console.Write("\r                  G o o d b y e.                                                        ");
            Thread.Sleep(authorAnimSpeed);
            Console.Write("\r               G  o  o  d  b  y  e .                                                    ");
            Thread.Sleep(authorAnimSpeed);
            Console.Write("\r            G   o   o   d   b   y   e  .                                                ");
            Thread.Sleep(authorAnimSpeed);
            Console.Write("\r         G    o    o    d    b    y    e   .                                            ");
            Thread.Sleep(authorAnimSpeed);
            Console.Write("\r      G     o     o     d     b     y     e    .                                        ");
            Thread.Sleep(authorAnimSpeed);
            Console.Write("\r   G      o      o      d      b      y      e     .                                    ");
            Thread.Sleep(authorAnimSpeed);
            Console.Write("\rG       o       o       d       b       y       e      .                                ");
            Thread.Sleep(authorAnimSpeed);
            Console.Write("\r      o        o        d        b        y        e       .                            ");
            Thread.Sleep(authorAnimSpeed);
            Console.Write("\r    o         o         d         b         y         e        .                        ");
            Thread.Sleep(authorAnimSpeed);
            Console.Write("\r  o          o          d          b          y          e         .                    ");
            Thread.Sleep(authorAnimSpeed);
            Console.Write("\r           o            d            b            y            e           .            ");
            Thread.Sleep(authorAnimSpeed);
            Console.Write("\r        o               d               b               y               e              .");
            Console.ResetColor();
            Thread.Sleep(authorAnimSpeed);
            Console.WriteLine("");
            irrUnitIn = Convert.ToByte(irrSecUserInput);
        }else {irrUnitIn = Convert.ToByte(irrSecUserInput);}
}else
    {
        irrUnitIn = Convert.ToByte(irrUserInput);
    }

if(irrUnitIn == 1)
{
    irrUnitOut = "Footcandles";
}
else if(irrUnitIn == 2)
{
    irrUnitOut = "Lux";
}
else{irrUnitOut = "Footcandles";}

//Print choice.  Calc uses fc, so special condition required:
if(irrUnitIn != 3){
Console.WriteLine(irrUnitOut);
Console.WriteLine("- - - - - - - - - - - - - - - -");
}else {
        Console.WriteLine("Calculate from Settings");
        Console.WriteLine("===============================");
        }

    

//establish irrValIn early, so can be referenced by calc:
double irrValIn = 0;

//Calculate from base reference 100ISO, 1/48s, f/4 => 160*sqrt(2)fc.  fstops squared when calculating mean factor, as fn = sqrt(2)^stops
//externally accessible variables:
double expStopsIn = 0.0;
double isoOut = 0.0;
double shutterValIn = 0.0;
double fnumOut = 0.0;
string expSuffix = "";
if(irrUnitIn == 3)
{
    Console.WriteLine("Enter ISO:");
    Console.ForegroundColor = ConsoleColor.Yellow;
    isoOut = Convert.ToDouble(Console.ReadLine());
    Console.ResetColor();

    Console.WriteLine("- - - - - - - - - - - - - - - -");

    Console.WriteLine("Enter Exposure Time, as denominator of 1 second:");
    Console.Write("1/");
    Console.ForegroundColor = ConsoleColor.Yellow;
    shutterValIn = Convert.ToDouble(Console.ReadLine());
    Console.ResetColor();
    double shutterOut = 1.000/shutterValIn;

       Console.WriteLine("- - - - - - - - - - - - - - - -");

    Console.WriteLine("Enter f-number or T-stop:");
    Console.Write("f/");
    Console.ForegroundColor = ConsoleColor.Yellow;
    fnumOut = Convert.ToDouble(Console.ReadLine());
    Console.ResetColor();

        Console.WriteLine("- - - - - - - - - - - - - - - -");

    Console.WriteLine("Expose for surface x stops over (under if x<0) 18% Grey, or (2^x*18)% reflectance");
    Console.WriteLine("i.e.:Rate ISO -/+x stops");
    Console.WriteLine("                                             (set x to zero to ignore)");
    Console.Write("x = ");
    Console.ForegroundColor = ConsoleColor.Red;
    expStopsIn = Convert.ToDouble(Console.ReadLine());
    double expGainOut = Math.Pow(2, expStopsIn);
    if(expStopsIn > 0 )
        {
            expSuffix = " +" + expStopsIn + "stops, ";
        }else if(expStopsIn < 0)
            {
                expSuffix = " " + expStopsIn + "stops, ";
            }else{expSuffix = ", ";}
    Console.ResetColor();

        Console.WriteLine("-");

    Console.WriteLine("-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-");
    Console.ForegroundColor = ConsoleColor.Yellow;

    double fcCalc = 160*Math.Sqrt(2) / (  (isoOut/100) * expGainOut * (shutterOut/(1.000/48.000)) * (Math.Pow(4/fnumOut, 2))  );
    Console.WriteLine("     " + isoOut + " ISO" + expSuffix + "1/" + shutterValIn + "s, at f/" + fnumOut + " = ");
    Console.WriteLine("     " + fcCalc + " Footcandles");
    irrValIn = fcCalc;//write to irrValIn, same as if user knew and entered fc value
    Console.ResetColor();
}else{irrValIn = irrValIn;}

//Ingest irradiance, and if fc, convert to lux, else keep:
if(irrUnitIn != 3)
{
    Console.WriteLine("Enter Desired Exposure, in " + irrUnitOut + ":");
    Console.ForegroundColor = ConsoleColor.Yellow;
    irrValIn = Convert.ToDouble(Console.ReadLine());//overwrite irrValIn if unit chosen
    Console.ResetColor();
    Console.WriteLine("-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-"); 
}else {irrValIn = irrValIn;}//if unit not chosen, irrValIn either already has calculated fc, or returns error (zero)
double luxOut;

Console.ForegroundColor = ConsoleColor.Yellow;
if(irrUnitIn == 1 || irrUnitIn == 3)//if fc(1) or calc(3), we used fc, so convert to lux
{
    luxOut = irrValIn * Math.Pow((1/0.3048), 2); //convert input value to lux if fc
    Console.WriteLine("     ...");
    Console.WriteLine("     " + irrValIn + " fc = " + luxOut + " Lux");
}else 
    { 
        luxOut = irrValIn; 
        Console.WriteLine("     ...");
        Console.WriteLine("     " + luxOut + "Lux (" + luxOut/Math.Pow((1/0.3048), 2) + "fc)");
    }
Console.ResetColor();
Console.WriteLine("-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-");
Console.WriteLine("===============================");
//Decide Distance Units:
Console.Write("Select units for ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("DISTANCE");
Console.ResetColor();
Console.WriteLine(":");
Console.WriteLine("[1] Feet      [2] Meters");
byte distUnitIn = Convert.ToByte(Console.ReadLine());
string distUnitOut;
if(distUnitIn == 1)
{
    distUnitOut = "Feet";
}else{distUnitOut = "Meters";}
Console.WriteLine(distUnitOut);

    Console.WriteLine("- - - - - - - - - - - - - - - -");

//Ingest distance, and if feet, convert to meters,else keep:
Console.WriteLine("Enter Distance from source, in " + distUnitOut + ", at which desired irradiance is measured");
Console.ForegroundColor = ConsoleColor.Yellow;
double distValIn = Convert.ToDouble(Console.ReadLine());
double meterOut;
Console.ResetColor();

    Console.WriteLine("-");

    Console.CursorVisible = false;
    Console.Write("Calculating ");
    Console.Write(@"--");
    Thread.Sleep(authorAnimSpeed);
        Console.Write("\r");//clear line

    Console.Write("Calculating ");
    Console.Write(@"\ ");
    Thread.Sleep(authorAnimSpeed);
        Console.Write("\r");//clear line

    Console.Write("Calculating ");
    Console.Write(@"| ");
    Thread.Sleep(authorAnimSpeed/2);
        Console.Write("\r");//clear line

    Console.Write("Calculating ");
    Console.Write(@"/ ");
    Thread.Sleep(authorAnimSpeed/2);
        Console.Write("\r");//clear line

//Unit conversion to meters if feet, then calculate lux@1m from inverse square falloff: Inew = Iold*(Rold/Rnew)^2
if(distUnitIn == 1)
{
    meterOut = distValIn*0.3048;
}else{meterOut = distValIn;}

double lumensCalc = luxOut*Math.Pow(meterOut, 2);

    Console.Write("Calculating ");
    Console.Write(@"--");
    Thread.Sleep(authorAnimSpeed/2);
        Console.Write("\r");//clear line

    Console.Write("Calculating ");
    Console.Write(@"\ ");
    Thread.Sleep(authorAnimSpeed/2);
        Console.Write("\r");//clear line

    Console.Write("Calculating ");
    Console.WriteLine(@"||");
    Thread.Sleep(authorAnimSpeed);

    Console.WriteLine(@"            \/");
    Console.CursorVisible = true;

Console.WriteLine("-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-");
Console.WriteLine("    " + luxOut + "Lux/" + luxOut/Math.Pow((1/0.3048), 2) + "fc" + " @ " + meterOut + "m/" + meterOut/0.3048 + "ft");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("     For a reading of " + irrValIn + " " + irrUnitOut + " at distance " + distValIn + " " + distUnitOut + "...");
Console.WriteLine("     ...");
Console.WriteLine("     Use " + lumensCalc + " lumen (lux@1m) light source");
Console.ResetColor();
Console.WriteLine("-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-._.-");
//Establish variables for exit screen and saves:
string exitScreenInput = "knights who say ni!";
string presetDirEnd = @"\";
string printDir = @"c:\";
byte printDirOpt = 1;
string dirConfirmation = "n";
string fileName = "knights who say ni!";
string infoBox = "A shrubbery!";
string[] printOutput = {"somebody", "once", "told me", "the world", "is gonna roll me"};

Console.WriteLine("Enter item letter from below to save data or proceed to exit:");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("[p]");
Console.ResetColor();
Console.Write(" Save and print to external .txt file");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write("           [x]");
Console.ResetColor();
Console.Write(" Proceed to exit");
Console.WriteLine(""); 
Console.WriteLine("");
Console.SetCursorPosition(0, Console.CursorTop-1);//scroll down then set cursor back to reserve space for exit prompt
    exitScreenInput = Console.ReadLine();
Console.WriteLine("");
//Begin save and dir prompt sequence if p selected:
if(exitScreenInput == "p")
{//while choice unconfirmed, prompt user to choose ending and confirm:
    do{
        Console.WriteLine("Choose where to save:");
        Console.WriteLine("   [1] " + System.Environment.UserName + "'s Downloads");
        Console.WriteLine("      [2] " + System.Environment.UserName + "'s Documents");
        Console.WriteLine("         [3] " + System.Environment.UserName + "'s Desktop");
        Console.WriteLine("            [4] Enter directory manually");
        printDirOpt = Convert.ToByte(Console.ReadLine());


        //choose default path based on option, else default to overwriting printDir entirely with user input string:
        switch (printDirOpt)
        {
            case 1:
            presetDirEnd = @"\Downloads";
            break;

            case 2: 
            presetDirEnd = @"\Documents";
            break;

            case 3:
            presetDirEnd = @"\Desktop";
            break;

            default:
            Console.WriteLine("- - - - - - - - - - - - - - - -");
            Console.WriteLine("Enter directory path manually:");
            Console.ForegroundColor = ConsoleColor.Blue;
            printDir = Console.ReadLine();
            Console.ResetColor();
            break;
        }
        if(printDirOpt!=4)
        {
            printDir = (@"C:\Users\" + System.Environment.UserName + presetDirEnd);//declare printDir once we have a DirEnd, only if using preset format
        }

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(printDir);
        Console.ResetColor();
        Console.WriteLine("Is this correct?");
        Console.WriteLine(" [y] YES, continue               [n] NO, retry");
        Console.WriteLine("           [x] Exit without saving");
        dirConfirmation = Console.ReadLine();

    }while(dirConfirmation != "y" && dirConfirmation != "x");
}

if(dirConfirmation == "x" || exitScreenInput == "x")
{
    exitScreenInput = "x";
}else if(dirConfirmation == "y")//dir confirmed and user doesn't want to exit (x) without saving
    {   Console.WriteLine("- - - - - - - - - - - - - - - -");
        Console.WriteLine("Enter a unique filename to save as.  Any existing");
        Console.Write("files with this name ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("WILL BE OVERWRITTEN:");
        Console.ResetColor();
        fileName = Console.ReadLine();
        Console.WriteLine("");

        if(irrUnitIn == 3)
        {
            infoBox = "    " + isoOut + " ISO" + expSuffix + "1/" + shutterValIn + "s, at f/" + fnumOut + " = " + irrValIn + "fc" + " (" + luxOut + "Lux)";
        }else {infoBox = "    None";}
        
        printDir = printDir + @"\" + fileName + "_lightcalc" + @".txt";
        printOutput = new string[]{fileName,
                                   "by " + System.Environment.UserName,
                                   "",
                                   "Exposure Info:",
                                   infoBox,
                                   "",
                                   "Output:",
                                   "    " + luxOut + "Lux/" + luxOut/Math.Pow((1/0.3048), 2) + "fc" + " @ " + meterOut + "m/" + meterOut/0.3048 + "ft",
                                   "    Radiance: " + lumensCalc + " lumens",
                                   "",
                                   "=============================================Printed Message:",
                                   "For " + irrValIn + " " + irrUnitOut + " at distance "  + distValIn + " " + distUnitOut,"...",
                                   "Use " + lumensCalc + " lumen (lux@1m) light source",
                                   "=============================================================",
                                   "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", 
                                   "                                          Generated using Exposure-to-Light Calculator v1.0",
                                   "                                                               Written by Michael Kreitzman",
                                   "                                                                                        || ",
                                  @"                                                                                        \/ ","","",
                                   "                                                                    github.com/FlyingGoatFX",
                                   "                                                                  instagram.com/flyinggoa7/",
                                   "                                                                  youtube.com/@FlyingGoatFX",
                                   "                                                                     FlyingGoatFX@gmail.com","","",
                                   "(c)MMXXVI FlyingGoatFX                                                                     "
                                   };
        File.WriteAllLines(printDir, printOutput);

        Console.CursorVisible = false;
        Console.WriteLine("");
        Console.Write("Doing the print to " + printDir);
        Console.Write(@" --");
            Thread.Sleep(authorAnimSpeed*2);
        Console.Write("\r");//clear line

        Console.Write("Doing the print to " + printDir);
        Console.Write(@" \ ");
            Thread.Sleep(authorAnimSpeed*2);
        Console.Write("\r");//clear line

        Console.Write("Doing the print to " + printDir);
        Console.Write(@" | ");
            Thread.Sleep(authorAnimSpeed*2);
        Console.Write("\r");//clear line
        
        Console.Write("Doing the print to " + printDir);
        Console.Write(@" / ");
            Thread.Sleep(authorAnimSpeed*2);
        Console.Write("\r");//clear line

        Console.Write("Doing the print to " + printDir);
        Console.Write(@" --");
            Thread.Sleep(authorAnimSpeed*2);
        Console.Write("\r");//clear line

        Console.Write("Doing the print to " + printDir);
        Console.Write(@" \ ");
            Thread.Sleep(authorAnimSpeed);
        Console.Write("\r");//clear line

        Console.Write("Doing the print to " + printDir);
        Console.Write(@" | ");
            Thread.Sleep(authorAnimSpeed);
        Console.Write("\r");//clear line

        Console.Write("Doing the print to " + printDir);
        Console.Write(@" / ");
            Thread.Sleep(authorAnimSpeed);
        Console.Write("\r");//clear line

        Console.Write("Doing the print to " + printDir);
        Console.WriteLine(@" _");
            Thread.Sleep(authorAnimSpeed);
        Console.CursorVisible = true;
        //printer code here
        Console.WriteLine("Done");
        exitScreenInput = "x";//exit condition to play footer
    }

Thread.Sleep(2000);

while(!Console.KeyAvailable && exitScreenInput == "x")
{   Console.CursorVisible = false;
        Thread.Sleep(authorAnimSpeed*2);
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write("\r                                                    Strike any key to ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("exit--->  ");
        Thread.Sleep(authorAnimSpeed*2);
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write("\r                                                    Strike any key to ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("exit----> ");
        Thread.Sleep(authorAnimSpeed*2);
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write("\r                                                    Strike any key to ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("exit ---->");
        Thread.Sleep(authorAnimSpeed*2);
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write("\r                                                    Strike any key to ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("exit  ----");
        Thread.Sleep(authorAnimSpeed*2);
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write("\r                                                    Strike any key to ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("exit   ---");
        Thread.Sleep(authorAnimSpeed*2);
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write("\r                                                    Strike any key to ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("exit>   --");
        Thread.Sleep(authorAnimSpeed*2);
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write("\r                                                    Strike any key to ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("exit->   -");
        Thread.Sleep(authorAnimSpeed*2);
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write("\r                                                    Strike any key to ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("exit-->   ");
}

if(exitScreenInput == "x")
{
    Console.CursorVisible = true;
    Console.ResetColor();
    Console.ReadKey();
    Console.Clear();
    Console.Write("                   :)");
    Thread.Sleep(authorAnimSpeed);
    Console.Write("\r                  T:)");
    Thread.Sleep(authorAnimSpeed);
    Console.Write("\r                 Th:)");
    Thread.Sleep(authorAnimSpeed);
    Console.Write("\r                Tha:)");
    Thread.Sleep(authorAnimSpeed);
    Console.Write("\r               Than:)");
    Thread.Sleep(authorAnimSpeed);
    Console.Write("\r              Thank:)");
    Thread.Sleep(authorAnimSpeed);
    Console.Write("\r             Thanks:)");
    Thread.Sleep(authorAnimSpeed);
    Console.Write("\r            Thanks :)");
    Thread.Sleep(authorAnimSpeed);
    Console.Write("\r           Thanks f:)");
    Thread.Sleep(authorAnimSpeed);
    Console.Write("\r          Thanks fo:)");
    Thread.Sleep(authorAnimSpeed);
    Console.Write("\r         Thanks for:)");
    Thread.Sleep(authorAnimSpeed);
    Console.Write("\r        Thanks for :)");
    Thread.Sleep(authorAnimSpeed);
    Console.Write("\r       Thanks for p:)");
    Thread.Sleep(authorAnimSpeed);
    Console.Write("\r      Thanks for pl:)");
    Thread.Sleep(authorAnimSpeed);
    Console.Write("\r     Thanks for pla:)");
    Thread.Sleep(authorAnimSpeed);
    Console.Write("\r    Thanks for play:)");
    Thread.Sleep(authorAnimSpeed);
    Console.Write("\r   Thanks for playi:)");
    Thread.Sleep(authorAnimSpeed);
    Console.Write("\r  Thanks for playin:)");
    Thread.Sleep(authorAnimSpeed);
    Console.Write("\r Thanks for playing:)");
    Thread.Sleep(authorAnimSpeed);
    Console.Write("\rThanks for playing!:)");
    Thread.Sleep(1500);
}

/*
double fcOut = fcIn;
double luxOut = fcOut * Math.Pow((1/0.3048), 2);

//Ingest feet and convert to meters
Console.WriteLine("Enter Distance, in feet, at which this Reading is measured:");
double distIn

Console.WriteLine(fcOut + "fc = " + luxOut + "lux");
Console.WriteLine("so...");*/
