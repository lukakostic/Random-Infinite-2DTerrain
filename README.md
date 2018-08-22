# 2DTerrain
Random Infinite 2D terrain in unity, to be used for driving on. Very simple code.

It gets randomly generated on start.


Put the script on an empty gameobject. That will add a polygon 2d collider and a line renderer. The line renderer needs to have a low width (to look nice) and world position bool set to false. "Loop" bool is optional.  
Currently the script sets all of the above, so you can comment those 4 lines out in the code's Start method if you are gonna set it manually from the inspector.  


##  


Setting the component's "Infinite" boolean to true will make it generate a connected terrain to the right.  
So if you want to infinitely drive you just need set the infinite bool of the terrain below you to true.  


When it generates the next terrain it puts it in the "nextTerrainOnRight" field. So if you want infinity then constantly set "Infinite" to true for the terrain below you if its "nextTerrainOnRight" field is set to null.  



