
# Holographic AR Card 
![](./ReadmeAssets/UIDemo_01.png)
For this project, I decided to create a Pokemon card visualiser in AR. i sought to replicated some of the visible characteristics of the cards such as the holographic effects seen in some of the cards as well as some parallax and stencil effects seen in some of the Digital version of cards seen in the PokemonTCG pocket game.

# Web Demo
[Web Demo- mobile browser like google chrome recommended](https://rbocarro.github.io)

# Tracking Target
![](./ReadmeAssets/PrimeTween01.gif)<br/>
Use this if you do not have a pokemon card.

# Tools Used

## AR Foundation
![](./ReadmeAssets/PrimeTween01.gif)<br/>
AR foundation was used as it probided.... 

#### Link:
[PrimeTween](https://github.com/KyryloKuzyk/PrimeTween)


## Stencil Shader
![](./ReadmeAssets/ScriptableObject.png)<br/>
Unity’s ScriptableObject system was used to manage character data, including abilities, artwork, and profile information. This allows game designers to create and modify character data directly in the Unity Editor without altering code, promoting a clear separation between data and logic, making the system highly extensible and designer-friendly.

## Holographic Shader
![](./ReadmeAssets/shaderGraph01.png)![](./ReadmeAssets/ShaderGraph02.gif)
I used Unity’s Shader Graph to create the  scrolling background featured in the demo. The animated dot pattern is achieved through UV tiling and time-based displacement, which is then masked using an animated Simplex Noise node. A clipping threshold controls the visibility of the dots within the noise mask, producing a dynamic, organic motion effect. The grid overlay is animated in a similar manner, utilising UV tiling and displacement.

## Improvements
+ [Daniel-ilett](https://github.com/daniel-ilett/shaders-holo-card)
+ [cyanilux](https://www.cyanilux.com/tutorials/holofoil-card-shader-breakdown/)
+ [Rigor Mortis Tortoise](+ [Daniel-ilett](https://github.com/daniel-ilett/shaders-holo-card))
+ [ameye.dev](https://ameye.dev/notes/holographic-card-shader/)

## Improvements
+ Opening transition animations on Tracker Detection 












