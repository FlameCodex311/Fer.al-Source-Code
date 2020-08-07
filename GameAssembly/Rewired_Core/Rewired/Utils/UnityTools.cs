/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Platforms;
using Rewired.Utils.Interfaces;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Utils
{
	public static class UnityTools // TypeDefIndex: 7054
	{
		// Fields
		private const UnityVersion WScJdaSIAhhYPacOfUMrBVxYNLpw = UnityVersion.UNITY_5_0; // Metadata: 0x007667CF
		private static UnityVersionClass zXuEGnAIWcYWiOPsZnPOBLpPGqTD; // 0x00
		private static UnityVersion XGXWrLTbHUJbUZcPqrJahIinIbif; // 0x08
		private static string nUxpnFRExFjvPAluyiaCsbLpZJx; // 0x10
		private static Rewired.Platforms.Platform oGHGiJyNkGGLGaClMTVLPaDWabO; // 0x18
		private static EditorPlatform TxfhmBGIgnWLQaApsgqLFjQQowUY; // 0x1C
		private static bool jGeTTfsKUFAqHipQAWnFoerpDuYR; // 0x20
		private static bool BehdbTjAadwGBArRmdjvgPqrrwqs; // 0x21
		private static bool MLiykYguKBuJpJdRTejsNxBxypK; // 0x22
		private static WebplayerPlatform joqpgIglPlFLIGGPWHJKGdlmQLSg; // 0x24
		private static bool YuRCcRCiNSIOhdmbDLambconuWw; // 0x28
		private static bool PGhmPQIwyfTyxwCmjEzlUEcOHdF; // 0x29
		private static bool NwZpOTcNTChGWxwSaddKTLtbYSf; // 0x2A
		private static bool VexwmWzFwplBrOMVmccyGPyiGFwE; // 0x2B
		private static bool AMJkAWJbwEXegntBhiFQLFYGDcjD; // 0x2C
		private static bool xOnbWlKgkqVcCobVgDapIyXCwxCc; // 0x2D
		private static string NYMKGLSpUKEMJeFVXUacvCkICynE; // 0x30
		private static ScriptingBackend THyJJeGFWtgbRxvsTjswoSZPIGn; // 0x38
		private static ScriptingAPILevel ihtbmxwCiFinffLOGhUnyTEdulKN; // 0x3C
		private static IExternalTools nhAGFSdWWacMFCxNPAHNFwdgKnWN; // 0x40
		private static bool MWVwUpzxrbBkQISppIDVAyTHTfC; // 0x48
	
		// Properties
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static UnityVersionClass unityVersionObj { get; } // 0x0000000181472880-0x0000000181472950 
		public static UnityVersion unityVersion { get; } // 0x0000000181472A30-0x0000000181472B00 
		public static string unityVersionString { get; } // 0x0000000181472950-0x0000000181472A30 
		public static Rewired.Platforms.Platform platform { get; } // 0x0000000181471DD0-0x0000000181471EA0 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static Rewired.Platforms.Platform effectivePlatform { get; } // 0x0000000181471140-0x0000000181471290 
		public static EditorPlatform editorPlatform { get; } // 0x0000000181471070-0x0000000181471140 
		public static bool isEditor { get; } // 0x00000001814715E0-0x00000001814716B0 
		public static bool isPlaying { get; } // 0x0000000181471830-0x0000000181471890 
		public static bool isDebugBuild { get; } // 0x0000000181471510-0x00000001814715E0 
		public static WebplayerPlatform webplayerPlatform { get; } // 0x0000000181472B00-0x0000000181472BD0 
		public static bool logToDebugLog { get; } // 0x0000000181471B60-0x0000000181471DD0 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static bool editorPlatformMatchesBuildPlatform { get; } // 0x0000000181470ED0-0x0000000181471070 
		public static bool isSupportedVersion3 { get; } // 0x00000001814719C0-0x0000000181471A90 
		public static bool isSupportedVersion4 { get; } // 0x0000000181471A90-0x0000000181471B60 
		public static bool supports2DColliders { get; } // 0x0000000181471F60-0x0000000181472030 
		public static bool supportsSortingLayers { get; } // 0x0000000181472100-0x00000001814721D0 
		public static bool supportsUnityUI { get; } // 0x0000000181472440-0x0000000181472510 
		public static bool supportsTouchControls { get; } // 0x00000001814722A0-0x0000000181472370 
		public static bool isAndroidPlatform { get; } // 0x00000001814713B0-0x0000000181471510 
		public static bool isIOSPlatform { get; } // 0x00000001814716B0-0x00000001814717D0 
		public static bool isStandalonePlatform { get; } // 0x0000000181471890-0x00000001814719C0 
		public static bool windowsJoystickNamesReturnsEmptyStringsIfJoystickNull { get; } // 0x0000000181472BD0-0x0000000181472CA0 
		public static bool supportsUnityUIGraphicRaycastTarget { get; } // 0x0000000181472370-0x0000000181472440 
		public static bool supportsNestedPrefabs { get; } // 0x0000000181472030-0x0000000181472100 
		public static bool supportsWindowsAppStore { get; } // 0x0000000181472510-0x0000000181472610 
		public static bool supportsWindowsUWP { get; } // 0x00000001814726E0-0x00000001814727B0 
		public static bool supportsWindowsUWP_IL2CPP { get; } // 0x0000000181472610-0x00000001814726E0 
		public static bool supportsXboxOne { get; } // 0x00000001814727B0-0x0000000181472880 
		public static bool supportsStadia { get; } // 0x00000001814721D0-0x00000001814722A0 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static ScriptingBackend scriptingBackend { get; } // 0x0000000181471F00-0x0000000181471F60 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static ScriptingAPILevel scriptingAPILevel { get; } // 0x0000000181471EA0-0x0000000181471F00 
		public static IExternalTools externalTools { get; } // 0x0000000181471290-0x0000000181471360 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static bool isInitialized { get; } // 0x00000001814717D0-0x0000000181471830 
		private static bool initialized { get; } // 0x0000000181471360-0x00000001814713B0 
	
		// Nested types
		public enum UnityVersion // TypeDefIndex: 7055
		{
			UNITY_2_6 = 0,
			UNITY_2_6_1 = 1,
			UNITY_3_0 = 2,
			UNITY_3_0_0 = 3,
			UNITY_3_1 = 4,
			UNITY_3_2 = 5,
			UNITY_3_3 = 6,
			UNITY_3_4 = 7,
			UNITY_3_5 = 8,
			UNITY_3_5_2 = 9,
			UNITY_3_5_7 = 10,
			UNITY_3_MAX = 11,
			UNITY_4_0 = 12,
			UNITY_4_0_1 = 13,
			UNITY_4_1 = 14,
			UNITY_4_2 = 15,
			UNITY_4_3 = 16,
			UNITY_4_4 = 17,
			UNITY_4_5 = 18,
			UNITY_4_6 = 19,
			UNITY_4_6_3p1 = 20,
			UNITY_4_6_3p1Plus = 21,
			UNITY_4_7 = 22,
			UNITY_4_8 = 23,
			UNITY_4_9 = 24,
			UNITY_4_MAX = 25,
			UNITY_5_0 = 26,
			UNITY_5_0_0p1 = 27,
			UNITY_5_0_0p1Plus = 28,
			UNITY_5_0_1 = 29,
			UNITY_5_0_2 = 30,
			UNITY_5_1 = 31,
			UNITY_5_2 = 32,
			UNITY_5_3 = 33,
			UNITY_5_4 = 34,
			UNITY_5_5 = 35,
			UNITY_5_6 = 36,
			UNITY_5_7 = 37,
			UNITY_5_8 = 38,
			UNITY_5_9 = 39,
			UNITY_5_MAX = 40,
			UNITY_2017_0 = 41,
			UNITY_2017_1 = 42,
			UNITY_2017_2 = 43,
			UNITY_2017_3 = 44,
			UNITY_2017_4 = 45,
			UNITY_2017_5 = 46,
			UNITY_2017_6 = 47,
			UNITY_2017_7 = 48,
			UNITY_2017_8 = 49,
			UNITY_2017_9 = 50,
			UNITY_2017_MAX = 51,
			UNITY_2018_0 = 52,
			UNITY_2018_1 = 53,
			UNITY_2018_2 = 54,
			UNITY_2018_3 = 55,
			UNITY_2018_4 = 56,
			UNITY_2018_5 = 57,
			UNITY_2018_6 = 58,
			UNITY_2018_7 = 59,
			UNITY_2018_8 = 60,
			UNITY_2018_9 = 61,
			UNITY_2018_MAX = 62,
			UNITY_2019_0 = 63,
			UNITY_2019_1 = 64,
			UNITY_2019_2 = 65,
			UNITY_2019_3 = 66,
			UNITY_2019_4 = 67,
			UNITY_2019_5 = 68,
			UNITY_2019_6 = 69,
			UNITY_2019_7 = 70,
			UNITY_2019_8 = 71,
			UNITY_2019_9 = 72,
			UNITY_2019_MAX = 73,
			UNITY_2020_0 = 74,
			UNITY_2020_1 = 75,
			UNITY_2020_2 = 76,
			UNITY_2020_3 = 77,
			UNITY_2020_4 = 78,
			UNITY_2020_5 = 79,
			UNITY_2020_6 = 80,
			UNITY_2020_7 = 81,
			UNITY_2020_8 = 82,
			UNITY_2020_9 = 83,
			UNITY_2020_MAX = 84,
			UNITY_2021_0 = 85,
			UNITY_2021_1 = 86,
			UNITY_2021_2 = 87,
			UNITY_2021_3 = 88,
			UNITY_2021_4 = 89,
			UNITY_2021_5 = 90,
			UNITY_2021_6 = 91,
			UNITY_2021_7 = 92,
			UNITY_2021_8 = 93,
			UNITY_2021_9 = 94,
			UNITY_2021_MAX = 95,
			Unknown = 1000
		}
	
		[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
		[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
		internal class UnityVersionClass // TypeDefIndex: 7056
		{
			// Fields
			public readonly int major; // 0x10
			public readonly int minor; // 0x14
			public readonly int maintenance; // 0x18
			public readonly xbzBGLHKdWtdSeNwkNkNupivaWXD type; // 0x1C
			public readonly int build; // 0x20
	
			// Nested types
			public enum xbzBGLHKdWtdSeNwkNkNupivaWXD // TypeDefIndex: 7057
			{
				YoYVWWjzZItTDjMArvaWSGlnarB = 0,
				VoAoabFvrWsVAECvsSiUtdvsBNwB = 1,
				bvEYAgLqUSYeqIGOpKNPcTWrMct = 2
			}
	
			// Constructors
			public UnityVersionClass(string versionString); // 0x0000000181473E60-0x00000001814741F0
	
			// Methods
			public override string ToString(); // 0x0000000181473A00-0x0000000181473DE0
			private string nHJQtbkQNmfDISnCBFCXhGkrtylU(xbzBGLHKdWtdSeNwkNkNupivaWXD param_0000f5a9); // 0x00000001814741F0-0x0000000181474280
			public override bool Equals(object obj); // 0x0000000181473640-0x0000000181473720
			public override int GetHashCode(); // 0x0000000180766BC0-0x0000000180766BD0
			public static bool operator <(UnityVersionClass a, UnityVersionClass b); // 0x0000000181474320-0x00000001814745F0
			public static bool operator >(UnityVersionClass a, UnityVersionClass b); // 0x00000001814742C0-0x00000001814742E0
			public static bool operator >=(UnityVersionClass a, UnityVersionClass b); // 0x00000001814742A0-0x00000001814742C0
			public static bool operator <=(UnityVersionClass a, UnityVersionClass b); // 0x0000000181474300-0x0000000181474320
			public static bool operator ==(UnityVersionClass a, UnityVersionClass b); // 0x0000000181474280-0x00000001814742A0
			public static bool operator !=(UnityVersionClass a, UnityVersionClass b); // 0x00000001814742E0-0x0000000181474300
			public static int Comparison(UnityVersionClass a, UnityVersionClass b); // 0x00000001814734C0-0x0000000181473640
			public static bool IsValidVersionString(string versionString); // 0x0000000181473720-0x0000000181473A00
			private static int UTWibXaWzEBeaqDVkQyevcZhGyMf(xbzBGLHKdWtdSeNwkNkNupivaWXD param_0000f5ba); // 0x0000000181473DE0-0x0000000181473E60
		}
	
		// Constructors
		static UnityTools(); // 0x0000000181470D70-0x0000000181470DB0
	
		// Methods
		private static bool QhIDUDYaSDLNsWnCHcHoNRLwBKp(); // 0x000000018146EFA0-0x000000018146F270
		internal static void ItdhavHGXcUkAhyjaCFbIXENJheh(Rewired.Platforms.Platform param_0000f460, EditorPlatform param_0000f461, bool param_0000f462, WebplayerPlatform param_0000f463, ScriptingBackend param_0000f464, ScriptingAPILevel param_0000f465, IExternalTools param_0000f466); // 0x000000018146EC00-0x000000018146EF30
		public static WebplayerPlatform DetermineWebplayerPlatformType(Rewired.Platforms.Platform platform, EditorPlatform editorPlatform); // 0x000000018037DDC0-0x000000018037DDD0
		public static bool IsUnityVersionInRange(string minVersionStr, string maxVersionStr); // 0x000000018146E550-0x000000018146EA10
		private static bool ASRhdoyyQTduMVFULEfoIGnXBLiG(string param_0000f46b, out int param_0000f46c); // 0x0000000181468980-0x0000000181468AB0
		private static void nWyRrAawuXTphPHFMDpxJzJYyWWc(); // 0x0000000181473140-0x00000001814732C0
		private static UnityVersion VRJyAUBeMxnkCKiBVlyAlWtGCIf(string param_0000f46d); // 0x0000000181470130-0x0000000181470D70
		private static UnityVersion MFMhNWQvqRxGEAVltAirSobzuAl(int param_0000f46e); // 0x000000018146EF30-0x000000018146EFA0
		private static UnityVersion HSNYfdLciUNmsMcEqlAyqzSLfLd(int param_0000f46f); // 0x000000018146DF90-0x000000018146E030
		private static void mRBLJgLzkPRcvSnFQVTgmGUfGJbj(); // 0x0000000181472CA0-0x0000000181473140
		internal static Type vqpfHgJAQRpyXkQmCQDJfwwrFtzt(UBAGvQUhxstTTsDMhtLmvhvzbqq param_0000f470); // 0x00000001814732C0-0x0000000181473430
		private static Type cAlBtLUlEjMaJWNgiKLpixNEzpJ(UBAGvQUhxstTTsDMhtLmvhvzbqq param_0000f471); // 0x0000000181470DB0-0x0000000181470E50
		public static List<string> GetCurrentPlatformResourecesDLLPaths(); // 0x000000018146D8F0-0x000000018146DA70
		public static Transform FindTransformInChildren(Transform transform, string name); // 0x00000001814697E0-0x00000001814699E0
		public static Transform FindTransformInChildren(GameObject gameObject, string name); // 0x0000000181469720-0x00000001814697E0
		public static GameObject FindGameObjectInChildren(GameObject gameObject, string name); // 0x0000000181469600-0x0000000181469720
		public static GameObject FindGameObjectInChildren(Transform transform, string name); // 0x0000000181469510-0x0000000181469600
		public static T GetComponent<T>(Transform transform)
			where T : class;
		public static T GetComponent<T>(Component component)
			where T : class;
		public static T GetComponent<T>(GameObject gameObject)
			where T : class;
		public static T GetComponent<T>(Transform transform, bool includeInactive)
			where T : class;
		public static T GetComponent<T>(Component component, bool includeInactive)
			where T : class;
		public static T GetComponent<T>(GameObject gameObject, bool includeInactive)
			where T : class;
		public static Component GetComponent(Transform transform, Type type, bool includeInactive); // 0x000000018146A100-0x000000018146A1D0
		public static Component GetComponent(Component component, Type type, bool includeInactive); // 0x000000018146A1D0-0x000000018146A2A0
		public static Component GetComponent(GameObject gameObject, Type type, bool includeInactive); // 0x000000018146A630-0x000000018146AA20
		public static Component GetComponent(Transform transform, Type type); // 0x000000018146AA20-0x000000018146AAE0
		public static Component GetComponent(Component component, Type type); // 0x000000018146A570-0x000000018146A630
		public static Component GetComponent(GameObject gameObject, Type type); // 0x000000018146A2A0-0x000000018146A570
		public static T GetComponentInChildren<T>(GameObject gameObject)
			where T : class;
		public static T GetComponentInChildren<T>(Component component)
			where T : class;
		public static T GetComponentInChildren<T>(Transform transform)
			where T : class;
		public static T GetComponentInChildren<T>(GameObject gameObject, bool includeInactive)
			where T : class;
		public static T GetComponentInChildren<T>(Component component, bool includeInactive)
			where T : class;
		public static T GetComponentInChildren<T>(Transform transform, bool includeInactive)
			where T : class;
		public static Component GetComponentInChildren(GameObject gameObject, Type type); // 0x00000001814699E0-0x0000000181469AA0
		public static Component GetComponentInChildren(Component component, Type type); // 0x000000018146A040-0x000000018146A100
		public static Component GetComponentInChildren(Transform transform, Type type); // 0x0000000181469EA0-0x000000018146A040
		public static Component GetComponentInChildren(GameObject gameObject, Type type, bool includeInactive); // 0x0000000181469B70-0x0000000181469C40
		public static Component GetComponentInChildren(Component component, Type type, bool includeInactive); // 0x0000000181469AA0-0x0000000181469B70
		public static Component GetComponentInChildren(Transform transform, Type type, bool includeInactive); // 0x0000000181469C40-0x0000000181469EA0
		public static T GetComponentInSelfOrChildren<T>(Transform transform)
			where T : class;
		public static T GetComponentInSelfOrChildren<T>(Component component)
			where T : class;
		public static T GetComponentInSelfOrChildren<T>(GameObject gameObject)
			where T : class;
		public static T GetComponentInParents<T>(GameObject gameObject)
			where T : class;
		public static T GetComponentInParents<T>(Component component)
			where T : class;
		public static T GetComponentInParents<T>(Transform transform)
			where T : class;
		public static T GetComponentInSelfOrParents<T>(GameObject gameObject)
			where T : class;
		public static T GetComponentInSelfOrParents<T>(Component component)
			where T : class;
		public static T GetComponentInSelfOrParents<T>(Transform transform)
			where T : class;
		public static List<T> GetComponents<T>(Transform transform)
			where T : class;
		public static List<T> GetComponents<T>(Component component)
			where T : class;
		public static List<T> GetComponents<T>(GameObject gameObject)
			where T : class;
		public static List<T> GetComponents<T>(Transform transform, bool includeInactive)
			where T : class;
		public static List<T> GetComponents<T>(Component component, bool includeInactive)
			where T : class;
		public static List<T> GetComponents<T>(GameObject gameObject, bool includeInactive)
			where T : class;
		public static List<Component> GetComponents(Transform transform, Type type); // 0x000000018146D300-0x000000018146D3E0
		public static List<Component> GetComponents(Component component, Type type); // 0x000000018146CBB0-0x000000018146CC90
		public static List<Component> GetComponents(GameObject gameObject, Type type); // 0x000000018146D230-0x000000018146D300
		public static List<Component> GetComponents(Transform transform, Type type, bool includeInactive); // 0x000000018146C770-0x000000018146C860
		public static List<Component> GetComponents(Component component, Type type, bool includeInactive); // 0x000000018146D3E0-0x000000018146D4D0
		public static List<Component> GetComponents(GameObject gameObject, Type type, bool includeInactive); // 0x000000018146D4D0-0x000000018146D6F0
		public static List<T> GetComponentsInChildren<T>(Transform transform)
			where T : class;
		public static List<T> GetComponentsInChildren<T>(Component component)
			where T : class;
		public static List<T> GetComponentsInChildren<T>(GameObject gameObject)
			where T : class;
		public static List<T> GetComponentsInChildren<T>(Transform transform, bool includeInactive)
			where T : class;
		public static List<T> GetComponentsInChildren<T>(Component component, bool includeInactive)
			where T : class;
		public static List<T> GetComponentsInChildren<T>(GameObject gameObject, bool includeInactive)
			where T : class;
		public static List<Component> GetComponentsInChildren(Transform transform); // 0x000000018146AAE0-0x000000018146AC80
		public static List<Component> GetComponentsInChildren(Component component); // 0x000000018146B040-0x000000018146B120
		public static List<Component> GetComponentsInChildren(GameObject gameObject); // 0x000000018146AC80-0x000000018146AD60
		public static List<T> GetComponentsInSelfAndChildren<T>(Transform transform)
			where T : class;
		public static List<T> GetComponentsInSelfAndChildren<T>(Component component)
			where T : class;
		public static List<T> GetComponentsInSelfAndChildren<T>(GameObject gameObject)
			where T : class;
		public static List<T> GetComponentsInParents<T>(Transform transform)
			where T : class;
		public static List<T> GetComponentsInParents<T>(Component component)
			where T : class;
		public static List<T> GetComponentsInParents<T>(GameObject gameObject)
			where T : class;
		public static List<Component> GetComponentsInParents(Transform transform); // 0x000000018146B900-0x000000018146BAB0
		public static List<Component> GetComponentsInParents(Component component); // 0x000000018146BAB0-0x000000018146BB80
		public static List<Component> GetComponentsInParents(GameObject gameObject); // 0x000000018146BE70-0x000000018146BF50
		public static int GetComponents<T>(Transform transform, List<T> results, bool append)
			where T : class;
		public static int GetComponents<T>(Component component, List<T> results, bool append)
			where T : class;
		public static int GetComponents<T>(GameObject gameObject, List<T> results, bool append)
			where T : class;
		public static int GetComponents<T>(Transform transform, bool includeInactive, List<T> results, bool append)
			where T : class;
		public static int GetComponents<T>(Component component, bool includeInactive, List<T> results, bool append)
			where T : class;
		public static int GetComponents<T>(GameObject gameObject, bool includeInactive, List<T> results, bool append)
			where T : class;
		public static int GetComponents(Transform transform, List<Component> results, bool append); // 0x000000018146D140-0x000000018146D230
		public static int GetComponents(Component component, List<Component> results, bool append); // 0x000000018146D6F0-0x000000018146D7E0
		public static int GetComponents(GameObject gameObject, List<Component> results, bool append); // 0x000000018146C860-0x000000018146CBB0
		public static int GetComponents(Transform transform, Type type, List<Component> results, bool append); // 0x000000018146CC90-0x000000018146CDA0
		public static int GetComponents(Component component, Type type, List<Component> results, bool append); // 0x000000018146D7E0-0x000000018146D8F0
		public static int GetComponents(GameObject gameObject, Type type, List<Component> results, bool append); // 0x000000018146CDA0-0x000000018146D140
		public static int GetComponentsInSelfAndChildren(Transform transform, List<Component> results, bool append); // 0x000000018146C280-0x000000018146C680
		public static int GetComponentsInSelfAndChildren(Component component, List<Component> results, bool append); // 0x000000018146C190-0x000000018146C280
		public static int GetComponentsInSelfAndChildren(GameObject gameObject, List<Component> results, bool append); // 0x000000018146C680-0x000000018146C770
		public static int GetComponentsInSelfAndChildren<T>(Transform transform, List<T> results, bool append)
			where T : class;
		public static int GetComponentsInSelfAndChildren<T>(Component component, List<T> results, bool append)
			where T : class;
		public static int GetComponentsInSelfAndChildren<T>(GameObject gameObject, List<T> results, bool append)
			where T : class;
		public static int GetComponentsInSelfAndChildren<T>(Transform transform, bool includeInactive, List<T> results, bool append)
			where T : class;
		public static int GetComponentsInSelfAndChildren<T>(Component component, bool includeInactive, List<T> results, bool append)
			where T : class;
		public static int GetComponentsInSelfAndChildren<T>(GameObject gameObject, bool includeInactive, List<T> results, bool append)
			where T : class;
		public static int GetComponentsInChildren<T>(Transform transform, List<T> results, bool append)
			where T : class;
		public static int GetComponentsInChildren<T>(Component component, List<T> results, bool append)
			where T : class;
		public static int GetComponentsInChildren<T>(GameObject gameObject, List<T> results, bool append)
			where T : class;
		public static int GetComponentsInChildren<T>(Transform transform, bool includeInactive, List<T> results, bool append)
			where T : class;
		public static int GetComponentsInChildren<T>(Component component, bool includeInactive, List<T> results, bool append)
			where T : class;
		public static int GetComponentsInChildren<T>(GameObject gameObject, bool includeInactive, List<T> results, bool append)
			where T : class;
		public static int GetComponentsInChildren(Transform transform, List<Component> results, bool append); // 0x000000018146B400-0x000000018146B610
		public static int GetComponentsInChildren(Component component, List<Component> results, bool append); // 0x000000018146AD60-0x000000018146B040
		public static int GetComponentsInChildren(GameObject gameObject, List<Component> results, bool append); // 0x000000018146B120-0x000000018146B400
		public static int GetComponentsInParents<T>(Transform transform, List<T> results, bool append)
			where T : class;
		public static int GetComponentsInParents<T>(Component component, List<T> results, bool append)
			where T : class;
		public static int GetComponentsInParents<T>(GameObject gameObject, List<T> results, bool append)
			where T : class;
		public static int GetComponentsInParents(Transform transform, List<Component> results, bool append); // 0x000000018146B610-0x000000018146B900
		public static int GetComponentsInParents(Component component, List<Component> results, bool append); // 0x000000018146BB80-0x000000018146BE70
		public static int GetComponentsInParents(GameObject gameObject, List<Component> results, bool append); // 0x000000018146BF50-0x000000018146C190
		public static void ForEachComponent<T>(Transform transform, Action<T> @delegate, bool includeChildren)
			where T : class;
		public static void ForEachComponent<T>(Transform transform, Action<T> @delegate)
			where T : class;
		public static void ForEachComponent<T>(Component component, Action<T> @delegate, bool includeChildren)
			where T : class;
		public static void ForEachComponent<T>(Component component, Action<T> @delegate)
			where T : class;
		public static void ForEachComponent<T>(GameObject gameObject, Action<T> @delegate, bool includeChildren)
			where T : class;
		public static void ForEachComponent<T>(GameObject gameObject, Action<T> @delegate)
			where T : class;
		public static void ForEachComponentInChildren<T>(Transform transform, Action<T> @delegate)
			where T : class;
		public static void ForEachComponentInChildren<T>(Component component, Action<T> @delegate)
			where T : class;
		public static void ForEachComponentInChildren<T>(GameObject gameObject, Action<T> @delegate)
			where T : class;
		public static bool IsEnabled(Component component); // 0x000000018146E340-0x000000018146E450
		public static bool IsActiveAndEnabled(Component component); // 0x000000018146E210-0x000000018146E340
		public static UnityEngine.Object Instantiate(UnityEngine.Object original, Transform parent, bool instantiateInWorldSpace); // 0x000000018146E0F0-0x000000018146E210
		public static UnityEngine.Object Instantiate(UnityEngine.Object original, Vector3 position, Quaternion rotation, Transform parent, bool instantiateInWorldSpace); // 0x000000018146E030-0x000000018146E0F0
		public static T Instantiate<T>(UnityEngine.Object original, Transform parent, bool instantiateInWorldSpace)
			where T : UnityEngine.Object;
		public static T Instantiate<T>(UnityEngine.Object original, Vector3 position, Quaternion rotation, Transform parent, bool instantiateInWorldSpace)
			where T : UnityEngine.Object;
		public static Vector3 TransformPoint(Transform from, Transform to, Vector3 point); // 0x000000018146F7C0-0x000000018146F910
		public static Vector3 TransformPoint(Transform from, Transform to); // 0x000000018146F610-0x000000018146F7C0
		public static Vector3 TransformDirection(Transform from, Transform to, Vector3 direction); // 0x000000018146F480-0x000000018146F610
		public static Vector3 TransformDirection(Transform from, Transform to); // 0x000000018146F270-0x000000018146F480
		public static Vector3 TransformVector(Transform from, Transform to, Vector3 vector); // 0x000000018146FEE0-0x0000000181470130
		public static Vector3 TransformVector(Transform from, Transform to); // 0x000000018146FDF0-0x000000018146FEE0
		public static Rect TransformRect(Transform from, Transform to, Rect rect); // 0x000000018146F910-0x000000018146FDF0
		public static void DebugDrawCross(Vector3 position, float length, Color color); // 0x0000000181468BD0-0x0000000181469060
		public static void DebugDrawCross(Vector3 position, float length, Color color, float duration); // 0x0000000181469060-0x0000000181469510
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static bool IsObjectInScene<T>(T @object)
			where T : UnityEngine.Object;
		public static string GetUnityInputAxisName(int unityJoystickIndex, int axisIndex); // 0x000000018146DC60-0x000000018146DCC0
		public static string GetUnityInputAxisNameByJoystickId(int unityJoystickId, int axisIndex); // 0x000000018146DA70-0x000000018146DC60
		public static string GetUnityInputButtonName(int unityJoystickIndex, int buttonIndex); // 0x000000018146DF30-0x000000018146DF90
		public static string GetUnityInputButtonNameByJoystickId(int unityJoystickId, int buttonIndex); // 0x000000018146DCC0-0x000000018146DF30
		public static bool IsValidUnityJoystickName(string name); // 0x000000018146EA10-0x000000018146EC00
		public static AnimationCurve Copy(AnimationCurve orig); // 0x0000000181468AB0-0x0000000181468BD0
		public static bool IsNullOrDestroyed(object @object); // 0x000000018146E450-0x000000018146E550
		public static bool IsNullOrDestroyed<T>(T @object)
			where T : class;
		private static T umQYQHnzcMfEIgNoIyZRSBMmXTd<T>(T param_0000f5a5)
			where T : class;
		internal static ButtonStateFlags wrGumvjDsGzAhGnijQIlEKnyPlw(KeyCode param_0000f5a6); // 0x0000000181473430-0x00000001814734C0
		internal static ButtonStateFlags fanZEvScpHOhjdyqIAGzUttVsod(string param_0000f5a7); // 0x0000000181470E50-0x0000000181470ED0
	}
}
