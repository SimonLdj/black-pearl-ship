# black-pearl-ship
*Reafactoring code-challenge for Black Pearl Ship crew*

## Description

Welcome to the black pearl!
In this code challenge you will be tasked to help the crew of the black pearl eat, drink and wage
war on the high sees.

The code in this repo implements a rudimentary simulation of some of the functions of the ship.  The
ship has a `Crew`, a `Captain` and various special `Department`s that perform specific functions.
The `Crew` and `Department`s are controlled by the `Captain`. In order to perform it's function,
each `Department` has various inputs that it needs to consume and outputs that it is required to
produce. Based on input from the `Crew` and output of these `Departemt`s, the `Captain` controls the
ship and  tells the crew what to do.

The ship's crew use the ships `Radio` to communicate their status to the `Captain` and/or
`Departments`, which then use that information to perform their function. Both the `Crew` and
`Department`s can produce their outputs at any point in time and update the `Captain` of
their status. Note that some `Department`'s input can depend on others' output.

## The Crew

The `Crew` can use the ship's `Radio` to inform the `Captain` of the following things:

- Hunger level
- Whether an enemy was detected

## Ship departments

There are currently three `Department`s the `Captain` consults with to control the Ship.

1. **Rum Hall** - Determines how much rum the crew should drink.
    - Inputs:
      - Time of day
      - Whether we recently hit an enemy ship
      - What kind of food is there to eat
    - Outputs:
        - Amount of rum the crew should drink (at the current time)

2. **Gun Deck** - Determines if the ship should fire on an enemy.
    - Inputs:
      - Time of day
      - Whether an enemy is in range
      - Enemy direction (if in range)
      - Amount of rum crew drank in the last hour
    - Outputs:
        - The number of the cannon that should be fired
        - Whether a target was hit (published some time after the above)

2. **Mess Hall** - Determines when, what and how much the crew should eat. 
    - Inputs:
      - Time of day
      - Crew hunger level
    - Outputs:
        - Type of food the crew should currently eat
        - How much food the crew should currently eat

## Challenge Instructions

Unfortunately, the code here was implemented by a one-armed, dim-witted cabin boy after a long night of
drinking rum, so the implementation is somewhat messy.

**TODO:** Describe what should be done as part of the challenge. Also describe how to run & compile the project (best if it's cross-platform).

## Submission Instructions

**TODO:** Describe how we expect the code to be submitted.

## License

**TODO**: Add a basic license & attribution.
