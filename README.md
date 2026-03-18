# LightCalc
A lightweight lil exposure/falloff tool in a text-game-style console app for Windows that takes input of desired exposure settings and distance from light source, then calculates the power of light source required to meet those parameters.
Also outputs unit conversions between metric and imperial.
_____________________________________________________
A light meter can be used to measure irradiance and determine what exposure parameters would best suit the shot.  This tool starts from either target exposure parameters or target irradiance and works backward to determine how radiant the light source should be.  These values can then be saved in a separate .txt file.  

It offers quick and free editing of input parameters, so the relationship between distance, exposure settings, and light can be observed, and changes made in realtime.  Edit any parameter, and the displayed radiance requirement will react instantly, giving a precise picture of how these parameters contribute to lighting needs and interfere with each other.

Right now, only radiance is targeted (and irradiance from exposure), so while finding something like 'the maximum distance for a specific light while maintaining acceptable exposure' isn't terribly difficult, it may require a bit of guess-and-check.

  **PLEASE NOTE** that for now this uses just a bare basic inverse square falloff calculation that assumes a simple source.  
  Irradiance from lights with strong focusing lenses (lekos, large fresnels, etc.) may be pretty drastically underestimated depending on how much they're spotted, and light sources with egg crates/grid modifiers will be *overestimated* at closer distances.
Accuracy may vary--spherical cows or something.

 Also note that I'm a film/photo/video guy, and that I have very little experience with C# coding outside of C-likes (see my DCTLs).  The flow and readability of the code isn't amazing, but it does do what it should do and seemingly smoothly from my own testing.  Any feedback welcome and very much appreciated.   
 
<br/>

### WHAT'S IT FOR?
Calculating light falloff, irradiance from exposure parameters, and/or radiance necessary to acheive the same, given distance from source.

### TO GET STARTED
You must have:
- A Windows x86 or x64 environment
- \>= 8.8 MB available storage space.
Start by downloading the .EXE.  (or compile from the source code .cs and .csproj files in something like Visual Studio.) 
Run LightCalc_Field.exe and ensure window and/or font is sized such that dimensions are >= 92x17. Use only with monospace fonts.  Uses CP437 character set.  Can be run as usual double-click or, better, from Powershell/CMD terminal.

### INTERFACE
If window/font size is sufficient, you can strike any key to clear the TITLE PAGE and enter the MAIN MENU.  Here, you can type and enter a letter corresponding to an action or parameter you'd like to enter or edit.  An EDIT MENU should descend that prompts for units, then a value.  When prompted for units or exposure parameter, a different letter from the main menu can be entered instead to hop between different parameters or actions.  Attempting the same from the input field for a value will return invalid and won't allow escape until a numerical value is entered.

Entering action "m" will, as stated, redraw the MAIN MENU with any saved values/params, close the EDIT MENU, and clear any glitchy or repeated lines.  If visual glitches persist, enter "t" from main menu to check window size.

### CALCULATIONS
Irradiance can be entered directly, or be calculated from exposure parameters.  Internally, a set with distinct subset sums is used to track filled parameters-- when sufficient data is entered for exposure or irradiance as well as distance from source, the required luminance is automatically drawn in the main menu.  Parameters can be edited at any time, in any order--the lumens output, irradiance and distance readouts, and exposure table (if applicable) should update the moment the return key is struck to enter an input.

While input data is insufficient or yields a radiance of either zero or infinite lumens, lumens readout will display "Not a Number", or "NaN."

To find, say, exposure parameter(s) from irradiance, a try-and-check approach can be used with relative ease, but I'd highly recommend consulting the dial on an analogue incident light meter (such as a Sekonic).

 >#### EXPOSURE MODE AND SWITCHING BACK TO DIRECT IRRADIANCE
>To enter input of exposure parameters, enter "e" for irradiance/exposure and enter option "\[3\] Calculate".  The EDIT MENU should now prompt you to select from ISO/shutter/ƒ/+stops parameters to edit. Redrawing ("m") and re-entering irr/exp ("e"), will lead back to this same menu, as does selecting and entering a value for one of the prompted exposure parameters.  To clear exposure parameters and return to direct irradiance input in footcandles or lux, enter "c" while in exposure mode when prompted to select from ISO/shutter/ƒ/+stops.  From here, you can then enter "m" to collapse exposure paramters into a single value in footcandles and return to menu, or select a unit of irradiance (currently either fc or lux) to reset irradiance/exposure entirely and enter a new value.

### COLOR MODES
From v1.11.0, you can enter "h" to toggle between different color modes.  'Default' is a simple grayscale scheme.  'Warm Light' has a gentler, orange or yellow (depending on terminal settings) color scheme--ideal for viewing in an environment with warm lighting, such as from tungsten or sodium.  'Dark Adapt' dims, tints the interface red, intended for comfortable viewing in darkness and to minimize photopupillary reflex from viewing a computer screen in an otherwise low-light environment.

//(add section on PRINTING, warning for onedrive users)
<br/>
<br/>
<br/>
<br/>
_ _ _ _ _
Note on old versions:
In the folder 'old' are some--you guessed it--older drafts, including a 'guided' version--this is an earlier draft that's more like a guided tour through sequential inputs and while comparatively verbose and sports shinier graphics, doesn't allow for live changes to previous inputs and doesn't run in a loop.
