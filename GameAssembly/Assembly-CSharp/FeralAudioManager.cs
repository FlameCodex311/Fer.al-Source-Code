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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class FeralAudioManager : CoreAudioManager // TypeDefIndex: 10297
{
	// Fields
	[SetInstance] // 0x00000001800BDB50-0x00000001800BDB60
	public static FeralAudioManager instance; // 0x00
	public string FMOD_Project_Name; // 0x88
	private GameObject _audioListener; // 0x90
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
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
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAnimationEvents <feralAnimationAudio>k__BackingField; // 0x108
	private Dictionary<GameObject, FeralAudioBehaviour> feralAudioBehaviours; // 0x110
	public List<BankInfo> bankInfos; // 0x118
	public List<string> _bankLoadsInProgress; // 0x120
	public List<string> _bankTextAssetsLoading; // 0x128

	// Properties
	public GameObject audioListener { get; } // 0x00000001810FE420-0x00000001810FE440 
	public GameObject AudioListenerOverride { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180369B70-0x0000000180369B80 0x000000018036A3D0-0x000000018036A3E0
	public FeralAnimationEvents feralAnimationAudio { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803BD3C0-0x00000001803BD3D0 0x00000001803BE5E0-0x00000001803BE5F0

	// Nested types
	[Serializable]
	public class BankInfo // TypeDefIndex: 10298
	{
		// Fields
		public string bankName; // 0x10
		public TextAsset bankTextAsset; // 0x18
		public EBankState bankState; // 0x20
		public GameObject bankGameObject; // 0x28

		// Constructors
		public BankInfo(); // 0x00000001810F91F0-0x00000001810F9240
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <InitCoroutine>d__30 : IEnumerator<object> // TypeDefIndex: 10299
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FeralAudioManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <InitCoroutine>d__30(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181111A80-0x0000000181111B60
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181111B60-0x0000000181111BB0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <LoadAudio>d__31 : IEnumerator<object> // TypeDefIndex: 10300
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FeralAudioManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <LoadAudio>d__31(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181111BB0-0x00000001811123D0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001811123D0-0x0000000181112420
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <LoadMasterBankStrings>d__33 : IEnumerator<object> // TypeDefIndex: 10301
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FeralAudioManager <>4__this; // 0x20
		private GameObject <gBankObject>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <LoadMasterBankStrings>d__33(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001811130A0-0x0000000181113310
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181113310-0x0000000181113360
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <LoadMasterBankAsset>d__34 : IEnumerator<object> // TypeDefIndex: 10302
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FeralAudioManager <>4__this; // 0x20
		private GameObject <gBankObject>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <LoadMasterBankAsset>d__34(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181112DB0-0x0000000181113050
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181113050-0x00000001811130A0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass47_0 // TypeDefIndex: 10303
	{
		// Fields
		public Action<bool> Callback; // 0x10

		// Constructors
		public <>c__DisplayClass47_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <LoadBank>b__0(bool cb); // 0x00000001811153B0-0x0000000181115400
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass48_0 // TypeDefIndex: 10304
	{
		// Fields
		public TextAsset cBankTextAsset; // 0x10
		public bool bLoading; // 0x18

		// Constructors
		public <>c__DisplayClass48_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <LoadBankRoutine>b__0(TextAsset loadedAsset); // 0x0000000181115400-0x0000000181115410
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <LoadBankRoutine>d__48 : IEnumerator<object> // TypeDefIndex: 10305
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FeralAudioManager <>4__this; // 0x20
		public string inBankName; // 0x28
		private <>c__DisplayClass48_0 <>8__1; // 0x30
		public Action<bool> Callback; // 0x38
		public FeralAudioInfo inAudioInfo; // 0x40
		private BankInfo <cBankInfo>5__2; // 0x48
		private GameObject <gBankObject>5__3; // 0x50

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <LoadBankRoutine>d__48(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001811127D0-0x0000000181112D60
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181112D60-0x0000000181112DB0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <LoadBankFromAsset>d__54 : IEnumerator<object> // TypeDefIndex: 10306
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FeralAudioManager <>4__this; // 0x20
		public TextAsset inBankAsset; // 0x28
		public GameObject inBankGameObject; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <LoadBankFromAsset>d__54(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181112420-0x0000000181112780
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181112780-0x00000001811127D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <SoundVolumeChangedInit>d__61 : IEnumerator<object> // TypeDefIndex: 10307
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FeralAudioManager <>4__this; // 0x20
		public float inVolume; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <SoundVolumeChangedInit>d__61(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181115070-0x0000000181115100
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181115100-0x0000000181115150
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <MusicVolumeChangedInit>d__62 : IEnumerator<object> // TypeDefIndex: 10308
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FeralAudioManager <>4__this; // 0x20
		public float inVolume; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <MusicVolumeChangedInit>d__62(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181114860-0x00000001811148F0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001811148F0-0x0000000181114940
	}

	// Constructors
	public FeralAudioManager(); // 0x00000001810FE310-0x00000001810FE420

	// Methods
	[IteratorStateMachine] // 0x00000001800D1000-0x00000001800D1050
	public override IEnumerator InitCoroutine(); // 0x00000001810FBDE0-0x00000001810FBE40
	[IteratorStateMachine] // 0x00000001800D1320-0x00000001800D1370
	private IEnumerator LoadAudio(); // 0x00000001810FC170-0x00000001810FC1D0
	private void AddListeners(bool inAdd); // 0x00000001810FAF60-0x00000001810FB250
	[IteratorStateMachine] // 0x00000001800D16D0-0x00000001800D1720
	private IEnumerator LoadMasterBankStrings(); // 0x00000001810FC5A0-0x00000001810FC600
	[IteratorStateMachine] // 0x00000001800D1940-0x00000001800D1990
	private IEnumerator LoadMasterBankAsset(); // 0x00000001810FC540-0x00000001810FC5A0
	private void OnAudioMessage(FeralAudioMessage inMessage); // 0x00000001810FCE30-0x00000001810FCEF0
	public override void MUpdate(); // 0x00000001810FC630-0x00000001810FCC20
	public override void MOnDestroy(); // 0x00000001810FC600-0x00000001810FC630
	private new void OnLevelLoaded(Message inMessage); // 0x00000001803581E0-0x00000001803581F0
	private new void OnLoadingStarted(Message inMessage); // 0x00000001810FD070-0x00000001810FD080
	private new void OnLoadingFinished(Message inMessage); // 0x00000001810FCEF0-0x00000001810FD070
	public void PlayAudio(AudioScriptableObject inAudioScriptableObject, GameObject inGameObject); // 0x00000001810FD0E0-0x00000001810FD120
	public void Add(GameObject inGameObject, FeralAudioBehaviour inAudioBehaviour); // 0x00000001810FB250-0x00000001810FB2E0
	public void Remove(GameObject inGameObject); // 0x00000001810FD120-0x00000001810FD180
	public void StopAllInstances(); // 0x00000001810FD9D0-0x00000001810FDB10
	public void KillAllInstances(); // 0x00000001810FBE40-0x00000001810FBF80
	public string GetBankName(string inEvent); // 0x00000001810FBC00-0x00000001810FBDE0
	public void LoadBank(FeralAudioInfo inAudioInfo, GameObject inGameObject = null, Action<bool> Callback = null); // 0x00000001810FC2E0-0x00000001810FC540
	[IteratorStateMachine] // 0x00000001800D1D10-0x00000001800D1D60
	private IEnumerator LoadBankRoutine(FeralAudioInfo inAudioInfo, string inBankName, Action<bool> Callback); // 0x00000001810FC250-0x00000001810FC2E0
	private void AddAudioInfo(BankInfo inBankInfo, FeralAudioInfo inAudioInfo); // 0x00000001803581E0-0x00000001803581F0
	public static bool ValidEvent(FeralAudioInfo inAudioInfo); // 0x00000001810FE1D0-0x00000001810FE250
	private BankInfo BankInfoExists(string inBankName); // 0x00000001810FB2E0-0x00000001810FB3F0
	public void UnloadAllBanks(); // 0x00000001810FDD30-0x00000001810FDF70
	private bool UnloadBank(string inBankName); // 0x00000001810FE050-0x00000001810FE1D0
	[IteratorStateMachine] // 0x00000001800D2140-0x00000001800D2190
	private IEnumerator LoadBankFromAsset(TextAsset inBankAsset, GameObject inBankGameObject); // 0x00000001810FC1D0-0x00000001810FC250
	private void UnloadBankFromAsset(BankInfo inBankInfo); // 0x00000001810FDF70-0x00000001810FE050
	private void WriteBank(TextAsset bankAsset); // 0x00000001810FE250-0x00000001810FE310
	private void CleanupBanks(); // 0x00000001810FB690-0x00000001810FB780
	private void DeleteOldBanks(); // 0x00000001810FB780-0x00000001810FB830
	public override void SoundVolumeChanged(float inVolume); // 0x00000001810FD890-0x00000001810FD9D0
	public override void MusicVolumeChanged(float inVolume); // 0x00000001810FCC90-0x00000001810FCDD0
	[IteratorStateMachine] // 0x00000001800D2480-0x00000001800D24D0
	private IEnumerator SoundVolumeChangedInit(float inVolume); // 0x00000001810FD820-0x00000001810FD890
	[IteratorStateMachine] // 0x00000001800D2840-0x00000001800D2890
	private IEnumerator MusicVolumeChangedInit(float inVolume); // 0x00000001810FCC20-0x00000001810FCC90
	public void SetParameter(FeralAudioInfo inAudioInfo, GameObject inGameObject, ParamRef inParamRef); // 0x00000001810FD180-0x00000001810FD220
	public void SetParameter(FeralAudioInfo inAudioInfo, GameObject inGameObject, FeralAudioParameter inFeralAudioParameter); // 0x00000001810FD220-0x00000001810FD470
	public void SetParameter(FeralAudioInfo inAudioInfo, GameObject inGameObject, string inParameterName, float? inParameterValue = default); // 0x00000001810FD470-0x00000001810FD820
	private void CheckParametersBeforePlay(GameObject inGameObject, FeralAudioInfo inAudioInfo, ParamRef inParamRef = null, FeralAudioParameter inFeralAudioParameter = null, string inSetParameterString = null, string inParameterName = null, float? inParameterValue = default); // 0x00000001810FB3F0-0x00000001810FB690
	private void DoPlay(GameObject inGameObject, FeralAudioInfo inAudioInfo, string inParameterName = null, float? inParameterValue = default); // 0x00000001810FB830-0x00000001810FBB80
	public void Stop(FeralAudioInfo inAudioInfo, GameObject inGameObject = null); // 0x00000001810FDB10-0x00000001810FDD20
	public void Kill(FeralAudioInfo inAudioInfo); // 0x00000001810FBF80-0x00000001810FC0D0
	private void FMODInfo(); // 0x00000001810FBB80-0x00000001810FBC00
	public void MuteAllEvents(bool inMute); // 0x00000001810FCDD0-0x00000001810FCE30
	public void PauseAllEvents(bool inPause); // 0x00000001810FD080-0x00000001810FD0E0
	public void LoadAudioActor(AudioActor inAudioActor, GameObject inGameObject); // 0x00000001810FC0D0-0x00000001810FC170
	[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
	[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
	private IEnumerator <>n__0(); // 0x00000001810FDD20-0x00000001810FDD30
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <LoadAudio>b__31_0(FeralAnimationEvents loadedAsset); // 0x00000001803BE5E0-0x00000001803BE5F0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <LoadMasterBankStrings>b__33_0(TextAsset loadedAsset); // 0x000000018037AA30-0x000000018037AA40
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <LoadMasterBankAsset>b__34_0(TextAsset loadedAsset); // 0x00000001803BE540-0x00000001803BE550
}

