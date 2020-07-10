/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 56: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7165-7238

namespace CodeStage.AntiCheat.Storage
{
	public static class ObscuredPrefs // TypeDefIndex: 7173
	{
		// Fields
		internal const string PrefsKey = "9978e9f39c218d674463dab9dc728bd6"; // Metadata: 0x0074125D
		private const string RawNotFound = "{not_found}"; // Metadata: 0x00741281
		private const string FinalLogPrefix = "[ACTk] ObscuredPrefs: "; // Metadata: 0x00741290
		private const byte Version = 3; // Metadata: 0x007412AA
		private static bool alterationReported; // 0x00
		private static bool foreignSavesReported; // 0x01
		private static string deviceId; // 0x08
		private static string cryptoKeyObsolete; // 0x10
		private static string cryptoKeyObsoleteForMigration; // 0x18
		internal static uint deviceIdHash; // 0x20
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Action OnAlterationDetected; // 0x28
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Action OnPossibleForeignSavesDetected; // 0x30
		public static bool preservePlayerPrefs; // 0x38
		public static DeviceLockLevel lockToDevice; // 0x39
		public static bool readForeignSaves; // 0x3A
		public static bool emergencyMode; // 0x3B
		private static readonly Type IntType; // 0x40
		private static readonly Type UIntType; // 0x48
		private static readonly Type StringType; // 0x50
		private static readonly Type FloatType; // 0x58
		private static readonly Type DoubleType; // 0x60
		private static readonly Type DecimalType; // 0x68
		private static readonly Type LongType; // 0x70
		private static readonly Type ULongType; // 0x78
		private static readonly Type BoolType; // 0x80
		private static char[] generatedCryptoKey; // 0x88
		private static bool migratingFromACTkV1; // 0x90
		private const char DEPRECATED_RAW_SEPARATOR = ':'; // Metadata: 0x007412AB
		private static string deprecatedDeviceId; // 0x98
	
		// Properties
		[Obsolete] // 0x00000001800D2AE0-0x00000001800D2B10
		public static string CryptoKey { get; set; } // 0x00000001822993F0-0x0000000182299450 0x0000000182299920-0x0000000182299980
		public static string DeviceId { get; set; } // 0x0000000182299600-0x0000000182299720 0x0000000182299980-0x00000001822999E0
		internal static uint DeviceIdHash { get; } // 0x0000000182299530-0x0000000182299600 
		private static string DeprecatedDeviceId { get; } // 0x0000000182299450-0x0000000182299530 
	
		// Events
		public static event Action OnAlterationDetected {
			add; // 0x00000001822991F0-0x00000001822992F0
			remove; // 0x0000000182299720-0x0000000182299820
		}
		public static event Action OnPossibleForeignSavesDetected {
			add; // 0x00000001822992F0-0x00000001822993F0
			remove; // 0x0000000182299820-0x0000000182299920
		}
	
		// Nested types
		internal enum DataType : byte // TypeDefIndex: 7174
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
	
		public enum DeviceLockLevel : byte // TypeDefIndex: 7175
		{
			None = 0,
			Soft = 1,
			Strict = 2
		}
	
		// Constructors
		static ObscuredPrefs(); // 0x0000000182299020-0x00000001822991F0
	
