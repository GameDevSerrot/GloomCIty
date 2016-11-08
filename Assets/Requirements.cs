using UnityEngine;
using System.Collections;

public class Requirements : MonoBehaviour
{
    /*
    Create a city builder style game similar Clash of Clans, Castle Crush, DomiNations, SimCity, etc.
        Only create the single player portion of the game.
    GUI
        [x]Include a splash screen with your 'logo'
        [x]Instead of a main menu, use a loading screen with progress bar (fake it for now).
        [x]Include a GUI in your game depicting 2 types of resources (gold/food, stone/wood, etc.)
            [x]Include a build button
                [x]When the player clicks on the build button, open up the building menu.
                    [x]The building menu should display all the buildings in the game as buttons.
                    [x]When the user clicks on a building button, the menu disappears, and the user can place the building on the game map.
                    [ ]Gray out any buildings the user cannot build (hit build limit, not enough resources, haven't researched the building type yet, not enough workers, etc.)
                    [ ]When the player taps a grayed out building, pop-up a message box telling them why they cannot create the building.

    Buildings
        [x]Include resource buildings for each of your resource types (farm, market, etc.)
            [x]Resources should accumulate in the building
            [x]When the player clicks on the building, the resources in the building are set to 0 and added to the player's pool (and displayed on the GUI)
            [x]When the building hits it's storage limit, display an icon above the building to inform the player.
        [x]Include storage buildings for each type of resource (silo, bank, etc.)
            [x]The storage buildings determines how much of each resource the player can accumulate
            [ ]When the player hits their resource limit, they cannot earn any more resources (cap it)
            [x]The player can use research on the storage buildings to increase the storage limits
        [x]Include a worker building (house(s), or workshop).
            [ ]Either can purchase workers (use a GUI), or build a house for each worker (building menu).
        [x]Include a town-house building (some resource storage, other functions?).
            [ ]Town-house should be upgradeable.
            [ ]Each upgrade gives bonuses (more potential workers, more buildings, etc.)
        [x]Include barracks (if a combat game, if not a combat game, what else could you do?)
            [x]Clicking on barracks should bring up troop menu where player can select troop to build (queue it up)
            [ ]Barracks should be upgrade-able (more troops)
            [x]Queued troops should be built over time (like resources).
            [x]Troops should just hang out on top of barracks or around barracks (on terrain owned by the barracks)
            [x]Include two types of troops.
        Note: you will need some GUI panels with buttons to upgrade each building
            [ ]The panel should display the cost of the upgrade
                [ ]Include OK and Cancel buttons (OK starts the upgrade)
                [ ]Disable the OK button if the player cannot upgrade the building (level limit, not enough resources, etc.)
*/
}
