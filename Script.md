## Intro to Unity - getting set up [~15m]

* Poll class knowledge
* Discuss engine
  * General concept and strengths / weaknesses
  * [if needed] Getting started
  	* Project structure
  	* Editor interface
* Discuss workflows
  * Programming model
  * Use of external tools
  * Asset store, plugins, SDKs

## Example walkthrough [~50m]

### Simple component [~15m]
* Create sphere
* Create GlowCycle script
  * Make sphere change colors and size in Update()
* Create new transparent material
* Show how to create "halo"
* Replace sphere model with Stanford bunny

### Basic VR setup [~20m]

* Enable VR in project settings
* Press play, demonstrate eye camera
* Gaze interaction
  * Create UserActionReceiver component with bool property
  * Create UserGazeSource component
* Make interactive object into prefab; add copies to scene

### VR hand controllers [~15m]

* SteamVR plugin setup
  * Import SteamVR plugin
  * Make new scene
    * Remove Main Camera from scene
    * Add CameraRig to scene
  * Press play, show controller models
* Create UserTouchSource component
* Enhance interaction by playing a sound
  * Import audio clip
  * Create InteractiveSoundPlayer component
  * Add events to UserActionReceiver

### Discussion and free work [~25m]
