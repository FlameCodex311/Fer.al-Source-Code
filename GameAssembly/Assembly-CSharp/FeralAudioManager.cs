/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FMOD.Studio;
using FMODUnity;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class FeralAudioManager : CoreAudioManager // TypeDefIndex: 11786
{
	// Fields
	[SetInstance] // 0x00000001801CEA70-0x00000001801CEA80
	public static FeralAudioManager instance; // 0x00
	public string FMOD_Project_Name; // 0x88
	private GameObject _audioListener; // 0x90
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject <AudioListenerOverride>k__BackingField; // 0x98
	private string sourceBankAssetPath; // 0xA0
	private string targetBankAssetPath; // 0xA8
	private VCA? _musicVCA; // 0xB0
	private VCA? _sfxVCA; // 0xC0
	private Coroutine _musicVolumeChangedInit; // 0xD0
	private Coroutine _sfxVolumeChangedInit; // 0xD8
	private bool _masterBankStringsLoaded; // 0xE0
	private bool _masterBankAssetLoaded; // 0xE1
	private TextAsset _masterBankStrings; // 0xE8
	private TextAsset _masterBankAsset; // 0xF0
	private string _masterMusicPath; // 0xF8
	private string _masterSfxPath; // 0x100
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAnimationEvents <feralAnimationAudio>k__BackingField; // 0x108
	private Dictionary<GameObject, FeralAudioBehaviour> feralAudioBehaviours; // 0x110
	public List<BankInfo> bankInfos; // 0x118
	public List<string> _bankLoadsInProgress; // 0x120
	public List<string> _bankTextAssetsLoading; // 0x128

	// Properties
	public GameObject audioListener { get; } // 0x0000000180693BD0-0x0000000180693BF0 
	public GameObject AudioListenerOverride { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180418990-0x00000001804189A0 0x0000000180419170-0x0000000180419180
	public FeralAnimationEvents feralAnimationAudio { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180380B50-0x0000000180380B60 0x00000001803B50D0-0x00000001803B50E0

	// Nested types
	[Serializable]
	public class BankInfo // TypeDefIndex: 11787
	{
		// Fields
		public string bankName; // 0x10
		public TextAsset bankTextAsset; // 0x18
		public EBankState bankState; // 0x20
		public GameObject bankGameObject; // 0x28
		public List<string> events; // 0x30

		// Constructors
		public BankInfo(); // 0x000000018068F370-0x000000018068F3E0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <InitCoroutine>d__30 : IEnumerator<object> // TypeDefIndex: 11788
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FeralAudioManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <InitCoroutine>d__30(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001806A70C0-0x00000001806A7190
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001806A7190-0x00000001806A71E0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <LoadAudio>d__31 : IEnumerator<object> // TypeDefIndex: 11789
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FeralAudioManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <LoadAudio>d__31(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001806A71E0-0x00000001806A79E0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001806A79E0-0x00000001806A7A30
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <LoadMasterBankStrings>d__33 : IEnumerator<object> // TypeDefIndex: 11790
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FeralAudioManager <>4__this; // 0x20
		private GameObject <gBankObject>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <LoadMasterBankStrings>d__33(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001806A8730-0x00000001806A8990
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001806A8990-0x00000001806A89E0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <LoadMasterBankAsset>d__34 : IEnumerator<object> // TypeDefIndex: 11791
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FeralAudioManager <>4__this; // 0x20
		private GameObject <gBankObject>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <LoadMasterBankAsset>d__34(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001806A8440-0x00000001806A86E0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001806A86E0-0x00000001806A8730
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <WaitThenUnloadAllBanks>d__40 : IEnumerator<object> // TypeDefIndex: 11792
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FeralAudioManager <>4__this; // 0x20
		public int iFrames; // 0x28
		private int <i>5__2; // 0x2C

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <WaitThenUnloadAllBanks>d__40(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001806A9AD0-0x00000001806A9B70
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001806A9B70-0x00000001806C0FD0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass48_0 // TypeDefIndex: 11793
	{
		// Fields
		public Action<bool> Callback; // 0x10

		// Constructors
		public <>c__DisplayClass48_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <LoadBank>b__0(bool cb); // 0x00000001806A9A10-0x00000001806A9A60
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass49_0 // TypeDefIndex: 11794
	{
		// Fields
		public TextAsset cBankTextAsset; // 0x10
		public bool bLoading; // 0x18

		// Constructors
		public <>c__DisplayClass49_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <LoadBankRoutine>b__0(TextAsset loadedAsset); // 0x00000001806A9A60-0x00000001806A9A70
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <LoadBankRoutine>d__49 : IEnumerator<object> // TypeDefIndex: 11795
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FeralAudioManager <>4__this; // 0x20
		public string inBankName; // 0x28
		private <>c__DisplayClass49_0 <>8__1; // 0x30
		public Action<bool> Callback; // 0x38
		public FeralAudioInfo inAudioInfo; // 0x40
		private BankInfo <cBankInfo>5__2; // 0x48
		private GameObject <gBankObject>5__3; // 0x50

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <LoadBankRoutine>d__49(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001806A7E00-0x00000001806A83F0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001806A83F0-0x00000001806A8440
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <LoadBankFromAsset>d__55 : IEnumerator<object> // TypeDefIndex: 11796
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FeralAudioManager <>4__this; // 0x20
		public TextAsset inBankAsset; // 0x28
		public GameObject inBankGameObject; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <LoadBankFromAsset>d__55(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001806A7A30-0x00000001806A7DB0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001806A7DB0-0x00000001806A7E00
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <SoundVolumeChangedInit>d__62 : IEnumerator<object> // TypeDefIndex: 11797
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FeralAudioManager <>4__this; // 0x20
		public float inVolume; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <SoundVolumeChangedInit>d__62(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001806A9930-0x00000001806A99C0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001806A99C0-0x00000001806A9A10
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <MusicVolumeChangedInit>d__63 : IEnumerator<object> // TypeDefIndex: 11798
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FeralAudioManager <>4__this; // 0x20
		public float inVolume; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <MusicVolumeChangedInit>d__63(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001806A95D0-0x00000001806A9660
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001806A9660-0x00000001806A96B0
	}

	// Constructors
	public FeralAudioManager(); // 0x0000000180693AC0-0x0000000180693BD0

	// Methods
	[IteratorStateMachine] // 0x0000000180260800-0x0000000180260850
	public override IEnumerator InitCoroutine(); // 0x0000000180691210-0x0000000180691270
	[IteratorStateMachine] // 0x0000000180260BC0-0x0000000180260C10
	private IEnumerator LoadAudio(); // 0x0000000180691590-0x00000001806915F0
	private void AddListeners(bool inAdd); // 0x00000001806903E0-0x00000001806906D0
	[IteratorStateMachine] // 0x0000000180260D70-0x0000000180260DC0
	private IEnumerator LoadMasterBankStrings(); // 0x0000000180691A50-0x0000000180691AB0
	[IteratorStateMachine] // 0x0000000180262280-0x00000001802622D0
	private IEnumerator LoadMasterBankAsset(); // 0x00000001806919F0-0x0000000180691A50
	private void OnAudioMessage(FeralAudioMessage inMessage); // 0x0000000180692530-0x00000001806925F0
	public override void MUpdate(); // 0x0000000180691AE0-0x0000000180692320
	public override void MOnDestroy(); // 0x0000000180691AB0-0x0000000180691AE0
	private new void OnLevelLoaded(Message inMessage); // 0x00000001803774A0-0x00000001803774B0
	private new void OnLoadingStarted(Message inMessage); // 0x0000000180692770-0x00000001806927E0
	[IteratorStateMachine] // 0x00000001802625C0-0x0000000180262610
	private IEnumerator WaitThenUnloadAllBanks(int iFrames); // 0x0000000180693990-0x0000000180693A00
	private new void OnLoadingFinished(Message inMessage); // 0x00000001806925F0-0x0000000180692770
	public void PlayAudio(AudioScriptableObject inAudioScriptableObject, GameObject inGameObject); // 0x0000000180692840-0x0000000180692870
	public void Add(GameObject inGameObject, FeralAudioBehaviour inAudioBehaviour); // 0x00000001806906D0-0x0000000180690760
	public void Remove(GameObject inGameObject); // 0x0000000180692870-0x00000001806928D0
	public void StopAllInstances(); // 0x00000001806930D0-0x0000000180693200
	public void KillAllInstances(); // 0x0000000180691270-0x00000001806913A0
	public string GetBankName(string inEvent); // 0x0000000180691040-0x0000000180691210
	public void LoadBank(FeralAudioInfo inAudioInfo, GameObject inGameObject = null, Action<bool> Callback = null); // 0x0000000180691700-0x00000001806919F0
	[IteratorStateMachine] // 0x0000000180262990-0x00000001802629E0
	private IEnumerator LoadBankRoutine(FeralAudioInfo inAudioInfo, string inBankName, Action<bool> Callback); // 0x0000000180691670-0x0000000180691700
	private void AddAudioInfo(BankInfo inBankInfo, FeralAudioInfo inAudioInfo); // 0x0000000180690350-0x00000001806903E0
	public static bool ValidEvent(FeralAudioInfo inAudioInfo); // 0x0000000180693910-0x0000000180693990
	private BankInfo BankInfoExists(string inBankName); // 0x0000000180690760-0x0000000180690860
	public void UnloadAllBanks(); // 0x0000000180693420-0x0000000180693690
	private bool UnloadBank(string inBankName); // 0x0000000180693780-0x0000000180693910
	[IteratorStateMachine] // 0x0000000180262AE0-0x0000000180262B30
	private IEnumerator LoadBankFromAsset(TextAsset inBankAsset, GameObject inBankGameObject); // 0x00000001806915F0-0x0000000180691670
	private void UnloadBankFromAsset(BankInfo inBankInfo); // 0x0000000180693690-0x0000000180693780
	private void WriteBank(TextAsset bankAsset); // 0x0000000180693A00-0x0000000180693AC0
	private void CleanupBanks(); // 0x0000000180690AF0-0x0000000180690BD0
	private void DeleteOldBanks(); // 0x0000000180690BD0-0x0000000180690C80
	public override void SoundVolumeChanged(float inVolume); // 0x0000000180692F90-0x00000001806930D0
	public override void MusicVolumeChanged(float inVolume); // 0x0000000180692390-0x00000001806924D0
	[IteratorStateMachine] // 0x0000000180262F00-0x0000000180262F50
	private IEnumerator SoundVolumeChangedInit(float inVolume); // 0x0000000180692F20-0x0000000180692F90
	[IteratorStateMachine] // 0x0000000180263140-0x0000000180263190
	private IEnumerator MusicVolumeChangedInit(float inVolume); // 0x0000000180692320-0x0000000180692390
	public void SetParameter(FeralAudioInfo inAudioInfo, GameObject inGameObject, ParamRef inParamRef); // 0x00000001806928D0-0x0000000180692970
	public void SetParameter(FeralAudioInfo inAudioInfo, GameObject inGameObject, FeralAudioParameter inFeralAudioParameter); // 0x0000000180692970-0x0000000180692BA0
	public void SetParameter(FeralAudioInfo inAudioInfo, GameObject inGameObject, string inParameterName, float? inParameterValue = default); // 0x0000000180692BA0-0x0000000180692F20
	private void CheckParametersBeforePlay(GameObject inGameObject, FeralAudioInfo inAudioInfo, ParamRef inParamRef = null, FeralAudioParameter inFeralAudioParameter = null, string inSetParameterString = null, string inParameterName = null, float? inParameterValue = default); // 0x0000000180690860-0x0000000180690AF0
	private void DoPlay(GameObject inGameObject, FeralAudioInfo inAudioInfo, string inParameterName = null, float? inParameterValue = default); // 0x0000000180690C80-0x0000000180690FC0
	public void Stop(FeralAudioInfo inAudioInfo, GameObject inGameObject = null); // 0x0000000180693200-0x0000000180693410
	public void Kill(FeralAudioInfo inAudioInfo); // 0x00000001806913A0-0x00000001806914F0
	private void FMODInfo(); // 0x0000000180690FC0-0x0000000180691040
	public void MuteAllEvents(bool inMute); // 0x00000001806924D0-0x0000000180692530
	public void PauseAllEvents(bool inPause); // 0x00000001806927E0-0x0000000180692840
	public void LoadAudioActor(AudioActor inAudioActor, GameObject inGameObject); // 0x00000001806914F0-0x0000000180691590
	[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
	[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
	private IEnumerator <>n__0(); // 0x0000000180693410-0x0000000180693420
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <LoadAudio>b__31_0(FeralAnimationEvents loadedAsset); // 0x00000001803B50D0-0x00000001803B50E0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <LoadMasterBankStrings>b__33_0(TextAsset loadedAsset); // 0x00000001804296B0-0x00000001804296C0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <LoadMasterBankAsset>b__34_0(TextAsset loadedAsset); // 0x00000001805AF740-0x00000001805AF750
}

