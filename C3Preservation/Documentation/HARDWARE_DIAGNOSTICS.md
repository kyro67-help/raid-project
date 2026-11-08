# Hardware diagnostics

The description “AMD Ryzen 7 6000 HD series” is not precise enough to determine the graphics hardware. Ryzen 7 is the CPU family; Radeon graphics may be integrated, and there may also be a separate GPU.

## Get exact model names
1. Press `Ctrl + Shift + Esc` to open Task Manager.
2. Select **Performance**.
3. Click **CPU** and copy the full model name shown at the top right.
4. Click **GPU 0** and **GPU 1** (if present) and copy each full model name.
5. In Task Manager's GPU panels, note **Dedicated GPU memory** and **Shared GPU memory**.
6. Open **Settings > System > About** and note the Windows edition/version and System type.

Alternative: press `Win + R`, enter `dxdiag`, press Enter, then check the **System** and **Display** tabs. Use the exact names shown there.

Do not infer the GPU model or VRAM from the Ryzen 7 label alone.
