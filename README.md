# Unity-2D-Movement
2D Movement for Top-Down or Stardew Valley type of games.

PlayerMovement script is using Unity's physics engine. Therefore, player object is required to have a rigidbody. Rigidbody is required to have Linear and Angular Drag according to needs. For example, an example on my game on https://typh13.itch.io/ called "They are coming!" settings are:

Rigidbody2D:
Linear Drag: 20
Angular Drag: 20

Player Movement:
Speed: 250

This provided enough drag and movement to match. However, the player will be faster if one tries to move on X and Y positions at the same time. Future updates may change it. 
