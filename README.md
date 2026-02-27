# LightCalc
A lil exposure tool for Windows that allows input of desired exposure settings and distance from light source, then calculates the power of light source required to optimally meet those parameters.  
Also outputs unit conversions between metric and imperial.
_____________________________________________________
A light meter can be used to measure irradiance and determine what exposure parameters would best suit the shot.  This tool starts with either target exposure 
parameters or target irradiance and works backward to determine how radiant the light source should be.  These values can then be saved in a separate .txt file.

Idea being that this could save a bit of time crunching numbers when planning shots or choosing lamps.  

  **NOTE** that for now this uses just a bare basic inverse square falloff calculation that assumes a bare, diffused, or open-face source.
  Due to difference between physical and apparent distance, irradiance from lights with strong focusing lenses (lekos, large fresnels, etc.) 
  may be pretty drastically underestimated depending on how much they're spotted, and light sources with egg crates/grid modifiers will be overestimated 
  at closer distances.

Accuracy may vary--spherical cows or something.

Oh, also--if you're a OneDrive user and want to save to desktop, don't select the preset desktop file path or the terminal will crash.
