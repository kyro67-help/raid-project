# Initial architecture

Launcher (C# desktop app) -> HTTPS/JSON -> Backend API (ASP.NET Core) -> PostgreSQL.
Backend handles accounts, profiles, matchmaking, session tickets, and results. Dedicated Unreal server owns authoritative match state, movement, combat, and results. Game client handles input and presentation. Offline solo should work locally without account login.
