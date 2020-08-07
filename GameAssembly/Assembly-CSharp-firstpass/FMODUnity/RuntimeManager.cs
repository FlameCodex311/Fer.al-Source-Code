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

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FMODUnity
{
	[AddComponentMenu] // 0x0000000180213020-0x0000000180213050
	public class RuntimeManager : UnityEngine.MonoBehaviour // TypeDefIndex: 10283
	{
		// Fields
		private static SystemNotInitializedException initException; // 0x00
		private static RuntimeManager instance; // 0x08
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private FMODPlatform fmodPlatform; // 0x18
		private FMOD.Studio.System studioSystem; // 0x20
		private FMOD.System coreSystem; // 0x28
		private DSP mixerHead; // 0x30
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
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
		private static RuntimeManager Instance { get; } // 0x0000000180D313D0-0x0000000180D31980 
		public static FMOD.Studio.System StudioSystem { get; } // 0x0000000180D31A60-0x0000000180D31AC0 
		public static FMOD.System CoreSystem { get; } // 0x0000000180D312F0-0x0000000180D31350 
		public static bool IsInitialized { get; } // 0x0000000180D31980-0x0000000180D31A60 
		public static bool HasBanksLoaded { get; } // 0x0000000180D31350-0x0000000180D313D0 
	
		// Nested types
		private struct LoadedBank // TypeDefIndex: 10284
		{
			// Fields
			public Bank Bank; // 0x00
			public int RefCount; // 0x08
		}
	
		private class GuidComparer : IEqualityComparer<Guid> // TypeDefIndex: 10285
		{
			// Constructors
			public GuidComparer(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			bool IEqualityComparer<Guid>.Equals(Guid x, Guid y); // 0x0000000180D28810-0x0000000180D28840
			int IEqualityComparer<Guid>.GetHashCode(Guid obj); // 0x0000000180D28840-0x0000000180D28860
		}
	
		private class AttachedInstance // TypeDefIndex: 10286
		{
			// Fields
			public EventInstance instance; // 0x10
			public Transform transform; // 0x18
			public Rigidbody rigidBody; // 0x20
			public Rigidbody2D rigidBody2D; // 0x28
	
			// Constructors
			public AttachedInstance(); // 0x0000000180373240-0x0000000180373250
		}
	
		// Constructors
		public RuntimeManager(); // 0x0000000180D311A0-0x0000000180D312F0
		static RuntimeManager(); // 0x0000000180D31120-0x0000000180D311A0
	
		// Methods
		[MonoPInvokeCallback] // 0x00000001802952C0-0x0000000180295310
		private static RESULT DEBUG_CALLBACK(DEBUG_FLAGS flags, StringWrapper file, int line, StringWrapper func, StringWrapper message); // 0x0000000180D2CAC0-0x0000000180D2CB60
		private void CheckInitResult(RESULT result, string cause); // 0x0000000180D2C860-0x0000000180D2C910
		private RESULT Initialize(); // 0x0000000180D2D880-0x0000000180D2E0C0
		public static bool AddListener(int index); // 0x0000000180D2C280-0x0000000180D2C470
		public static bool RemoveListener(int index); // 0x0000000180D2FDD0-0x0000000180D2FFE0
		private static int RecalculateTotalListeners(); // 0x0000000180D2FCD0-0x0000000180D2FDD0
		private void Update(); // 0x0000000180D30AE0-0x0000000180D310C0
		public static void AttachInstanceToGameObject(EventInstance instance, Transform transform, Rigidbody rigidBody); // 0x0000000180D2C740-0x0000000180D2C860
		public static void AttachInstanceToGameObject(EventInstance instance, Transform transform, Rigidbody2D rigidBody2D); // 0x0000000180D2C620-0x0000000180D2C740
		public static void DetachInstanceFromGameObject(EventInstance instance); // 0x0000000180D2CB60-0x0000000180D2CC70
		public void ExecuteOnGUI(); // 0x0000000180D2D130-0x0000000180D2D210
		private void Start(); // 0x0000000180D308B0-0x0000000180D30980
		private void DrawDebugOverlay(int windowID); // 0x0000000180D2CC70-0x0000000180D2D130
		private void OnDisable(); // 0x0000000180D2F3A0-0x0000000180D2F420
		private void OnDestroy(); // 0x0000000180D2F300-0x0000000180D2F3A0
		private void OnApplicationPause(bool pauseStatus); // 0x0000000180D2F170-0x0000000180D2F300
		private void loadedBankRegister(LoadedBank loadedBank, string bankPath, string bankName, bool loadSamples, RESULT loadResult); // 0x0000000180D31AC0-0x0000000180D31C10
		public static void LoadBankWW(string bankName, string bankFolder, bool loadSamples = false /* Metadata: 0x0077B979 */); // 0x0000000180D2E0C0-0x0000000180D2E3A0
		public static void LoadBank(string bankName, bool loadSamples = false /* Metadata: 0x0077B97A */); // 0x0000000180D2E6E0-0x0000000180D2E9F0
		public static void LoadBank(TextAsset asset, bool loadSamples = false /* Metadata: 0x0077B97B */); // 0x0000000180D2E3A0-0x0000000180D2E6E0
		private void LoadBanks(Settings fmodSettings); // 0x0000000180D2E9F0-0x0000000180D2EE30
		public static void UnloadBank(string bankName); // 0x0000000180D30980-0x0000000180D30AE0
		public static bool AnyBankLoading(); // 0x0000000180D2C470-0x0000000180D2C620
		public static void WaitForAllLoads(); // 0x0000000180D310C0-0x0000000180D31120
		public static Guid PathToGUID(string path); // 0x0000000180D2F420-0x0000000180D2F540
		public static EventInstance CreateInstance(string path); // 0x0000000180D2C9A0-0x0000000180D2CAC0
		public static EventInstance CreateInstance(Guid guid); // 0x0000000180D2C910-0x0000000180D2C9A0
		public static void PlayOneShot(string path, Vector3 position = default); // 0x0000000180D2F950-0x0000000180D2FB50
		public static void PlayOneShot(Guid guid, Vector3 position = default); // 0x0000000180D2FB50-0x0000000180D2FCD0
		public static void PlayOneShotAttached(string path, GameObject gameObject); // 0x0000000180D2F650-0x0000000180D2F820
		public static void PlayOneShotAttached(Guid guid, GameObject gameObject); // 0x0000000180D2F820-0x0000000180D2F950
		public static EventDescription GetEventDescription(string path); // 0x0000000180D2D320-0x0000000180D2D3E0
		public static EventDescription GetEventDescription(Guid guid); // 0x0000000180D2D3E0-0x0000000180D2D670
		public static void SetListenerLocation(GameObject gameObject, Rigidbody rigidBody = null); // 0x0000000180D30570-0x0000000180D30740
		public static void SetListenerLocation(GameObject gameObject, Rigidbody2D rigidBody2D); // 0x0000000180D301B0-0x0000000180D30390
		public static void SetListenerLocation(Transform transform); // 0x0000000180D30800-0x0000000180D308B0
		public static void SetListenerLocation(int listenerIndex, GameObject gameObject, Rigidbody rigidBody = null); // 0x0000000180D2FFE0-0x0000000180D301B0
		public static void SetListenerLocation(int listenerIndex, GameObject gameObject, Rigidbody2D rigidBody2D); // 0x0000000180D30390-0x0000000180D30570
		public static void SetListenerLocation(int listenerIndex, Transform transform); // 0x0000000180D30740-0x0000000180D30800
		public static Bus GetBus(string path); // 0x0000000180D2D210-0x0000000180D2D320
		public static VCA GetVCA(string path); // 0x0000000180D2D670-0x0000000180D2D7F0
		public static void PauseAllEvents(bool paused); // 0x0000000180D2F540-0x0000000180D2F650
		public static void MuteAllEvents(bool muted); // 0x0000000180D2F060-0x0000000180D2F170
		public static bool HasBankLoaded(string loadedBank); // 0x0000000180D2D7F0-0x0000000180D2D880
		private void LoadPlugins(Settings fmodSettings); // 0x0000000180D2EE30-0x0000000180D2F060
		private void SetThreadAffinity(); // 0x00000001803774A0-0x00000001803774B0
	}
}
