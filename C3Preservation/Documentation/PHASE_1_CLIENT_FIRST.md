# Phase 1 — Client-first build plan

## Milestone A: Hardware and engine readiness
- Confirm Windows version, exact CPU, GPU model, and dedicated/integrated graphics memory.
- Install Epic Games Launcher updates and verify the engine install location has sufficient free SSD space.
- Install a stable Unreal Engine 5 release through the Launcher. If Launcher install continues failing, use Epic's official troubleshooting and installation documentation; do not use unofficial repackaged engine installers.

## Milestone B: First playable prototype
- Create Games > Third Person > C++ project named `C3Preservation`.
- Use a scalable renderer configuration appropriate to the verified GPU.
- Build and launch the default map.
- Verify movement, jump, camera, and packaged Development build.

## Milestone C: First Chapter 3-inspired slice
- Create a small original test area with grass, a shoreline, a hill, and a few buildings.
- Add a basic loot pickup and inventory placeholder.
- Add a simple storm boundary prototype.
- Build the first custom HUD using Unreal UMG.

## Later phases
- Expand the island and points of interest using original/licensed assets.
- Add weapons, vehicles, match flow, and solo gameplay.
- Add dedicated servers, matchmaking, and accounts after the local client loop is stable.
- Build the custom desktop launcher after game startup arguments and versioning are defined.

## Definition of done for Phase 1
A source-controlled Unreal C++ project opens, builds, and launches a third-person test map on this PC.
