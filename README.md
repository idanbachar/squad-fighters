# Squad Fighters

Squad Fighters is a multiplayer team battle game where three squads race to secure coin pickups and deliver them to base. The first team to hit the target score wins.

<p align="center">
  <img src="./images/cover/cover.png" width="450" alt="Squad Fighters cover" />
</p>

## Overview

- 3-team objective mode: Alpha, Beta, and Omega.
- Fast combat with shooting, revives, and post-death spectating.
- Randomized item placement each match.
- Team economy loop: collect, carry, and bank coins safely.

## Gameplay Goal

Collect coins around the map, survive fights, and return coins to your team base.
The first team to reach the required banked coin total wins the round.

## Controls

- W: Move forward
- A / D: Rotate player
- Space: Shoot
- R: Revive teammate (when in range and eligible)
- Tab: Show team player cards while held
- Right Arrow: Switch spectate target after death
- Esc: Exit game

## Teams

Choose one of three teams and push your squad to victory.

<table border="1" cellspacing="0">
  <tr>
    <th>Alpha</th>
    <th>Beta</th>
    <th>Omega</th>
  </tr>
  <tr>
    <td><img src="./images/teams/alpha_team.png" width="250" alt="Alpha team" /></td>
    <td><img src="./images/teams/beta_team.png" width="250" alt="Beta team" /></td>
    <td><img src="./images/teams/omega_team.png" width="250" alt="Omega team" /></td>
  </tr>
</table>

## Characters

Each team has a distinct character style and color identity.

<table border="1" cellspacing="0">
  <tr>
    <th>Alpha</th>
    <th>Beta</th>
    <th>Omega</th>
  </tr>
  <tr>
    <td><img src="./images/characters/alpha_character.png" width="100" alt="Alpha character" /></td>
    <td><img src="./images/characters/beta_character.png" width="100" alt="Beta character" /></td>
    <td><img src="./images/characters/omega_character.png" width="100" alt="Omega character" /></td>
  </tr>
</table>

## World Items

Items are scattered across the map and spawn in randomized locations.

<table border="1" cellspacing="0">
  <tr>
    <th>Ammunition</th>
    <th>Food</th>
    <th>Armor</th>
  </tr>
  <tr>
    <td><img src="./images/items/bullets.png" width="50" alt="Bullets" /></td>
    <td><img src="./images/items/banana.png" width="50" alt="Banana" /></td>
    <td><img src="./images/items/shield_lv1.png" width="50" alt="Shield level 1" /></td>
  </tr>
  <tr>
    <td>No additional ammo type</td>
    <td><img src="./images/items/orange.png" width="50" alt="Orange" /></td>
    <td><img src="./images/items/shield_lv2.png" width="50" alt="Shield level 2" /></td>
  </tr>
  <tr>
    <td>No additional ammo type</td>
    <td><img src="./images/items/pear.png" width="45" height="50" alt="Pear" /></td>
    <td><img src="./images/items/shield_rare.png" width="50" alt="Rare shield" /></td>
  </tr>
  <tr>
    <td>No additional ammo type</td>
    <td>No additional food type</td>
    <td><img src="./images/items/shield_legendery.png" width="50" alt="Legendary shield" /></td>
  </tr>
</table>

## Gallery

<table border="1" cellspacing="0">
  <tr>
    <td><img src="./images/gameplay/gameplay_1.png" width="350" alt="Gameplay 1" /></td>
    <td><img src="./images/gameplay/gameplay_2.png" width="350" alt="Gameplay 2" /></td>
    <td><img src="./images/gameplay/gameplay_3.png" width="350" alt="Gameplay 3" /></td>
  </tr>
  <tr>
    <td><img src="./images/gameplay/gameplay_4.png" width="350" alt="Gameplay 4" /></td>
    <td><img src="./images/gameplay/gameplay_5.png" width="350" alt="Gameplay 5" /></td>
    <td></td>
  </tr>
</table>

## Tech Stack

- Client: C#, MonoGame DesktopGL, .NET 10 (SquadFighters.Client)
- Server: C#, .NET Framework 4.8 (SquadFighters.Server)

## Getting Started

### Prerequisites

- Windows
- .NET 10 SDK
- Visual Studio 2022 (recommended)
- .NET Framework 4.8 Developer Pack (for the server project)

### Installation

1. Clone the repository:

```bash
git clone https://github.com/idanbachar/squad-fighters.git
cd squad-fighters
```

2. Restore client local tools (MonoGame content builder CLI):

```bash
cd SquadFighters.Client
dotnet tool restore
```

3. Restore NuGet packages and build the client:

```bash
dotnet restore
dotnet build
```

4. Build the server project in Visual Studio:

- Open SquadFighters.Server/SquadFighters.Server.sln.
- Build once in Debug or Release.

5. Return to the repository root:

```bash
cd ..
```

### Run the Server

1. Open SquadFighters.Server/SquadFighters.Server.sln in Visual Studio.
2. Build and run the server project.
3. The server listens on port 7895.

### Run the Client

1. Open SquadFighters.Client/SquadFighters.Client.sln (or the project) in Visual Studio.
2. Build and run the client.
3. Join a match from the main menu.

### Network Configuration

The client currently uses a hardcoded server IP in SquadFighters.Client/SquadFighters.cs.

- Update ServerIp to your server machine IP.
- Keep port 7895 unless you also change it on the server.
