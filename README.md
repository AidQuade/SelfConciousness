# selfconcious

   This github will serve as the blog and progress updates for the top down shoot em up game I am working on. 
   
   # HOW TO PLAY
     This game is a top down shooter utilizing a mechanic where the player can switch into any enemies body and then takes control of that body until death or they are able to switch again. 
     LEFT SHIFT: Pop out of current body into an orb of conciousness, colliding into any enemy as this orb will take control of their body instead. This kills your current body. There is a small bullet time effect when initially leaving the body in order to help the player get into an enemy.
     BEWARE - you can only survive as a concious orb for so long outside of a body so find one quick.
     Each enemy has different weapon types, health, move speed and some enemies have special abilities.
     Some enemies fire by holding down left click while others fire semi automatically on each click
     SPACE: Use current bodies special ability if applicable
     Try to reach the exit of the level, killing and switching along the way to get a higher score.
     TIPS:
     -It can be difficult to survive long at first but switching is always the better option then trying to fight it out in a low health body
     
   
  # Initial brainstorming/ Concept Sketches
  
<div style="display:flex">
<img src="https://user-images.githubusercontent.com/60955272/122830226-4b517b00-d2a5-11eb-95c7-130cee14d2d5.jpg" width="40%" height="500">
<img src="https://user-images.githubusercontent.com/60955272/122830233-4e4c6b80-d2a5-11eb-87a7-a6bb9ee627fe.jpg" width="40%" height="500">
<img src="https://user-images.githubusercontent.com/60955272/122830241-4ee50200-d2a5-11eb-8ec4-6f2366a8974d.jpg" width="40%" height="500">
<img src="https://user-images.githubusercontent.com/60955272/122830245-50aec580-d2a5-11eb-8274-fe9b226d0bb1.jpg" width="40%" height="500">
</div>

  # Progress 1 Brainstorming and concept
  First I settled on the concept of a top down shooter game with the core mechanic of "Switching" between the playable character, making the enemies playable as well. The switching will serve as a way to reset health, use different weapons or take advantage of the enemies attributes like higher health, speed and specific more complex attributes later in the game. I formulated a plan to execute this game within 8 weeks and hope to have a working playable demo with a few levels by then.
      
   # Progress 2 Initial top down shooter setup.
This second week I did not get as far as I would have liked on the core switching mechanics and instead just focused on making a working top down shooter base with enemies that have AI to roam randomly, target the player within range and stop or retreat based on the distance of the player. There is no technical single "player" character as any character that is attacking the player needs to also have the ability to be switched into and thus toggle off their state as an AI and give control to the player.
  
  # Progress 3 Switching mechanic
  After trying two different methods I settled on using a collision based switching. When the left shift key is pressed the loose conciousness or soul that was in the character being controlled pops out and the character dies. The player now controls this small orb and time slows down slightly. This orb can pass through some walls within the level and cannot take damage, however the player can only survive in this orb state for five seconds so they must quickly switch into another enemy by colliding into them as the orb.

# Progress 4 Tileset creation and enemies
   I created a couple different sets of tiles in order to be able to use a 2D tileset asset to start designing levels for the game in order to test out how different feautures im adding will affect the gameplay. Laying out the level I used Tileset colliders in order to make the environment work with the movement and contain the character and enemies. I also created the first couple enemies with different properties like health, movespeed and shooting speed so that there would be variation to test while switching between them.
 
 # Progress 5 Improving switching mechanic and adding more enemies with variations
 This week I fixed the switching to be more responsive and shortened the amount of time the player can survive while switching while also putting the switch ability on a cool down so it cant be abused to beat levels. I also added a couple more enemies with variations in their attributes and began to create different shooting styles with different projectile types for each enemy.
 # Progress 6 Adding more art assets and testing different level designs
   I have been trying out different aspects of level design in my test level in order to decide which types of levels will be best for my gameplay moving forward and creating official different levels to progress through. I also have been adding more pixel art assets with animations to them for the enemies and projectiles.
   # Progress 7 Adding finished levels and UI elements as well as the progression of beating and moving between levels.