		// Methods
		public static void ForceLockToDeviceInit(); // 0x0000000182294040-0x0000000182294170
		public static void SetRawValue(string encryptedKey, string encryptedValue); // 0x0000000182298690-0x00000001822986A0
		public static bool GetRawValue(string key, out string encryptedKey, out string encryptedValue); // 0x00000001822957A0-0x00000001822958C0
		public static bool HasKey(string key); // 0x0000000182296590-0x00000001822966D0
		public static void DeleteKey(string key); // 0x0000000182292C30-0x0000000182292D30
		public static void DeleteCryptoKey(); // 0x0000000182292BB0-0x0000000182292C30
		public static void DeleteAll(); // 0x0000000182292B30-0x0000000182292BB0
		public static void Save(); // 0x0000000182297A30-0x0000000182297A40
		public static void SetInt(string key, int value); // 0x00000001822981F0-0x00000001822982F0
		public static int GetInt(string key, int defaultValue = 0 /* Metadata: 0x0074121B */); // 0x00000001822950B0-0x00000001822952B0
		public static void SetUInt(string key, uint value); // 0x0000000182298A30-0x0000000182298B30
		public static uint GetUInt(string key, uint defaultValue = 0 /* Metadata: 0x0074121F */); // 0x0000000182295DF0-0x0000000182295EE0
		public static void SetString(string key, string value); // 0x00000001822988F0-0x0000000182298A30
		public static string GetString(string key, string defaultValue = "" /* Metadata: 0x00741223 */); // 0x0000000182295BF0-0x0000000182295DF0
		public static void SetFloat(string key, float value); // 0x00000001822980F0-0x00000001822981F0
		public static float GetFloat(string key, float defaultValue = 0f /* Metadata: 0x00741227 */); // 0x0000000182294EB0-0x00000001822950B0
		public static void SetDouble(string key, double value); // 0x0000000182297FF0-0x00000001822980F0
		public static double GetDouble(string key, double defaultValue = 0 /* Metadata: 0x0074122B */); // 0x0000000182294C90-0x0000000182294D80
		public static void SetDecimal(string key, decimal value); // 0x0000000182297EE0-0x0000000182297FF0
		public static decimal GetDecimal(string key, [DecimalConstant] /* 0x00000001800D2910-0x00000001800D2940 */ decimal defaultValue = default); // 0x0000000182294B00-0x0000000182294C30
		public static void SetLong(string key, long value); // 0x00000001822982F0-0x00000001822983F0
		public static long GetLong(string key, long defaultValue = 0 /* Metadata: 0x00741233 */); // 0x00000001822952B0-0x00000001822953A0
		public static void SetULong(string key, ulong value); // 0x0000000182298B30-0x0000000182298C30
		public static ulong GetULong(string key, ulong defaultValue = 0 /* Metadata: 0x0074123B */); // 0x0000000182295EE0-0x0000000182295FD0
		public static void SetBool(string key, bool value); // 0x0000000182297B20-0x0000000182297C20
		public static bool GetBool(string key, bool defaultValue = false /* Metadata: 0x00741243 */); // 0x0000000182294170-0x00000001822942E0
		public static void SetByteArray(string key, byte[] value); // 0x0000000182297C20-0x0000000182297D50
		public static byte[] GetByteArray(string key, byte defaultValue = 0 /* Metadata: 0x00741244 */, int defaultLength = 0 /* Metadata: 0x00741245 */); // 0x00000001822942E0-0x0000000182294450
		private static string EncryptByteArrayValue(string key, byte[] value); // 0x00000001822932C0-0x0000000182293330
		private static byte[] DecryptByteArrayValue(string key, string encryptedInput, byte defaultValue, int defaultLength); // 0x0000000182291F00-0x0000000182291FB0
		private static byte[] ConstructByteArray(byte value, int length); // 0x0000000182291D00-0x0000000182291D80
		public static void SetVector2(string key, Vector2 value); // 0x0000000182298C30-0x0000000182298E00
		public static Vector2 GetVector2(string key); // 0x0000000182295FD0-0x0000000182296180
		public static Vector2 GetVector2(string key, Vector2 defaultValue); // 0x0000000182296180-0x00000001822962D0
		private static string EncryptVector2Value(string key, Vector2 value); // 0x0000000182293E00-0x0000000182293F00
		private static Vector2 DecryptVector2Value(string key, string encryptedInput, Vector2 defaultValue); // 0x0000000182292930-0x0000000182292A10
		public static void SetVector3(string key, Vector3 value); // 0x0000000182298E00-0x0000000182299020
		public static Vector3 GetVector3(string key); // 0x00000001822962D0-0x00000001822963A0
		public static Vector3 GetVector3(string key, Vector3 defaultValue); // 0x00000001822963A0-0x0000000182296590
		private static string EncryptVector3Value(string key, Vector3 value); // 0x0000000182293F00-0x0000000182294040
		private static Vector3 DecryptVector3Value(string key, string encryptedInput, Vector3 defaultValue); // 0x0000000182292A10-0x0000000182292B30
		public static void SetQuaternion(string key, Quaternion value); // 0x0000000182298470-0x0000000182298690
		public static Quaternion GetQuaternion(string key); // 0x0000000182295500-0x00000001822956C0
		public static Quaternion GetQuaternion(string key, Quaternion defaultValue); // 0x00000001822953A0-0x0000000182295500
		private static string EncryptQuaternionValue(string key, Quaternion value); // 0x0000000182293B20-0x0000000182293C80
		private static Quaternion DecryptQuaternionValue(string key, string encryptedInput, Quaternion defaultValue); // 0x00000001822926B0-0x00000001822927F0
		public static void SetColor(string key, Color32 value); // 0x0000000182297D50-0x0000000182297EE0
		public static Color32 GetColor(string key); // 0x00000001822945E0-0x00000001822947C0
		public static Color32 GetColor(string key, Color32 defaultValue); // 0x0000000182294450-0x00000001822945E0
		private static string EncryptColorValue(string key, uint value); // 0x0000000182293330-0x00000001822933C0
		public static void SetRect(string key, Rect value); // 0x00000001822986A0-0x00000001822988F0
		public static Rect GetRect(string key); // 0x00000001822958C0-0x0000000182295A90
		public static Rect GetRect(string key, Rect defaultValue); // 0x0000000182295A90-0x0000000182295BF0
		private static string EncryptRectValue(string key, Rect value); // 0x0000000182293C80-0x0000000182293E00
		private static Rect DecryptRectValue(string key, string encryptedInput, Rect defaultValue); // 0x00000001822927F0-0x0000000182292930
		public static bool MigrateFromACTkV1(string key, string cryptoKey = "e806f6" /* Metadata: 0x00741249 */); // 0x00000001822978E0-0x0000000182297950
		public static string EncryptKeyWithACTkV1Algorithm(string key, string cryptoKey = "e806f6" /* Metadata: 0x00741253 */); // 0x0000000182293A70-0x0000000182293A90
		private static void SavesTampered(); // 0x0000000182297A40-0x0000000182297B20
		private static void PossibleForeignSavesDetected(); // 0x0000000182297950-0x0000000182297A30
		private static string GetDeviceId(); // 0x0000000182294C30-0x0000000182294C90
		internal static char[] GetCryptoKey(string dynamicSuffix = null); // 0x00000001822947C0-0x0000000182294B00
		internal static string EncryptKey(string key); // 0x0000000182293A90-0x0000000182293B20
		internal static string EncryptData(string key, byte[] cleanBytes, DataType type); // 0x00000001822933C0-0x0000000182293850
		internal static byte[] DecryptData(string key, string encryptedInput); // 0x0000000182291FB0-0x00000001822926B0
		internal static DataType GetRawValueType(string value); // 0x00000001822956C0-0x00000001822957A0
		internal static string EncryptValue<T>(string key, T value)
			where T : IConvertible;
		internal static T DecryptValue<T>(string key, string encryptedKey, T defaultValue, string encryptedInput = null);
		private static byte[] EncryptDecryptBytes(byte[] bytes, int dataLength, char[] key); // 0x0000000182293970-0x0000000182293A70
		private static byte[] DecimalToBytes(decimal dec); // 0x0000000182291D80-0x0000000182291EC0
		private static decimal BytesToDecimal(byte[] bytes); // 0x0000000182291A50-0x0000000182291B90
		private static string GetEncryptedPrefsString(string key, string encryptedKey); // 0x0000000182294D80-0x0000000182294EB0
		private static uint CalculateChecksum(string input); // 0x0000000182291B90-0x0000000182291D00
		private static Color32 DecodeColor(uint encodedColor); // 0x0000000182291EC0-0x0000000182291F00
		private static bool MigrateFromACTkV1Internal(string key, string cryptoKey, DataType deprecatedMigrationType); // 0x00000001822966D0-0x00000001822978E0
		private static void SetMigrationMode(bool enabled); // 0x00000001822983F0-0x0000000182298470
		private static byte[] EncryptDecryptBytesObsolete(byte[] bytes, int dataLength, string key); // 0x0000000182293850-0x0000000182293970
		private static string DeprecatedDecryptValue(string value); // 0x0000000182292E90-0x00000001822932C0
		private static string DeprecatedCalculateChecksum(string input); // 0x0000000182292D30-0x0000000182292E90
	}
}
