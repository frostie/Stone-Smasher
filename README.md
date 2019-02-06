# Xerienstone
A 2D breakout-style game.

Note: The game is currently in a protoype phase. Once original sprites are created, screen shots of game play will be added to the repo.

Genre: Action

Theme: Medieval

## Game Design

### Points & Effects

#### Regular Stones
- Bronze Stone - 6 pts
- Silver Stone - 12 pts
- Gold Stone - 24 pts
- Platinum Stone - 48 pts

#### Special Stones
- Life Stone - Adds 1 life to player lives

#### Orbs
    Orbs are held in place by stones and will fall once the stones holding it are destroyed.
- Ice Orb - 100 pts; slows down game speed for 10 seconds
- Fire Orb - 100 pts; destroys blocks within 1 unit radius

#### Special Items
- Power Ball - destroys all blocks in one hit without bouncing back for 5 seconds
- Multi Ball - fires 10 disposable balls to accompany the main ball in destroying stones

## Level Design
### Level 1:
- 1-hit stones (30)

### Level 2:
- 1-hit stones (30)
- 2-hit stones (3)

## Next Actions
- Add different point values for stones
- Create "Win" screen when all levels cleared
- Create original logo and sprites
- Add core gameplay screenshots to GitHub to illustrate elements of game
- Record original sound effects and music
- Create online database for high scores
    - Write code to track user high scores in online database

## Bugs
- The following error message appears when a stone is destroyed:
    - "IndexOutOfRangeException: Array index is out of range."
      - Note: Message does not affect game play.
                
## Credits
- Foundational code provided by Ben Tristem's and Rick Davidson's "Complete C# Unity Developer 2D: Learn to Code Making Games" tutorials
