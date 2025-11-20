
# Holographic AR Card 
![](./ReadmeAssets/UIDemo_01.png)
For this project, I decided to create a Pokemon card visualiser in AR. I sought to replicated some of the visible characteristics of the cards such as the holographic effects seen in some of the cards as well as a stencil effect seen in some AR and games. 


# Web Demo
[Web Demo- mobile browser like google chrome recommended](https://rbocarro.github.io)

# Tracking Target
![](./ReadmeAssets/PrimeTween01.gif)<br/>
Use this if you do not have a pokemon card.

# Tools Used

## AR Foundation
![](./ReadmeAssets/PrimeTween01.gif)<br/>
AR foundation was used as it provided a straightforward framework for implementing image Tacking. It was important to set the image tracking size to the real world scale of a standard Pokemon TCG (63.5 to )


## Stencil Shader
![](./ReadmeAssets/ScriptableObject.png)<br/>
Unity’s ScriptableObject system was used to manage character data, including abilities, artwork, and profile information. This allows game designers to create and modify character data directly in the Unity Editor without altering code, promoting a clear separation between data and logic, making the system highly extensible and designer-friendly.

## Holographic Shader
![](./ReadmeAssets/shaderGraph01.png)![](./ReadmeAssets/ShaderGraph02.gif)
I used Unity’s Shader Graph to create the Holographic effect.it uses the view direction node in tangent space.

## References
+ [Mimikyu Model by AlmondFeather](https://sketchfab.com/3d-models/mimikyu-ad2aaa7bb372441984f40df49854b3eb)-[Twitter](https://x.com/AlmondFeather)
+ [Daniel-ilett](https://github.com/daniel-ilett/shaders-holo-card)
+ [cyanilux](https://www.cyanilux.com/tutorials/holofoil-card-shader-breakdown/)
+ [Rigor Mortis Tortoise](https://www.youtube.com/watch?v=rYsWYjHzaMY&t=1s)
+ [ameye.dev](https://ameye.dev/notes/holographic-card-shader/)














