![alt_text](https://github.com/frostie/Xerienstone/blob/master/Assets/Screen%20Shots/Xerienstone%20Title.png)

> _Currently in a protoype phase. Once original sprites are added, screen shots of gameplay will be added to the repo._

Xerienstone is a 2D breakout-style game with a medieval-fantasy theme. Destroy all stones to uncover the map for each level.

Genre: Action-Arcade

## Game Design

### Points & Effects

#### Charms
- Common Charm - 6 pts
- Blue Charm - 12 pts
- Indigo Charm - 24 pts
- Ivory Charm - 48 pts

#### Special Charm
- Life Charm - Adds 1 life to player lives

#### Orbs
> An orb is held in place by charms and will fall once the charms holding it are destroyed.
- Ice Orb - 100 pts; slows down ball speed by 25% for 10 seconds
- Fire Orb - 100 pts; destroys blocks within 1 unit radius

#### Special Items
- Power Ball - destroys all blocks in one hit without bouncing back for 5 seconds
- Multi Ball - fires 10 disposable balls to accompany the main ball in destroying stones

## Level Design
### TBD

## Next Actions
- Add rigidity to boundary colliders and paddle
- Add shop screen after every level clearance to purchase effects, etc.
- Add different point values for charms
- Add special items
- Increase/decrease ball speed for more complex levels
- Create "Win" screen when all levels cleared
- Create original logo and sprites
- Create medieval-themed UI which includes:
    - Player score
    - Player lives
    - Number of Xerienstones (TBD)
    - Active effects
- Add core gameplay screenshots to GitHub to illustrate elements of game
- Record original sound effects and music
- Write game synopsis
- Create online database for high scores
    - Write code to track user high scores in online database
- Deploy game on web browser for open beta testing!

## Bugs
- Ball velocity slows down as game progresses
- Sometimes the ball bounces back and forth between two colliders in a straight line and never bounces any other way
- The following error message appears when a charm is destroyed:
    - "IndexOutOfRangeException: Array index is out of range."
      > Note: Message does not affect game play

## Deployment
- Browser (website TBD)
- Desktop (PC, Mac, & Linux)
- Mobile (Android & iOS) TBD

## Credits
- Foundational code provided by Ben Tristem's and Rick Davidson's "Complete C# Unity Developer 2D: Learn to Code Making Games" tutorials
- "RPG Coins Set" sprites created by LoversHorizon
