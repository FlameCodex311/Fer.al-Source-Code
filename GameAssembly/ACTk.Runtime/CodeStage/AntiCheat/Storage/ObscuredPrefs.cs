/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 57: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7331-7404

namespace CodeStage.AntiCheat.Storage
{
	public static class ObscuredPrefs // TypeDefIndex: 7339
	{
		// Fields
		private static readonly Type IntType; // 0x00
		private static readonly Type UIntType; // 0x08
		private static readonly Type StringType; // 0x10
		private static readonly Type FloatType; // 0x18
		private static readonly Type DoubleType; // 0x20
		private static readonly Type DecimalType; // 0x28
		private static readonly Type LongType; // 0x30
		private static readonly Type ULongType; // 0x38
		private static readonly Type BoolType; // 0x40
		private static char[] generatedCryptoKey; // 0x48
		private static bool migratingFromACTkV1; // 0x50
		private const char DEPRECATED_RAW_SEPARATOR = ':'; // Metadata: 0x00775F4B
		private static string deprecatedDeviceId; // 0x58
		internal const string PrefsKey = "9978e9f39c218d674463dab9dc728bd6"; // Metadata: 0x00775F4D
		private const string RawNotFound = "{not_found}"; // Metadata: 0x00775F71
		private const string FinalLogPrefix = "[ACTk] ObscuredPrefs: "; // Metadata: 0x00775F80
		private const byte Version = 3; // Metadata: 0x00775F9A
		private static bool alterationReported; // 0x60
		private static bool foreignSavesReported; // 0x61
		private static string deviceId; // 0x68
		private static string cryptoKeyObsolete; // 0x70
		private static string cryptoKeyObsoleteForMigration; // 0x78
		internal static uint deviceIdHash; // 0x80
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Action OnAlterationDetected; // 0x88
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Action OnPossibleForeignSavesDetected; // 0x90
		public static bool preservePlayerPrefs; // 0x98
		public static DeviceLockLevel lockToDevice; // 0x99
		public static bool readForeignSaves; // 0x9A
		public static bool emergencyMode; // 0x9B
	
		// Properties
		private static string DeprecatedDeviceId { get; } // 0x0000000182003440-0x0000000182003520 
		[Obsolete] // 0x0000000180233DF0-0x0000000180233E20
		public static string CryptoKey { get; set; } // 0x00000001820033E0-0x0000000182003440 0x0000000182003940-0x00000001820039A0
		public static string DeviceId { get; set; } // 0x0000000182003600-0x0000000182003720 0x00000001820039A0-0x0000000182003A00
		internal static uint DeviceIdHash { get; } // 0x0000000182003520-0x0000000182003600 
	
		// Events
		public static event Action OnAlterationDetected {
			add; // 0x00000001820031C0-0x00000001820032D0
			remove; // 0x0000000182003720-0x0000000182003830
		}
		public static event Action OnPossibleForeignSavesDetected {
			add; // 0x00000001820032D0-0x00000001820033E0
			remove; // 0x0000000182003830-0x0000000182003940
		}
	
		// Nested types
		internal enum DataType : byte // TypeDefIndex: 7340
		{
			Unknown = 0,
			Int = 5,
			UInt = 10,
			String = 15,
			Float = 20,
			Double = 25,
			Decimal = 27,
			Long = 30,
			ULong = 32,
			Bool = 35,
			ByteArray = 40,
			Vector2 = 45,
			Vector3 = 50,
			Quaternion = 55,
			Color = 60,
			Rect = 65
		}
	
		public enum DeviceLockLevel : byte // TypeDefIndex: 7341
		{
			None = 0,
			Soft = 1,
			Strict = 2
		}
	
		// Constructors
		static ObscuredPrefs(); // 0x0000000182002FE0-0x00000001820031C0
	
