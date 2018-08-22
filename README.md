# RandomTerrain2D.cs
Random Infinite 2D terrain in unity, to be used for driving on. Very simple code. Its in the RandomTerrain2D.cs in the repository.  

It gets randomly generated on start and has a 2d polygon collider.


Put the script on an empty gameobject. That will add a polygon 2d collider and a line renderer. The line renderer needs to have a low width (to look nice) and world position bool set to false. "Loop" bool is optional.  
Currently the script sets all of the above, so you can comment those 4 lines out in the code's Start method if you are gonna set it manually from the inspector.  


##  


Setting the component's "Infinite" boolean to true will make it generate a connected terrain to the right and set "Infinite" back to false  
So if you want to infinitely drive you just need set the infinite bool of the terrain below you to true.  


When it generates the next terrain it puts it in the "nextTerrainOnRight" field. So if you want infinity then constantly set "Infinite" to true for the terrain below you if its "nextTerrainOnRight" field is set to null.  


Delete on infinite will delete the current object as soon as it generates the next terrain.

##  

Whole thing is just 1 simple script.

![2dterrain03](https://user-images.githubusercontent.com/41348897/44438020-82ffbc00-a5bd-11e8-8e7f-9ff97247e5c8.png)

1 terrain.

![2dterrain01](https://user-images.githubusercontent.com/41348897/44438016-82672580-a5bd-11e8-9781-e5dca307186c.png)

2 terrains, "Infinite" was set to true on the first one so it generated another one next to it.

![2dterrain02](https://user-images.githubusercontent.com/41348897/44438019-82672580-a5bd-11e8-84dd-f9f1a9cc7748.png)

4 terrains.

![2dterrain04](https://user-images.githubusercontent.com/41348897/44438021-82ffbc00-a5bd-11e8-9fd7-dff640e3ee20.png)
