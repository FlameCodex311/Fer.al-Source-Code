/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using WW.Debug;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public static class CoreSharedUtils // TypeDefIndex: 11331
{
	// Fields
	private static bool _slowInternetPopupShown; // 0x00
	public static Vector3 Zero; // 0x04
	public static Vector3 One; // 0x10
	public static Quaternion Identity; // 0x1C
	private static Coroutine _globalInternetConnectionTester; // 0x30
	public static bool _clearAssets; // 0x38
	public static bool _garbageCollect; // 0x39
	private static Coroutine _clearAssetsCoroutine; // 0x40
	private static Dictionary<string, string> _toLowerDict; // 0x48
	private static Dictionary<string, Type> _allUserTypes; // 0x50
	private static Dictionary<string, Type> _allPublicTypes; // 0x58
	private static Dictionary<string, Type> _allPublicExecutingTypes; // 0x60
	private static int _rootResolution; // 0x68
	private static string[] _sizeSuffixes; // 0x70

	// Properties
	public static string CurrentUnitySceneName { get; } // 0x0000000180AA1ED0-0x0000000180AA1F00 
	public static Dictionary<string, Type> AllUserTypes { get; } // 0x0000000180AA1C10-0x0000000180AA1ED0 
	public static Dictionary<string, Type> AllPublicTypes { get; } // 0x0000000180AA1990-0x0000000180AA1C10 
	public static Dictionary<string, Type> AllPublicExecutingTypes { get; } // 0x0000000180AA1790-0x0000000180AA1990 
	public static int rootResolution { get; } // 0x0000000180AA1F00-0x0000000180AA2300 

	// Nested types
	public enum EImageQuality // TypeDefIndex: 11332
	{
		HQ = 0,
		LQ = 1
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass29_0 // TypeDefIndex: 11333
	{
		// Fields
		public bool internetConnected; // 0x10

		// Constructors
		public <>c__DisplayClass29_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <InternetConnectionTesterRoutine>b__0(bool connected); // 0x00000001803FD630-0x00000001803FD640
		internal void <InternetConnectionTesterRoutine>b__1(bool connected); // 0x00000001803FD630-0x00000001803FD640
		internal void <InternetConnectionTesterRoutine>b__2(bool connected); // 0x00000001803FD630-0x00000001803FD640
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <InternetConnectionTesterRoutine>d__29 : IEnumerator<object> // TypeDefIndex: 11334
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		private <>c__DisplayClass29_0 <>8__1; // 0x20
		private float <timeBetweenInternetConnectionTest>5__2; // 0x28
		private float <timeBetweenTest>5__3; // 0x2C

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <InternetConnectionTesterRoutine>d__29(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180AAF410-0x0000000180AAF920
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180AAF920-0x0000000180AAF970
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <ClearAssetsCoroutine>d__34 : IEnumerator<object> // TypeDefIndex: 11335
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <ClearAssetsCoroutine>d__34(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180AAC1A0-0x0000000180AAC2D0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180AAC2D0-0x0000000180AAC320
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <InternetConnected>d__40 : IEnumerator<object> // TypeDefIndex: 11336
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Action<bool> internetConnectedCallback; // 0x20
		private UnityWebRequest <internetCheckWebRequest>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <InternetConnected>d__40(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180AAEF40-0x0000000180AAF3C0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180AAF3C0-0x0000000180AAF410
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SetIconUsingURL>d__66 : IAsyncStateMachine // TypeDefIndex: 11337
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<Sprite> <>t__builder; // 0x08
		public string inURL; // 0x20
		public bool inSetTexture; // 0x28
		public Image inTexture; // 0x30
		private UnityWebRequest <request>5__2; // 0x38
		private UnityWebRequestAsyncOperation <operation>5__3; // 0x40
		private TaskAwaiter <>u__1; // 0x48

		// Methods
		private void MoveNext(); // 0x0000000180030F00-0x0000000180030F10
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180030F10-0x0000000180030F80
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass67_0 // TypeDefIndex: 11338
	{
		// Fields
		public Sprite asset; // 0x10

		// Constructors
		public <>c__DisplayClass67_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <DownloadIconUsingImageDefComponent>b__0(Sprite loadedTexture); // 0x0000000180379F20-0x0000000180379F30
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <DownloadIconUsingImageDefComponent>d__67 : IEnumerator<object> // TypeDefIndex: 11339
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ImageDefComponent inImageDef; // 0x20
		public EImageQuality inImageQuality; // 0x28
		public Action<Sprite> inOnComplete; // 0x30
		public Image inTexture; // 0x38
		private <>c__DisplayClass67_0 <>8__1; // 0x40
		public bool inSetTexture; // 0x48
		private string <path>5__2; // 0x50

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <DownloadIconUsingImageDefComponent>d__67(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180AAC830-0x0000000180AACB50
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180AACB50-0x0000000180AACBA0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass70_0 // TypeDefIndex: 11340
	{
		// Fields
		public Sprite cAsset; // 0x10

		// Constructors
		public <>c__DisplayClass70_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <DownloadSpriteUsingImageDefComponent>b__0(Sprite loadedTexture); // 0x0000000180379F20-0x0000000180379F30
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <DownloadSpriteUsingImageDefComponent>d__70 : IEnumerator<object> // TypeDefIndex: 11341
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ImageDefComponent inImageDef; // 0x20
		public Action<Sprite> inOnComplete; // 0x28
		public GameObject inCacheToGameObject; // 0x30
		private <>c__DisplayClass70_0 <>8__1; // 0x38
		private string <sPath>5__2; // 0x40

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <DownloadSpriteUsingImageDefComponent>d__70(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180AACBA0-0x0000000180AACE20
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180AACE20-0x0000000180AACE70
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass71_0 // TypeDefIndex: 11342
	{
		// Fields
		public Texture cAsset; // 0x10

		// Constructors
		public <>c__DisplayClass71_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <DownloadTextureUsingImageDefComponent>b__0(Texture loadedTexture); // 0x0000000180379F20-0x0000000180379F30
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <DownloadTextureUsingImageDefComponent>d__71 : IEnumerator<object> // TypeDefIndex: 11343
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ImageDefComponent inImageDef; // 0x20
		public Action<Texture> inOnComplete; // 0x28
		public GameObject inCacheToGameObject; // 0x30
		private <>c__DisplayClass71_0 <>8__1; // 0x38
		private string <sPath>5__2; // 0x40

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <DownloadTextureUsingImageDefComponent>d__71(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180AADA70-0x0000000180AADCF0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180AADCF0-0x0000000180AADD40
	}

	// Constructors
	static CoreSharedUtils(); // 0x0000000180AA12F0-0x0000000180AA1790

	// Methods
	public static string GetAppUpdateURL(); // 0x0000000180A9E340-0x0000000180A9E410
	public static string GetSharedImagesURL(); // 0x0000000180A9EBC0-0x0000000180A9EC60
	public static void OnAndroidQuit(Message inMessage); // 0x00000001803774A0-0x00000001803774B0
	public static void SetResolution(int inWidth, int inHeight, bool inFullscreen); // 0x0000000180AA0730-0x0000000180AA0A10
	public static bool WithinDistance(Transform inTransform, Transform inOtherTransform, float inDistance); // 0x0000000180AA0F20-0x0000000180AA1100
	public static bool WithinDistance(Vector3 inPosition, Vector3 inOtherPosition, float inDistance); // 0x0000000180AA0E50-0x0000000180AA0F20
	public static float GetDistance(Transform inTransform, Transform inOtherTransform); // 0x0000000180A9E6E0-0x0000000180A9E800
	public static float GetDistance(Vector3 inPosition, Vector3 inOtherPosition); // 0x0000000180A9E650-0x0000000180A9E6E0
	[DebugButton] // 0x0000000180289960-0x00000001802899C0
	private static void DebugCoreResetDefaultError(); // 0x0000000180A9D260-0x0000000180A9D2F0
	public static void CoreReset(SplashError inSplashError, ErrorCode inErrorCode); // 0x0000000180A9D040-0x0000000180A9D260
	[DebugButton] // 0x0000000180289C10-0x0000000180289C70
	public static void CoreReset(); // 0x0000000180A9CF90-0x0000000180A9D040
	public static Vector2 WorldToCanvasPosition(RectTransform inCanvas, Camera inCamera, Vector3 inPosition, bool inCenteredY = false /* Metadata: 0x0077CA60 */); // 0x0000000180AA1100-0x0000000180AA12F0
	public static void PopupErrorAndResetCoreWithLocDefIDs(string inMessageDefID, string inTitleDefID); // 0x0000000180A9FD50-0x0000000180A9FE90
	public static void PopupErrorAndResetCoreWithStrings(string inMessageString, string inTitleString); // 0x0000000180A9FE90-0x0000000180A9FF60
	private static void OnDisconnectPopupClosed(string inButton); // 0x0000000180A9FCD0-0x0000000180A9FD50
	public static T[] GetObjectsOfTypeInScene<T>()
		where T : UnityEngine.Object;
	public static bool HasFlag(UnityEngine.Object inObject, HideFlags inFlag); // 0x0000000180A9F0B0-0x0000000180A9F0E0
	public static void SetActive(List<Transform> inTransforms, bool InActive); // 0x0000000180AA0220-0x0000000180AA02F0
	public static void SetActive(Transform InTransform, bool InActive); // 0x0000000180AA0100-0x0000000180AA0220
	public static void SetActive(GameObject InGameObject, bool InActive); // 0x0000000180AA02F0-0x0000000180AA0380
	public static void SetActiveUIGroup(GameObject[] objects, bool inBool); // 0x0000000180AA0040-0x0000000180AA0100
	public static void StopGlobalInternetConnectionTester(); // 0x0000000180AA0D80-0x0000000180AA0E50
	public static void StartGlobalInternetConnectionTester(); // 0x0000000180AA0BD0-0x0000000180AA0CD0
	[IteratorStateMachine] // 0x0000000180289D50-0x0000000180289DA0
	public static IEnumerator InternetConnectionTesterRoutine(); // 0x0000000180A9F370-0x0000000180A9F3C0
	public static void StopClearAssetsCoroutine(); // 0x0000000180AA0CD0-0x0000000180AA0D80
	[IteratorStateMachine] // 0x000000018028A110-0x000000018028A160
	private static IEnumerator ClearAssetsCoroutine(); // 0x0000000180A9CD50-0x0000000180A9CDA0
	public static void ClearAssets(bool inGarbageCollect = false /* Metadata: 0x0077CA61 */, bool inUseGCRCoroutine = true /* Metadata: 0x0077CA62 */); // 0x0000000180A9CDA0-0x0000000180A9CF90
	private static void GC(); // 0x0000000180A9DD60-0x0000000180A9DDB0
	public static bool IsVisible(List<Renderer> InRenderers); // 0x0000000180A9F880-0x0000000180A9F980
	[IteratorStateMachine] // 0x000000018028A3F0-0x000000018028A440
	public static IEnumerator InternetConnected(Action<bool> internetConnectedCallback); // 0x0000000180A9F310-0x0000000180A9F370
	public static string FastToLower(string inName); // 0x0000000180A9D7B0-0x0000000180A9D900
	public static Type GetTypeFromAllUserTypes(string inName); // 0x0000000180A9ED20-0x0000000180A9ED80
	public static Type GetTypeFromAllPublicTypes(string inName); // 0x0000000180A9ECC0-0x0000000180A9ED20
	public static Type GetTypeFromAllPublicExecutingTypes(string inName); // 0x0000000180A9EC60-0x0000000180A9ECC0
	public static Type GetType(string typeName); // 0x0000000180A9ED80-0x0000000180A9F000
	public static int GetClientDeviceType(); // 0x0000000180A9E410-0x0000000180A9E470
	private static bool IsTablet(); // 0x0000000180380950-0x0000000180380960
	public static T Instantiate<T>(T InObject)
		where T : MonoBehaviour;
	public static T Instantiate<T>(T InObject, Vector3 InPosition, Quaternion InRotation)
		where T : MonoBehaviour;
	public static UnityEngine.Object Instance(UnityEngine.Object InObject); // 0x0000000180A9F0E0-0x0000000180A9F220
	public static UnityEngine.Object Instance(UnityEngine.Object InObject, Vector3 InPosition, Quaternion InRotation); // 0x0000000180A9F220-0x0000000180A9F310
	public static void SetIconUsingImageComponentDefID(string inImageDefID, WWImage inTexture, Action<Sprite> inOnComplete = null); // 0x0000000180AA0380-0x0000000180AA04A0
	public static void SetIconUsingImageDefComponent(ImageDefComponent inImageDef, Image inTexture, EImageQuality inImageQuality, Action<Sprite> inOnComplete = null, bool inSetTexture = true /* Metadata: 0x0077CA63 */); // 0x0000000180AA04A0-0x0000000180AA0560
	public static void SetIconUsingImageDefComponent(ImageDefComponent inImageDef, Image inTexture, Action<Sprite> inOnComplete = null, bool inSetTexture = true /* Metadata: 0x0077CA64 */); // 0x0000000180AA0560-0x0000000180AA0620
	[AsyncStateMachine] // 0x000000018028A5A0-0x000000018028A5F0
	public static Task<Sprite> SetIconUsingURL(string inURL, Image inTexture, bool inSetTexture = true /* Metadata: 0x0077CA65 */); // 0x0000000180AA0620-0x0000000180AA0730
	[IteratorStateMachine] // 0x000000018028A7A0-0x000000018028A7F0
	public static IEnumerator DownloadIconUsingImageDefComponent(ImageDefComponent inImageDef, Image inTexture, EImageQuality inImageQuality, Action<Sprite> inOnComplete = null, bool inSetTexture = true /* Metadata: 0x0077CA66 */); // 0x0000000180A9D450-0x0000000180A9D4F0
	public static void SetSpriteUsingImageDefComponent(ImageDefComponent inImageDef, GameObject inCacheToGameObject, Action<Sprite> inOnComplete); // 0x0000000180AA0A10-0x0000000180AA0AF0
	public static void SetTextureUsingImageDefComponent(ImageDefComponent inImageDef, GameObject inCacheToGameObject, Action<Texture> inOnComplete); // 0x0000000180AA0AF0-0x0000000180AA0BD0
	[IteratorStateMachine] // 0x000000018028A9E0-0x000000018028AA30
	public static IEnumerator DownloadSpriteUsingImageDefComponent(ImageDefComponent inImageDef, GameObject inCacheToGameObject, Action<Sprite> inOnComplete); // 0x0000000180A9D4F0-0x0000000180A9D570
	[IteratorStateMachine] // 0x000000018028ABB0-0x000000018028AC00
	public static IEnumerator DownloadTextureUsingImageDefComponent(ImageDefComponent inImageDef, GameObject inCacheToGameObject, Action<Texture> inOnComplete); // 0x0000000180A9D570-0x0000000180A9D5F0
	public static string GetImageComponentPath(ImageDefComponent inImageDef, EImageQuality inImageQuality); // 0x0000000180A9E800-0x0000000180A9EA60
	public static string FormatBytesToMegaBytes(int inBytes, int inDecimals = 1 /* Metadata: 0x0077CA67 */); // 0x0000000180A9DD00-0x0000000180A9DD60
	public static string FormatBytesToMegaBytes(float inBytes, int inDecimals = 1 /* Metadata: 0x0077CA6B */); // 0x0000000180A9D900-0x0000000180A9D970
	public static string FormatBytesToMegaBytes(long inBytes, int inDecimals = 1 /* Metadata: 0x0077CA6F */); // 0x0000000180A9D970-0x0000000180A9DD00
	public static float Map(float inValue, float inOriginalStart, float inOriginalEnd, float inNewStart, float inNewEnd); // 0x0000000180A9FC90-0x0000000180A9FCD0
	public static Vector2 Map(float inValue, Vector2 inOriginalStart, Vector2 inOriginalEnd, Vector2 inNewStart, Vector2 inNewEnd); // 0x0000000180A9FB80-0x0000000180A9FC90
	public static Vector3 Map(float inValue, Vector3 inOriginalStart, Vector3 inOriginalEnd, Vector3 inNewStart, Vector3 inNewEnd); // 0x0000000180A9F980-0x0000000180A9FB80
	public static float GetPercentage(int inCurrentValue, int inMinValue, int inMaxValue); // 0x0000000180A9EA60-0x0000000180A9EB40
	public static float GetPercentage(float inCurrentValue, float inMinValue, float inMaxValue); // 0x0000000180A9EB40-0x0000000180A9EBC0
	public static float GetValueFromPercentage(float inPercentage, float inMinValue, float inMaxValue); // 0x0000000180A9F000-0x0000000180A9F0B0
	public static bool IsEven(int InValue); // 0x0000000180A9F450-0x0000000180A9F4B0
	public static bool IsEven(float InValue); // 0x0000000180A9F3C0-0x0000000180A9F450
	public static bool IsOdd(int InValue); // 0x0000000180A9F860-0x0000000180A9F880
	public static bool IsOdd(float InValue); // 0x0000000180A9F820-0x0000000180A9F860
	public static string GetDefIDFromPackedName(string inDefName); // 0x0000000180A9E470-0x0000000180A9E560
	public static string GetDefNameFromPackedName(string inDefName); // 0x0000000180A9E560-0x0000000180A9E650
	public static bool ArePackedDefNamesEqual(string inDefName1, string inDefName2); // 0x0000000180A9C770-0x0000000180A9C880
	public static void InsertionSort<T>(IList<T> inList, Comparison<T> inComparison);
	public static void DestroyChildren(Transform inTransform); // 0x0000000180A9D3A0-0x0000000180A9D450
	public static void DestroyChildrenImmediate(Transform inTransform); // 0x0000000180A9D2F0-0x0000000180A9D3A0
	public static bool CanFitBytesOnDisk(long inByteCount); // 0x0000000180A9C880-0x0000000180A9CA50
	public static void DrawLineOnTexture(Texture2D inTex, Vector2 inPoint1, Vector2 inPoint2, Color inColor); // 0x0000000180A9D5F0-0x0000000180A9D7B0
	public static Sprite GenerateUVSpriteFromMesh(Mesh inMesh, int inResolution); // 0x0000000180A9DDB0-0x0000000180A9E340
	public static string RepairBundleIDString(string inString); // 0x0000000180A9FF60-0x0000000180AA0040
	public static string CleanForJSON(string s); // 0x0000000180A9CA80-0x0000000180A9CD50
	public static List<ValueTuple<T, U>> MakeTupleList<T, U>(List<T> inList1, List<U> inList2);
	public static bool IsInside(Vector3 inPosition, BoxCollider inBoxCollider); // 0x0000000180A9F4B0-0x0000000180A9F6C0
	public static bool IsInside(Vector3 inPosition, SphereCollider inSphereCollider); // 0x0000000180A9F6C0-0x0000000180A9F820

	// Extension methods
	public static bool CaseInsensitiveContains(this string source, string toCheck); // 0x0000000180A9CA50-0x0000000180A9CA80
	public static T AddComponentCopy<T>(this GameObject go, T toAdd)
		where T : Component;
	public static T CopyComponent<T>(this Component comp, T other)
		where T : Component;
}

