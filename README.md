# LightCalc
A lightweight lil exposure tool in a text-game-style console app for Windows that takes input of desired exposure settings and distance from light source, then calculates the power of light source required to meet those parameters.
Also outputs unit conversions between metric and imperial.
_____________________________________________________
A light meter can be used to measure irradiance and determine what exposure parameters would best suit the shot.  This tool starts from either target exposure parameters or target irradiance and works backward to determine how radiant the light source should be.  These values can then be saved in a separate .txt file.  

It offers quick and free editing of input parameters, so the relationship between distance, exposure settings, and light can be observed, and changes made in realtime.  Edit any parameter, and the displayed radiance requirement will react instantly, giving a precise picture of how these parameters contribute to lighting needs and interfere with each other.

Right now, only radiance is targeted (and irradiance from exposure), so while finding something such as 'the maximum distance for a specific light while maintaining acceptable exposure' isn't terribly difficult, it may require a bit of guess-and-check.

  **PLEASE NOTE** that for now this uses just a bare basic inverse square falloff calculation that assumes a simple source.  
  Irradiance from lights with strong focusing lenses (lekos, large fresnels, etc.) may be pretty drastically underestimated depending on how much they're spotted, and light sources with egg crates/grid modifiers will be *overestimated* at closer distances.

Accuracy may vary--spherical cows or something.
<br/>
<br/>
### WHAT'S IT FOR?
Calculating light falloff, irradiance from exposure parameters, and/or radiance necessary to acheive the same, given distance from source.

### HOW TO USE
To get started, strike any key to enter the MAIN MENU.  From here, you can type and enter a letter corresponding to an action or parameter you'd like to enter or edit.  An EDIT MENU should descend that prompts for units, then a value.  When prompted for units or exposure parameter, a different letter from the main menu can be entered instead to hop between different parameters or actions.  Attempting the same from the input field for a value will return invalid and won't allow escape until a numerical value is entered.  

Irradiance can be entered directly, or be calculated from exposure parameters.  Internally, a set with distinct subset sums is used to track filled parameters-- when sufficient data is entered for exposure or irradiance as well as distance from source, the required luminance is automatically drawn in the main menu.  Parameters can be edited at any time, in any order--the lumens output, irradiance and distance readouts, and exposure table (if applicable) should update the moment the return key is struck to enter an input.

While input data is insufficient or yields a radiance of either zero or infinite lumens, Lumens readout will read "Not a Number", or "NaN."

To find exposure parameter(s) from irradiance, a try-and-check approach can be used, but I'd highly recommend consulting the dial on an analogue incident light meter (such as a Sekonic).

### COLOR MODES
Starting with v1.11.0, you can enter "h" to toggle between different color modes.  'Default' is a simple grayscale scheme.  'Warm Light' has a gentler, orange or yellow (depending on terminal settings) color scheme--ideal for viewing when in an environment with warm lighting, such as from tungsten or sodium.  'Dark Adapt' dims, tints the interface red, intended for comfortable viewing in darkness and to minimize photopupillary reflex from viewing a terminal screen in an otherwise low-light environment.

//(add section on PRINTING)
<br/>
<br/>
<br/>
<br/>
_ _ _ _ _
Note on old versions:
In the folder 'old' are some--you guessed it--older drafts, including a 'guided' version--this is an earlier draft that's more like a guided tour through sequential inputs and while comparatively verbose and sports shinier graphics, doesn't allow for live changes to previous inputs and doesn't run in a loop.
