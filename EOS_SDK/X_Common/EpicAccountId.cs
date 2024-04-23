﻿using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace EOS_SDK.Others
{
    public unsafe class EpicAccountId
    {
        public const int EpicaccountidMaxLength = 32;
        public static string Static_EpicAccountId = "ffaabbccddeeff0123456789deadc0de";   //Init just for test stuff
        public const string Invalid_EpicAccountId = "ffffffffffffffffffffffffffffffff";

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr _EOS_EpicAccountId_FromString(IntPtr accountIdString)
        {
            string UserID = Helpers.ToString(accountIdString);
            if (UserID.Length == EpicaccountidMaxLength && Regex.Match(UserID, "[a-fA-F0-9]{32}").Success)
                Static_EpicAccountId = UserID;
            return Helpers.FromString(Static_EpicAccountId);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_EpicAccountId_IsValid(IntPtr accountId)
        {
            var UserId = Helpers.ToString(accountId);
            if (UserId.Length == EpicaccountidMaxLength)
                return 1;
            if (Regex.Match(UserId, "[a-fA-F0-9]{32}").Success)
                return 1;
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_EpicAccountId_ToString(IntPtr accountId, IntPtr outBuffer, [Out] int inOutBufferLength)
        {
            string UserID = Helpers.ToString(accountId);
            if (UserID.Length == EpicaccountidMaxLength && Regex.Match(UserID, "[a-fA-F0-9]{32}").Success)
                Static_EpicAccountId = UserID;
            else
                return (int)Result.InvalidUser;
            if (inOutBufferLength != EpicaccountidMaxLength + 1)
                return (int)Result.InvalidParameters;
            var ptr = Helpers.FromString(Static_EpicAccountId);
            Marshal.WriteIntPtr(outBuffer, 0, ptr);
            return (int)Result.Success;
        }

        public static string Generate()
        {
            var byets = RandomNumberGenerator.GetBytes(EpicaccountidMaxLength / 2);
            return Convert.ToHexString(byets).ToLower();
        }

        public static string Generator(string productId, string username)
        {
            byte[] bytes = new byte[EpicaccountidMaxLength / 2];

            for (int i = 0; i < EpicaccountidMaxLength / 2; ++i)
                bytes[i] = (byte)(productId[i] ^ username[i % username.Length] ^ 0xEA); // EA aka EpicAccound

            return Convert.ToHexString(bytes).ToLower();
        }
    }
}
