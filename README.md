# BDSP Randomizer
A tool to randomize your Brilliant Diamond/Shining Pearl game. 

# Setup

- Clone this repo
- Compile

# Compiling

Compile using Visual Studio. 

# Usage

Use UABEA to extract the necessary sheets from your game's assets.
(until i finish implementing Assettools.net and making this step obsolete)

The usage for all programs is the same: 
  place your dumped monobehavior into the resources folder.
  Remove the CAB-**** from the filename so it should look like.
  FieldEncountTable_*.txt
  tick your checkboxes you want active Levels or encounters or both.
 
 Output txt will have a trailing _rand. Remove it, 
 import back the txt in the gamesettings bundle then patch with atmo/yuzu.  
 
 # Sheets to extract
 
 - For encounters: Dpr/scriptableobjects/gamesettings/FieldEncountTable_d/p
 
 # Other info(PLEASE READ)
 
 - If you indeed use any code in here for your own project, please credit.
 - Contributions are always nice.
 - I do plan on adding trainer/tm/item randomizing as well. 
 
 # Credits
 
 - Me for being bored and wanting to do it.
 - XLuma for releasing a more complete randomizer a day before I finished mine (and for the readme i stole).
 