# LightCalc
A lil exposure tool text game for Windows that takes input of desired exposure settings and distance from light source, then calculates the power of light source required to meet those parameters.
Also outputs unit conversions between metric and imperial.
_____________________________________________________
A light meter can be used to measure irradiance and determine what exposure parameters would best suit the shot.  This tool starts from either target exposure parameters or target irradiance and works backward to determine how radiant the light source should be.  These values can then be saved in a separate .txt file.  

LightCalc_Field is newer with quick and free editing of input parameters; while Guided is an older draft that's more like a guided tour through sequential inputs

  **PLEASE NOTE** that for now this uses just a bare basic inverse square falloff calculation that assumes a simple source.  
  Irradiance from lights with strong focusing lenses (lekos, large fresnels, etc.) may be pretty drastically underestimated depending on how much they're spotted, and light sources with egg crates/grid modifiers will be *overestimated* at closer distances.

Accuracy may vary--spherical cows or something.
