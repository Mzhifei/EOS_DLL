﻿using EOS_SDK._Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EOS_SDK.Achievements
{
    public unsafe class Achievements_Exports
    {
        #region Notify
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong _EOS_Achievements_AddNotifyAchievementsUnlocked(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
        {
            _log.Logger.WriteDebug($"{nameof(_EOS_Achievements_AddNotifyAchievementsUnlocked)} Called", Logging.LogCategory.Achievements);
            if (!EOS_Main.GetPlatform().CheckArgs(handle, notificationFn))
                return 0;
            var _AddNotifyAchievementsUnlockedOptions = Marshal.PtrToStructure<AddNotifyAchievementsUnlockedOptions>(options);
            if (notificationFn == IntPtr.Zero)
                return 0;
            OnAchievementsUnlockedCallbackInfo callbackInfo = new()
            { 
                ClientData = clientData
            };
            var id = NotifyManager.AddNotify(nameof(_EOS_Achievements_AddNotifyAchievementsUnlocked), notificationFn, callbackInfo);
            return id;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong _EOS_Achievements_AddNotifyAchievementsUnlockedV2(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
        {
            _log.Logger.WriteDebug($"{nameof(_EOS_Achievements_AddNotifyAchievementsUnlockedV2)} Called", Logging.LogCategory.Achievements);
            if (!EOS_Main.GetPlatform().CheckArgs(handle, notificationFn))
                return 0;
            var _AddNotifyAchievementsUnlockedV2Options = Marshal.PtrToStructure<AddNotifyAchievementsUnlockedV2Options>(options);
            if (notificationFn == IntPtr.Zero)
                return 0;
            OnAchievementsUnlockedCallbackV2Info callbackInfo = new()
            {
                ClientData = clientData
            };
            var id = NotifyManager.AddNotify(nameof(_EOS_Achievements_AddNotifyAchievementsUnlockedV2), notificationFn, callbackInfo);
            return id;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void _EOS_Achievements_RemoveNotifyAchievementsUnlocked(IntPtr handle, ulong inId)
        {
            _log.Logger.WriteDebug($"{nameof(_EOS_Achievements_RemoveNotifyAchievementsUnlocked)} Called", Logging.LogCategory.Achievements);
            var handler = EOS_Main.GetPlatform().GetHandler<Achievements_Handler>(handle);
            if (handler == null)
                return;
            NotifyManager.RemoveNotify(inId);
        }
        #endregion
        #region AchievementDefinition
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_Achievements_CopyAchievementDefinitionByAchievementId(IntPtr handle, IntPtr options, IntPtr outDefinition)
        {
            _log.Logger.WriteDebug($"{nameof(_EOS_Achievements_CopyAchievementDefinitionByAchievementId)} Called", Logging.LogCategory.Achievements);
            if (!EOS_Main.GetPlatform().CheckArgs(handle, outDefinition))
                return 0;
            var handler = EOS_Main.GetPlatform().GetHandler<Achievements_Handler>(handle);
            if (handler == null)
                return (int)Result.NotImplemented;
            var _CopyAchievementDefinitionByAchievementIdOptions = Marshal.PtrToStructure<CopyAchievementDefinitionByAchievementIdOptions>(options);
            if (!handler.IsAchiExist(_CopyAchievementDefinitionByAchievementIdOptions.AchievementId))
                return (int)Result.InvalidParameters;
            Definition definition = handler.GetDefinition(_CopyAchievementDefinitionByAchievementIdOptions.AchievementId);
            Helpers.StructWriteOut(definition, outDefinition);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_Achievements_CopyAchievementDefinitionByIndex(IntPtr handle, IntPtr options, IntPtr outDefinition)
        {
            _log.Logger.WriteDebug($"{nameof(_EOS_Achievements_CopyAchievementDefinitionByIndex)} Called", Logging.LogCategory.Achievements);
            if (!EOS_Main.GetPlatform().CheckArgs(handle, outDefinition))
                return (int)Result.InvalidParameters;
            var handler = EOS_Main.GetPlatform().GetHandler<Achievements_Handler>(handle);
            if (handler == null)
                return (int)Result.NotImplemented;
            var _CopyAchievementDefinitionByIndexOptions = Marshal.PtrToStructure<CopyAchievementDefinitionByIndexOptions>(options);
            if (!handler.IsAchiExistIndex(_CopyAchievementDefinitionByIndexOptions.AchievementIndex))
                return (int)Result.InvalidParameters;
            Definition definition = handler.GetDefinitionIndex(_CopyAchievementDefinitionByIndexOptions.AchievementIndex);
            Helpers.StructWriteOut(definition, outDefinition);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void _EOS_Achievements_Definition_Release(IntPtr achievementDefinition)
        {
            _log.Logger.WriteDebug($"{nameof(_EOS_Achievements_Definition_Release)} Called", Logging.LogCategory.Achievements);
            var def = Marshal.PtrToStructure<Definition>(achievementDefinition);
            Helpers.DestroyStructArray<StatThresholds>(def.StatThresholds, def.StatThresholdsCount);
            Helpers.Destroy<Definition>(achievementDefinition);
        }
        #endregion
        #region AchievementDefinitionV2
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_Achievements_CopyAchievementDefinitionV2ByAchievementId(IntPtr handle, IntPtr options, IntPtr outDefinition)
        {
            _log.Logger.WriteDebug($"{nameof(_EOS_Achievements_CopyAchievementDefinitionV2ByAchievementId)} Called", Logging.LogCategory.Achievements);
            if (!EOS_Main.GetPlatform().CheckArgs(handle, outDefinition))
                return 0;
            var handler = EOS_Main.GetPlatform().GetHandler<Achievements_Handler>(handle);
            if (handler == null)
                return (int)Result.NotImplemented;
            var _CopyAchievementDefinitionV2ByAchievementIdOptions = Marshal.PtrToStructure<CopyAchievementDefinitionV2ByAchievementIdOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_Achievements_CopyAchievementDefinitionV2ByIndex(IntPtr handle, IntPtr options, IntPtr outDefinition)
        {
            _log.Logger.WriteDebug($"{nameof(_EOS_Achievements_CopyAchievementDefinitionV2ByIndex)} Called", Logging.LogCategory.Achievements);
            if (!EOS_Main.GetPlatform().CheckArgs(handle, outDefinition))
                return 0;
            var handler = EOS_Main.GetPlatform().GetHandler<Achievements_Handler>(handle);
            if (handler == null)
                return (int)Result.NotImplemented;
            var _CopyAchievementDefinitionV2ByIndexOptions = Marshal.PtrToStructure<CopyAchievementDefinitionV2ByIndexOptions>(options);
            return (int)Result.Success;
        }


        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void _EOS_Achievements_DefinitionV2_Release(IntPtr achievementDefinition)
        {
            _log.Logger.WriteDebug($"{nameof(_EOS_Achievements_DefinitionV2_Release)} Called", Logging.LogCategory.Achievements);

        }
        #endregion
        #region PlayerAchievement
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_Achievements_CopyPlayerAchievementByAchievementId(IntPtr handle, IntPtr options, IntPtr outAchievement)
        {
            _log.Logger.WriteDebug($"{nameof(_EOS_Achievements_CopyPlayerAchievementByAchievementId)} Called", Logging.LogCategory.Achievements);
            if (!EOS_Main.GetPlatform().CheckArgs(handle, outAchievement))
                return 0;
            var handler = EOS_Main.GetPlatform().GetHandler<Achievements_Handler>(handle);
            if (handler == null)
                return (int)Result.NotImplemented;
            var _CopyPlayerAchievementByAchievementIdOptions = Marshal.PtrToStructure<CopyPlayerAchievementByAchievementIdOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_Achievements_CopyPlayerAchievementByIndex(IntPtr handle, IntPtr options, IntPtr outAchievement)
        {
            _log.Logger.WriteDebug($"{nameof(_EOS_Achievements_CopyPlayerAchievementByIndex)} Called", Logging.LogCategory.Achievements);
            if (!EOS_Main.GetPlatform().CheckArgs(handle, outAchievement))
                return 0;
            var handler = EOS_Main.GetPlatform().GetHandler<Achievements_Handler>(handle);
            if (handler == null)
                return (int)Result.NotImplemented;
            var _CopyPlayerAchievementByIndexOptions = Marshal.PtrToStructure<CopyPlayerAchievementByIndexOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void _EOS_Achievements_PlayerAchievement_Release(IntPtr achievement)
        {
            _log.Logger.WriteDebug($"{nameof(_EOS_Achievements_PlayerAchievement_Release)} Called", Logging.LogCategory.Achievements);

        }
        #endregion
        #region Count Getter
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint _EOS_Achievements_GetAchievementDefinitionCount(IntPtr handle, IntPtr options)
        {
            _log.Logger.WriteDebug($"{nameof(_EOS_Achievements_GetAchievementDefinitionCount)} Called", Logging.LogCategory.Achievements);
            var _GetAchievementDefinitionCountOptions = Marshal.PtrToStructure<GetAchievementDefinitionCountOptions>(options);
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint _EOS_Achievements_GetPlayerAchievementCount(IntPtr handle, IntPtr options)
        {
            _log.Logger.WriteDebug($"{nameof(_EOS_Achievements_GetPlayerAchievementCount)} Called", Logging.LogCategory.Achievements);
            var _GetPlayerAchievementCountOptions = Marshal.PtrToStructure<GetPlayerAchievementCountOptions>(options);
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint _EOS_Achievements_GetUnlockedAchievementCount(IntPtr handle, IntPtr options)
        {
            _log.Logger.WriteDebug($"{nameof(_EOS_Achievements_GetUnlockedAchievementCount)} Called", Logging.LogCategory.Achievements);
            var _GetUnlockedAchievementCountOptions = Marshal.PtrToStructure<GetUnlockedAchievementCountOptions>(options);
            return 0;
        }
        #endregion
        #region Query
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void _EOS_Achievements_QueryDefinitions(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            _log.Logger.WriteDebug($"{nameof(_EOS_Achievements_QueryDefinitions)} Called", Logging.LogCategory.Achievements);
            if (!EOS_Main.GetPlatform().CheckArgs(handle, completionDelegate))
                return;
            var handler = EOS_Main.GetPlatform().GetHandler<Achievements_Handler>(handle);
            if (handler == null)
                return;
            var _QueryDefinitionsOptions = Marshal.PtrToStructure<QueryDefinitionsOptions>(options);
            OnQueryDefinitionsCompleteCallbackInfo info = new OnQueryDefinitionsCompleteCallbackInfo()
            {
                ClientData = clientData,
                ResultCode = Result.Success
            };
            CallbackManager.AddCallback(completionDelegate, info, nameof(_EOS_Achievements_QueryDefinitions));
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void _EOS_Achievements_QueryPlayerAchievements(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            _log.Logger.WriteDebug($"{nameof(_EOS_Achievements_QueryPlayerAchievements)} Called", Logging.LogCategory.Achievements);
            if (!EOS_Main.GetPlatform().CheckArgs(handle, completionDelegate))
                return;
            var handler = EOS_Main.GetPlatform().GetHandler<Achievements_Handler>(handle);
            if (handler == null)
                return;

            var _QueryPlayerAchievementsOptions = Marshal.PtrToStructure<QueryPlayerAchievementsOptions>(options);

            //  TODO Send network achivement.


            OnQueryPlayerAchievementsCompleteCallbackInfo onQueryPlayerAchievementsCompleteCallbackInfo = new()
            { 
                ClientData = clientData,
                ResultCode = Result.Success,
                UserId = _QueryPlayerAchievementsOptions.LocalUserId
            };

            CallbackManager.AddCallback(completionDelegate, onQueryPlayerAchievementsCompleteCallbackInfo, nameof(_EOS_Achievements_QueryPlayerAchievements));
        }
        #endregion
        #region UnlockAchivement
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void _EOS_Achievements_UnlockAchievements(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            _log.Logger.WriteDebug($"{nameof(_EOS_Achievements_UnlockAchievements)} Called", Logging.LogCategory.Achievements);
            if (!EOS_Main.GetPlatform().CheckArgs(handle, completionDelegate))
                return;
            var handler = EOS_Main.GetPlatform().GetHandler<Achievements_Handler>(handle);
            if (handler == null)
                return;

            var _UnlockAchievementsOptions = Marshal.PtrToStructure<UnlockAchievementsOptions>(options);
            _UnlockAchievementsOptions = handler.UnlockAchievements(_UnlockAchievementsOptions);

            NotifyManager.TriggerNotify(nameof(_EOS_Achievements_AddNotifyAchievementsUnlocked), _UnlockAchievementsOptions);

            OnUnlockAchievementsCompleteCallbackInfo onUnlockAchievementsCompleteCallbackInfo = new()
            {
                ClientData = clientData,
                ResultCode = Result.Success,
                AchievementsCount = _UnlockAchievementsOptions.AchievementsCount,
                UserId = _UnlockAchievementsOptions.UserId
            };
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: OnUnlockAchievementsCompleteCallback
            CallbackManager.AddCallback(completionDelegate, onUnlockAchievementsCompleteCallbackInfo, nameof(_EOS_Achievements_QueryDefinitions));
        }
        #endregion
        #region UnlockedAchievement

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_Achievements_CopyUnlockedAchievementByAchievementId(IntPtr handle, IntPtr options, IntPtr outAchievement)
        {
            _log.Logger.WriteDebug($"{nameof(_EOS_Achievements_CopyUnlockedAchievementByAchievementId)} Called", Logging.LogCategory.Achievements);
            var _CopyUnlockedAchievementByAchievementIdOptions = Marshal.PtrToStructure<CopyUnlockedAchievementByAchievementIdOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_Achievements_CopyUnlockedAchievementByIndex(IntPtr handle, IntPtr options, IntPtr outAchievement)
        {
            _log.Logger.WriteDebug($"{nameof(_EOS_Achievements_CopyUnlockedAchievementByIndex)} Called", Logging.LogCategory.Achievements);
            var _CopyUnlockedAchievementByIndexOptions = Marshal.PtrToStructure<CopyUnlockedAchievementByIndexOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void _EOS_Achievements_UnlockedAchievement_Release(IntPtr achievement)
        {
            _log.Logger.WriteDebug($"{nameof(_EOS_Achievements_UnlockedAchievement_Release)} Called", Logging.LogCategory.Achievements);
        }
        #endregion
    }
}
