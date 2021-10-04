# Flight-Sim-Project

**TO HELP UNDERSTAND THE GAME AND HOW THE SCRIPTS/VARIABLES WORK.** 
***We will be updating this regularly.***

Starting with the **Assets** folder:
  
  *Materials* - these are just the basic materials used for the planes, buildings and ground.
  
  *Prefabs* - this folder splits into both the PaperPlanes & Target Indicators folder. The Target Indicators here are used for the World empty object to see enemy/ally planes.(These go on the UI Controller scripts for "Target Indicator Prefab".)
  
  *Scenes* - these are the two scenes for this project file. Once again, I just like to keep my testing files separate from the actual game just to keep things less cluttered and organized. It's also easier on my CPU and allows me to have ONLY what I need in the actually game at all times so I don't get confused lol. Don't worry, I'm working on putting the actual full game file on GitHub as well.
  
  *Scripts* - this folder splits into the AI Scripts, Collision Avoid(Incomplete), & UI Controller Scripts folders.

    >*AI Scripts:* these scripts are the current AI scripts at the moment.(They go on the different paper plane prefabs.) Right now the Ally Follow AI script is the main one currently being used and modified. The "Torque" can be adjusted in increments of 1000 to make the AI move faster/sharper. And of course the "Player" on this script is whatever plane prefab desired for the enemy/ally. The E, N, and H Wander AI scripts were my first prototype AI.(E,N, and H stand for Easy, Normal, Hard difficulty.) They basically just wander around, but I had an issue with them going a little too far out of bounds. This could probaby be fixed however with some invisible walls and a Sphere Collider or something, in addition to an Out-Of-Bounds script that I'm working on. 
    >*Collision Avoid(Incomplete):* this folder has both the Ground Boundary & Ground Script. The Ground Boundary script will probably be renamed to Terrain Boundary at some point. It works with Sphere Colliders on the AI planes to keep them from getting stuck on the ground/buildings/terrain. Its not perfected yet however, and I'm still working on it. We will update this once it's finished. The "Player" of course is the plane prefab desired for the AI. The "Smooth" is useless and will be removed, pay it no mind for now. The "Torque" and "Rotation Speed" I've found to be best kept at 800 & 100. And then the Ground Script goes on the actual terrain Prefabs.(Make sure the tag on each terrain is set to "Terrain" or else it won't work at all.)
