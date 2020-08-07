/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class ErrorCode // TypeDefIndex: 11064
{
	// Fields
	private static readonly IDictionary<int, ErrorCode> _errorCodesLookup; // 0x00
	private static bool _isErrorCodesLookupInitialized; // 0x08
	private static bool _isInitializingErrorCodes; // 0x09
	private int _code; // 0x10
	private string _subcode; // 0x18
	private string _internalErrorText; // 0x20
	private bool _isShownAsError; // 0x28
	private bool _isInitialized; // 0x29

	// Properties
	[ErrorCodeDefinition] // 0x00000001801CDAD0-0x00000001801CDAE0
	public static ErrorCode None { get; } // 0x0000000180860810-0x0000000180860870 
	[ErrorCodeDefinition] // 0x00000001801CDAD0-0x00000001801CDAE0
	public static ErrorCode DeviceUnsupported { get; } // 0x0000000180860180-0x00000001808601E0 
	[ErrorCodeDefinition] // 0x00000001801CDAD0-0x00000001801CDAE0
	public static ErrorCode NoInternet { get; } // 0x00000001808607B0-0x0000000180860810 
	[ErrorCodeDefinition] // 0x00000001801CDAD0-0x00000001801CDAE0
	public static ErrorCode CurrentStoreVersionNull { get; } // 0x0000000180860060-0x00000001808600C0 
	[ErrorCodeDefinition] // 0x00000001801CDAD0-0x00000001801CDAE0
	public static ErrorCode StoreVersionMismatchOfflineMode { get; } // 0x00000001808608D0-0x0000000180860930 
	[ErrorCodeDefinition] // 0x00000001801CDAD0-0x00000001801CDAE0
	public static ErrorCode StoreVersionMismatchOnlineMode { get; } // 0x0000000180860930-0x0000000180860990 
	[ErrorCodeDefinition] // 0x00000001801CDAD0-0x00000001801CDAE0
	public static ErrorCode UpdateInProgress { get; } // 0x0000000180860AC0-0x0000000180860B20 
	[ErrorCodeDefinition] // 0x00000001801CDAD0-0x00000001801CDAE0
	public static ErrorCode DisconnectPopupClosedReset { get; } // 0x00000001808601E0-0x0000000180860240 
	[ErrorCodeDefinition] // 0x00000001801CDAD0-0x00000001801CDAE0
	public static ErrorCode FailedBackgroundInternetCheck { get; } // 0x00000001808602B0-0x0000000180860310 
	[ErrorCodeDefinition] // 0x00000001801CDAD0-0x00000001801CDAE0
	public static ErrorCode LostServerConnection { get; } // 0x0000000180860630-0x0000000180860690 
	[ErrorCodeDefinition] // 0x00000001801CDAD0-0x00000001801CDAE0
	public static ErrorCode BundleDownloadFailure { get; } // 0x000000018085FE70-0x000000018085FED0 
	[ErrorCodeDefinition] // 0x00000001801CDAD0-0x00000001801CDAE0
	public static ErrorCode IncompatibleBundleFailure { get; } // 0x0000000180860430-0x0000000180860490 
	[ErrorCodeDefinition] // 0x00000001801CDAD0-0x00000001801CDAE0
	public static ErrorCode FailedToFreeUpDiskSpace { get; } // 0x0000000180860310-0x0000000180860370 
	[ErrorCodeDefinition] // 0x00000001801CDAD0-0x00000001801CDAE0
	public static ErrorCode LoadedEmptyAssetBundle { get; } // 0x0000000180860570-0x00000001808605D0 
	[ErrorCodeDefinition] // 0x00000001801CDAD0-0x00000001801CDAE0
	public static ErrorCode UnencryptedChartData { get; } // 0x0000000180860A60-0x0000000180860AC0 
	[ErrorCodeDefinition] // 0x00000001801CDAD0-0x00000001801CDAE0
	public static ErrorCode ChangingLanguages { get; } // 0x000000018085FED0-0x000000018085FF30 
	[ErrorCodeDefinition] // 0x00000001801CDAD0-0x00000001801CDAE0
	public static ErrorCode DownloadManifestHashRetryExceeded { get; } // 0x0000000180860240-0x00000001808602A0 
	[ErrorCodeDefinition] // 0x00000001801CDAD0-0x00000001801CDAE0
	public static ErrorCode ServerManifestChanged { get; } // 0x0000000180860870-0x00000001808608D0 
	[ErrorCodeDefinition] // 0x00000001801CDAD0-0x00000001801CDAE0
	public static ErrorCode ChartDownloadProgressStalled { get; } // 0x000000018085FF90-0x000000018085FFF0 
	[ErrorCodeDefinition] // 0x00000001801CDAD0-0x00000001801CDAE0
	public static ErrorCode ChartDownloadFailure { get; } // 0x000000018085FF30-0x000000018085FF90 
	[ErrorCodeDefinition] // 0x00000001801CDAD0-0x00000001801CDAE0
	public static ErrorCode DatabaseDoesNotExist { get; } // 0x00000001808600C0-0x0000000180860120 
	[ErrorCodeDefinition] // 0x00000001801CDAD0-0x00000001801CDAE0
	public static ErrorCode DatabaseFileDownloadRetryLimitExceeded { get; } // 0x0000000180860120-0x0000000180860180 
	[ErrorCodeDefinition] // 0x00000001801CDAD0-0x00000001801CDAE0
	public static ErrorCode NoCachedDatabaseFileForcedOfflineMode { get; } // 0x0000000180860690-0x00000001808606F0 
	[ErrorCodeDefinition] // 0x00000001801CDAD0-0x00000001801CDAE0
	public static ErrorCode NoCachedHashForDatabaseFileOfflineMode { get; } // 0x0000000180860750-0x00000001808607B0 
	[ErrorCodeDefinition] // 0x00000001801CDAD0-0x00000001801CDAE0
	public static ErrorCode NoCachedDatabaseFileOfflineMode { get; } // 0x00000001808606F0-0x0000000180860750 
	[ErrorCodeDefinition] // 0x00000001801CDAD0-0x00000001801CDAE0
	public static ErrorCode LoadingTimeout { get; } // 0x00000001808605D0-0x0000000180860630 
	[ErrorCodeDefinition] // 0x00000001801CDAD0-0x00000001801CDAE0
	public static ErrorCode TarFailure { get; } // 0x0000000180860A00-0x0000000180860A60 
	[ErrorCodeDefinition] // 0x00000001801CDAD0-0x00000001801CDAE0
	public static ErrorCode HangingLoadingScreen { get; } // 0x0000000180860370-0x00000001808603D0 
	[ErrorCodeDefinition] // 0x00000001801CDAD0-0x00000001801CDAE0
	public static ErrorCode IdleUserTimeout { get; } // 0x00000001808603D0-0x0000000180860430 
	protected virtual int ErrorCodeLowerBound { get; } // 0x000000018037DDC0-0x000000018037DDD0 
	protected virtual int ErrorCodeUpperBound { get; } // 0x00000001808602A0-0x00000001808602B0 
	public int Code { get; } // 0x000000018085FFF0-0x0000000180860060 
	public string Subcode { get; } // 0x0000000180860990-0x0000000180860A00 
	public string InternalErrorText { get; } // 0x0000000180860490-0x0000000180860500 
	public bool IsShownAsError { get; } // 0x0000000180860500-0x0000000180860570 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 11065
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<int, int> <>9__61_0; // 0x08
		public static Func<Type, bool> <>9__65_0; // 0x10
		public static Func<CustomAttributeData, bool> <>9__65_2; // 0x18
		public static Func<PropertyInfo, bool> <>9__65_1; // 0x20

		// Constructors
		static <>c(); // 0x000000018086C2C0-0x000000018086C320
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal int <GetAllCodes>b__61_0(int k); // 0x000000018055A6D0-0x000000018055A6E0
		internal bool <InitializeErrorCodes>b__65_0(Type t); // 0x000000018086BB60-0x000000018086BC50
		internal bool <InitializeErrorCodes>b__65_1(PropertyInfo p); // 0x000000018086BC50-0x000000018086BD60
		internal bool <InitializeErrorCodes>b__65_2(CustomAttributeData c); // 0x000000018086BD60-0x000000018086BDF0
	}

	// Constructors
	public ErrorCode(); // 0x0000000180373240-0x0000000180373250
	static ErrorCode(); // 0x000000018085FDF0-0x000000018085FE70

	// Methods
	public static int[] GetAllCodes(); // 0x000000018085EE90-0x000000018085EFF0
	public static bool Contains(int code); // 0x000000018085ED60-0x000000018085EDE0
	public static ErrorCode Get(int code); // 0x000000018085F070-0x000000018085F150
	protected static T DefineErrorCode<T>(int code, string internalErrorText, bool isShownAsError)
		where T : ErrorCode, new();
	private static void InitializeErrorCodes(); // 0x000000018085F430-0x000000018085F960
	public ErrorCode WithSubCode(string subCode); // 0x000000018085FD70-0x000000018085FDF0
	public override bool Equals(object obj); // 0x000000018085EDE0-0x000000018085EE90
	public override int GetHashCode(); // 0x000000018085EFF0-0x000000018085F070
	public override string ToString(); // 0x000000018085F960-0x000000018085F970
	public string ToString(bool displayInternalErrorText); // 0x000000018085F970-0x000000018085FD70
	private void InitializeErrorCode(int code, string internalErrorText, bool isShownAsError); // 0x000000018085F150-0x000000018085F430
	private void CheckInitialization(); // 0x000000018085ECF0-0x000000018085ED60
}

