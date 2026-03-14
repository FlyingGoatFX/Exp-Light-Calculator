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
<br/>
<br/>
<br/>
<br/>
_ _ _ _ _
Note on old versions:
In the folder 'old' are some--you guessed it--older drafts, including a 'guided' version--this is an earlier draft that's more like a guided tour through sequential inputs and while comparatively verbose and sports shinier graphics, doesn't allow for live changes to previous inputs and doesn't run in a loop.
