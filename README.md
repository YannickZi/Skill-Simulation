# Skill Simulation
A simulation of a competitive 1v1 game with generated players and basic matchmaking.

Compares the effectiveness of different rating systems in approximating the true skill of a player.

# Player Ratings
Skill:            The true skill of a player, used to calculte the outcome of a match

Elo:              Conventional Elo rating system, using k = 32

Reflecting Elo:   Uses the same calculation as Elo, but after each round of matches recalculates the last 5 rounds with the new Rating. Older matches are weighted less. Approaches true skill faster than normal Elo for a new player but is less stable.

# Player Attributes
Queue chance:   The likelihood of the player queueing in the next round

Drive:          Determines the rate at which Queue chance decreases after playing a match

Recharge:       Determines the rate at which Queue chance increased after not playing a match

Consistency:		Used to randomly modify the skill each match

Skill gain:			Determines how much a player improves after playing a match

Skill decay:		Determines how much a players skill deteriorates after not playing.

# Technologies
C#

SQLite for data storing

Windows Forms as a GUI
