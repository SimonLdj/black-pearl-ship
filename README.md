# black-pearl-ship
*Refactoring code-challenge*

```
                                                    _  _
                                                   ' \/ '
   _  _                        <|
    \/              __'__     __'__      __'__
                   /    /    /    /     /    /
                  /\____\    \____\     \____\               _  _
                 / ___!___   ___!___    ___!___               \/
               // (      (  (      (   (      (
             / /   \______\  \______\   \______\
           /  /   ____!_____ ___!______ ____!_____
         /   /   /         //         //         /
      /    /   |         ||         ||         |
     /_____/     \         \\         \\         \
           \      \_________\\_________\\_________\
            \         |          |         |
             \________!__________!_________!________/
              \|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_/|
               \    _______________                /
^^^%%%^%^^^%^%%^\_"/_)/_)_/_)__)/_)/)/)_)_"_'_"_//)/)/)/)%%%^^^%^^%%%%^
^!!^^"!%%!^^^!^^^!!^^^%%%%%!!!!^^^%%^^^!!%%%%^^^!!!!!!%%%^^^^%^^%%%^^^!
```

## Description

Welcome to the black pearl challenge!  In this code challenge you will be tasked to help the crew of
a notorious pirate ship drink considerable amounts of rum, eat rancid moldy food and wage war on the
high sees against unsuspecting trade vessels.

The code in this repo implements a rudimentary simulation of some of the functions of the pirate
ship.  The ship has a `Crew`, a `Captain` and various special `Department`s that perform specific
functions.  The `Crew` and `Department`s are controlled by the `Captain`. In order to perform it's
function, each `Department` has various inputs that it needs to consume and outputs that it is
required to produce. Based on input from the `Crew` and output of these `Departemt`s, the `Captain`
controls the ship and  tells the crew what to do.

The ship's `Crew` uses the `Radio` to communicate their status to the `Captain` and/or
`Departments`, which then use that information to perform their function. Both the `Crew` and
`Department`s can produce their outputs at any point in time and update the `Captain` of
their status. Note that some `Department`'s input can depend on others' output.

## The crew

The `Crew` can use the ship's `Radio` to inform the `Captain` of the following things:

- Number of days at sea
- Current time of day
- Hunger level
- Whether an enemy ship was detected
- Messages to the captain

## Ship departments

There are currently three `Department`s the `Captain` consults with to control the Ship.

1. `RumHall` - Determines how much rum the crew should drink.
    - Inputs:
      - Time of day
      - Number of days at sea
      - Whether we recently hit an enemy ship
      - What kind of food is there to eat
    - Outputs:
        - Amount of rum the crew should drink (at the current time)

2. `GunDeck` - Determines if the ship should fire on an enemy.
    - Inputs:
      - Time of day
      - Whether an enemy is in range
      - Enemy direction
      - Amount of rum crew drank in the last hour
    - Outputs:
        - The number of the cannon that should be fired
        - Whether a target was hit (published some time after the above)

3. `Galley` - Determines when, what and how much the crew should eat.
    - Inputs:
      - Time of day
      - Crew hunger level
    - Outputs:
        - Type of food the crew should currently eat
        - How much food the crew should currently eat

## Challenge Instructions

Unfortunately, the code here was implemented by a dim-witted, one-armed monkey after a long night of
drinking rum, so the implementation is somewhat messy.  In this challenge, you're tasked to refactor
the monkey's code into something more maintainable and testable and then add some necessary
functionality.

Due to the monkey's poor performance as a ship's programmer, he was transferred to the `CrowsNest`
department - a small platform on top of the tallest mast from which he is to observe. After the
`GunDeck` fires upon an enemy ship, he must report whether it was hit by the cannons (instead of the
`GunDeck`).

In addition, due to the updated responsibilities of various parts of the ship, the `Captain` feels
that the ship's software is getting more difficult to test. Therefor, he would like to you implement
the `CaptainsLog`, a special part of the ship that records everything that happens aboard, such as
`Radio` broadcasts and `Department` outputs along with their time. The `CaptainsLog` should only be
in use when testing the ships functions, not during normal operations.

### Tasks for challenge completion

1. Refactor the code in a way that will make implementing all of the above
   requirements (both new and original) as easy and straightforward as possible.
   You can use the console output before and after refactoring as an indicator
   that the code still works.  Notes:
    - Feel free to change as much of the code as you want, just make sure all
      of the original requirements are still met after the refactor.
    - Prioritize refactoring software design problems, not trivialities or cosmetic issues.
    - Assume that more departments and many more data-dependencies (between
      different departments) will be added to the code in the future.
    - After refactoring, commit your code before continuing to the next task.
2. After your refactored code works properly, implement the `CrowsNest` department.
3. Implement the `CaptainsLog`. Make sure it doesn't exist during the normal function of the ship.
4. Create an automated test for the ship's `Department`s. The test should generate fake `Radio` broadcasts from the
   `Crew`, and use the `CaptainsLog` to test for the expected output and behaviours.

## Submission Instructions

Ask for instructions from the Black Pearl Ship crew.

## License

**TODO**: Add a basic license & attribution.
