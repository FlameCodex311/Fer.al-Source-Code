/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class ErrorCode // TypeDefIndex: 13393
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
	[ErrorCodeDefinition] // 0x00000001800B36B0-0x00000001800B36C0
	public static ErrorCode None { get; } // 0x0000000181193CA0-0x0000000181193D00 
	[ErrorCodeDefinition] // 0x00000001800B36B0-0x00000001800B36C0
	public static ErrorCode DeviceUnsupported { get; } // 0x0000000181193610-0x0000000181193670 
	[ErrorCodeDefinition] // 0x00000001800B36B0-0x00000001800B36C0
	public static ErrorCode NoInternet { get; } // 0x0000000181193C40-0x0000000181193CA0 
	[ErrorCodeDefinition] // 0x00000001800B36B0-0x00000001800B36C0
	public static ErrorCode CurrentStoreVersionNull { get; } // 0x00000001811934F0-0x0000000181193550 
	[ErrorCodeDefinition] // 0x00000001800B36B0-0x00000001800B36C0
	public static ErrorCode StoreVersionMismatchOfflineMode { get; } // 0x0000000181193D60-0x0000000181193DC0 
	[ErrorCodeDefinition] // 0x00000001800B36B0-0x00000001800B36C0
	public static ErrorCode StoreVersionMismatchOnlineMode { get; } // 0x0000000181193DC0-0x0000000181193E20 
	[ErrorCodeDefinition] // 0x00000001800B36B0-0x00000001800B36C0
	public static ErrorCode UpdateInProgress { get; } // 0x0000000181193F50-0x0000000181193FB0 
	[ErrorCodeDefinition] // 0x00000001800B36B0-0x00000001800B36C0
	public static ErrorCode DisconnectPopupClosedReset { get; } // 0x0000000181193670-0x00000001811936D0 
	[ErrorCodeDefinition] // 0x00000001800B36B0-0x00000001800B36C0
	public static ErrorCode FailedBackgroundInternetCheck { get; } // 0x0000000181193740-0x00000001811937A0 
	[ErrorCodeDefinition] // 0x00000001800B36B0-0x00000001800B36C0
	public static ErrorCode LostServerConnection { get; } // 0x0000000181193AC0-0x0000000181193B20 
	[ErrorCodeDefinition] // 0x00000001800B36B0-0x00000001800B36C0
	public static ErrorCode BundleDownloadFailure { get; } // 0x0000000181193300-0x0000000181193360 
	[ErrorCodeDefinition] // 0x00000001800B36B0-0x00000001800B36C0
	public static ErrorCode IncompatibleBundleFailure { get; } // 0x00000001811938C0-0x0000000181193920 
	[ErrorCodeDefinition] // 0x00000001800B36B0-0x00000001800B36C0
	public static ErrorCode FailedToFreeUpDiskSpace { get; } // 0x00000001811937A0-0x0000000181193800 
	[ErrorCodeDefinition] // 0x00000001800B36B0-0x00000001800B36C0
	public static ErrorCode LoadedEmptyAssetBundle { get; } // 0x0000000181193A00-0x0000000181193A60 
	[ErrorCodeDefinition] // 0x00000001800B36B0-0x00000001800B36C0
	public static ErrorCode UnencryptedChartData { get; } // 0x0000000181193EF0-0x0000000181193F50 
	[ErrorCodeDefinition] // 0x00000001800B36B0-0x00000001800B36C0
	public static ErrorCode ChangingLanguages { get; } // 0x0000000181193360-0x00000001811933C0 
	[ErrorCodeDefinition] // 0x00000001800B36B0-0x00000001800B36C0
	public static ErrorCode DownloadManifestHashRetryExceeded { get; } // 0x00000001811936D0-0x0000000181193730 
	[ErrorCodeDefinition] // 0x00000001800B36B0-0x00000001800B36C0
	public static ErrorCode ServerManifestChanged { get; } // 0x0000000181193D00-0x0000000181193D60 
	[ErrorCodeDefinition] // 0x00000001800B36B0-0x00000001800B36C0
	public static ErrorCode ChartDownloadProgressStalled { get; } // 0x0000000181193420-0x0000000181193480 
	[ErrorCodeDefinition] // 0x00000001800B36B0-0x00000001800B36C0
	public static ErrorCode ChartDownloadFailure { get; } // 0x00000001811933C0-0x0000000181193420 
	[ErrorCodeDefinition] // 0x00000001800B36B0-0x00000001800B36C0
	public static ErrorCode DatabaseDoesNotExist { get; } // 0x0000000181193550-0x00000001811935B0 
	[ErrorCodeDefinition] // 0x00000001800B36B0-0x00000001800B36C0
	public static ErrorCode DatabaseFileDownloadRetryLimitExceeded { get; } // 0x00000001811935B0-0x0000000181193610 
	[ErrorCodeDefinition] // 0x00000001800B36B0-0x00000001800B36C0
	public static ErrorCode NoCachedDatabaseFileForcedOfflineMode { get; } // 0x0000000181193B20-0x0000000181193B80 
	[ErrorCodeDefinition] // 0x00000001800B36B0-0x00000001800B36C0
	public static ErrorCode NoCachedHashForDatabaseFileOfflineMode { get; } // 0x0000000181193BE0-0x0000000181193C40 
	[ErrorCodeDefinition] // 0x00000001800B36B0-0x00000001800B36C0
	public static ErrorCode NoCachedDatabaseFileOfflineMode { get; } // 0x0000000181193B80-0x0000000181193BE0 
	[ErrorCodeDefinition] // 0x00000001800B36B0-0x00000001800B36C0
	public static ErrorCode LoadingTimeout { get; } // 0x0000000181193A60-0x0000000181193AC0 
	[ErrorCodeDefinition] // 0x00000001800B36B0-0x00000001800B36C0
	public static ErrorCode TarFailure { get; } // 0x0000000181193E90-0x0000000181193EF0 
	[ErrorCodeDefinition] // 0x00000001800B36B0-0x00000001800B36C0
	public static ErrorCode HangingLoadingScreen { get; } // 0x0000000181193800-0x0000000181193860 
	[ErrorCodeDefinition] // 0x00000001800B36B0-0x00000001800B36C0
	public static ErrorCode IdleUserTimeout { get; } // 0x0000000181193860-0x00000001811938C0 
	protected virtual int ErrorCodeLowerBound { get; } // 0x000000018035FCC0-0x000000018035FCD0 
	protected virtual int ErrorCodeUpperBound { get; } // 0x0000000181193730-0x0000000181193740 
	public int Code { get; } // 0x0000000181193480-0x00000001811934F0 
	public string Subcode { get; } // 0x0000000181193E20-0x0000000181193E90 
	public string InternalErrorText { get; } // 0x0000000181193920-0x0000000181193990 
	public bool IsShownAsError { get; } // 0x0000000181193990-0x0000000181193A00 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 13394
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<int, int> <>9__61_0; // 0x08
		public static Func<Type, bool> <>9__65_0; // 0x10
		public static Func<CustomAttributeData, bool> <>9__65_2; // 0x18
		public static Func<PropertyInfo, bool> <>9__65_1; // 0x20

		// Constructors
		static <>c(); // 0x000000018119DBB0-0x000000018119DDC0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal int <GetAllCodes>b__61_0(int k); // 0x0000000180F47D40-0x0000000180F47D50
		internal bool <InitializeErrorCodes>b__65_0(Type t); // 0x000000018119CE90-0x000000018119CF80
		internal bool <InitializeErrorCodes>b__65_1(PropertyInfo p); // 0x000000018119CF80-0x000000018119D0A0
		internal bool <InitializeErrorCodes>b__65_2(CustomAttributeData c); // 0x000000018119D0A0-0x000000018119D130
	}

	// Constructors
	public ErrorCode(); // 0x000000018036B6C0-0x000000018036B6D0
	static ErrorCode(); // 0x0000000181193280-0x0000000181193300

	// Methods
	public static int[] GetAllCodes(); // 0x00000001811922E0-0x0000000181192440
	public static bool Contains(int code); // 0x00000001811921B0-0x0000000181192230
	public static ErrorCode Get(int code); // 0x00000001811924C0-0x00000001811925A0
	protected static T DefineErrorCode<T>(int code, string internalErrorText, bool isShownAsError)
		where T : ErrorCode, new();
	private static void InitializeErrorCodes(); // 0x0000000181192890-0x0000000181192DD0
	public ErrorCode WithSubCode(string subCode); // 0x0000000181193200-0x0000000181193280
	public override bool Equals(object obj); // 0x0000000181192230-0x00000001811922E0
	public override int GetHashCode(); // 0x0000000181192440-0x00000001811924C0
	public override string ToString(); // 0x0000000181192DD0-0x0000000181192DE0
	public string ToString(bool displayInternalErrorText); // 0x0000000181192DE0-0x0000000181193200
	private void InitializeErrorCode(int code, string internalErrorText, bool isShownAsError); // 0x00000001811925A0-0x0000000181192890
	private void CheckInitialization(); // 0x0000000181192140-0x00000001811921B0
}

