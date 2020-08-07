/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace SQLite4Unity3d
{
	public static class SQLite3 // TypeDefIndex: 16315
	{
		// Nested types
		public enum Result // TypeDefIndex: 16316
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
	
		public enum ExtendedResult // TypeDefIndex: 16317
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
	
		public enum ConfigOption // TypeDefIndex: 16318
		{
			SingleThread = 1,
			MultiThread = 2,
			Serialized = 3
		}
	
		public enum ColType // TypeDefIndex: 16319
		{
			Integer = 1,
			Float = 2,
			Text = 3,
			Blob = 4,
			Null = 5
		}
	
		// Methods
		public static extern Result Open(string filename, out IntPtr db); // 0x00000001807471B0-0x0000000180747250
		public static extern Result Open(string filename, out IntPtr db, int flags, IntPtr zvfs); // 0x0000000180747250-0x0000000180747310
		public static extern Result Open(byte[] filename, out IntPtr db, int flags, IntPtr zvfs); // 0x0000000180747310-0x00000001807473C0
		public static extern Result Open16(string filename, out IntPtr db); // 0x0000000180747120-0x00000001807471B0
		public static extern Result EnableLoadExtension(IntPtr db, int onoff); // 0x0000000180746CF0-0x0000000180746D80
		public static extern Result Close(IntPtr db); // 0x00000001807462B0-0x0000000180746330
		public static extern Result Initialize(); // 0x0000000180746FC0-0x0000000180747030
		public static extern Result Shutdown(); // 0x00000001807476E0-0x0000000180747750
		public static extern Result Config(ConfigOption option); // 0x0000000180746C70-0x0000000180746CF0
		public static extern int SetDirectory(uint directoryType, string directoryPath); // 0x0000000180747650-0x00000001807476E0
		public static extern Result BusyTimeout(IntPtr db, int milliseconds); // 0x00000001807461A0-0x0000000180746230
		public static extern int Changes(IntPtr db); // 0x0000000180746230-0x00000001807462B0
		public static extern Result Prepare2(IntPtr db, string sql, int numBytes, out IntPtr stmt, IntPtr pzTail); // 0x0000000180747500-0x00000001807475D0
		public static IntPtr Prepare2(IntPtr db, string query); // 0x00000001807473C0-0x0000000180747500
		public static extern Result Step(IntPtr stmt); // 0x0000000180747750-0x00000001807477D0
		public static extern Result Reset(IntPtr stmt); // 0x00000001807475D0-0x0000000180747650
		public static extern Result Finalize(IntPtr stmt); // 0x0000000180746E80-0x0000000180746F00
		public static extern long LastInsertRowid(IntPtr db); // 0x0000000180747030-0x00000001807470B0
		public static extern IntPtr Errmsg(IntPtr db); // 0x0000000180746D80-0x0000000180746E00
		public static string GetErrmsg(IntPtr db); // 0x0000000180746F00-0x0000000180746FC0
		public static extern int BindParameterIndex(IntPtr stmt, string name); // 0x0000000180746030-0x00000001807460E0
		public static extern int BindNull(IntPtr stmt, int index); // 0x0000000180745FA0-0x0000000180746030
		public static extern int BindInt(IntPtr stmt, int index, int val); // 0x0000000180745F00-0x0000000180745FA0
		public static extern int BindInt64(IntPtr stmt, int index, long val); // 0x0000000180745E60-0x0000000180745F00
		public static extern int BindDouble(IntPtr stmt, int index, double val); // 0x0000000180745DC0-0x0000000180745E60
		public static extern int BindText(IntPtr stmt, int index, string val, int n, IntPtr free); // 0x00000001807460E0-0x00000001807461A0
		public static extern int BindBlob(IntPtr stmt, int index, byte[] val, int n, IntPtr free); // 0x0000000180745D00-0x0000000180745DC0
		public static extern int ColumnCount(IntPtr stmt); // 0x00000001807465D0-0x0000000180746650
		public static extern IntPtr ColumnName(IntPtr stmt, int index); // 0x0000000180746960-0x00000001807469F0
		private static extern IntPtr ColumnName16Internal(IntPtr stmt, int index); // 0x0000000180746800-0x0000000180746890
		public static string ColumnName16(IntPtr stmt, int index); // 0x0000000180746890-0x0000000180746960
		public static extern ColType ColumnType(IntPtr stmt, int index); // 0x0000000180746BE0-0x0000000180746C70
		public static extern int ColumnInt(IntPtr stmt, int index); // 0x0000000180746770-0x0000000180746800
		public static extern long ColumnInt64(IntPtr stmt, int index); // 0x00000001807466E0-0x0000000180746770
		public static extern double ColumnDouble(IntPtr stmt, int index); // 0x0000000180746650-0x00000001807466E0
		public static extern IntPtr ColumnText(IntPtr stmt, int index); // 0x0000000180746B50-0x0000000180746BE0
		public static extern IntPtr ColumnText16(IntPtr stmt, int index); // 0x0000000180746AC0-0x0000000180746B50
		public static extern IntPtr ColumnBlob(IntPtr stmt, int index); // 0x0000000180746330-0x00000001807463C0
		public static extern int ColumnBytes(IntPtr stmt, int index); // 0x0000000180746540-0x00000001807465D0
		public static string ColumnString(IntPtr stmt, int index); // 0x00000001807469F0-0x0000000180746AC0
		public static byte[] ColumnByteArray(IntPtr stmt, int index); // 0x00000001807463C0-0x0000000180746540
		public static extern ExtendedResult ExtendedErrCode(IntPtr db); // 0x0000000180746E00-0x0000000180746E80
		public static extern int LibVersionNumber(); // 0x00000001807470B0-0x0000000180747120
	}
}
