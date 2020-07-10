/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace SQLite4Unity3d
{
	public static class SQLite3 // TypeDefIndex: 15476
	{
		// Nested types
		public enum Result // TypeDefIndex: 15477
		{
			OK = 0,
			Error = 1,
			Internal = 2,
			Perm = 3,
			Abort = 4,
			Busy = 5,
			Locked = 6,
			NoMem = 7,
			ReadOnly = 8,
			Interrupt = 9,
			IOError = 10,
			Corrupt = 11,
			NotFound = 12,
			Full = 13,
			CannotOpen = 14,
			LockErr = 15,
			Empty = 16,
			SchemaChngd = 17,
			TooBig = 18,
			Constraint = 19,
			Mismatch = 20,
			Misuse = 21,
			NotImplementedLFS = 22,
			AccessDenied = 23,
			Format = 24,
			Range = 25,
			NonDBFile = 26,
			Notice = 27,
			Warning = 28,
			Row = 100,
			Done = 101
		}
	
		public enum ExtendedResult // TypeDefIndex: 15478
		{
			BusyRecovery = 261,
			LockedSharedcache = 262,
			ReadonlyRecovery = 264,
			IOErrorRead = 266,
			CorruptVTab = 267,
			CannottOpenNoTempDir = 270,
			ConstraintCheck = 275,
			NoticeRecoverWAL = 283,
			AbortRollback = 516,
			ReadonlyCannotLock = 520,
			IOErrorShortRead = 522,
			CannotOpenIsDir = 526,
			ConstraintCommitHook = 531,
			NoticeRecoverRollback = 539,
			ReadonlyRollback = 776,
			IOErrorWrite = 778,
			CannotOpenFullPath = 782,
			ConstraintForeignKey = 787,
			IOErrorFsync = 1034,
			ConstraintFunction = 1043,
			IOErrorDirFSync = 1290,
			ConstraintNotNull = 1299,
			IOErrorTruncate = 1546,
			ConstraintPrimaryKey = 1555,
			IOErrorFStat = 1802,
			ConstraintTrigger = 1811,
			IOErrorUnlock = 2058,
			ConstraintUnique = 2067,
			IOErrorRdlock = 2314,
			ConstraintVTab = 2323,
			IOErrorDelete = 2570,
			IOErrorBlocked = 2826,
			IOErrorNoMem = 3082,
			IOErrorAccess = 3338,
			IOErrorCheckReservedLock = 3594,
			IOErrorLock = 3850,
			IOErrorClose = 4106,
			IOErrorDirClose = 4362,
			IOErrorSHMOpen = 4618,
			IOErrorSHMSize = 4874,
			IOErrorSHMLock = 5130,
			IOErrorSHMMap = 5386,
			IOErrorSeek = 5642,
			IOErrorDeleteNoEnt = 5898,
			IOErrorMMap = 6154
		}
	
		public enum ConfigOption // TypeDefIndex: 15479
		{
			SingleThread = 1,
			MultiThread = 2,
			Serialized = 3
		}
	
		public enum ColType // TypeDefIndex: 15480
		{
			Integer = 1,
			Float = 2,
			Text = 3,
			Blob = 4,
			Null = 5
		}
	
		// Methods
		public static extern Result Open(string filename, out IntPtr db); // 0x0000000180E157C0-0x0000000180E15880
		public static extern Result Open(string filename, out IntPtr db, int flags, IntPtr zvfs); // 0x0000000180E15880-0x0000000180E15960
		public static extern Result Open(byte[] filename, out IntPtr db, int flags, IntPtr zvfs); // 0x0000000180E15960-0x0000000180E15A30
		public static extern Result Open16(string filename, out IntPtr db); // 0x0000000180E15710-0x0000000180E157C0
		public static extern Result EnableLoadExtension(IntPtr db, int onoff); // 0x0000000180E151E0-0x0000000180E15290
		public static extern Result Close(IntPtr db); // 0x0000000180E14570-0x0000000180E14610
		public static extern Result Initialize(); // 0x0000000180E15550-0x0000000180E155E0
		public static extern Result Shutdown(); // 0x0000000180E15DE0-0x0000000180E15E70
		public static extern Result Config(ConfigOption option); // 0x0000000180E15140-0x0000000180E151E0
		public static extern int SetDirectory(uint directoryType, string directoryPath); // 0x0000000180E15D30-0x0000000180E15DE0
		public static extern Result BusyTimeout(IntPtr db, int milliseconds); // 0x0000000180E14420-0x0000000180E144D0
		public static extern int Changes(IntPtr db); // 0x0000000180E144D0-0x0000000180E14570
		public static extern Result Prepare2(IntPtr db, string sql, int numBytes, out IntPtr stmt, IntPtr pzTail); // 0x0000000180E15BA0-0x0000000180E15C90
		public static IntPtr Prepare2(IntPtr db, string query); // 0x0000000180E15A30-0x0000000180E15BA0
		public static extern Result Step(IntPtr stmt); // 0x0000000180E15E70-0x0000000180E15F10
		public static extern Result Reset(IntPtr stmt); // 0x0000000180E15C90-0x0000000180E15D30
		public static extern Result Finalize(IntPtr stmt); // 0x0000000180E153D0-0x0000000180E15470
		public static extern long LastInsertRowid(IntPtr db); // 0x0000000180E155E0-0x0000000180E15680
		public static extern IntPtr Errmsg(IntPtr db); // 0x0000000180E15290-0x0000000180E15330
		public static string GetErrmsg(IntPtr db); // 0x0000000180E15470-0x0000000180E15550
		public static extern int BindParameterIndex(IntPtr stmt, string name); // 0x0000000180E14270-0x0000000180E14340
		public static extern int BindNull(IntPtr stmt, int index); // 0x0000000180E141C0-0x0000000180E14270
		public static extern int BindInt(IntPtr stmt, int index, int val); // 0x0000000180E14110-0x0000000180E141C0
		public static extern int BindInt64(IntPtr stmt, int index, long val); // 0x0000000180E14060-0x0000000180E14110
		public static extern int BindDouble(IntPtr stmt, int index, double val); // 0x0000000180E13FA0-0x0000000180E14060
		public static extern int BindText(IntPtr stmt, int index, string val, int n, IntPtr free); // 0x0000000180E14340-0x0000000180E14420
		public static extern int BindBlob(IntPtr stmt, int index, byte[] val, int n, IntPtr free); // 0x0000000180E13EC0-0x0000000180E13FA0
		public static extern int ColumnCount(IntPtr stmt); // 0x0000000180E14940-0x0000000180E149E0
		public static extern IntPtr ColumnName(IntPtr stmt, int index); // 0x0000000180E14D90-0x0000000180E14E40
		private static extern IntPtr ColumnName16Internal(IntPtr stmt, int index); // 0x0000000180E14BF0-0x0000000180E14CA0
		public static string ColumnName16(IntPtr stmt, int index); // 0x0000000180E14CA0-0x0000000180E14D90
		public static extern ColType ColumnType(IntPtr stmt, int index); // 0x0000000180E15090-0x0000000180E15140
		public static extern int ColumnInt(IntPtr stmt, int index); // 0x0000000180E14B40-0x0000000180E14BF0
		public static extern long ColumnInt64(IntPtr stmt, int index); // 0x0000000180E14A90-0x0000000180E14B40
		public static extern double ColumnDouble(IntPtr stmt, int index); // 0x0000000180E149E0-0x0000000180E14A90
		public static extern IntPtr ColumnText(IntPtr stmt, int index); // 0x0000000180E14FE0-0x0000000180E15090
		public static extern IntPtr ColumnText16(IntPtr stmt, int index); // 0x0000000180E14F30-0x0000000180E14FE0
		public static extern IntPtr ColumnBlob(IntPtr stmt, int index); // 0x0000000180E14610-0x0000000180E146C0
		public static extern int ColumnBytes(IntPtr stmt, int index); // 0x0000000180E14890-0x0000000180E14940
		public static string ColumnString(IntPtr stmt, int index); // 0x0000000180E14E40-0x0000000180E14F30
		public static byte[] ColumnByteArray(IntPtr stmt, int index); // 0x0000000180E146C0-0x0000000180E14890
		public static extern ExtendedResult ExtendedErrCode(IntPtr db); // 0x0000000180E15330-0x0000000180E153D0
		public static extern int LibVersionNumber(); // 0x0000000180E15680-0x0000000180E15710
	}
}
