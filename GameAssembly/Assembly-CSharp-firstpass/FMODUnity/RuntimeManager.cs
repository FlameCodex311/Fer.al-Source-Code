/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AOT;
using FMOD;
using FMOD.Studio;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FMODUnity
{
	[AddComponentMenu] // 0x00000001800B75F0-0x00000001800B7620
	public class RuntimeManager : UnityEngine.MonoBehaviour // TypeDefIndex: 9829
	{
		// Fields
		private static SystemNotInitializedException initException; // 0x00
		private static RuntimeManager instance; // 0x08
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private FMODPlatform fmodPlatform; // 0x18
		private FMOD.Studio.System studioSystem; // 0x20
		private FMOD.System coreSystem; // 0x28
		private DSP mixerHead; // 0x30
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private long[] cachedPointers; // 0x38
		private Dictionary<string, LoadedBank> loadedBanks; // 0x40
		private Dictionary<string, uint> loadedPlugins; // 0x48
		private Dictionary<Guid, EventDescription> cachedDescriptions; // 0x50
		private List<AttachedInstance> attachedInstances; // 0x58
		private bool listenerWarningIssued; // 0x60
		protected bool isOverlayEnabled; // 0x61
		private FMODRuntimeManagerOnGUIHelper overlayDrawer; // 0x68
		private Rect windowRect; // 0x70
		private string lastDebugText; // 0x80
		private float lastDebugUpdate; // 0x88
		public static bool[] HasListener; // 0x10
		private static int numListeners; // 0x18
	
		// Properties
		private static RuntimeManager Instance { get; } // 0x0000000181B2BD20-0x0000000181B2C340 
		public static FMOD.Studio.System StudioSystem { get; } // 0x0000000181B2C420-0x0000000181B2C480 
		public static FMOD.System CoreSystem { get; } // 0x0000000181B2BC40-0x0000000181B2BCA0 
		public static bool IsInitialized { get; } // 0x0000000181B2C340-0x0000000181B2C420 
		public static bool HasBanksLoaded { get; } // 0x0000000181B2BCA0-0x0000000181B2BD20 
	
		// Nested types
		private struct LoadedBank // TypeDefIndex: 9830
		{
			// Fields
			public Bank Bank; // 0x00
			public int RefCount; // 0x08
		}
	
		private class GuidComparer : IEqualityComparer<Guid> // TypeDefIndex: 9831
		{
			// Constructors
			public GuidComparer(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			bool IEqualityComparer<Guid>.Equals(Guid x, Guid y); // 0x0000000181B1A090-0x0000000181B1A0C0
			int IEqualityComparer<Guid>.GetHashCode(Guid obj); // 0x0000000181B1AA80-0x0000000181B1AAA0
		}
	
		private class AttachedInstance // TypeDefIndex: 9832
		{
			// Fields
			public EventInstance instance; // 0x10
			public Transform transform; // 0x18
			public Rigidbody rigidBody; // 0x20
			public Rigidbody2D rigidBody2D; // 0x28
	
			// Constructors
			public AttachedInstance(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		// Constructors
		public RuntimeManager(); // 0x0000000181B2BAF0-0x0000000181B2BC40
		static RuntimeManager(); // 0x0000000181B2BA70-0x0000000181B2BAF0
	
		// Methods
		[MonoPInvokeCallback] // 0x00000001800EDF40-0x00000001800EDF90
		private static RESULT DEBUG_CALLBACK(DEBUG_FLAGS flags, StringWrapper file, int line, StringWrapper func, StringWrapper message); // 0x0000000181B26BE0-0x0000000181B26C80
		private void CheckInitResult(RESULT result, string cause); // 0x0000000181B26970-0x0000000181B26A20
		private RESULT Initialize(); // 0x0000000181B27AC0-0x0000000181B28310
		public static bool AddListener(int index); // 0x0000000181B26140-0x0000000181B263B0
		public static bool RemoveListener(int index); // 0x0000000181B2A370-0x0000000181B2A580
		private static int RecalculateTotalListeners(); // 0x0000000181B2A270-0x0000000181B2A370
		private void Update(); // 0x0000000181B2B380-0x0000000181B2BA10
		public static void AttachInstanceToGameObject(EventInstance instance, Transform transform, Rigidbody rigidBody); // 0x0000000181B26710-0x0000000181B26970
		public static void AttachInstanceToGameObject(EventInstance instance, Transform transform, Rigidbody2D rigidBody2D); // 0x0000000181B26560-0x0000000181B26710
		public static void DetachInstanceFromGameObject(EventInstance instance); // 0x0000000181B26C80-0x0000000181B26D90
		public void ExecuteOnGUI(); // 0x0000000181B272F0-0x0000000181B273D0
		private void Start(); // 0x0000000181B2B130-0x0000000181B2B210
		private void DrawDebugOverlay(int windowID); // 0x0000000181B26D90-0x0000000181B272F0
		private void OnDisable(); // 0x0000000181B29650-0x0000000181B296E0
		private void OnDestroy(); // 0x0000000181B29590-0x0000000181B29650
		private void OnApplicationPause(bool pauseStatus); // 0x0000000181B29400-0x0000000181B29590
		private void loadedBankRegister(LoadedBank loadedBank, string bankPath, string bankName, bool loadSamples, RESULT loadResult); // 0x0000000181B2C480-0x0000000181B2C5D0
		public static void LoadBankWW(string bankName, string bankFolder, bool loadSamples = false /* Metadata: 0x00745EC7 */); // 0x0000000181B28310-0x0000000181B285F0
		public static void LoadBank(string bankName, bool loadSamples = false /* Metadata: 0x00745EC8 */); // 0x0000000181B28940-0x0000000181B28C60
		public static void LoadBank(TextAsset asset, bool loadSamples = false /* Metadata: 0x00745EC9 */); // 0x0000000181B285F0-0x0000000181B28940
		private void LoadBanks(Settings fmodSettings); // 0x0000000181B28C60-0x0000000181B290C0
		public static void UnloadBank(string bankName); // 0x0000000181B2B210-0x0000000181B2B380
		public static bool AnyBankLoading(); // 0x0000000181B263B0-0x0000000181B26560
		public static void WaitForAllLoads(); // 0x0000000181B2BA10-0x0000000181B2BA70
		public static Guid PathToGUID(string path); // 0x0000000181B296E0-0x0000000181B29800
		public static EventInstance CreateInstance(string path); // 0x0000000181B26B20-0x0000000181B26BE0
		public static EventInstance CreateInstance(Guid guid); // 0x0000000181B26A20-0x0000000181B26B20
		public static void PlayOneShot(string path, Vector3 position = default); // 0x0000000181B29D40-0x0000000181B2A030
		public static void PlayOneShot(Guid guid, Vector3 position = default); // 0x0000000181B2A030-0x0000000181B2A270
		public static void PlayOneShotAttached(string path, GameObject gameObject); // 0x0000000181B29910-0x0000000181B29B80
		public static void PlayOneShotAttached(Guid guid, GameObject gameObject); // 0x0000000181B29B80-0x0000000181B29D40
		public static EventDescription GetEventDescription(string path); // 0x0000000181B274E0-0x0000000181B275A0
		public static EventDescription GetEventDescription(Guid guid); // 0x0000000181B275A0-0x0000000181B278B0
		public static void SetListenerLocation(GameObject gameObject, Rigidbody rigidBody = null); // 0x0000000181B2AC70-0x0000000181B2AEB0
		public static void SetListenerLocation(GameObject gameObject, Rigidbody2D rigidBody2D); // 0x0000000181B2A7D0-0x0000000181B2AA20
		public static void SetListenerLocation(Transform transform); // 0x0000000181B2AFF0-0x0000000181B2B130
		public static void SetListenerLocation(int listenerIndex, GameObject gameObject, Rigidbody rigidBody = null); // 0x0000000181B2A580-0x0000000181B2A7D0
		public static void SetListenerLocation(int listenerIndex, GameObject gameObject, Rigidbody2D rigidBody2D); // 0x0000000181B2AA20-0x0000000181B2AC70
		public static void SetListenerLocation(int listenerIndex, Transform transform); // 0x0000000181B2AEB0-0x0000000181B2AFF0
		public static Bus GetBus(string path); // 0x0000000181B273D0-0x0000000181B274E0
		public static VCA GetVCA(string path); // 0x0000000181B278B0-0x0000000181B27A30
		public static void PauseAllEvents(bool paused); // 0x0000000181B29800-0x0000000181B29910
		public static void MuteAllEvents(bool muted); // 0x0000000181B292F0-0x0000000181B29400
		public static bool HasBankLoaded(string loadedBank); // 0x0000000181B27A30-0x0000000181B27AC0
		private void LoadPlugins(Settings fmodSettings); // 0x0000000181B290C0-0x0000000181B292F0
		private void SetThreadAffinity(); // 0x00000001803581E0-0x00000001803581F0
	}
}
