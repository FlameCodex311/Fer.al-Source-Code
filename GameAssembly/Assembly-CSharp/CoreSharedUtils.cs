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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public static class CoreSharedUtils // TypeDefIndex: 13664
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
	public static string CurrentUnitySceneName { get; } // 0x00000001813237B0-0x00000001813237E0 
	public static Dictionary<string, Type> AllUserTypes { get; } // 0x00000001813234E0-0x00000001813237B0 
	public static Dictionary<string, Type> AllPublicTypes { get; } // 0x0000000181323250-0x00000001813234E0 
	public static Dictionary<string, Type> AllPublicExecutingTypes { get; } // 0x0000000181323040-0x0000000181323250 
	public static int rootResolution { get; } // 0x00000001813237E0-0x0000000181323C00 

	// Nested types
	public enum EImageQuality // TypeDefIndex: 13665
	{
		HQ = 0,
		LQ = 1
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass29_0 // TypeDefIndex: 13666
	{
		// Fields
		public bool internetConnected; // 0x10

		// Constructors
		public <>c__DisplayClass29_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <InternetConnectionTesterRoutine>b__0(bool connected); // 0x00000001803930B0-0x00000001803930C0
		internal void <InternetConnectionTesterRoutine>b__1(bool connected); // 0x00000001803930B0-0x00000001803930C0
		internal void <InternetConnectionTesterRoutine>b__2(bool connected); // 0x00000001803930B0-0x00000001803930C0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <InternetConnectionTesterRoutine>d__29 : IEnumerator<object> // TypeDefIndex: 13667
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		private <>c__DisplayClass29_0 <>8__1; // 0x20
		private float <timeBetweenInternetConnectionTest>5__2; // 0x28
		private float <timeBetweenTest>5__3; // 0x2C

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <InternetConnectionTesterRoutine>d__29(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180F502C0-0x0000000180F50850
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180F50850-0x0000000180F508A0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <ClearAssetsCoroutine>d__34 : IEnumerator<object> // TypeDefIndex: 13668
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <ClearAssetsCoroutine>d__34(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181324A60-0x0000000181324B90
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181324B90-0x0000000181324BE0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <InternetConnected>d__40 : IEnumerator<object> // TypeDefIndex: 13669
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Action<bool> internetConnectedCallback; // 0x20
		private UnityWebRequest <internetCheckWebRequest>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <InternetConnected>d__40(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180F4FDE0-0x0000000180F50270
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180F50270-0x0000000180F502C0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SetIconUsingURL>d__66 : IAsyncStateMachine // TypeDefIndex: 13670
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
		private void MoveNext(); // 0x00000001801F1580-0x00000001801F1590
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F1590-0x00000001801F15E0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass67_0 // TypeDefIndex: 13671
	{
		// Fields
		public Sprite asset; // 0x10

		// Constructors
		public <>c__DisplayClass67_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <DownloadIconUsingImageDefComponent>b__0(Sprite loadedTexture); // 0x000000018036B1E0-0x000000018036B1F0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <DownloadIconUsingImageDefComponent>d__67 : IEnumerator<object> // TypeDefIndex: 13672
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <DownloadIconUsingImageDefComponent>d__67(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001813271F0-0x0000000181327520
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181327520-0x0000000181327570
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass70_0 // TypeDefIndex: 13673
	{
		// Fields
		public Sprite cAsset; // 0x10

		// Constructors
		public <>c__DisplayClass70_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <DownloadSpriteUsingImageDefComponent>b__0(Sprite loadedTexture); // 0x000000018036B1E0-0x000000018036B1F0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <DownloadSpriteUsingImageDefComponent>d__70 : IEnumerator<object> // TypeDefIndex: 13674
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <DownloadSpriteUsingImageDefComponent>d__70(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180F4D870-0x0000000180F4DAF0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180F4DAF0-0x0000000180F4DB40
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass71_0 // TypeDefIndex: 13675
	{
		// Fields
		public Texture cAsset; // 0x10

		// Constructors
		public <>c__DisplayClass71_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <DownloadTextureUsingImageDefComponent>b__0(Texture loadedTexture); // 0x000000018036B1E0-0x000000018036B1F0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <DownloadTextureUsingImageDefComponent>d__71 : IEnumerator<object> // TypeDefIndex: 13676
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <DownloadTextureUsingImageDefComponent>d__71(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180F4E780-0x0000000180F4EA00
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180F4EA00-0x0000000180F4EA50
	}

	// Constructors
	static CoreSharedUtils(); // 0x0000000181322B70-0x0000000181323040

	// Methods
	public static string GetAppUpdateURL(); // 0x000000018131F960-0x000000018131FA30
	public static string GetSharedImagesURL(); // 0x0000000181320210-0x0000000181320430
	public static void OnAndroidQuit(Message inMessage); // 0x00000001803581E0-0x00000001803581F0
	public static void SetResolution(int inWidth, int inHeight, bool inFullscreen); // 0x0000000181321F60-0x0000000181322260
	public static bool WithinDistance(Transform inTransform, Transform inOtherTransform, float inDistance); // 0x0000000181322790-0x0000000181322970
	public static bool WithinDistance(Vector3 inPosition, Vector3 inOtherPosition, float inDistance); // 0x00000001813226C0-0x0000000181322790
	public static float GetDistance(Transform inTransform, Transform inOtherTransform); // 0x000000018131FD20-0x000000018131FE40
	public static float GetDistance(Vector3 inPosition, Vector3 inOtherPosition); // 0x000000018131FC90-0x000000018131FD20
	[DebugButton] // 0x00000001800EC360-0x00000001800EC3C0
	private static void DebugCoreResetDefaultError(); // 0x000000018131E8C0-0x000000018131E950
	public static void CoreReset(SplashError inSplashError, ErrorCode inErrorCode); // 0x000000018131E6A0-0x000000018131E8C0
	[DebugButton] // 0x00000001800EC4A0-0x00000001800EC500
	public static void CoreReset(); // 0x000000018131E5E0-0x000000018131E6A0
	public static Vector2 WorldToCanvasPosition(RectTransform inCanvas, Camera inCamera, Vector3 inPosition, bool inCenteredY = false /* Metadata: 0x00783FA1 */); // 0x0000000181322970-0x0000000181322B70
	public static void PopupErrorAndResetCoreWithLocDefIDs(string inMessageDefID, string inTitleDefID); // 0x0000000181321550-0x0000000181321690
	public static void PopupErrorAndResetCoreWithStrings(string inMessageString, string inTitleString); // 0x0000000181321690-0x0000000181321760
	private static void OnDisconnectPopupClosed(string inButton); // 0x00000001813214D0-0x0000000181321550
	public static T[] GetObjectsOfTypeInScene<T>()
		where T : UnityEngine.Object;
	public static bool HasFlag(UnityEngine.Object inObject, HideFlags inFlag); // 0x0000000181320890-0x00000001813208C0
	public static void SetActive(List<Transform> inTransforms, bool InActive); // 0x0000000181321A30-0x0000000181321B00
	public static void SetActive(Transform InTransform, bool InActive); // 0x0000000181321910-0x0000000181321A30
	public static void SetActive(GameObject InGameObject, bool InActive); // 0x0000000181321B00-0x0000000181321B90
	public static void SetActiveUIGroup(GameObject[] objects, bool inBool); // 0x0000000181321850-0x0000000181321910
	public static void StopGlobalInternetConnectionTester(); // 0x00000001813225F0-0x00000001813226C0
	public static void StartGlobalInternetConnectionTester(); // 0x0000000181322440-0x0000000181322540
	[IteratorStateMachine] // 0x00000001800EC660-0x00000001800EC6B0
	public static IEnumerator InternetConnectionTesterRoutine(); // 0x0000000181320B60-0x0000000181320BB0
	public static void StopClearAssetsCoroutine(); // 0x0000000181322540-0x00000001813225F0
	[IteratorStateMachine] // 0x00000001800EC910-0x00000001800EC960
	private static IEnumerator ClearAssetsCoroutine(); // 0x000000018131E3A0-0x000000018131E3F0
	public static void ClearAssets(bool inGarbageCollect = false /* Metadata: 0x00783FA2 */, bool inUseGCRCoroutine = true /* Metadata: 0x00783FA3 */); // 0x000000018131E3F0-0x000000018131E5E0
	private static void GC(); // 0x000000018131F350-0x000000018131F3A0
	public static bool IsVisible(List<Renderer> InRenderers); // 0x0000000181321080-0x0000000181321180
	[IteratorStateMachine] // 0x00000001800ECC70-0x00000001800ECCC0
	public static IEnumerator InternetConnected(Action<bool> internetConnectedCallback); // 0x0000000181320AF0-0x0000000181320B60
	public static string FastToLower(string inName); // 0x000000018131ED90-0x000000018131EEE0
	public static Type GetTypeFromAllUserTypes(string inName); // 0x00000001813204F0-0x0000000181320550
	public static Type GetTypeFromAllPublicTypes(string inName); // 0x0000000181320490-0x00000001813204F0
	public static Type GetTypeFromAllPublicExecutingTypes(string inName); // 0x0000000181320430-0x0000000181320490
	public static Type GetType(string typeName); // 0x0000000181320550-0x00000001813207E0
	public static int GetClientDeviceType(); // 0x000000018131FA30-0x000000018131FA90
	private static bool IsTablet(); // 0x00000001803C28F0-0x00000001803C2900
	public static T Instantiate<T>(T InObject)
		where T : MonoBehaviour;
	public static T Instantiate<T>(T InObject, Vector3 InPosition, Quaternion InRotation)
		where T : MonoBehaviour;
	public static UnityEngine.Object Instance(UnityEngine.Object InObject); // 0x00000001813208C0-0x0000000181320A00
	public static UnityEngine.Object Instance(UnityEngine.Object InObject, Vector3 InPosition, Quaternion InRotation); // 0x0000000181320A00-0x0000000181320AF0
	public static void SetIconUsingImageComponentDefID(string inImageDefID, WWImage inTexture, Action<Sprite> inOnComplete = null); // 0x0000000181321B90-0x0000000181321CB0
	public static void SetIconUsingImageDefComponent(ImageDefComponent inImageDef, Image inTexture, EImageQuality inImageQuality, Action<Sprite> inOnComplete = null, bool inSetTexture = true /* Metadata: 0x00783FA4 */); // 0x0000000181321CB0-0x0000000181321D80
	public static void SetIconUsingImageDefComponent(ImageDefComponent inImageDef, Image inTexture, Action<Sprite> inOnComplete = null, bool inSetTexture = true /* Metadata: 0x00783FA5 */); // 0x0000000181321D80-0x0000000181321E50
	[AsyncStateMachine] // 0x00000001800ECFC0-0x00000001800ED010
	public static Task<Sprite> SetIconUsingURL(string inURL, Image inTexture, bool inSetTexture = true /* Metadata: 0x00783FA6 */); // 0x0000000181321E50-0x0000000181321F60
	[IteratorStateMachine] // 0x00000001800ED0D0-0x00000001800ED120
	public static IEnumerator DownloadIconUsingImageDefComponent(ImageDefComponent inImageDef, Image inTexture, EImageQuality inImageQuality, Action<Sprite> inOnComplete = null, bool inSetTexture = true /* Metadata: 0x00783FA7 */); // 0x000000018131EA10-0x000000018131EAB0
	public static void SetSpriteUsingImageDefComponent(ImageDefComponent inImageDef, GameObject inCacheToGameObject, Action<Sprite> inOnComplete); // 0x0000000181322260-0x0000000181322350
	public static void SetTextureUsingImageDefComponent(ImageDefComponent inImageDef, GameObject inCacheToGameObject, Action<Texture> inOnComplete); // 0x0000000181322350-0x0000000181322440
	[IteratorStateMachine] // 0x00000001800ED380-0x00000001800ED3D0
	public static IEnumerator DownloadSpriteUsingImageDefComponent(ImageDefComponent inImageDef, GameObject inCacheToGameObject, Action<Sprite> inOnComplete); // 0x000000018131EAB0-0x000000018131EB40
	[IteratorStateMachine] // 0x00000001800ED490-0x00000001800ED4E0
	public static IEnumerator DownloadTextureUsingImageDefComponent(ImageDefComponent inImageDef, GameObject inCacheToGameObject, Action<Texture> inOnComplete); // 0x000000018131EB40-0x000000018131EBD0
	public static string GetImageComponentPath(ImageDefComponent inImageDef, EImageQuality inImageQuality); // 0x000000018131FE40-0x00000001813200B0
	public static string FormatBytesToMegaBytes(int inBytes, int inDecimals = 1 /* Metadata: 0x00783FA8 */); // 0x000000018131F2F0-0x000000018131F350
	public static string FormatBytesToMegaBytes(float inBytes, int inDecimals = 1 /* Metadata: 0x00783FAC */); // 0x000000018131EEE0-0x000000018131EF50
	public static string FormatBytesToMegaBytes(long inBytes, int inDecimals = 1 /* Metadata: 0x00783FB0 */); // 0x000000018131EF50-0x000000018131F2F0
	public static float Map(float inValue, float inOriginalStart, float inOriginalEnd, float inNewStart, float inNewEnd); // 0x0000000181321490-0x00000001813214D0
	public static Vector2 Map(float inValue, Vector2 inOriginalStart, Vector2 inOriginalEnd, Vector2 inNewStart, Vector2 inNewEnd); // 0x0000000181321380-0x0000000181321490
	public static Vector3 Map(float inValue, Vector3 inOriginalStart, Vector3 inOriginalEnd, Vector3 inNewStart, Vector3 inNewEnd); // 0x0000000181321180-0x0000000181321380
	public static float GetPercentage(int inCurrentValue, int inMinValue, int inMaxValue); // 0x00000001813200B0-0x0000000181320190
	public static float GetPercentage(float inCurrentValue, float inMinValue, float inMaxValue); // 0x0000000181320190-0x0000000181320210
	public static float GetValueFromPercentage(float inPercentage, float inMinValue, float inMaxValue); // 0x00000001813207E0-0x0000000181320890
	public static bool IsEven(int InValue); // 0x0000000181320C40-0x0000000181320CA0
	public static bool IsEven(float InValue); // 0x0000000181320BB0-0x0000000181320C40
	public static bool IsOdd(int InValue); // 0x0000000181321060-0x0000000181321080
	public static bool IsOdd(float InValue); // 0x0000000181321020-0x0000000181321060
	public static string GetDefIDFromPackedName(string inDefName); // 0x000000018131FA90-0x000000018131FB90
	public static string GetDefNameFromPackedName(string inDefName); // 0x000000018131FB90-0x000000018131FC90
	public static bool ArePackedDefNamesEqual(string inDefName1, string inDefName2); // 0x000000018131DDF0-0x000000018131DF00
	public static void InsertionSort<T>(IList<T> inList, Comparison<T> inComparison);
	public static void DestroyChildren(Transform inTransform); // 0x000000018131E950-0x000000018131EA10
	public static bool CanFitBytesOnDisk(long inByteCount); // 0x000000018131DF00-0x000000018131E080
	public static void DrawLineOnTexture(Texture2D inTex, Vector2 inPoint1, Vector2 inPoint2, Color inColor); // 0x000000018131EBD0-0x000000018131ED90
	public static Sprite GenerateUVSpriteFromMesh(Mesh inMesh, int inResolution); // 0x000000018131F3A0-0x000000018131F960
	public static string RepairBundleIDString(string inString); // 0x0000000181321760-0x0000000181321850
	public static string CleanForJSON(string s); // 0x000000018131E0B0-0x000000018131E3A0
	public static List<ValueTuple<T, U>> MakeTupleList<T, U>(List<T> inList1, List<U> inList2);
	public static bool IsInside(Vector3 inPosition, BoxCollider inBoxCollider); // 0x0000000181320CA0-0x0000000181320EB0
	public static bool IsInside(Vector3 inPosition, SphereCollider inSphereCollider); // 0x0000000181320EB0-0x0000000181321020

	// Extension methods
	public static bool CaseInsensitiveContains(this string source, string toCheck); // 0x000000018131E080-0x000000018131E0B0
	public static T AddComponentCopy<T>(this GameObject go, T toAdd)
		where T : Component;
	public static T CopyComponent<T>(this Component comp, T other)
		where T : Component;
}

