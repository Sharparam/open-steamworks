#pragma once

#define STEAMCLIENT_ICLASS	ISteamClient008
#define STEAMCLIENT_IFACE	STEAMCLIENT_INTERFACE_VERSION_008

extern CSteamAPILoader *loader;
extern CreateInterfaceFn clientFactory;
extern STEAMCLIENT_ICLASS *steamclient;

extern HSteamUser user;
extern HSteamPipe pipe;

S_API bool STEAM_CALL SteamAPI_Init();
S_API bool STEAM_CALL SteamAPI_InitSafe();

S_API void STEAM_CALL SteamAPI_Shutdown();