		// Methods
		internal static char[] GetCryptoKey(string dynamicSuffix = null); // 0x0000000181FFE7E0-0x0000000181FFEB00
		internal static string EncryptKey(string key); // 0x0000000181FFDAC0-0x0000000181FFDB40
		internal static string EncryptData(string key, byte[] cleanBytes, DataType type); // 0x0000000181FFD430-0x0000000181FFD890
		internal static byte[] DecryptData(string key, string encryptedInput); // 0x0000000181FFC050-0x0000000181FFC720
		internal static DataType GetRawValueType(string value); // 0x0000000181FFF6B0-0x0000000181FFF790
		internal static string EncryptValue<T>(string key, T value)
			where T : IConvertible;
		internal static T DecryptValue<T>(string key, string encryptedKey, T defaultValue, string encryptedInput = null);
		private static byte[] EncryptDecryptBytes(byte[] bytes, int dataLength, char[] key); // 0x0000000181FFD9A0-0x0000000181FFDAA0
		private static byte[] DecimalToBytes(decimal dec); // 0x0000000181FFBE20-0x0000000181FFBF60
		private static decimal BytesToDecimal(byte[] bytes); // 0x0000000181FFBB00-0x0000000181FFBC30
		private static string GetEncryptedPrefsString(string key, string encryptedKey); // 0x0000000181FFED70-0x0000000181FFEEA0
		private static uint CalculateChecksum(string input); // 0x0000000181FFBC30-0x0000000181FFBDA0
		private static Color32 DecodeColor(uint encodedColor); // 0x0000000181FFBF60-0x0000000181FFBFA0
		private static bool MigrateFromACTkV1Internal(string key, string cryptoKey, DataType deprecatedMigrationType); // 0x00000001820006C0-0x00000001820018B0
		private static void SetMigrationMode(bool enabled); // 0x00000001820023B0-0x0000000182002430
		private static byte[] EncryptDecryptBytesObsolete(byte[] bytes, int dataLength, string key); // 0x0000000181FFD890-0x0000000181FFD9A0
		private static string DeprecatedDecryptValue(string value); // 0x0000000181FFCF00-0x0000000181FFD330
		private static string DeprecatedCalculateChecksum(string input); // 0x0000000181FFCDA0-0x0000000181FFCF00
		public static void ForceLockToDeviceInit(); // 0x0000000181FFE060-0x0000000181FFE190
		public static void SetRawValue(string encryptedKey, string encryptedValue); // 0x0000000182002650-0x0000000182002660
		public static bool GetRawValue(string key, out string encryptedKey, out string encryptedValue); // 0x0000000181FFF790-0x0000000181FFF8A0
		public static bool HasKey(string key); // 0x0000000182000580-0x00000001820006C0
		public static void DeleteKey(string key); // 0x0000000181FFCCA0-0x0000000181FFCDA0
		public static void DeleteCryptoKey(); // 0x0000000181FFCC20-0x0000000181FFCCA0
		public static void DeleteAll(); // 0x0000000181FFCBA0-0x0000000181FFCC20
		public static void Save(); // 0x0000000182001A00-0x0000000182001A10
		public static void SetInt(string key, int value); // 0x00000001820021B0-0x00000001820022B0
		public static int GetInt(string key, int defaultValue = 0 /* Metadata: 0x00775F09 */); // 0x0000000181FFF0A0-0x0000000181FFF2A0
		public static void SetUInt(string key, uint value); // 0x00000001820029F0-0x0000000182002AF0
		public static uint GetUInt(string key, uint defaultValue = 0 /* Metadata: 0x00775F0D */); // 0x0000000181FFFDE0-0x0000000181FFFED0
		public static void SetString(string key, string value); // 0x00000001820028B0-0x00000001820029F0
		public static string GetString(string key, string defaultValue = "" /* Metadata: 0x00775F11 */); // 0x0000000181FFFBD0-0x0000000181FFFDE0
		public static void SetFloat(string key, float value); // 0x00000001820020B0-0x00000001820021B0
		public static float GetFloat(string key, float defaultValue = 0f /* Metadata: 0x00775F15 */); // 0x0000000181FFEEA0-0x0000000181FFF0A0
		public static void SetDouble(string key, double value); // 0x0000000182001FB0-0x00000001820020B0
		public static double GetDouble(string key, double defaultValue = 0 /* Metadata: 0x00775F19 */); // 0x0000000181FFEC80-0x0000000181FFED70
		public static void SetDecimal(string key, decimal value); // 0x0000000182001EB0-0x0000000182001FB0
		public static decimal GetDecimal(string key, [DecimalConstant] /* 0x0000000180233A50-0x0000000180233A80 */ decimal defaultValue = default); // 0x0000000181FFEB00-0x0000000181FFEC20
		public static void SetLong(string key, long value); // 0x00000001820022B0-0x00000001820023B0
		public static long GetLong(string key, long defaultValue = 0 /* Metadata: 0x00775F21 */); // 0x0000000181FFF2A0-0x0000000181FFF390
		public static void SetULong(string key, ulong value); // 0x0000000182002AF0-0x0000000182002BF0
		public static ulong GetULong(string key, ulong defaultValue = 0 /* Metadata: 0x00775F29 */); // 0x0000000181FFFED0-0x0000000181FFFFC0
		public static void SetBool(string key, bool value); // 0x0000000182001AF0-0x0000000182001BF0
		public static bool GetBool(string key, bool defaultValue = false /* Metadata: 0x00775F31 */); // 0x0000000181FFE190-0x0000000181FFE300
		public static void SetByteArray(string key, byte[] value); // 0x0000000182001BF0-0x0000000182001D20
		public static byte[] GetByteArray(string key, byte defaultValue = 0 /* Metadata: 0x00775F32 */, int defaultLength = 0 /* Metadata: 0x00775F33 */); // 0x0000000181FFE300-0x0000000181FFE470
		private static string EncryptByteArrayValue(string key, byte[] value); // 0x0000000181FFD330-0x0000000181FFD3A0
		private static byte[] DecryptByteArrayValue(string key, string encryptedInput, byte defaultValue, int defaultLength); // 0x0000000181FFBFA0-0x0000000181FFC050
		private static byte[] ConstructByteArray(byte value, int length); // 0x0000000181FFBDA0-0x0000000181FFBE20
		public static void SetVector2(string key, Vector2 value); // 0x0000000182002BF0-0x0000000182002DC0
		public static Vector2 GetVector2(string key); // 0x0000000181FFFFC0-0x0000000182000170
		public static Vector2 GetVector2(string key, Vector2 defaultValue); // 0x0000000182000170-0x00000001820002C0
		private static string EncryptVector2Value(string key, Vector2 value); // 0x0000000181FFDE20-0x0000000181FFDF20
		private static Vector2 DecryptVector2Value(string key, string encryptedInput, Vector2 defaultValue); // 0x0000000181FFC9A0-0x0000000181FFCA80
		public static void SetVector3(string key, Vector3 value); // 0x0000000182002DC0-0x0000000182002FE0
		public static Vector3 GetVector3(string key); // 0x00000001820002C0-0x0000000182000390
		public static Vector3 GetVector3(string key, Vector3 defaultValue); // 0x0000000182000390-0x0000000182000580
		private static string EncryptVector3Value(string key, Vector3 value); // 0x0000000181FFDF20-0x0000000181FFE060
		private static Vector3 DecryptVector3Value(string key, string encryptedInput, Vector3 defaultValue); // 0x0000000181FFCA80-0x0000000181FFCBA0
		public static void SetQuaternion(string key, Quaternion value); // 0x0000000182002430-0x0000000182002650
		public static Quaternion GetQuaternion(string key); // 0x0000000181FFF4F0-0x0000000181FFF6B0
		public static Quaternion GetQuaternion(string key, Quaternion defaultValue); // 0x0000000181FFF390-0x0000000181FFF4F0
		private static string EncryptQuaternionValue(string key, Quaternion value); // 0x0000000181FFDB40-0x0000000181FFDCA0
		private static Quaternion DecryptQuaternionValue(string key, string encryptedInput, Quaternion defaultValue); // 0x0000000181FFC720-0x0000000181FFC860
		public static void SetColor(string key, Color32 value); // 0x0000000182001D20-0x0000000182001EB0
		public static Color32 GetColor(string key); // 0x0000000181FFE600-0x0000000181FFE7E0
		public static Color32 GetColor(string key, Color32 defaultValue); // 0x0000000181FFE470-0x0000000181FFE600
		private static string EncryptColorValue(string key, uint value); // 0x0000000181FFD3A0-0x0000000181FFD430
		public static void SetRect(string key, Rect value); // 0x0000000182002660-0x00000001820028B0
		public static Rect GetRect(string key); // 0x0000000181FFF8A0-0x0000000181FFFA70
		public static Rect GetRect(string key, Rect defaultValue); // 0x0000000181FFFA70-0x0000000181FFFBD0
		private static string EncryptRectValue(string key, Rect value); // 0x0000000181FFDCA0-0x0000000181FFDE20
		private static Rect DecryptRectValue(string key, string encryptedInput, Rect defaultValue); // 0x0000000181FFC860-0x0000000181FFC9A0
		public static bool MigrateFromACTkV1(string key, string cryptoKey = "e806f6" /* Metadata: 0x00775F37 */); // 0x00000001820018B0-0x0000000182001920
		public static string EncryptKeyWithACTkV1Algorithm(string key, string cryptoKey = "e806f6" /* Metadata: 0x00775F41 */); // 0x0000000181FFDAA0-0x0000000181FFDAC0
		private static void SavesTampered(); // 0x0000000182001A10-0x0000000182001AF0
		private static void PossibleForeignSavesDetected(); // 0x0000000182001920-0x0000000182001A00
		private static string GetDeviceId(); // 0x0000000181FFEC20-0x0000000181FFEC80
	}
}
