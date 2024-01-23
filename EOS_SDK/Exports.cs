﻿using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EOS_SDK
{
    public unsafe class Exports
    {
#if false
        #region Exports


        

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_AntiCheatServer_AddNotifyClientActionRequired(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyClientActionRequiredOptionspublic = Marshal.PtrToStructure<AddNotifyClientActionRequiredOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: AntiCheatServer.OnClientActionRequiredCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_AntiCheatServer_AddNotifyClientAuthStatusChanged(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyClientAuthStatusChangedOptionspublic = Marshal.PtrToStructure<AddNotifyClientAuthStatusChangedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: AntiCheatServer.OnClientAuthStatusChangedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_AntiCheatServer_AddNotifyMessageToClient(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyMessageToClientOptionspublic = Marshal.PtrToStructure<AddNotifyMessageToClientOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: AntiCheatServer.OnMessageToClientCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_AntiCheatServer_BeginSession(IntPtr handle, IntPtr options)
		{
			var _BeginSessionOptionspublic = Marshal.PtrToStructure<BeginSessionOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_AntiCheatServer_EndSession(IntPtr handle, IntPtr options)
		{
			var _EndSessionOptionspublic = Marshal.PtrToStructure<EndSessionOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_AntiCheatServer_GetProtectMessageOutputLength(IntPtr handle, IntPtr options, [Out] uint outBufferSizeBytes)
		{
			var _GetProtectMessageOutputLengthOptionspublic = Marshal.PtrToStructure<GetProtectMessageOutputLengthOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_AntiCheatServer_LogEvent(IntPtr handle, IntPtr options)
		{
			var _LogEventOptionspublic = Marshal.PtrToStructure<LogEventOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_AntiCheatServer_LogGameRoundEnd(IntPtr handle, IntPtr options)
		{
			var _LogGameRoundEndOptionspublic = Marshal.PtrToStructure<LogGameRoundEndOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_AntiCheatServer_LogGameRoundStart(IntPtr handle, IntPtr options)
		{
			var _LogGameRoundStartOptionspublic = Marshal.PtrToStructure<LogGameRoundStartOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_AntiCheatServer_LogPlayerDespawn(IntPtr handle, IntPtr options)
		{
			var _LogPlayerDespawnOptionspublic = Marshal.PtrToStructure<LogPlayerDespawnOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_AntiCheatServer_LogPlayerRevive(IntPtr handle, IntPtr options)
		{
			var _LogPlayerReviveOptionspublic = Marshal.PtrToStructure<LogPlayerReviveOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_AntiCheatServer_LogPlayerSpawn(IntPtr handle, IntPtr options)
		{
			var _LogPlayerSpawnOptionspublic = Marshal.PtrToStructure<LogPlayerSpawnOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_AntiCheatServer_LogPlayerTakeDamage(IntPtr handle, IntPtr options)
		{
			var _LogPlayerTakeDamageOptionspublic = Marshal.PtrToStructure<LogPlayerTakeDamageOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_AntiCheatServer_LogPlayerTick(IntPtr handle, IntPtr options)
		{
			var _LogPlayerTickOptionspublic = Marshal.PtrToStructure<LogPlayerTickOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_AntiCheatServer_LogPlayerUseAbility(IntPtr handle, IntPtr options)
		{
			var _LogPlayerUseAbilityOptionspublic = Marshal.PtrToStructure<LogPlayerUseAbilityOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_AntiCheatServer_LogPlayerUseWeapon(IntPtr handle, IntPtr options)
		{
			var _LogPlayerUseWeaponOptionspublic = Marshal.PtrToStructure<LogPlayerUseWeaponOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_AntiCheatServer_ProtectMessage(IntPtr handle, IntPtr options, IntPtr outBuffer, [Out] uint outBytesWritten)
		{
			var _ProtectMessageOptionspublic = Marshal.PtrToStructure<ProtectMessageOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_AntiCheatServer_ReceiveMessageFromClient(IntPtr handle, IntPtr options)
		{
			var _ReceiveMessageFromClientOptionspublic = Marshal.PtrToStructure<ReceiveMessageFromClientOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_AntiCheatServer_RegisterClient(IntPtr handle, IntPtr options)
		{
			var _RegisterClientOptionspublic = Marshal.PtrToStructure<RegisterClientOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_AntiCheatServer_RegisterEvent(IntPtr handle, IntPtr options)
		{
			var _RegisterEventOptionspublic = Marshal.PtrToStructure<RegisterEventOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_AntiCheatServer_RemoveNotifyClientActionRequired(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_AntiCheatServer_RemoveNotifyClientAuthStatusChanged(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_AntiCheatServer_RemoveNotifyMessageToClient(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_AntiCheatServer_SetClientDetails(IntPtr handle, IntPtr options)
		{
			var _SetClientDetailsOptionspublic = Marshal.PtrToStructure<SetClientDetailsOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_AntiCheatServer_SetClientNetworkState(IntPtr handle, IntPtr options)
		{
			var _SetClientNetworkStateOptionspublic = Marshal.PtrToStructure<SetClientNetworkStateOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_AntiCheatServer_SetGameSessionId(IntPtr handle, IntPtr options)
		{
			var _SetGameSessionIdOptionspublic = Marshal.PtrToStructure<SetGameSessionIdOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_AntiCheatServer_UnprotectMessage(IntPtr handle, IntPtr options, IntPtr outBuffer, [Out] uint outBytesWritten)
		{
			var _UnprotectMessageOptionspublic = Marshal.PtrToStructure<UnprotectMessageOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_AntiCheatServer_UnregisterClient(IntPtr handle, IntPtr options)
		{
			var _UnregisterClientOptionspublic = Marshal.PtrToStructure<UnregisterClientOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Auth_AddNotifyLoginStatusChanged(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notification)
		{
			var _AddNotifyLoginStatusChangedOptionspublic = Marshal.PtrToStructure<AddNotifyLoginStatusChangedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notification; //Delegate Class was: Auth.OnLoginStatusChangedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Auth_CopyIdToken(IntPtr handle, IntPtr options, IntPtr outIdToken)
		{
			var _CopyIdTokenOptionspublic = Marshal.PtrToStructure<CopyIdTokenOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Auth_CopyUserAuthToken(IntPtr handle, IntPtr options, IntPtr localUserId, IntPtr outUserAuthToken)
		{
			var _CopyUserAuthTokenOptionspublic = Marshal.PtrToStructure<CopyUserAuthTokenOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Auth_DeletePersistentAuth(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _DeletePersistentAuthOptionspublic = Marshal.PtrToStructure<DeletePersistentAuthOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Auth.OnDeletePersistentAuthCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Auth_GetLoggedInAccountByIndex(IntPtr handle, int index)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Auth_GetLoggedInAccountsCount(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static LoginStatus EOS_Auth_GetLoginStatus(IntPtr handle, IntPtr localUserId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Auth_GetMergedAccountByIndex(IntPtr handle, IntPtr localUserId, uint index)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_Auth_GetMergedAccountsCount(IntPtr handle, IntPtr localUserId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Auth_GetSelectedAccountId(IntPtr handle, IntPtr localUserId, IntPtr outSelectedAccountId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Auth_IdToken_Release(IntPtr idToken)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Auth_LinkAccount(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _LinkAccountOptionspublic = Marshal.PtrToStructure<LinkAccountOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Auth.OnLinkAccountCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Auth_Login(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _LoginOptionspublic = Marshal.PtrToStructure<LoginOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Auth.OnLoginCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Auth_Logout(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _LogoutOptionspublic = Marshal.PtrToStructure<LogoutOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Auth.OnLogoutCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Auth_QueryIdToken(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryIdTokenOptionspublic = Marshal.PtrToStructure<QueryIdTokenOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Auth.OnQueryIdTokenCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Auth_RemoveNotifyLoginStatusChanged(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Auth_Token_Release(IntPtr authToken)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Auth_VerifyIdToken(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _VerifyIdTokenOptionspublic = Marshal.PtrToStructure<VerifyIdTokenOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Auth.OnVerifyIdTokenCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Auth_VerifyUserAuth(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _VerifyUserAuthOptionspublic = Marshal.PtrToStructure<VerifyUserAuthOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Auth.OnVerifyUserAuthCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_ByteArray_ToString(IntPtr byteArray, uint length, IntPtr outBuffer, [Out] uint inOutBufferLength)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Connect_AddNotifyAuthExpiration(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notification)
		{
			var _AddNotifyAuthExpirationOptionspublic = Marshal.PtrToStructure<AddNotifyAuthExpirationOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notification; //Delegate Class was: Connect.OnAuthExpirationCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Connect_AddNotifyLoginStatusChanged(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notification)
		{
			var _AddNotifyLoginStatusChangedOptionspublic = Marshal.PtrToStructure<AddNotifyLoginStatusChangedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notification; //Delegate Class was: Connect.OnLoginStatusChangedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Connect_CopyIdToken(IntPtr handle, IntPtr options, IntPtr outIdToken)
		{
			var _CopyIdTokenOptionspublic = Marshal.PtrToStructure<CopyIdTokenOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Connect_CopyProductUserExternalAccountByAccountId(IntPtr handle, IntPtr options, IntPtr outExternalAccountInfo)
		{
			var _CopyProductUserExternalAccountByAccountIdOptionspublic = Marshal.PtrToStructure<CopyProductUserExternalAccountByAccountIdOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Connect_CopyProductUserExternalAccountByAccountType(IntPtr handle, IntPtr options, IntPtr outExternalAccountInfo)
		{
			var _CopyProductUserExternalAccountByAccountTypeOptionspublic = Marshal.PtrToStructure<CopyProductUserExternalAccountByAccountTypeOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Connect_CopyProductUserExternalAccountByIndex(IntPtr handle, IntPtr options, IntPtr outExternalAccountInfo)
		{
			var _CopyProductUserExternalAccountByIndexOptionspublic = Marshal.PtrToStructure<CopyProductUserExternalAccountByIndexOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Connect_CopyProductUserInfo(IntPtr handle, IntPtr options, IntPtr outExternalAccountInfo)
		{
			var _CopyProductUserInfoOptionspublic = Marshal.PtrToStructure<CopyProductUserInfoOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Connect_CreateDeviceId(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _CreateDeviceIdOptionspublic = Marshal.PtrToStructure<CreateDeviceIdOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Connect.OnCreateDeviceIdCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Connect_CreateUser(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _CreateUserOptionspublic = Marshal.PtrToStructure<CreateUserOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Connect.OnCreateUserCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Connect_DeleteDeviceId(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _DeleteDeviceIdOptionspublic = Marshal.PtrToStructure<DeleteDeviceIdOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Connect.OnDeleteDeviceIdCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Connect_ExternalAccountInfo_Release(IntPtr externalAccountInfo)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Connect_GetExternalAccountMapping(IntPtr handle, IntPtr options)
		{
			var _GetExternalAccountMappingsOptionspublic = Marshal.PtrToStructure<GetExternalAccountMappingsOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Connect_GetLoggedInUserByIndex(IntPtr handle, int index)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Connect_GetLoggedInUsersCount(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static LoginStatus EOS_Connect_GetLoginStatus(IntPtr handle, IntPtr localUserId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_Connect_GetProductUserExternalAccountCount(IntPtr handle, IntPtr options)
		{
			var _GetProductUserExternalAccountCountOptionspublic = Marshal.PtrToStructure<GetProductUserExternalAccountCountOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Connect_GetProductUserIdMapping(IntPtr handle, IntPtr options, IntPtr outBuffer, [Out] int inOutBufferLength)
		{
			var _GetProductUserIdMappingOptionspublic = Marshal.PtrToStructure<GetProductUserIdMappingOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Connect_IdToken_Release(IntPtr idToken)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Connect_LinkAccount(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _LinkAccountOptionspublic = Marshal.PtrToStructure<LinkAccountOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Connect.OnLinkAccountCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Connect_Login(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _LoginOptionspublic = Marshal.PtrToStructure<LoginOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Connect.OnLoginCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Connect_QueryExternalAccountMappings(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryExternalAccountMappingsOptionspublic = Marshal.PtrToStructure<QueryExternalAccountMappingsOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Connect.OnQueryExternalAccountMappingsCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Connect_QueryProductUserIdMappings(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryProductUserIdMappingsOptionspublic = Marshal.PtrToStructure<QueryProductUserIdMappingsOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Connect.OnQueryProductUserIdMappingsCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Connect_RemoveNotifyAuthExpiration(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Connect_RemoveNotifyLoginStatusChanged(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Connect_TransferDeviceIdAccount(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _TransferDeviceIdAccountOptionspublic = Marshal.PtrToStructure<TransferDeviceIdAccountOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Connect.OnTransferDeviceIdAccountCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Connect_UnlinkAccount(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _UnlinkAccountOptionspublic = Marshal.PtrToStructure<UnlinkAccountOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Connect.OnUnlinkAccountCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Connect_VerifyIdToken(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _VerifyIdTokenOptionspublic = Marshal.PtrToStructure<VerifyIdTokenOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Connect.OnVerifyIdTokenCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_ContinuanceToken_ToString(IntPtr continuanceToken, IntPtr outBuffer, [Out] int inOutBufferLength)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_CustomInvites_AcceptRequestToJoin(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _AcceptRequestToJoinOptionspublic = Marshal.PtrToStructure<AcceptRequestToJoinOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: CustomInvites.OnAcceptRequestToJoinCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_CustomInvites_AddNotifyCustomInviteAccepted(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyCustomInviteAcceptedOptionspublic = Marshal.PtrToStructure<AddNotifyCustomInviteAcceptedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: CustomInvites.OnCustomInviteAcceptedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_CustomInvites_AddNotifyCustomInviteReceived(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyCustomInviteReceivedOptionspublic = Marshal.PtrToStructure<AddNotifyCustomInviteReceivedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: CustomInvites.OnCustomInviteReceivedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_CustomInvites_AddNotifyCustomInviteRejected(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyCustomInviteRejectedOptionspublic = Marshal.PtrToStructure<AddNotifyCustomInviteRejectedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: CustomInvites.OnCustomInviteRejectedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_CustomInvites_AddNotifyRequestToJoinAccepted(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyRequestToJoinAcceptedOptionspublic = Marshal.PtrToStructure<AddNotifyRequestToJoinAcceptedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: CustomInvites.OnRequestToJoinAcceptedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_CustomInvites_AddNotifyRequestToJoinReceived(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyRequestToJoinReceivedOptionspublic = Marshal.PtrToStructure<AddNotifyRequestToJoinReceivedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: CustomInvites.OnRequestToJoinReceivedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_CustomInvites_AddNotifyRequestToJoinRejected(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyRequestToJoinRejectedOptionspublic = Marshal.PtrToStructure<AddNotifyRequestToJoinRejectedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: CustomInvites.OnRequestToJoinRejectedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_CustomInvites_AddNotifyRequestToJoinResponseReceived(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyRequestToJoinResponseReceivedOptionspublic = Marshal.PtrToStructure<AddNotifyRequestToJoinResponseReceivedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: CustomInvites.OnRequestToJoinResponseReceivedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_CustomInvites_AddNotifySendCustomNativeInviteRequested(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifySendCustomNativeInviteRequestedOptionspublic = Marshal.PtrToStructure<AddNotifySendCustomNativeInviteRequestedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: CustomInvites.OnSendCustomNativeInviteRequestedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_CustomInvites_FinalizeInvite(IntPtr handle, IntPtr options)
		{
			var _FinalizeInviteOptionspublic = Marshal.PtrToStructure<FinalizeInviteOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_CustomInvites_RejectRequestToJoin(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _RejectRequestToJoinOptionspublic = Marshal.PtrToStructure<RejectRequestToJoinOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: CustomInvites.OnRejectRequestToJoinCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_CustomInvites_RemoveNotifyCustomInviteAccepted(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_CustomInvites_RemoveNotifyCustomInviteReceived(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_CustomInvites_RemoveNotifyCustomInviteRejected(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_CustomInvites_RemoveNotifyRequestToJoinAccepted(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_CustomInvites_RemoveNotifyRequestToJoinReceived(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_CustomInvites_RemoveNotifyRequestToJoinRejected(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_CustomInvites_RemoveNotifyRequestToJoinResponseReceived(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_CustomInvites_RemoveNotifySendCustomNativeInviteRequested(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_CustomInvites_SendCustomInvite(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _SendCustomInviteOptionspublic = Marshal.PtrToStructure<SendCustomInviteOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: CustomInvites.OnSendCustomInviteCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_CustomInvites_SendRequestToJoin(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _SendRequestToJoinOptionspublic = Marshal.PtrToStructure<SendRequestToJoinOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: CustomInvites.OnSendRequestToJoinCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_CustomInvites_SetCustomInvite(IntPtr handle, IntPtr options)
		{
			var _SetCustomInviteOptionspublic = Marshal.PtrToStructure<SetCustomInviteOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_EApplicationStatus_ToString(Platform.ApplicationStatus applicationStatus)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_ENetworkStatus_ToString(Platform.NetworkStatus networkStatus)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_EResult_IsOperationComplete(Result result)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_EResult_ToString(Result result)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Ecom_CatalogItem_Release(IntPtr catalogItem)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Ecom_CatalogOffer_Release(IntPtr catalogOffer)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Ecom_CatalogRelease_Release(IntPtr catalogRelease)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Ecom_Checkout(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _CheckoutOptionspublic = Marshal.PtrToStructure<CheckoutOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Ecom.OnCheckoutCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Ecom_CopyEntitlementById(IntPtr handle, IntPtr options, IntPtr outEntitlement)
		{
			var _CopyEntitlementByIdOptionspublic = Marshal.PtrToStructure<CopyEntitlementByIdOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Ecom_CopyEntitlementByIndex(IntPtr handle, IntPtr options, IntPtr outEntitlement)
		{
			var _CopyEntitlementByIndexOptionspublic = Marshal.PtrToStructure<CopyEntitlementByIndexOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Ecom_CopyEntitlementByNameAndIndex(IntPtr handle, IntPtr options, IntPtr outEntitlement)
		{
			var _CopyEntitlementByNameAndIndexOptionspublic = Marshal.PtrToStructure<CopyEntitlementByNameAndIndexOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Ecom_CopyItemById(IntPtr handle, IntPtr options, IntPtr outItem)
		{
			var _CopyItemByIdOptionspublic = Marshal.PtrToStructure<CopyItemByIdOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Ecom_CopyItemImageInfoByIndex(IntPtr handle, IntPtr options, IntPtr outImageInfo)
		{
			var _CopyItemImageInfoByIndexOptionspublic = Marshal.PtrToStructure<CopyItemImageInfoByIndexOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Ecom_CopyItemReleaseByIndex(IntPtr handle, IntPtr options, IntPtr outRelease)
		{
			var _CopyItemReleaseByIndexOptionspublic = Marshal.PtrToStructure<CopyItemReleaseByIndexOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Ecom_CopyLastRedeemedEntitlementByIndex(IntPtr handle, IntPtr options, IntPtr outRedeemedEntitlementId, [Out] int inOutRedeemedEntitlementIdLength)
		{
			var _CopyLastRedeemedEntitlementByIndexOptionspublic = Marshal.PtrToStructure<CopyLastRedeemedEntitlementByIndexOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Ecom_CopyOfferById(IntPtr handle, IntPtr options, IntPtr outOffer)
		{
			var _CopyOfferByIdOptionspublic = Marshal.PtrToStructure<CopyOfferByIdOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Ecom_CopyOfferByIndex(IntPtr handle, IntPtr options, IntPtr outOffer)
		{
			var _CopyOfferByIndexOptionspublic = Marshal.PtrToStructure<CopyOfferByIndexOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Ecom_CopyOfferImageInfoByIndex(IntPtr handle, IntPtr options, IntPtr outImageInfo)
		{
			var _CopyOfferImageInfoByIndexOptionspublic = Marshal.PtrToStructure<CopyOfferImageInfoByIndexOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Ecom_CopyOfferItemByIndex(IntPtr handle, IntPtr options, IntPtr outItem)
		{
			var _CopyOfferItemByIndexOptionspublic = Marshal.PtrToStructure<CopyOfferItemByIndexOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Ecom_CopyTransactionById(IntPtr handle, IntPtr options, IntPtr outTransaction)
		{
			var _CopyTransactionByIdOptionspublic = Marshal.PtrToStructure<CopyTransactionByIdOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Ecom_CopyTransactionByIndex(IntPtr handle, IntPtr options, IntPtr outTransaction)
		{
			var _CopyTransactionByIndexOptionspublic = Marshal.PtrToStructure<CopyTransactionByIndexOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Ecom_Entitlement_Release(IntPtr entitlement)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_Ecom_GetEntitlementsByNameCount(IntPtr handle, IntPtr options)
		{
			var _GetEntitlementsByNameCountOptionspublic = Marshal.PtrToStructure<GetEntitlementsByNameCountOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_Ecom_GetEntitlementsCount(IntPtr handle, IntPtr options)
		{
			var _GetEntitlementsCountOptionspublic = Marshal.PtrToStructure<GetEntitlementsCountOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_Ecom_GetItemImageInfoCount(IntPtr handle, IntPtr options)
		{
			var _GetItemImageInfoCountOptionspublic = Marshal.PtrToStructure<GetItemImageInfoCountOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_Ecom_GetItemReleaseCount(IntPtr handle, IntPtr options)
		{
			var _GetItemReleaseCountOptionspublic = Marshal.PtrToStructure<GetItemReleaseCountOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_Ecom_GetLastRedeemedEntitlementsCount(IntPtr handle, IntPtr options)
		{
			var _GetLastRedeemedEntitlementsCountOptionspublic = Marshal.PtrToStructure<GetLastRedeemedEntitlementsCountOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_Ecom_GetOfferCount(IntPtr handle, IntPtr options)
		{
			var _GetOfferCountOptionspublic = Marshal.PtrToStructure<GetOfferCountOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_Ecom_GetOfferImageInfoCount(IntPtr handle, IntPtr options)
		{
			var _GetOfferImageInfoCountOptionspublic = Marshal.PtrToStructure<GetOfferImageInfoCountOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_Ecom_GetOfferItemCount(IntPtr handle, IntPtr options)
		{
			var _GetOfferItemCountOptionspublic = Marshal.PtrToStructure<GetOfferItemCountOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_Ecom_GetTransactionCount(IntPtr handle, IntPtr options)
		{
			var _GetTransactionCountOptionspublic = Marshal.PtrToStructure<GetTransactionCountOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Ecom_KeyImageInfo_Release(IntPtr keyImageInfo)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Ecom_QueryEntitlementToken(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryEntitlementTokenOptionspublic = Marshal.PtrToStructure<QueryEntitlementTokenOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Ecom.OnQueryEntitlementTokenCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Ecom_QueryEntitlements(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryEntitlementsOptionspublic = Marshal.PtrToStructure<QueryEntitlementsOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Ecom.OnQueryEntitlementsCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Ecom_QueryOffers(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryOffersOptionspublic = Marshal.PtrToStructure<QueryOffersOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Ecom.OnQueryOffersCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Ecom_QueryOwnership(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryOwnershipOptionspublic = Marshal.PtrToStructure<QueryOwnershipOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Ecom.OnQueryOwnershipCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Ecom_QueryOwnershipBySandboxIds(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryOwnershipBySandboxIdsOptionspublic = Marshal.PtrToStructure<QueryOwnershipBySandboxIdsOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Ecom.OnQueryOwnershipBySandboxIdsCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Ecom_QueryOwnershipToken(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryOwnershipTokenOptionspublic = Marshal.PtrToStructure<QueryOwnershipTokenOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Ecom.OnQueryOwnershipTokenCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Ecom_RedeemEntitlements(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _RedeemEntitlementsOptionspublic = Marshal.PtrToStructure<RedeemEntitlementsOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Ecom.OnRedeemEntitlementsCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Ecom_Transaction_CopyEntitlementByIndex(IntPtr handle, IntPtr options, IntPtr outEntitlement)
		{
			var _TransactionCopyEntitlementByIndexOptionspublic = Marshal.PtrToStructure<TransactionCopyEntitlementByIndexOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_Ecom_Transaction_GetEntitlementsCount(IntPtr handle, IntPtr options)
		{
			var _TransactionGetEntitlementsCountOptionspublic = Marshal.PtrToStructure<TransactionGetEntitlementsCountOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Ecom_Transaction_GetTransactionId(IntPtr handle, IntPtr outBuffer, [Out] int inOutBufferLength)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Ecom_Transaction_Release(IntPtr transaction)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_EpicAccountId_FromString(IntPtr accountIdString)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_EpicAccountId_IsValid(IntPtr accountId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_EpicAccountId_ToString(IntPtr accountId, IntPtr outBuffer, [Out] int inOutBufferLength)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Friends_AcceptInvite(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _AcceptInviteOptionspublic = Marshal.PtrToStructure<AcceptInviteOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Friends.OnAcceptInviteCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Friends_AddNotifyBlockedUsersUpdate(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr blockedUsersUpdateHandler)
		{
			var _AddNotifyBlockedUsersUpdateOptionspublic = Marshal.PtrToStructure<AddNotifyBlockedUsersUpdateOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)blockedUsersUpdateHandler; //Delegate Class was: Friends.OnBlockedUsersUpdateCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Friends_AddNotifyFriendsUpdate(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr friendsUpdateHandler)
		{
			var _AddNotifyFriendsUpdateOptionspublic = Marshal.PtrToStructure<AddNotifyFriendsUpdateOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)friendsUpdateHandler; //Delegate Class was: Friends.OnFriendsUpdateCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Friends_GetBlockedUserAtIndex(IntPtr handle, IntPtr options)
		{
			var _GetBlockedUserAtIndexOptionspublic = Marshal.PtrToStructure<GetBlockedUserAtIndexOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Friends_GetBlockedUsersCount(IntPtr handle, IntPtr options)
		{
			var _GetBlockedUsersCountOptionspublic = Marshal.PtrToStructure<GetBlockedUsersCountOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Friends_GetFriendAtIndex(IntPtr handle, IntPtr options)
		{
			var _GetFriendAtIndexOptionspublic = Marshal.PtrToStructure<GetFriendAtIndexOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Friends_GetFriendsCount(IntPtr handle, IntPtr options)
		{
			var _GetFriendsCountOptionspublic = Marshal.PtrToStructure<GetFriendsCountOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Friends.FriendsStatus EOS_Friends_GetStatus(IntPtr handle, IntPtr options)
		{
			var _GetStatusOptionspublic = Marshal.PtrToStructure<GetStatusOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Friends_QueryFriends(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryFriendsOptionspublic = Marshal.PtrToStructure<QueryFriendsOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Friends.OnQueryFriendsCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Friends_RejectInvite(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _RejectInviteOptionspublic = Marshal.PtrToStructure<RejectInviteOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Friends.OnRejectInviteCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Friends_RemoveNotifyBlockedUsersUpdate(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Friends_RemoveNotifyFriendsUpdate(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Friends_SendInvite(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _SendInviteOptionspublic = Marshal.PtrToStructure<SendInviteOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Friends.OnSendInviteCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_GetVersion()
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Initialize(IntPtr options)
        {
			var _InitializeOptionspublic = Marshal.PtrToStructure<InitializeOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_IntegratedPlatformOptionsContainer_Add(IntPtr handle, IntPtr inOptions)
		{
			var _IntegratedPlatformOptionsContainerAddOptionspublic = Marshal.PtrToStructure<IntegratedPlatformOptionsContainerAddOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_IntegratedPlatformOptionsContainer_Release(IntPtr integratedPlatformOptionsContainerHandle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_IntegratedPlatform_AddNotifyUserLoginStatusChanged(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr callbackFunction)
		{
			var _AddNotifyUserLoginStatusChangedOptionspublic = Marshal.PtrToStructure<AddNotifyUserLoginStatusChangedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)callbackFunction; //Delegate Class was: IntegratedPlatform.OnUserLoginStatusChangedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_IntegratedPlatform_ClearUserPreLogoutCallback(IntPtr handle, IntPtr options)
		{
			var _ClearUserPreLogoutCallbackOptionspublic = Marshal.PtrToStructure<ClearUserPreLogoutCallbackOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_IntegratedPlatform_CreateIntegratedPlatformOptionsContainer(IntPtr options, IntPtr outIntegratedPlatformOptionsContainerHandle)
        {
			var _CreateIntegratedPlatformOptionsContainerOptionspublic = Marshal.PtrToStructure<CreateIntegratedPlatformOptionsContainerOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_IntegratedPlatform_FinalizeDeferredUserLogout(IntPtr handle, IntPtr options)
		{
			var _FinalizeDeferredUserLogoutOptionspublic = Marshal.PtrToStructure<FinalizeDeferredUserLogoutOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_IntegratedPlatform_RemoveNotifyUserLoginStatusChanged(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_IntegratedPlatform_SetUserLoginStatus(IntPtr handle, IntPtr options)
		{
			var _SetUserLoginStatusOptionspublic = Marshal.PtrToStructure<SetUserLoginStatusOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_IntegratedPlatform_SetUserPreLogoutCallback(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr callbackFunction)
		{
			var _SetUserPreLogoutCallbackOptionspublic = Marshal.PtrToStructure<SetUserPreLogoutCallbackOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)callbackFunction; //Delegate Class was: IntegratedPlatform.OnUserPreLogoutCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_KWS_AddNotifyPermissionsUpdateReceived(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyPermissionsUpdateReceivedOptionspublic = Marshal.PtrToStructure<AddNotifyPermissionsUpdateReceivedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: KWS.OnPermissionsUpdateReceivedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_KWS_CopyPermissionByIndex(IntPtr handle, IntPtr options, IntPtr outPermission)
		{
			var _CopyPermissionByIndexOptionspublic = Marshal.PtrToStructure<CopyPermissionByIndexOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_KWS_CreateUser(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _CreateUserOptionspublic = Marshal.PtrToStructure<CreateUserOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: KWS.OnCreateUserCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_KWS_GetPermissionByKey(IntPtr handle, IntPtr options, IntPtr outPermission)
		{
			var _GetPermissionByKeyOptionspublic = Marshal.PtrToStructure<GetPermissionByKeyOptionspublic>(options);
            //outPermission  = KWSPermissionStatus ref
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_KWS_GetPermissionsCount(IntPtr handle, IntPtr options)
		{
			var _GetPermissionsCountOptionspublic = Marshal.PtrToStructure<GetPermissionsCountOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_KWS_PermissionStatus_Release(IntPtr permissionStatus)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_KWS_QueryAgeGate(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryAgeGateOptionspublic = Marshal.PtrToStructure<QueryAgeGateOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: KWS.OnQueryAgeGateCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_KWS_QueryPermissions(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryPermissionsOptionspublic = Marshal.PtrToStructure<QueryPermissionsOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: KWS.OnQueryPermissionsCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_KWS_RemoveNotifyPermissionsUpdateReceived(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_KWS_RequestPermissions(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _RequestPermissionsOptionspublic = Marshal.PtrToStructure<RequestPermissionsOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: KWS.OnRequestPermissionsCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_KWS_UpdateParentEmail(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _UpdateParentEmailOptionspublic = Marshal.PtrToStructure<UpdateParentEmailOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: KWS.OnUpdateParentEmailCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Leaderboards_CopyLeaderboardDefinitionByIndex(IntPtr handle, IntPtr options, IntPtr outLeaderboardDefinition)
		{
			var _CopyLeaderboardDefinitionByIndexOptionspublic = Marshal.PtrToStructure<CopyLeaderboardDefinitionByIndexOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Leaderboards_CopyLeaderboardDefinitionByLeaderboardId(IntPtr handle, IntPtr options, IntPtr outLeaderboardDefinition)
		{
			var _CopyLeaderboardDefinitionByLeaderboardIdOptionspublic = Marshal.PtrToStructure<CopyLeaderboardDefinitionByLeaderboardIdOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Leaderboards_CopyLeaderboardRecordByIndex(IntPtr handle, IntPtr options, IntPtr outLeaderboardRecord)
		{
			var _CopyLeaderboardRecordByIndexOptionspublic = Marshal.PtrToStructure<CopyLeaderboardRecordByIndexOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Leaderboards_CopyLeaderboardRecordByUserId(IntPtr handle, IntPtr options, IntPtr outLeaderboardRecord)
		{
			var _CopyLeaderboardRecordByUserIdOptionspublic = Marshal.PtrToStructure<CopyLeaderboardRecordByUserIdOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Leaderboards_CopyLeaderboardUserScoreByIndex(IntPtr handle, IntPtr options, IntPtr outLeaderboardUserScore)
		{
			var _CopyLeaderboardUserScoreByIndexOptionspublic = Marshal.PtrToStructure<CopyLeaderboardUserScoreByIndexOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Leaderboards_CopyLeaderboardUserScoreByUserId(IntPtr handle, IntPtr options, IntPtr outLeaderboardUserScore)
		{
			var _CopyLeaderboardUserScoreByUserIdOptionspublic = Marshal.PtrToStructure<CopyLeaderboardUserScoreByUserIdOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Leaderboards_Definition_Release(IntPtr leaderboardDefinition)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_Leaderboards_GetLeaderboardDefinitionCount(IntPtr handle, IntPtr options)
		{
			var _GetLeaderboardDefinitionCountOptionspublic = Marshal.PtrToStructure<GetLeaderboardDefinitionCountOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_Leaderboards_GetLeaderboardRecordCount(IntPtr handle, IntPtr options)
		{
			var _GetLeaderboardRecordCountOptionspublic = Marshal.PtrToStructure<GetLeaderboardRecordCountOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_Leaderboards_GetLeaderboardUserScoreCount(IntPtr handle, IntPtr options)
		{
			var _GetLeaderboardUserScoreCountOptionspublic = Marshal.PtrToStructure<GetLeaderboardUserScoreCountOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Leaderboards_LeaderboardDefinition_Release(IntPtr leaderboardDefinition)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Leaderboards_LeaderboardRecord_Release(IntPtr leaderboardRecord)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Leaderboards_LeaderboardUserScore_Release(IntPtr leaderboardUserScore)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Leaderboards_QueryLeaderboardDefinitions(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryLeaderboardDefinitionsOptionspublic = Marshal.PtrToStructure<QueryLeaderboardDefinitionsOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Leaderboards.OnQueryLeaderboardDefinitionsCompleteCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Leaderboards_QueryLeaderboardRanks(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryLeaderboardRanksOptionspublic = Marshal.PtrToStructure<QueryLeaderboardRanksOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Leaderboards.OnQueryLeaderboardRanksCompleteCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Leaderboards_QueryLeaderboardUserScores(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryLeaderboardUserScoresOptionspublic = Marshal.PtrToStructure<QueryLeaderboardUserScoresOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Leaderboards.OnQueryLeaderboardUserScoresCompleteCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbyDetails_CopyAttributeByIndex(IntPtr handle, IntPtr options, IntPtr outAttribute)
		{
			var _LobbyDetailsCopyAttributeByIndexOptionspublic = Marshal.PtrToStructure<LobbyDetailsCopyAttributeByIndexOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbyDetails_CopyAttributeByKey(IntPtr handle, IntPtr options, IntPtr outAttribute)
		{
			var _LobbyDetailsCopyAttributeByKeyOptionspublic = Marshal.PtrToStructure<LobbyDetailsCopyAttributeByKeyOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbyDetails_CopyInfo(IntPtr handle, IntPtr options, IntPtr outLobbyDetailsInfo)
		{
			var _LobbyDetailsCopyInfoOptionspublic = Marshal.PtrToStructure<LobbyDetailsCopyInfoOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbyDetails_CopyMemberAttributeByIndex(IntPtr handle, IntPtr options, IntPtr outAttribute)
		{
			var _LobbyDetailsCopyMemberAttributeByIndexOptionspublic = Marshal.PtrToStructure<LobbyDetailsCopyMemberAttributeByIndexOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbyDetails_CopyMemberAttributeByKey(IntPtr handle, IntPtr options, IntPtr outAttribute)
		{
			var _LobbyDetailsCopyMemberAttributeByKeyOptionspublic = Marshal.PtrToStructure<LobbyDetailsCopyMemberAttributeByKeyOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbyDetails_CopyMemberInfo(IntPtr handle, IntPtr options, IntPtr outLobbyDetailsMemberInfo)
		{
			var _LobbyDetailsCopyMemberInfoOptionspublic = Marshal.PtrToStructure<LobbyDetailsCopyMemberInfoOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_LobbyDetails_GetAttributeCount(IntPtr handle, IntPtr options)
		{
			var _LobbyDetailsGetAttributeCountOptionspublic = Marshal.PtrToStructure<LobbyDetailsGetAttributeCountOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_LobbyDetails_GetLobbyOwner(IntPtr handle, IntPtr options)
		{
			var _LobbyDetailsGetLobbyOwnerOptionspublic = Marshal.PtrToStructure<LobbyDetailsGetLobbyOwnerOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_LobbyDetails_GetMemberAttributeCount(IntPtr handle, IntPtr options)
		{
			var _LobbyDetailsGetMemberAttributeCountOptionspublic = Marshal.PtrToStructure<LobbyDetailsGetMemberAttributeCountOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_LobbyDetails_GetMemberByIndex(IntPtr handle, IntPtr options)
		{
			var _LobbyDetailsGetMemberByIndexOptionspublic = Marshal.PtrToStructure<LobbyDetailsGetMemberByIndexOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_LobbyDetails_GetMemberCount(IntPtr handle, IntPtr options)
		{
			var _LobbyDetailsGetMemberCountOptionspublic = Marshal.PtrToStructure<LobbyDetailsGetMemberCountOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_LobbyDetails_Info_Release(IntPtr lobbyDetailsInfo)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_LobbyDetails_MemberInfo_Release(IntPtr lobbyDetailsMemberInfo)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_LobbyDetails_Release(IntPtr lobbyHandle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbyModification_AddAttribute(IntPtr handle, IntPtr options)
		{
			var _LobbyModificationAddAttributeOptionspublic = Marshal.PtrToStructure<LobbyModificationAddAttributeOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbyModification_AddMemberAttribute(IntPtr handle, IntPtr options)
		{
			var _LobbyModificationAddMemberAttributeOptionspublic = Marshal.PtrToStructure<LobbyModificationAddMemberAttributeOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_LobbyModification_Release(IntPtr lobbyModificationHandle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbyModification_RemoveAttribute(IntPtr handle, IntPtr options)
		{
			var _LobbyModificationRemoveAttributeOptionspublic = Marshal.PtrToStructure<LobbyModificationRemoveAttributeOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbyModification_RemoveMemberAttribute(IntPtr handle, IntPtr options)
		{
			var _LobbyModificationRemoveMemberAttributeOptionspublic = Marshal.PtrToStructure<LobbyModificationRemoveMemberAttributeOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbyModification_SetAllowedPlatformIds(IntPtr handle, IntPtr options)
		{
			var _LobbyModificationSetAllowedPlatformIdsOptionspublic = Marshal.PtrToStructure<LobbyModificationSetAllowedPlatformIdsOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbyModification_SetBucketId(IntPtr handle, IntPtr options)
		{
			var _LobbyModificationSetBucketIdOptionspublic = Marshal.PtrToStructure<LobbyModificationSetBucketIdOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbyModification_SetInvitesAllowed(IntPtr handle, IntPtr options)
		{
			var _LobbyModificationSetInvitesAllowedOptionspublic = Marshal.PtrToStructure<LobbyModificationSetInvitesAllowedOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbyModification_SetMaxMembers(IntPtr handle, IntPtr options)
		{
			var _LobbyModificationSetMaxMembersOptionspublic = Marshal.PtrToStructure<LobbyModificationSetMaxMembersOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbyModification_SetPermissionLevel(IntPtr handle, IntPtr options)
		{
			var _LobbyModificationSetPermissionLevelOptionspublic = Marshal.PtrToStructure<LobbyModificationSetPermissionLevelOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbySearch_CopySearchResultByIndex(IntPtr handle, IntPtr options, IntPtr outLobbyDetailsHandle)
		{
			var _LobbySearchCopySearchResultByIndexOptionspublic = Marshal.PtrToStructure<LobbySearchCopySearchResultByIndexOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_LobbySearch_Find(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _LobbySearchFindOptionspublic = Marshal.PtrToStructure<LobbySearchFindOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Lobby.LobbySearchOnFindCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_LobbySearch_GetSearchResultCount(IntPtr handle, IntPtr options)
		{
			var _LobbySearchGetSearchResultCountOptionspublic = Marshal.PtrToStructure<LobbySearchGetSearchResultCountOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_LobbySearch_Release(IntPtr lobbySearchHandle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbySearch_RemoveParameter(IntPtr handle, IntPtr options)
		{
			var _LobbySearchRemoveParameterOptionspublic = Marshal.PtrToStructure<LobbySearchRemoveParameterOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbySearch_SetLobbyId(IntPtr handle, IntPtr options)
		{
			var _LobbySearchSetLobbyIdOptionspublic = Marshal.PtrToStructure<LobbySearchSetLobbyIdOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbySearch_SetMaxResults(IntPtr handle, IntPtr options)
		{
			var _LobbySearchSetMaxResultsOptionspublic = Marshal.PtrToStructure<LobbySearchSetMaxResultsOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbySearch_SetParameter(IntPtr handle, IntPtr options)
		{
			var _LobbySearchSetParameterOptionspublic = Marshal.PtrToStructure<LobbySearchSetParameterOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbySearch_SetTargetUserId(IntPtr handle, IntPtr options)
		{
			var _LobbySearchSetTargetUserIdOptionspublic = Marshal.PtrToStructure<LobbySearchSetTargetUserIdOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Lobby_AddNotifyJoinLobbyAccepted(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyJoinLobbyAcceptedOptionspublic = Marshal.PtrToStructure<AddNotifyJoinLobbyAcceptedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: Lobby.OnJoinLobbyAcceptedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Lobby_AddNotifyLeaveLobbyRequested(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyLeaveLobbyRequestedOptionspublic = Marshal.PtrToStructure<AddNotifyLeaveLobbyRequestedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: Lobby.OnLeaveLobbyRequestedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Lobby_AddNotifyLobbyInviteAccepted(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyLobbyInviteAcceptedOptionspublic = Marshal.PtrToStructure<AddNotifyLobbyInviteAcceptedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: Lobby.OnLobbyInviteAcceptedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Lobby_AddNotifyLobbyInviteReceived(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyLobbyInviteReceivedOptionspublic = Marshal.PtrToStructure<AddNotifyLobbyInviteReceivedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: Lobby.OnLobbyInviteReceivedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Lobby_AddNotifyLobbyInviteRejected(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyLobbyInviteRejectedOptionspublic = Marshal.PtrToStructure<AddNotifyLobbyInviteRejectedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: Lobby.OnLobbyInviteRejectedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Lobby_AddNotifyLobbyMemberStatusReceived(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyLobbyMemberStatusReceivedOptionspublic = Marshal.PtrToStructure<AddNotifyLobbyMemberStatusReceivedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: Lobby.OnLobbyMemberStatusReceivedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Lobby_AddNotifyLobbyMemberUpdateReceived(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyLobbyMemberUpdateReceivedOptionspublic = Marshal.PtrToStructure<AddNotifyLobbyMemberUpdateReceivedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: Lobby.OnLobbyMemberUpdateReceivedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Lobby_AddNotifyLobbyUpdateReceived(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyLobbyUpdateReceivedOptionspublic = Marshal.PtrToStructure<AddNotifyLobbyUpdateReceivedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: Lobby.OnLobbyUpdateReceivedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Lobby_AddNotifyRTCRoomConnectionChanged(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyRTCRoomConnectionChangedOptionspublic = Marshal.PtrToStructure<AddNotifyRTCRoomConnectionChangedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: Lobby.OnRTCRoomConnectionChangedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Lobby_AddNotifySendLobbyNativeInviteRequested(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifySendLobbyNativeInviteRequestedOptionspublic = Marshal.PtrToStructure<AddNotifySendLobbyNativeInviteRequestedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: Lobby.OnSendLobbyNativeInviteRequestedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_Attribute_Release(IntPtr lobbyAttribute)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Lobby_CopyLobbyDetailsHandle(IntPtr handle, IntPtr options, IntPtr outLobbyDetailsHandle)
		{
			var _CopyLobbyDetailsHandleOptionspublic = Marshal.PtrToStructure<CopyLobbyDetailsHandleOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Lobby_CopyLobbyDetailsHandleByInviteId(IntPtr handle, IntPtr options, IntPtr outLobbyDetailsHandle)
		{
			var _CopyLobbyDetailsHandleByInviteIdOptionspublic = Marshal.PtrToStructure<CopyLobbyDetailsHandleByInviteIdOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Lobby_CopyLobbyDetailsHandleByUiEventId(IntPtr handle, IntPtr options, IntPtr outLobbyDetailsHandle)
		{
			var _CopyLobbyDetailsHandleByUiEventIdOptionspublic = Marshal.PtrToStructure<CopyLobbyDetailsHandleByUiEventIdOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_CreateLobby(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _CreateLobbyOptionspublic = Marshal.PtrToStructure<CreateLobbyOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Lobby.OnCreateLobbyCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Lobby_CreateLobbySearch(IntPtr handle, IntPtr options, IntPtr outLobbySearchHandle)
		{
			var _CreateLobbySearchOptionspublic = Marshal.PtrToStructure<CreateLobbySearchOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_DestroyLobby(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _DestroyLobbyOptionspublic = Marshal.PtrToStructure<DestroyLobbyOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Lobby.OnDestroyLobbyCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Lobby_GetConnectString(IntPtr handle, IntPtr options, IntPtr outBuffer, [Out] uint inOutBufferLength)
		{
			var _GetConnectStringOptionspublic = Marshal.PtrToStructure<GetConnectStringOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_Lobby_GetInviteCount(IntPtr handle, IntPtr options)
		{
			var _GetInviteCountOptionspublic = Marshal.PtrToStructure<GetInviteCountOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Lobby_GetInviteIdByIndex(IntPtr handle, IntPtr options, IntPtr outBuffer, [Out] int inOutBufferLength)
		{
			var _GetInviteIdByIndexOptionspublic = Marshal.PtrToStructure<GetInviteIdByIndexOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Lobby_GetRTCRoomName(IntPtr handle, IntPtr options, IntPtr outBuffer, [Out] uint inOutBufferLength)
		{
			var _GetRTCRoomNameOptionspublic = Marshal.PtrToStructure<GetRTCRoomNameOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_HardMuteMember(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _HardMuteMemberOptionspublic = Marshal.PtrToStructure<HardMuteMemberOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Lobby.OnHardMuteMemberCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Lobby_IsRTCRoomConnected(IntPtr handle, IntPtr options, [Out] int bOutIsConnected)
		{
			var _IsRTCRoomConnectedOptionspublic = Marshal.PtrToStructure<IsRTCRoomConnectedOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_JoinLobby(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _JoinLobbyOptionspublic = Marshal.PtrToStructure<JoinLobbyOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Lobby.OnJoinLobbyCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_JoinLobbyById(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _JoinLobbyByIdOptionspublic = Marshal.PtrToStructure<JoinLobbyByIdOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Lobby.OnJoinLobbyByIdCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_KickMember(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _KickMemberOptionspublic = Marshal.PtrToStructure<KickMemberOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Lobby.OnKickMemberCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_LeaveLobby(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _LeaveLobbyOptionspublic = Marshal.PtrToStructure<LeaveLobbyOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Lobby.OnLeaveLobbyCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Lobby_ParseConnectString(IntPtr handle, IntPtr options, IntPtr outBuffer, [Out] uint inOutBufferLength)
		{
			var _ParseConnectStringOptionspublic = Marshal.PtrToStructure<ParseConnectStringOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_PromoteMember(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _PromoteMemberOptionspublic = Marshal.PtrToStructure<PromoteMemberOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Lobby.OnPromoteMemberCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_QueryInvites(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryInvitesOptionspublic = Marshal.PtrToStructure<QueryInvitesOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Lobby.OnQueryInvitesCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_RejectInvite(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _RejectInviteOptionspublic = Marshal.PtrToStructure<RejectInviteOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Lobby.OnRejectInviteCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_RemoveNotifyJoinLobbyAccepted(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_RemoveNotifyLeaveLobbyRequested(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_RemoveNotifyLobbyInviteAccepted(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_RemoveNotifyLobbyInviteReceived(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_RemoveNotifyLobbyInviteRejected(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_RemoveNotifyLobbyMemberStatusReceived(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_RemoveNotifyLobbyMemberUpdateReceived(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_RemoveNotifyLobbyUpdateReceived(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_RemoveNotifyRTCRoomConnectionChanged(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_RemoveNotifySendLobbyNativeInviteRequested(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_SendInvite(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _SendInviteOptionspublic = Marshal.PtrToStructure<SendInviteOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Lobby.OnSendInviteCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_UpdateLobby(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _UpdateLobbyOptionspublic = Marshal.PtrToStructure<UpdateLobbyOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Lobby.OnUpdateLobbyCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Lobby_UpdateLobbyModification(IntPtr handle, IntPtr options, IntPtr outLobbyModificationHandle)
		{
			var _UpdateLobbyModificationOptionspublic = Marshal.PtrToStructure<UpdateLobbyModificationOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
IntPtr IntPtr IntPtr IntPtr IntPtr IntPtr IntPtr IntPtr IntPtrpIntPtruIntPtrbIntPtrlIntPtriIntPtrcIntPtr IntPtrsIntPtrtIntPtraIntPtrtIntPtriIntPtrcIntPtr IntPtrRIntPtreIntPtrsIntPtruIntPtrlIntPtrtIntPtr IntPtrEIntPtrOIntPtrSIntPtr_IntPtrLIntPtroIntPtrgIntPtrgIntPtriIntPtrnIntPtrgIntPtr_IntPtrSIntPtreIntPtrtIntPtrCIntPtraIntPtrlIntPtrlIntPtrbIntPtraIntPtrcIntPtrkIntPtr(IntPtrLIntPtroIntPtrgIntPtrgIntPtriIntPtrnIntPtrgIntPtr.IntPtrLIntPtroIntPtrgIntPtrMIntPtreIntPtrsIntPtrsIntPtraIntPtrgIntPtreIntPtrFIntPtruIntPtrnIntPtrcIntPtrIIntPtrnIntPtrtIntPtreIntPtrrIntPtrnIntPtraIntPtrlIntPtr IntPtrcIntPtraIntPtrlIntPtrlIntPtrbIntPtraIntPtrcIntPtrkIntPtr)IntPtr
IntPtr        {
        }
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>); //Delegate Class was: 

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Logging_SetLogLevel(Logging.LogCategory logCategory, Logging.LogLevel logLevel)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Metrics_BeginPlayerSession(IntPtr handle, IntPtr options)
		{
			var _BeginPlayerSessionOptionspublic = Marshal.PtrToStructure<BeginPlayerSessionOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Metrics_EndPlayerSession(IntPtr handle, IntPtr options)
		{
			var _EndPlayerSessionOptionspublic = Marshal.PtrToStructure<EndPlayerSessionOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Mods_CopyModInfo(IntPtr handle, IntPtr options, IntPtr outEnumeratedMods)
		{
			var _CopyModInfoOptionspublic = Marshal.PtrToStructure<CopyModInfoOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Mods_EnumerateMods(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _EnumerateModsOptionspublic = Marshal.PtrToStructure<EnumerateModsOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Mods.OnEnumerateModsCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Mods_InstallMod(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _InstallModOptionspublic = Marshal.PtrToStructure<InstallModOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Mods.OnInstallModCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Mods_ModInfo_Release(IntPtr modInfo)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Mods_UninstallMod(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _UninstallModOptionspublic = Marshal.PtrToStructure<UninstallModOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Mods.OnUninstallModCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Mods_UpdateMod(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _UpdateModOptionspublic = Marshal.PtrToStructure<UpdateModOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Mods.OnUpdateModCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_P2P_AcceptConnection(IntPtr handle, IntPtr options)
		{
			var _AcceptConnectionOptionspublic = Marshal.PtrToStructure<AcceptConnectionOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_P2P_AddNotifyIncomingPacketQueueFull(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr incomingPacketQueueFullHandler)
		{
			var _AddNotifyIncomingPacketQueueFullOptionspublic = Marshal.PtrToStructure<AddNotifyIncomingPacketQueueFullOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)incomingPacketQueueFullHandler; //Delegate Class was: P2P.OnIncomingPacketQueueFullCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_P2P_AddNotifyPeerConnectionClosed(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr connectionClosedHandler)
		{
			var _AddNotifyPeerConnectionClosedOptionspublic = Marshal.PtrToStructure<AddNotifyPeerConnectionClosedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)connectionClosedHandler; //Delegate Class was: P2P.OnRemoteConnectionClosedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_P2P_AddNotifyPeerConnectionEstablished(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr connectionEstablishedHandler)
		{
			var _AddNotifyPeerConnectionEstablishedOptionspublic = Marshal.PtrToStructure<AddNotifyPeerConnectionEstablishedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)connectionEstablishedHandler; //Delegate Class was: P2P.OnPeerConnectionEstablishedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_P2P_AddNotifyPeerConnectionInterrupted(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr connectionInterruptedHandler)
		{
			var _AddNotifyPeerConnectionInterruptedOptionspublic = Marshal.PtrToStructure<AddNotifyPeerConnectionInterruptedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)connectionInterruptedHandler; //Delegate Class was: P2P.OnPeerConnectionInterruptedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_P2P_AddNotifyPeerConnectionRequest(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr connectionRequestHandler)
		{
			var _AddNotifyPeerConnectionRequestOptionspublic = Marshal.PtrToStructure<AddNotifyPeerConnectionRequestOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)connectionRequestHandler; //Delegate Class was: P2P.OnIncomingConnectionRequestCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_P2P_ClearPacketQueue(IntPtr handle, IntPtr options)
		{
			var _ClearPacketQueueOptionspublic = Marshal.PtrToStructure<ClearPacketQueueOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_P2P_CloseConnection(IntPtr handle, IntPtr options)
		{
			var _CloseConnectionOptionspublic = Marshal.PtrToStructure<CloseConnectionOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_P2P_CloseConnections(IntPtr handle, IntPtr options)
		{
			var _CloseConnectionsOptionspublic = Marshal.PtrToStructure<CloseConnectionsOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_P2P_GetNATType(IntPtr handle, IntPtr options, [Out] P2P.NATType outNATType)
		{
			var _GetNATTypeOptionspublic = Marshal.PtrToStructure<GetNATTypeOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_P2P_GetNextReceivedPacketSize(IntPtr handle, IntPtr options, [Out] uint outPacketSizeBytes)
		{
			var _GetNextReceivedPacketSizeOptionspublic = Marshal.PtrToStructure<GetNextReceivedPacketSizeOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_P2P_GetPacketQueueInfo(IntPtr handle, IntPtr options, IntPtr P2P.PacketQueueInfopublic outPacketQueueInfo)
		{
			var _GetPacketQueueInfoOptionspublic = Marshal.PtrToStructure<GetPacketQueueInfoOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)P2P.PacketQueueInfopublic; //Delegate Class was: [Out]
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_P2P_GetPortRange(IntPtr handle, IntPtr options, [Out] ushort outPort, [Out] ushort outNumAdditionalPortsToTry)
		{
			var _GetPortRangeOptionspublic = Marshal.PtrToStructure<GetPortRangeOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_P2P_GetRelayControl(IntPtr handle, IntPtr options, [Out] P2P.RelayControl outRelayControl)
		{
			var _GetRelayControlOptionspublic = Marshal.PtrToStructure<GetRelayControlOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_P2P_QueryNATType(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryNATTypeOptionspublic = Marshal.PtrToStructure<QueryNATTypeOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: P2P.OnQueryNATTypeCompleteCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_P2P_ReceivePacket(IntPtr handle, IntPtr options, IntPtr outPeerId, IntPtr P2P.SocketIdpublic outSocketId, IntPtr byte outChannel, IntPtr outData, IntPtr uint outBytesWritten)
		{
			var _ReceivePacketOptionspublic = Marshal.PtrToStructure<ReceivePacketOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)P2P.SocketIdpublic; //Delegate Class was: [Out]
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_P2P_RemoveNotifyIncomingPacketQueueFull(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_P2P_RemoveNotifyPeerConnectionClosed(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_P2P_RemoveNotifyPeerConnectionEstablished(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_P2P_RemoveNotifyPeerConnectionInterrupted(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_P2P_RemoveNotifyPeerConnectionRequest(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_P2P_SendPacket(IntPtr handle, IntPtr options)
		{
			var _SendPacketOptionspublic = Marshal.PtrToStructure<SendPacketOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_P2P_SetPacketQueueSize(IntPtr handle, IntPtr options)
		{
			var _SetPacketQueueSizeOptionspublic = Marshal.PtrToStructure<SetPacketQueueSizeOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_P2P_SetPortRange(IntPtr handle, IntPtr options)
		{
			var _SetPortRangeOptionspublic = Marshal.PtrToStructure<SetPortRangeOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_P2P_SetRelayControl(IntPtr handle, IntPtr options)
		{
			var _SetRelayControlOptionspublic = Marshal.PtrToStructure<SetRelayControlOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Platform_CheckForLauncherAndRestart(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_Create(IntPtr options)
        {
			var _Optionspublic = Marshal.PtrToStructure<Optionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetAchievementsInterface(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Platform_GetActiveCountryCode(IntPtr handle, IntPtr localUserId, IntPtr outBuffer, [Out] int inOutBufferLength)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Platform_GetActiveLocaleCode(IntPtr handle, IntPtr localUserId, IntPtr outBuffer, [Out] int inOutBufferLength)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetAntiCheatClientInterface(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetAntiCheatServerInterface(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Platform.ApplicationStatus EOS_Platform_GetApplicationStatus(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetAuthInterface(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetConnectInterface(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetCustomInvitesInterface(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Platform_GetDesktopCrossplayStatus(IntPtr handle, IntPtr options, IntPtr Platform.DesktopCrossplayStatusInfopublic outDesktopCrossplayStatusInfo)
		{
			var _GetDesktopCrossplayStatusOptionspublic = Marshal.PtrToStructure<GetDesktopCrossplayStatusOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)Platform.DesktopCrossplayStatusInfopublic; //Delegate Class was: [Out]
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetEcomInterface(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetFriendsInterface(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetIntegratedPlatformInterface(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetKWSInterface(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetLeaderboardsInterface(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetLobbyInterface(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetMetricsInterface(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetModsInterface(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Platform.NetworkStatus EOS_Platform_GetNetworkStatus(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Platform_GetOverrideCountryCode(IntPtr handle, IntPtr outBuffer, [Out] int inOutBufferLength)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Platform_GetOverrideLocaleCode(IntPtr handle, IntPtr outBuffer, [Out] int inOutBufferLength)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetP2PInterface(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetPlayerDataStorageInterface(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetPresenceInterface(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetProgressionSnapshotInterface(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetRTCAdminInterface(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetRTCInterface(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetReportsInterface(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetSanctionsInterface(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetSessionsInterface(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetStatsInterface(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetTitleStorageInterface(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetUIInterface(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetUserInfoInterface(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Platform_Release(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Platform_SetApplicationStatus(IntPtr handle, Platform.ApplicationStatus newStatus)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Platform_SetNetworkStatus(IntPtr handle, Platform.NetworkStatus newStatus)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Platform_SetOverrideCountryCode(IntPtr handle, IntPtr newCountryCode)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Platform_SetOverrideLocaleCode(IntPtr handle, IntPtr newLocaleCode)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Platform_Tick(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_PlayerDataStorageFileTransferRequest_CancelRequest(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_PlayerDataStorageFileTransferRequest_GetFileRequestState(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_PlayerDataStorageFileTransferRequest_GetFilename(IntPtr handle, uint filenameStringBufferSizeBytes, IntPtr outStringBuffer, [Out] int outStringLength)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_PlayerDataStorageFileTransferRequest_Release(IntPtr playerDataStorageFileTransferHandle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_PlayerDataStorage_CopyFileMetadataAtIndex(IntPtr handle, IntPtr copyFileMetadataOptions, IntPtr outMetadata)
		{
			var _CopyFileMetadataAtIndexOptionspublic = Marshal.PtrToStructure<CopyFileMetadataAtIndexOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_PlayerDataStorage_CopyFileMetadataByFilename(IntPtr handle, IntPtr copyFileMetadataOptions, IntPtr outMetadata)
		{
			var _CopyFileMetadataByFilenameOptionspublic = Marshal.PtrToStructure<CopyFileMetadataByFilenameOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_PlayerDataStorage_DeleteCache(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionCallback)
		{
			var _DeleteCacheOptionspublic = Marshal.PtrToStructure<DeleteCacheOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionCallback; //Delegate Class was: PlayerDataStorage.OnDeleteCacheCompleteCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_PlayerDataStorage_DeleteFile(IntPtr handle, IntPtr deleteOptions, IntPtr clientData, IntPtr completionCallback)
		{
			var _DeleteFileOptionspublic = Marshal.PtrToStructure<DeleteFileOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionCallback; //Delegate Class was: PlayerDataStorage.OnDeleteFileCompleteCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_PlayerDataStorage_DuplicateFile(IntPtr handle, IntPtr duplicateOptions, IntPtr clientData, IntPtr completionCallback)
		{
			var _DuplicateFileOptionspublic = Marshal.PtrToStructure<DuplicateFileOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionCallback; //Delegate Class was: PlayerDataStorage.OnDuplicateFileCompleteCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_PlayerDataStorage_FileMetadata_Release(IntPtr fileMetadata)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_PlayerDataStorage_GetFileMetadataCount(IntPtr handle, IntPtr getFileMetadataCountOptions, [Out] int outFileMetadataCount)
		{
			var _GetFileMetadataCountOptionspublic = Marshal.PtrToStructure<GetFileMetadataCountOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_PlayerDataStorage_QueryFile(IntPtr handle, IntPtr queryFileOptions, IntPtr clientData, IntPtr completionCallback)
		{
			var _QueryFileOptionspublic = Marshal.PtrToStructure<QueryFileOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionCallback; //Delegate Class was: PlayerDataStorage.OnQueryFileCompleteCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_PlayerDataStorage_QueryFileList(IntPtr handle, IntPtr queryFileListOptions, IntPtr clientData, IntPtr completionCallback)
		{
			var _QueryFileListOptionspublic = Marshal.PtrToStructure<QueryFileListOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionCallback; //Delegate Class was: PlayerDataStorage.OnQueryFileListCompleteCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_PlayerDataStorage_ReadFile(IntPtr handle, IntPtr readOptions, IntPtr clientData, IntPtr completionCallback)
		{
			var _ReadFileOptionspublic = Marshal.PtrToStructure<ReadFileOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionCallback; //Delegate Class was: PlayerDataStorage.OnReadFileCompleteCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_PlayerDataStorage_WriteFile(IntPtr handle, IntPtr writeOptions, IntPtr clientData, IntPtr completionCallback)
		{
			var _WriteFileOptionspublic = Marshal.PtrToStructure<WriteFileOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionCallback; //Delegate Class was: PlayerDataStorage.OnWriteFileCompleteCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_PresenceModification_DeleteData(IntPtr handle, IntPtr options)
		{
			var _PresenceModificationDeleteDataOptionspublic = Marshal.PtrToStructure<PresenceModificationDeleteDataOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_PresenceModification_Release(IntPtr presenceModificationHandle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_PresenceModification_SetData(IntPtr handle, IntPtr options)
		{
			var _PresenceModificationSetDataOptionspublic = Marshal.PtrToStructure<PresenceModificationSetDataOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_PresenceModification_SetJoinInfo(IntPtr handle, IntPtr options)
		{
			var _PresenceModificationSetJoinInfoOptionspublic = Marshal.PtrToStructure<PresenceModificationSetJoinInfoOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_PresenceModification_SetRawRichText(IntPtr handle, IntPtr options)
		{
			var _PresenceModificationSetRawRichTextOptionspublic = Marshal.PtrToStructure<PresenceModificationSetRawRichTextOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_PresenceModification_SetStatus(IntPtr handle, IntPtr options)
		{
			var _PresenceModificationSetStatusOptionspublic = Marshal.PtrToStructure<PresenceModificationSetStatusOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Presence_AddNotifyJoinGameAccepted(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyJoinGameAcceptedOptionspublic = Marshal.PtrToStructure<AddNotifyJoinGameAcceptedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: Presence.OnJoinGameAcceptedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Presence_AddNotifyOnPresenceChanged(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationHandler)
		{
			var _AddNotifyOnPresenceChangedOptionspublic = Marshal.PtrToStructure<AddNotifyOnPresenceChangedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationHandler; //Delegate Class was: Presence.OnPresenceChangedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Presence_CopyPresence(IntPtr handle, IntPtr options, IntPtr outPresence)
		{
			var _CopyPresenceOptionspublic = Marshal.PtrToStructure<CopyPresenceOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Presence_CreatePresenceModification(IntPtr handle, IntPtr options, IntPtr outPresenceModificationHandle)
		{
			var _CreatePresenceModificationOptionspublic = Marshal.PtrToStructure<CreatePresenceModificationOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Presence_GetJoinInfo(IntPtr handle, IntPtr options, IntPtr outBuffer, [Out] int inOutBufferLength)
		{
			var _GetJoinInfoOptionspublic = Marshal.PtrToStructure<GetJoinInfoOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Presence_HasPresence(IntPtr handle, IntPtr options)
		{
			var _HasPresenceOptionspublic = Marshal.PtrToStructure<HasPresenceOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Presence_Info_Release(IntPtr presenceInfo)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Presence_QueryPresence(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryPresenceOptionspublic = Marshal.PtrToStructure<QueryPresenceOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Presence.OnQueryPresenceCompleteCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Presence_RemoveNotifyJoinGameAccepted(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Presence_RemoveNotifyOnPresenceChanged(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Presence_SetPresence(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _SetPresenceOptionspublic = Marshal.PtrToStructure<SetPresenceOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Presence.SetPresenceCompleteCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_ProgressionSnapshot_AddProgression(IntPtr handle, IntPtr options)
		{
			var _AddProgressionOptionspublic = Marshal.PtrToStructure<AddProgressionOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_ProgressionSnapshot_BeginSnapshot(IntPtr handle, IntPtr options, [Out] uint outSnapshotId)
		{
			var _BeginSnapshotOptionspublic = Marshal.PtrToStructure<BeginSnapshotOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_ProgressionSnapshot_DeleteSnapshot(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _DeleteSnapshotOptionspublic = Marshal.PtrToStructure<DeleteSnapshotOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: ProgressionSnapshot.OnDeleteSnapshotCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_ProgressionSnapshot_EndSnapshot(IntPtr handle, IntPtr options)
		{
			var _EndSnapshotOptionspublic = Marshal.PtrToStructure<EndSnapshotOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_ProgressionSnapshot_SubmitSnapshot(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _SubmitSnapshotOptionspublic = Marshal.PtrToStructure<SubmitSnapshotOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: ProgressionSnapshot.OnSubmitSnapshotCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_RTCAdmin_CopyUserTokenByIndex(IntPtr handle, IntPtr options, IntPtr outUserToken)
		{
			var _CopyUserTokenByIndexOptionspublic = Marshal.PtrToStructure<CopyUserTokenByIndexOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_RTCAdmin_CopyUserTokenByUserId(IntPtr handle, IntPtr options, IntPtr outUserToken)
		{
			var _CopyUserTokenByUserIdOptionspublic = Marshal.PtrToStructure<CopyUserTokenByUserIdOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_RTCAdmin_Kick(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _KickOptionspublic = Marshal.PtrToStructure<KickOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAdmin.OnKickCompleteCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_RTCAdmin_QueryJoinRoomToken(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryJoinRoomTokenOptionspublic = Marshal.PtrToStructure<QueryJoinRoomTokenOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAdmin.OnQueryJoinRoomTokenCompleteCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_RTCAdmin_SetParticipantHardMute(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _SetParticipantHardMuteOptionspublic = Marshal.PtrToStructure<SetParticipantHardMuteOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAdmin.OnSetParticipantHardMuteCompleteCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_RTCAdmin_UserToken_Release(IntPtr userToken)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_RTCAudio_AddNotifyAudioBeforeRender(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _AddNotifyAudioBeforeRenderOptionspublic = Marshal.PtrToStructure<AddNotifyAudioBeforeRenderOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAudio.OnAudioBeforeRenderCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_RTCAudio_AddNotifyAudioBeforeSend(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _AddNotifyAudioBeforeSendOptionspublic = Marshal.PtrToStructure<AddNotifyAudioBeforeSendOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAudio.OnAudioBeforeSendCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_RTCAudio_AddNotifyAudioDevicesChanged(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _AddNotifyAudioDevicesChangedOptionspublic = Marshal.PtrToStructure<AddNotifyAudioDevicesChangedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAudio.OnAudioDevicesChangedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_RTCAudio_AddNotifyAudioInputState(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _AddNotifyAudioInputStateOptionspublic = Marshal.PtrToStructure<AddNotifyAudioInputStateOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAudio.OnAudioInputStateCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_RTCAudio_AddNotifyAudioOutputState(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _AddNotifyAudioOutputStateOptionspublic = Marshal.PtrToStructure<AddNotifyAudioOutputStateOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAudio.OnAudioOutputStateCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_RTCAudio_AddNotifyParticipantUpdated(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _AddNotifyParticipantUpdatedOptionspublic = Marshal.PtrToStructure<AddNotifyParticipantUpdatedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAudio.OnParticipantUpdatedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_RTCAudio_CopyInputDeviceInformationByIndex(IntPtr handle, IntPtr options, IntPtr outInputDeviceInformation)
		{
			var _CopyInputDeviceInformationByIndexOptionspublic = Marshal.PtrToStructure<CopyInputDeviceInformationByIndexOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_RTCAudio_CopyOutputDeviceInformationByIndex(IntPtr handle, IntPtr options, IntPtr outOutputDeviceInformation)
		{
			var _CopyOutputDeviceInformationByIndexOptionspublic = Marshal.PtrToStructure<CopyOutputDeviceInformationByIndexOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_RTCAudio_GetAudioInputDeviceByIndex(IntPtr handle, IntPtr options)
		{
			var _GetAudioInputDeviceByIndexOptionspublic = Marshal.PtrToStructure<GetAudioInputDeviceByIndexOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_RTCAudio_GetAudioInputDevicesCount(IntPtr handle, IntPtr options)
		{
			var _GetAudioInputDevicesCountOptionspublic = Marshal.PtrToStructure<GetAudioInputDevicesCountOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_RTCAudio_GetAudioOutputDeviceByIndex(IntPtr handle, IntPtr options)
		{
			var _GetAudioOutputDeviceByIndexOptionspublic = Marshal.PtrToStructure<GetAudioOutputDeviceByIndexOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_RTCAudio_GetAudioOutputDevicesCount(IntPtr handle, IntPtr options)
		{
			var _GetAudioOutputDevicesCountOptionspublic = Marshal.PtrToStructure<GetAudioOutputDevicesCountOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_RTCAudio_GetInputDevicesCount(IntPtr handle, IntPtr options)
		{
			var _GetInputDevicesCountOptionspublic = Marshal.PtrToStructure<GetInputDevicesCountOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_RTCAudio_GetOutputDevicesCount(IntPtr handle, IntPtr options)
		{
			var _GetOutputDevicesCountOptionspublic = Marshal.PtrToStructure<GetOutputDevicesCountOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_RTCAudio_InputDeviceInformation_Release(IntPtr deviceInformation)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_RTCAudio_OutputDeviceInformation_Release(IntPtr deviceInformation)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_RTCAudio_QueryInputDevicesInformation(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryInputDevicesInformationOptionspublic = Marshal.PtrToStructure<QueryInputDevicesInformationOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAudio.OnQueryInputDevicesInformationCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_RTCAudio_QueryOutputDevicesInformation(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryOutputDevicesInformationOptionspublic = Marshal.PtrToStructure<QueryOutputDevicesInformationOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAudio.OnQueryOutputDevicesInformationCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_RTCAudio_RegisterPlatformAudioUser(IntPtr handle, IntPtr options)
		{
			var _RegisterPlatformAudioUserOptionspublic = Marshal.PtrToStructure<RegisterPlatformAudioUserOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_RTCAudio_RegisterPlatformUser(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _RegisterPlatformUserOptionspublic = Marshal.PtrToStructure<RegisterPlatformUserOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAudio.OnRegisterPlatformUserCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_RTCAudio_RemoveNotifyAudioBeforeRender(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_RTCAudio_RemoveNotifyAudioBeforeSend(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_RTCAudio_RemoveNotifyAudioDevicesChanged(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_RTCAudio_RemoveNotifyAudioInputState(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_RTCAudio_RemoveNotifyAudioOutputState(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_RTCAudio_RemoveNotifyParticipantUpdated(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_RTCAudio_SendAudio(IntPtr handle, IntPtr options)
		{
			var _SendAudioOptionspublic = Marshal.PtrToStructure<SendAudioOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_RTCAudio_SetAudioInputSettings(IntPtr handle, IntPtr options)
		{
			var _SetAudioInputSettingsOptionspublic = Marshal.PtrToStructure<SetAudioInputSettingsOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_RTCAudio_SetAudioOutputSettings(IntPtr handle, IntPtr options)
		{
			var _SetAudioOutputSettingsOptionspublic = Marshal.PtrToStructure<SetAudioOutputSettingsOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_RTCAudio_SetInputDeviceSettings(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _SetInputDeviceSettingsOptionspublic = Marshal.PtrToStructure<SetInputDeviceSettingsOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAudio.OnSetInputDeviceSettingsCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_RTCAudio_SetOutputDeviceSettings(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _SetOutputDeviceSettingsOptionspublic = Marshal.PtrToStructure<SetOutputDeviceSettingsOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAudio.OnSetOutputDeviceSettingsCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_RTCAudio_UnregisterPlatformAudioUser(IntPtr handle, IntPtr options)
		{
			var _UnregisterPlatformAudioUserOptionspublic = Marshal.PtrToStructure<UnregisterPlatformAudioUserOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_RTCAudio_UnregisterPlatformUser(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _UnregisterPlatformUserOptionspublic = Marshal.PtrToStructure<UnregisterPlatformUserOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAudio.OnUnregisterPlatformUserCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_RTCAudio_UpdateParticipantVolume(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _UpdateParticipantVolumeOptionspublic = Marshal.PtrToStructure<UpdateParticipantVolumeOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAudio.OnUpdateParticipantVolumeCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_RTCAudio_UpdateReceiving(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _UpdateReceivingOptionspublic = Marshal.PtrToStructure<UpdateReceivingOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAudio.OnUpdateReceivingCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_RTCAudio_UpdateReceivingVolume(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _UpdateReceivingVolumeOptionspublic = Marshal.PtrToStructure<UpdateReceivingVolumeOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAudio.OnUpdateReceivingVolumeCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_RTCAudio_UpdateSending(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _UpdateSendingOptionspublic = Marshal.PtrToStructure<UpdateSendingOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAudio.OnUpdateSendingCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_RTCAudio_UpdateSendingVolume(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _UpdateSendingVolumeOptionspublic = Marshal.PtrToStructure<UpdateSendingVolumeOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAudio.OnUpdateSendingVolumeCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_RTC_AddNotifyDisconnected(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _AddNotifyDisconnectedOptionspublic = Marshal.PtrToStructure<AddNotifyDisconnectedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: RTC.OnDisconnectedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_RTC_AddNotifyParticipantStatusChanged(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _AddNotifyParticipantStatusChangedOptionspublic = Marshal.PtrToStructure<AddNotifyParticipantStatusChangedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: RTC.OnParticipantStatusChangedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_RTC_AddNotifyRoomStatisticsUpdated(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr statisticsUpdateHandler)
		{
			var _AddNotifyRoomStatisticsUpdatedOptionspublic = Marshal.PtrToStructure<AddNotifyRoomStatisticsUpdatedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)statisticsUpdateHandler; //Delegate Class was: RTC.OnRoomStatisticsUpdatedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_RTC_BlockParticipant(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _BlockParticipantOptionspublic = Marshal.PtrToStructure<BlockParticipantOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: RTC.OnBlockParticipantCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_RTC_GetAudioInterface(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_RTC_JoinRoom(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _JoinRoomOptionspublic = Marshal.PtrToStructure<JoinRoomOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: RTC.OnJoinRoomCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_RTC_LeaveRoom(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _LeaveRoomOptionspublic = Marshal.PtrToStructure<LeaveRoomOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: RTC.OnLeaveRoomCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_RTC_RemoveNotifyDisconnected(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_RTC_RemoveNotifyParticipantStatusChanged(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_RTC_RemoveNotifyRoomStatisticsUpdated(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_RTC_SetRoomSetting(IntPtr handle, IntPtr options)
		{
			var _SetRoomSettingOptionspublic = Marshal.PtrToStructure<SetRoomSettingOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_RTC_SetSetting(IntPtr handle, IntPtr options)
		{
			var _SetSettingOptionspublic = Marshal.PtrToStructure<SetSettingOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Reports_SendPlayerBehaviorReport(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _SendPlayerBehaviorReportOptionspublic = Marshal.PtrToStructure<SendPlayerBehaviorReportOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Reports.OnSendPlayerBehaviorReportCompleteCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Sanctions_CopyPlayerSanctionByIndex(IntPtr handle, IntPtr options, IntPtr outSanction)
		{
			var _CopyPlayerSanctionByIndexOptionspublic = Marshal.PtrToStructure<CopyPlayerSanctionByIndexOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_Sanctions_GetPlayerSanctionCount(IntPtr handle, IntPtr options)
		{
			var _GetPlayerSanctionCountOptionspublic = Marshal.PtrToStructure<GetPlayerSanctionCountOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sanctions_PlayerSanction_Release(IntPtr sanction)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sanctions_QueryActivePlayerSanctions(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryActivePlayerSanctionsOptionspublic = Marshal.PtrToStructure<QueryActivePlayerSanctionsOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Sanctions.OnQueryActivePlayerSanctionsCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_SessionDetails_Attribute_Release(IntPtr sessionAttribute)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionDetails_CopyInfo(IntPtr handle, IntPtr options, IntPtr outSessionInfo)
		{
			var _SessionDetailsCopyInfoOptionspublic = Marshal.PtrToStructure<SessionDetailsCopyInfoOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionDetails_CopySessionAttributeByIndex(IntPtr handle, IntPtr options, IntPtr outSessionAttribute)
		{
			var _SessionDetailsCopySessionAttributeByIndexOptionspublic = Marshal.PtrToStructure<SessionDetailsCopySessionAttributeByIndexOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionDetails_CopySessionAttributeByKey(IntPtr handle, IntPtr options, IntPtr outSessionAttribute)
		{
			var _SessionDetailsCopySessionAttributeByKeyOptionspublic = Marshal.PtrToStructure<SessionDetailsCopySessionAttributeByKeyOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_SessionDetails_GetSessionAttributeCount(IntPtr handle, IntPtr options)
		{
			var _SessionDetailsGetSessionAttributeCountOptionspublic = Marshal.PtrToStructure<SessionDetailsGetSessionAttributeCountOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_SessionDetails_Info_Release(IntPtr sessionInfo)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_SessionDetails_Release(IntPtr sessionHandle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionModification_AddAttribute(IntPtr handle, IntPtr options)
		{
			var _SessionModificationAddAttributeOptionspublic = Marshal.PtrToStructure<SessionModificationAddAttributeOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_SessionModification_Release(IntPtr sessionModificationHandle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionModification_RemoveAttribute(IntPtr handle, IntPtr options)
		{
			var _SessionModificationRemoveAttributeOptionspublic = Marshal.PtrToStructure<SessionModificationRemoveAttributeOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionModification_SetAllowedPlatformIds(IntPtr handle, IntPtr options)
		{
			var _SessionModificationSetAllowedPlatformIdsOptionspublic = Marshal.PtrToStructure<SessionModificationSetAllowedPlatformIdsOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionModification_SetBucketId(IntPtr handle, IntPtr options)
		{
			var _SessionModificationSetBucketIdOptionspublic = Marshal.PtrToStructure<SessionModificationSetBucketIdOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionModification_SetHostAddress(IntPtr handle, IntPtr options)
		{
			var _SessionModificationSetHostAddressOptionspublic = Marshal.PtrToStructure<SessionModificationSetHostAddressOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionModification_SetInvitesAllowed(IntPtr handle, IntPtr options)
		{
			var _SessionModificationSetInvitesAllowedOptionspublic = Marshal.PtrToStructure<SessionModificationSetInvitesAllowedOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionModification_SetJoinInProgressAllowed(IntPtr handle, IntPtr options)
		{
			var _SessionModificationSetJoinInProgressAllowedOptionspublic = Marshal.PtrToStructure<SessionModificationSetJoinInProgressAllowedOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionModification_SetMaxPlayers(IntPtr handle, IntPtr options)
		{
			var _SessionModificationSetMaxPlayersOptionspublic = Marshal.PtrToStructure<SessionModificationSetMaxPlayersOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionModification_SetPermissionLevel(IntPtr handle, IntPtr options)
		{
			var _SessionModificationSetPermissionLevelOptionspublic = Marshal.PtrToStructure<SessionModificationSetPermissionLevelOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionSearch_CopySearchResultByIndex(IntPtr handle, IntPtr options, IntPtr outSessionHandle)
		{
			var _SessionSearchCopySearchResultByIndexOptionspublic = Marshal.PtrToStructure<SessionSearchCopySearchResultByIndexOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_SessionSearch_Find(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _SessionSearchFindOptionspublic = Marshal.PtrToStructure<SessionSearchFindOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Sessions.SessionSearchOnFindCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_SessionSearch_GetSearchResultCount(IntPtr handle, IntPtr options)
		{
			var _SessionSearchGetSearchResultCountOptionspublic = Marshal.PtrToStructure<SessionSearchGetSearchResultCountOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_SessionSearch_Release(IntPtr sessionSearchHandle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionSearch_RemoveParameter(IntPtr handle, IntPtr options)
		{
			var _SessionSearchRemoveParameterOptionspublic = Marshal.PtrToStructure<SessionSearchRemoveParameterOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionSearch_SetMaxResults(IntPtr handle, IntPtr options)
		{
			var _SessionSearchSetMaxResultsOptionspublic = Marshal.PtrToStructure<SessionSearchSetMaxResultsOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionSearch_SetParameter(IntPtr handle, IntPtr options)
		{
			var _SessionSearchSetParameterOptionspublic = Marshal.PtrToStructure<SessionSearchSetParameterOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionSearch_SetSessionId(IntPtr handle, IntPtr options)
		{
			var _SessionSearchSetSessionIdOptionspublic = Marshal.PtrToStructure<SessionSearchSetSessionIdOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionSearch_SetTargetUserId(IntPtr handle, IntPtr options)
		{
			var _SessionSearchSetTargetUserIdOptionspublic = Marshal.PtrToStructure<SessionSearchSetTargetUserIdOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Sessions_AddNotifyJoinSessionAccepted(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyJoinSessionAcceptedOptionspublic = Marshal.PtrToStructure<AddNotifyJoinSessionAcceptedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: Sessions.OnJoinSessionAcceptedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Sessions_AddNotifyLeaveSessionRequested(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyLeaveSessionRequestedOptionspublic = Marshal.PtrToStructure<AddNotifyLeaveSessionRequestedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: Sessions.OnLeaveSessionRequestedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Sessions_AddNotifySendSessionNativeInviteRequested(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifySendSessionNativeInviteRequestedOptionspublic = Marshal.PtrToStructure<AddNotifySendSessionNativeInviteRequestedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: Sessions.OnSendSessionNativeInviteRequestedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Sessions_AddNotifySessionInviteAccepted(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifySessionInviteAcceptedOptionspublic = Marshal.PtrToStructure<AddNotifySessionInviteAcceptedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: Sessions.OnSessionInviteAcceptedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Sessions_AddNotifySessionInviteReceived(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifySessionInviteReceivedOptionspublic = Marshal.PtrToStructure<AddNotifySessionInviteReceivedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: Sessions.OnSessionInviteReceivedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Sessions_AddNotifySessionInviteRejected(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifySessionInviteRejectedOptionspublic = Marshal.PtrToStructure<AddNotifySessionInviteRejectedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: Sessions.OnSessionInviteRejectedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Sessions_CopyActiveSessionHandle(IntPtr handle, IntPtr options, IntPtr outSessionHandle)
		{
			var _CopyActiveSessionHandleOptionspublic = Marshal.PtrToStructure<CopyActiveSessionHandleOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Sessions_CopySessionHandleByInviteId(IntPtr handle, IntPtr options, IntPtr outSessionHandle)
		{
			var _CopySessionHandleByInviteIdOptionspublic = Marshal.PtrToStructure<CopySessionHandleByInviteIdOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Sessions_CopySessionHandleByUiEventId(IntPtr handle, IntPtr options, IntPtr outSessionHandle)
		{
			var _CopySessionHandleByUiEventIdOptionspublic = Marshal.PtrToStructure<CopySessionHandleByUiEventIdOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Sessions_CopySessionHandleForPresence(IntPtr handle, IntPtr options, IntPtr outSessionHandle)
		{
			var _CopySessionHandleForPresenceOptionspublic = Marshal.PtrToStructure<CopySessionHandleForPresenceOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Sessions_CreateSessionModification(IntPtr handle, IntPtr options, IntPtr outSessionModificationHandle)
		{
			var _CreateSessionModificationOptionspublic = Marshal.PtrToStructure<CreateSessionModificationOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Sessions_CreateSessionSearch(IntPtr handle, IntPtr options, IntPtr outSessionSearchHandle)
		{
			var _CreateSessionSearchOptionspublic = Marshal.PtrToStructure<CreateSessionSearchOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_DestroySession(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _DestroySessionOptionspublic = Marshal.PtrToStructure<DestroySessionOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Sessions.OnDestroySessionCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Sessions_DumpSessionState(IntPtr handle, IntPtr options)
		{
			var _DumpSessionStateOptionspublic = Marshal.PtrToStructure<DumpSessionStateOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_EndSession(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _EndSessionOptionspublic = Marshal.PtrToStructure<EndSessionOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Sessions.OnEndSessionCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_Sessions_GetInviteCount(IntPtr handle, IntPtr options)
		{
			var _GetInviteCountOptionspublic = Marshal.PtrToStructure<GetInviteCountOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Sessions_GetInviteIdByIndex(IntPtr handle, IntPtr options, IntPtr outBuffer, [Out] int inOutBufferLength)
		{
			var _GetInviteIdByIndexOptionspublic = Marshal.PtrToStructure<GetInviteIdByIndexOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Sessions_IsUserInSession(IntPtr handle, IntPtr options)
		{
			var _IsUserInSessionOptionspublic = Marshal.PtrToStructure<IsUserInSessionOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_JoinSession(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _JoinSessionOptionspublic = Marshal.PtrToStructure<JoinSessionOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Sessions.OnJoinSessionCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_QueryInvites(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryInvitesOptionspublic = Marshal.PtrToStructure<QueryInvitesOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Sessions.OnQueryInvitesCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_RegisterPlayers(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _RegisterPlayersOptionspublic = Marshal.PtrToStructure<RegisterPlayersOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Sessions.OnRegisterPlayersCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_RejectInvite(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _RejectInviteOptionspublic = Marshal.PtrToStructure<RejectInviteOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Sessions.OnRejectInviteCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_RemoveNotifyJoinSessionAccepted(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_RemoveNotifyLeaveSessionRequested(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_RemoveNotifySendSessionNativeInviteRequested(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_RemoveNotifySessionInviteAccepted(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_RemoveNotifySessionInviteReceived(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_RemoveNotifySessionInviteRejected(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_SendInvite(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _SendInviteOptionspublic = Marshal.PtrToStructure<SendInviteOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Sessions.OnSendInviteCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_StartSession(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _StartSessionOptionspublic = Marshal.PtrToStructure<StartSessionOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Sessions.OnStartSessionCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_UnregisterPlayers(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _UnregisterPlayersOptionspublic = Marshal.PtrToStructure<UnregisterPlayersOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Sessions.OnUnregisterPlayersCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_UpdateSession(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _UpdateSessionOptionspublic = Marshal.PtrToStructure<UpdateSessionOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Sessions.OnUpdateSessionCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Sessions_UpdateSessionModification(IntPtr handle, IntPtr options, IntPtr outSessionModificationHandle)
		{
			var _UpdateSessionModificationOptionspublic = Marshal.PtrToStructure<UpdateSessionModificationOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Shutdown()
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Stats_CopyStatByIndex(IntPtr handle, IntPtr options, IntPtr outStat)
		{
			var _CopyStatByIndexOptionspublic = Marshal.PtrToStructure<CopyStatByIndexOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Stats_CopyStatByName(IntPtr handle, IntPtr options, IntPtr outStat)
		{
			var _CopyStatByNameOptionspublic = Marshal.PtrToStructure<CopyStatByNameOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_Stats_GetStatsCount(IntPtr handle, IntPtr options)
		{
			var _GetStatCountOptionspublic = Marshal.PtrToStructure<GetStatCountOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Stats_IngestStat(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _IngestStatOptionspublic = Marshal.PtrToStructure<IngestStatOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Stats.OnIngestStatCompleteCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Stats_QueryStats(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryStatsOptionspublic = Marshal.PtrToStructure<QueryStatsOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Stats.OnQueryStatsCompleteCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Stats_Stat_Release(IntPtr stat)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_TitleStorageFileTransferRequest_CancelRequest(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_TitleStorageFileTransferRequest_GetFileRequestState(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_TitleStorageFileTransferRequest_GetFilename(IntPtr handle, uint filenameStringBufferSizeBytes, IntPtr outStringBuffer, [Out] int outStringLength)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_TitleStorageFileTransferRequest_Release(IntPtr titleStorageFileTransferHandle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_TitleStorage_CopyFileMetadataAtIndex(IntPtr handle, IntPtr options, IntPtr outMetadata)
		{
			var _CopyFileMetadataAtIndexOptionspublic = Marshal.PtrToStructure<CopyFileMetadataAtIndexOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_TitleStorage_CopyFileMetadataByFilename(IntPtr handle, IntPtr options, IntPtr outMetadata)
		{
			var _CopyFileMetadataByFilenameOptionspublic = Marshal.PtrToStructure<CopyFileMetadataByFilenameOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_TitleStorage_DeleteCache(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionCallback)
		{
			var _DeleteCacheOptionspublic = Marshal.PtrToStructure<DeleteCacheOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionCallback; //Delegate Class was: TitleStorage.OnDeleteCacheCompleteCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_TitleStorage_FileMetadata_Release(IntPtr fileMetadata)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_TitleStorage_GetFileMetadataCount(IntPtr handle, IntPtr options)
		{
			var _GetFileMetadataCountOptionspublic = Marshal.PtrToStructure<GetFileMetadataCountOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_TitleStorage_QueryFile(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionCallback)
		{
			var _QueryFileOptionspublic = Marshal.PtrToStructure<QueryFileOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionCallback; //Delegate Class was: TitleStorage.OnQueryFileCompleteCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_TitleStorage_QueryFileList(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionCallback)
		{
			var _QueryFileListOptionspublic = Marshal.PtrToStructure<QueryFileListOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionCallback; //Delegate Class was: TitleStorage.OnQueryFileListCompleteCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_TitleStorage_ReadFile(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionCallback)
		{
			var _ReadFileOptionspublic = Marshal.PtrToStructure<ReadFileOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionCallback; //Delegate Class was: TitleStorage.OnReadFileCompleteCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_UI_AcknowledgeEventId(IntPtr handle, IntPtr options)
		{
			var _AcknowledgeEventIdOptionspublic = Marshal.PtrToStructure<AcknowledgeEventIdOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_UI_AddNotifyDisplaySettingsUpdated(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyDisplaySettingsUpdatedOptionspublic = Marshal.PtrToStructure<AddNotifyDisplaySettingsUpdatedOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: UI.OnDisplaySettingsUpdatedCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_UI_AddNotifyMemoryMonitor(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyMemoryMonitorOptionspublic = Marshal.PtrToStructure<AddNotifyMemoryMonitorOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: UI.OnMemoryMonitorCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_UI_GetFriendsExclusiveInput(IntPtr handle, IntPtr options)
		{
			var _GetFriendsExclusiveInputOptionspublic = Marshal.PtrToStructure<GetFriendsExclusiveInputOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_UI_GetFriendsVisible(IntPtr handle, IntPtr options)
		{
			var _GetFriendsVisibleOptionspublic = Marshal.PtrToStructure<GetFriendsVisibleOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static UI.NotificationLocation EOS_UI_GetNotificationLocationPreference(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static UI.InputStateButtonFlags EOS_UI_GetToggleFriendsButton(IntPtr handle, IntPtr options)
		{
			var _GetToggleFriendsButtonOptionspublic = Marshal.PtrToStructure<GetToggleFriendsButtonOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static UI.KeyCombination EOS_UI_GetToggleFriendsKey(IntPtr handle, IntPtr options)
		{
			var _GetToggleFriendsKeyOptionspublic = Marshal.PtrToStructure<GetToggleFriendsKeyOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_UI_HideFriends(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _HideFriendsOptionspublic = Marshal.PtrToStructure<HideFriendsOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: UI.OnHideFriendsCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_UI_IsSocialOverlayPaused(IntPtr handle, IntPtr options)
		{
			var _IsSocialOverlayPausedOptionspublic = Marshal.PtrToStructure<IsSocialOverlayPausedOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_UI_IsValidButtonCombination(IntPtr handle, UI.InputStateButtonFlags buttonCombination)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_UI_IsValidKeyCombination(IntPtr handle, UI.KeyCombination keyCombination)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_UI_PauseSocialOverlay(IntPtr handle, IntPtr options)
		{
			var _PauseSocialOverlayOptionspublic = Marshal.PtrToStructure<PauseSocialOverlayOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_UI_PrePresent(IntPtr handle, IntPtr options)
		{
			var _PrePresentOptionspublic = Marshal.PtrToStructure<PrePresentOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_UI_RemoveNotifyDisplaySettingsUpdated(IntPtr handle, ulong id)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_UI_RemoveNotifyMemoryMonitor(IntPtr handle, ulong id)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_UI_ReportInputState(IntPtr handle, IntPtr options)
		{
			var _ReportInputStateOptionspublic = Marshal.PtrToStructure<ReportInputStateOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_UI_SetDisplayPreference(IntPtr handle, IntPtr options)
		{
			var _SetDisplayPreferenceOptionspublic = Marshal.PtrToStructure<SetDisplayPreferenceOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_UI_SetToggleFriendsButton(IntPtr handle, IntPtr options)
		{
			var _SetToggleFriendsButtonOptionspublic = Marshal.PtrToStructure<SetToggleFriendsButtonOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_UI_SetToggleFriendsKey(IntPtr handle, IntPtr options)
		{
			var _SetToggleFriendsKeyOptionspublic = Marshal.PtrToStructure<SetToggleFriendsKeyOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_UI_ShowBlockPlayer(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _ShowBlockPlayerOptionspublic = Marshal.PtrToStructure<ShowBlockPlayerOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: UI.OnShowBlockPlayerCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_UI_ShowFriends(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _ShowFriendsOptionspublic = Marshal.PtrToStructure<ShowFriendsOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: UI.OnShowFriendsCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_UI_ShowNativeProfile(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _ShowNativeProfileOptionspublic = Marshal.PtrToStructure<ShowNativeProfileOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: UI.OnShowNativeProfileCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_UI_ShowReportPlayer(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _ShowReportPlayerOptionspublic = Marshal.PtrToStructure<ShowReportPlayerOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: UI.OnShowReportPlayerCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_UserInfo_BestDisplayName_Release(IntPtr bestDisplayName)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_UserInfo_CopyBestDisplayName(IntPtr handle, IntPtr options, IntPtr outBestDisplayName)
		{
			var _CopyBestDisplayNameOptionspublic = Marshal.PtrToStructure<CopyBestDisplayNameOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_UserInfo_CopyBestDisplayNameWithPlatform(IntPtr handle, IntPtr options, IntPtr outBestDisplayName)
		{
			var _CopyBestDisplayNameWithPlatformOptionspublic = Marshal.PtrToStructure<CopyBestDisplayNameWithPlatformOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_UserInfo_CopyExternalUserInfoByAccountId(IntPtr handle, IntPtr options, IntPtr outExternalUserInfo)
		{
			var _CopyExternalUserInfoByAccountIdOptionspublic = Marshal.PtrToStructure<CopyExternalUserInfoByAccountIdOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_UserInfo_CopyExternalUserInfoByAccountType(IntPtr handle, IntPtr options, IntPtr outExternalUserInfo)
		{
			var _CopyExternalUserInfoByAccountTypeOptionspublic = Marshal.PtrToStructure<CopyExternalUserInfoByAccountTypeOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_UserInfo_CopyExternalUserInfoByIndex(IntPtr handle, IntPtr options, IntPtr outExternalUserInfo)
		{
			var _CopyExternalUserInfoByIndexOptionspublic = Marshal.PtrToStructure<CopyExternalUserInfoByIndexOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_UserInfo_CopyUserInfo(IntPtr handle, IntPtr options, IntPtr outUserInfo)
		{
			var _CopyUserInfoOptionspublic = Marshal.PtrToStructure<CopyUserInfoOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_UserInfo_ExternalUserInfo_Release(IntPtr externalUserInfo)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_UserInfo_GetExternalUserInfoCount(IntPtr handle, IntPtr options)
		{
			var _GetExternalUserInfoCountOptionspublic = Marshal.PtrToStructure<GetExternalUserInfoCountOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_UserInfo_GetLocalPlatformType(IntPtr handle, IntPtr options)
		{
			var _GetLocalPlatformTypeOptionspublic = Marshal.PtrToStructure<GetLocalPlatformTypeOptionspublic>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_UserInfo_QueryUserInfo(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryUserInfoOptionspublic = Marshal.PtrToStructure<QueryUserInfoOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: UserInfo.OnQueryUserInfoCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_UserInfo_QueryUserInfoByDisplayName(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryUserInfoByDisplayNameOptionspublic = Marshal.PtrToStructure<QueryUserInfoByDisplayNameOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: UserInfo.OnQueryUserInfoByDisplayNameCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_UserInfo_QueryUserInfoByExternalAccount(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryUserInfoByExternalAccountOptionspublic = Marshal.PtrToStructure<QueryUserInfoByExternalAccountOptionspublic>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: UserInfo.OnQueryUserInfoByExternalAccountCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_UserInfo_Release(IntPtr userInfo)
        {
        }

        #endregion
#endif
    }
}
