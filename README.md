# Unity HDRP Image Synthesis
 
## Table of Contents
* [General Info](#general-info)
* [Technologies](#technologies)
* [Setup](#setup)
* [Features](#features)
* [Credits](#credits)

## General Info
This project is a combination of Custom Pass effects within Unity's HDRP with the goal of using the effects for compressing data for cloud based gaming.
	
## Technologies
Project is created with:
* Unity 2021.2.3f1
* C# and HLSL
* HDRP 12.0+
	
## Setup
To make use of these Custom Pass effects, this project has been created in a fashion that allows for quick implementation in to any project.

* Import the Image Synthesis folder from this repository in to the scene
* Drag and drop the "Image Synthesis Volumes" prefab in to the scene
* Optionally, there's also a "Image Synthesis Canvas" prefab you can place in the scene for a "debug" screen of all the effects

### Object Segmentation Setup

Object Segmentation works slightly different than the other effects and requires some extra setup to output to a render texture:
* Make a custom layer named "ObjectID"
* Remove this layer from your main camera's volume mask (Camera -> Environment -> Volume Mask)
* Apply this layer to the "Object Segmentation" object (This a child of the "Image Synthesis Volumes" prefab)
* Duplicate your scene's main camera
* Make the duplicate a child of the main camera
* Drag and drop the "Object Segmentation" Render Texture from the "Render Textures" folder on to the duplicated camera's target texture (Camera -> Output -> Target Texture)

## Features

### Sample Scene
![default](https://github.com/Dylarno/Unity-HDRP-Image-Synthesis/blob/main/GIFs/color.gif)

### Object Normals
![normals](https://github.com/Dylarno/Unity-HDRP-Image-Synthesis/blob/main/GIFs/normalmap.gif)

### Depth
![depth](https://github.com/Dylarno/Unity-HDRP-Image-Synthesis/blob/main/GIFs/depth.gif)

### Roughness:
Perceptual roughness from the camera's normal buffer
![roughness](https://github.com/Dylarno/Unity-HDRP-Image-Synthesis/blob/main/GIFs/rough.gif)

### Object Segmentation:
Gives a unique colour to each object within the scene based on their ID
![object segmentation](https://github.com/Dylarno/Unity-HDRP-Image-Synthesis/blob/main/GIFs/objectID.gif)

### Optical Flow
![optical flow](https://github.com/Dylarno/Unity-HDRP-Image-Synthesis/blob/main/GIFs/opticalflow.gif)

### Motion Vectors
![motion vectors](https://github.com/Dylarno/Unity-HDRP-Image-Synthesis/blob/main/GIFs/motionvectors.gif)

## Credits
* https://github.com/alelievr/HDRP-Custom-Passes/tree/master/Assets/CustomPasses/CopyPass
* https://github.com/Unity-Technologies/Graphics/blob/master/com.unity.render-pipelines.high-definition/Documentation~/Custom-Pass-Creating.md
