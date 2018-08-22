# 2DTerrain
Random Infinite 2D terrain in unity, to be used for driving on. Very simple code.

It gets randomly generated on start. Setting the component's "Infinite" boolean to true will make it generate a connected terrain to the right.


So if you want to infinitely drive you just need set the infinite bool of the terrain below you to true.


Make sure not to set it multiple times as that will create multiple terrains next to it, which is probably what you dont want.  
So you might want to add a Transform field called child or something and add the next terrain to it to keep track if it already made the next terrain or not  


I didnt add it because the whole infinite thing was added last minute and i wouldnt want to make the code longer.  


Put the script on an empty gameobject. That will add a polygon 2d collider and a line renderer. The line renderer needs to have a low width (to look nice) and world position bool set to false.Loop bool is optional.  
Currently the script sets all of the above, so you can comment those 4 lines out in the code if you are gonna set it manually from the inspector.  
