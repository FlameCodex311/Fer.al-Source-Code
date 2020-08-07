/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

// Image 68: SimpleAnimationComponent.dll - Assembly: SimpleAnimationComponent, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8524-8541

public class SimpleAnimationPlayable : PlayableBehaviour // TypeDefIndex: 8532
{
	// Fields
	private LinkedList<QueuedState> m_StateQueue; // 0x10
	private StateManagement m_States; // 0x18
	private bool m_Initialized; // 0x20
	private bool m_KeepStoppedPlayablesConnected; // 0x21
	protected Playable m_ActualPlayable; // 0x28
	private AnimationMixerPlayable m_Mixer; // 0x38
	public Action onDone; // 0x48
	private int m_StatesVersion; // 0x50

	// Properties
	public bool keepStoppedPlayablesConnected { get; set; } // 0x00000001804F2E80-0x00000001804F2E90 0x0000000182071BF0-0x0000000182071C00
	protected Playable self { get; } // 0x0000000180379E90-0x0000000180379EA0 
	public Playable playable { get; } // 0x0000000180379E90-0x0000000180379EA0 
	protected PlayableGraph graph { get; } // 0x0000000182071B90-0x0000000182071BF0 

	// Nested types
	private class StateEnumerable : IEnumerable<IState> // TypeDefIndex: 8533
	{
		// Fields
		private SimpleAnimationPlayable m_Owner; // 0x10

		// Nested types
		private class StateEnumerator : IEnumerator<IState> // TypeDefIndex: 8534
		{
			// Fields
			private int m_Index; // 0x10
			private int m_Version; // 0x14
			private SimpleAnimationPlayable m_Owner; // 0x18

			// Properties
			object IEnumerator.Current { get; } // 0x0000000182074D90-0x0000000182074DA0 
			IState IEnumerator<SimpleAnimationPlayable.IState>.Current { get; } // 0x0000000182074D90-0x0000000182074DA0 

			// Constructors
			public StateEnumerator(SimpleAnimationPlayable owner); // 0x0000000182074EB0-0x0000000182074F60

			// Methods
			private bool IsValid(); // 0x0000000182074B00-0x0000000182074B20
			private IState GetCurrentHandle(int index); // 0x00000001820748F0-0x0000000182074A70
			public void Dispose(); // 0x00000001803774A0-0x00000001803774B0
			public bool MoveNext(); // 0x0000000182074B20-0x0000000182074C70
			public void Reset(); // 0x0000000182074CC0-0x0000000182074D40
		}

		// Constructors
		public StateEnumerable(SimpleAnimationPlayable owner); // 0x0000000180400150-0x0000000180400180

		// Methods
		public IEnumerator<IState> GetEnumerator(); // 0x0000000182074670-0x0000000182074750
		IEnumerator IEnumerable.GetEnumerator(); // 0x00000001820747B0-0x0000000182074890
	}

	public interface IState // TypeDefIndex: 8535
	{
		// Properties
		bool enabled { get; set; }
		float time { get; set; }
		float normalizedTime { get; set; }
		float speed { get; set; }
		string name { get; set; }
		float weight { get; set; }
		float length { get; }
		AnimationClip clip { get; }
		WrapMode wrapMode { get; }

		// Methods
		bool IsValid();
	}

	public class StateHandle : IState // TypeDefIndex: 8536
	{
		// Fields
		private SimpleAnimationPlayable m_Parent; // 0x10
		private int m_Index; // 0x18
		private Playable m_Target; // 0x20

		// Properties
		public bool enabled { get; set; } // 0x0000000182075250-0x0000000182075350 0x0000000182075B20-0x0000000182075C60
		public float time { get; set; } // 0x0000000182075880-0x0000000182075920 0x0000000182075FE0-0x0000000182076090
		public float normalizedTime { get; set; } // 0x0000000182075650-0x0000000182075740 0x0000000182075DA0-0x0000000182075E90
		public float speed { get; set; } // 0x0000000182075740-0x0000000182075880 0x0000000182075E90-0x0000000182075FE0
		public string name { get; set; } // 0x0000000182075550-0x0000000182075650 0x0000000182075C60-0x0000000182075DA0
		public float weight { get; set; } // 0x0000000182075920-0x0000000182075A20 0x0000000182076090-0x00000001820761E0
		public float length { get; } // 0x0000000182075350-0x0000000182075550 
		public AnimationClip clip { get; } // 0x0000000182075150-0x0000000182075250 
		public WrapMode wrapMode { get; } // 0x0000000182075A20-0x0000000182075B20 
		public int index { get; } // 0x00000001803F46B0-0x00000001803F46C0 

		// Constructors
		public StateHandle(SimpleAnimationPlayable s, int index, Playable target); // 0x0000000182075100-0x0000000182075150

		// Methods
		public bool IsValid(); // 0x0000000182074F60-0x0000000182075100
	}

	private class StateInfo // TypeDefIndex: 8537
	{
		// Fields
		private bool m_Enabled; // 0x10
		private int m_Index; // 0x14
		private string m_StateName; // 0x18
		private bool m_Fading; // 0x20
		private float m_Time; // 0x24
		private float m_TargetWeight; // 0x28
		private float m_Weight; // 0x2C
		private float m_FadeSpeed; // 0x30
		private AnimationClip m_Clip; // 0x38
		private Playable m_Playable; // 0x40
		private WrapMode m_WrapMode; // 0x50
		private bool m_IsClone; // 0x54
		private bool m_ReadyForCleanup; // 0x55
		public StateHandle m_ParentState; // 0x58
		private bool m_WeightDirty; // 0x60
		private bool m_EnabledDirty; // 0x61
		private bool m_TimeIsUpToDate; // 0x62

		// Properties
		public bool enabled { get; } // 0x00000001803FD450-0x00000001803FD460 
		public int index { get; set; } // 0x00000001803FD2F0-0x00000001803FD300 0x00000001803FD620-0x00000001803FD630
		public string stateName { get; set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
		public bool fading { get; } // 0x00000001803FA090-0x00000001803FA0A0 
		public float targetWeight { get; } // 0x0000000180491DA0-0x0000000180491DB0 
		public float weight { get; } // 0x00000001807DDA30-0x00000001807DDA40 
		public float fadeSpeed { get; } // 0x00000001806757B0-0x00000001806757C0 
		public float speed { get; set; } // 0x0000000182076E40-0x0000000182076E90 0x0000000182076E90-0x0000000182076EF0
		public float playableDuration { get; } // 0x0000000182076DF0-0x0000000182076E40 
		public AnimationClip clip { get; } // 0x00000001803743D0-0x00000001803743E0 
		public bool isDone { get; } // 0x0000000182076DA0-0x0000000182076DF0 
		public Playable playable { get; } // 0x000000018043C620-0x000000018043C630 
		public WrapMode wrapMode { get; } // 0x00000001803F8270-0x00000001803F8280 
		public bool isClone { get; } // 0x00000001804D5820-0x00000001804D5830 
		public bool isReadyForCleanup { get; } // 0x0000000180C07EA0-0x0000000180C07EB0 
		public StateHandle parentState { get; } // 0x00000001803A1580-0x00000001803A1590 
		public bool enabledDirty { get; } // 0x0000000180459DB0-0x0000000180459DC0 
		public bool weightDirty { get; } // 0x00000001803CE080-0x00000001803CE090 

		// Constructors
		public StateInfo(); // 0x0000000180373240-0x0000000180373250

		// Methods
		public void Initialize(string name, AnimationClip clip, WrapMode wrapMode); // 0x0000000182076B50-0x0000000182076B60
		public float GetTime(); // 0x0000000182076AE0-0x0000000182076B50
		public void SetTime(float newTime); // 0x0000000182076C30-0x0000000182076D10
		public void Enable(); // 0x0000000182076A20-0x0000000182076A30
		public void Disable(); // 0x0000000182076A10-0x0000000182076A20
		public void Pause(); // 0x0000000182076B60-0x0000000182076BB0
		public void Play(); // 0x0000000182076BB0-0x0000000182076C00
		public void Stop(); // 0x0000000182076D20-0x0000000182076DA0
		public void ForceWeight(float weight); // 0x0000000182076AC0-0x0000000182076AE0
		public void SetWeight(float weight); // 0x0000000182076D10-0x0000000182076D20
		public void FadeTo(float weight, float speed); // 0x0000000182076A30-0x0000000182076AC0
		public void DestroyPlayable(); // 0x0000000182076970-0x0000000182076A10
		public void SetAsCloneOf(StateHandle handle); // 0x0000000182076C10-0x0000000182076C20
		public void SetPlayable(Playable playable); // 0x0000000182076C20-0x0000000182076C30
		public void ResetDirtyFlags(); // 0x0000000182076C00-0x0000000182076C10
		public void InvalidateTime(); // 0x000000018158BB40-0x000000018158BB50
	}

	private class StateManagement // TypeDefIndex: 8538
	{
		// Fields
		private List<StateInfo> m_States; // 0x10
		private int m_Count; // 0x18

		// Properties
		public int Count { get; } // 0x00000001803F46B0-0x00000001803F46C0 
		public StateInfo this[int i] { get => default; } // 0x0000000182077F80-0x0000000182077FE0 

		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 8539
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Predicate<StateInfo> <>9__7_0; // 0x08
			public static Predicate<StateInfo> <>9__8_0; // 0x10

			// Constructors
			static <>c(); // 0x0000000182078010-0x0000000182078070
			public <>c(); // 0x0000000180373240-0x0000000180373250

			// Methods
			internal bool <InsertState>b__7_0(StateInfo s); // 0x0000000180BE18F0-0x0000000180BE1900
			internal bool <AnyStatePlaying>b__8_0(StateInfo s); // 0x0000000182077FE0-0x0000000182077FF0
		}

		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass11_0 // TypeDefIndex: 8540
		{
			// Fields
			public string name; // 0x10

			// Constructors
			public <>c__DisplayClass11_0(); // 0x0000000180373240-0x0000000180373250

			// Methods
			internal bool <FindState>b__0(StateInfo s); // 0x0000000182077FF0-0x0000000182078010
		}

		// Constructors
		public StateManagement(); // 0x0000000182077F20-0x0000000182077F80

		// Methods
		public StateInfo InsertState(); // 0x00000001820777E0-0x0000000182077960
		public bool AnyStatePlaying(); // 0x0000000182076EF0-0x0000000182076FF0
		public void RemoveState(int index); // 0x0000000182077B10-0x0000000182077C50
		public bool RemoveClip(AnimationClip clip); // 0x0000000182077A00-0x0000000182077B10
		public StateInfo FindState(string name); // 0x00000001820770F0-0x00000001820771E0
		public void EnableState(int index); // 0x0000000182077070-0x00000001820770F0
		public void DisableState(int index); // 0x0000000182076FF0-0x0000000182077070
		public void SetInputWeight(int index, float weight); // 0x0000000182077C50-0x0000000182077CD0
		public void SetStateTime(int index, float time); // 0x0000000182077E00-0x0000000182077E80
		public float GetStateTime(int index); // 0x00000001820776B0-0x0000000182077770
		public bool IsCloneOf(int potentialCloneIndex, int originalIndex); // 0x0000000182077960-0x0000000182077A00
		public float GetStateSpeed(int index); // 0x0000000182077610-0x00000001820776B0
		public void SetStateSpeed(int index, float value); // 0x0000000182077D50-0x0000000182077E00
		public float GetInputWeight(int index); // 0x00000001820772A0-0x0000000182077310
		public float GetStateLength(int index); // 0x0000000182077380-0x0000000182077500
		public float GetClipLength(int index); // 0x00000001820771E0-0x00000001820772A0
		public float GetStatePlayableDuration(int index); // 0x0000000182077570-0x0000000182077610
		public AnimationClip GetStateClip(int index); // 0x0000000182077310-0x0000000182077380
		public WrapMode GetStateWrapMode(int index); // 0x0000000182077770-0x00000001820777E0
		public string GetStateName(int index); // 0x0000000182077500-0x0000000182077570
		public void SetStateName(int index, string name); // 0x0000000182077CD0-0x0000000182077D50
		public void StopState(int index, bool cleanup); // 0x0000000182077E80-0x0000000182077F20
	}

	private struct QueuedState // TypeDefIndex: 8541
	{
		// Fields
		public StateHandle state; // 0x00
		public float fadeTime; // 0x08

		// Constructors
		public QueuedState(StateHandle s, float t); // 0x00000001800C0D90-0x00000001800C0DF0
	}

	// Constructors
	public SimpleAnimationPlayable(); // 0x0000000182071AC0-0x0000000182071B90

	// Methods
	private void UpdateStoppedPlayablesConnections(); // 0x0000000182071810-0x0000000182071900
	public Playable GetInput(int index); // 0x000000018206F770-0x000000018206F830
	public override void OnPlayableCreate(Playable playable); // 0x000000018206FED0-0x0000000182070060
	public IEnumerable<IState> GetStates(); // 0x000000018206F8E0-0x000000018206F940
	public IState GetState(string name); // 0x000000018206F830-0x000000018206F8E0
	private StateInfo DoAddClip(string name, AnimationClip clip); // 0x000000018206F280-0x000000018206F600
	public bool AddClip(AnimationClip clip, string name); // 0x000000018206E050-0x000000018206E130
	public bool RemoveClip(string name); // 0x0000000182070870-0x0000000182070950
	public bool RemoveClip(AnimationClip clip); // 0x0000000182070750-0x0000000182070870
	public bool Play(string name); // 0x0000000182070370-0x0000000182070420
	private bool Play(int index); // 0x0000000182070420-0x0000000182070540
	public bool PlayQueued(string name, QueueMode queueMode); // 0x0000000182070060-0x0000000182070230
	private bool PlayQueued(int index, QueueMode queueMode); // 0x0000000182070230-0x0000000182070370
	public void Rewind(string name); // 0x0000000182070C20-0x0000000182070D30
	private void Rewind(int index); // 0x0000000182070BA0-0x0000000182070C20
	public void Rewind(); // 0x0000000182070AC0-0x0000000182070BA0
	private void RemoveClones(StateInfo state); // 0x0000000182070950-0x0000000182070AC0
	public bool Stop(string name); // 0x0000000182071140-0x0000000182071200
	private void DoStop(int index); // 0x000000018206F600-0x000000018206F6B0
	public bool StopAll(); // 0x0000000182070F20-0x0000000182071140
	public bool IsPlaying(); // 0x000000018206FC80-0x000000018206FCA0
	public bool IsPlaying(string stateName); // 0x000000018206FB30-0x000000018206FC80
	private bool IsClonePlaying(StateInfo state); // 0x000000018206FA20-0x000000018206FB30
	public int GetClipCount(); // 0x000000018206F6B0-0x000000018206F770
	private void SetupLerp(StateInfo state, float targetWeight, float time); // 0x0000000182070D30-0x0000000182070E90
	private bool Crossfade(int index, float time); // 0x000000018206EEF0-0x000000018206F030
	private StateInfo CloneState(int index); // 0x000000018206E980-0x000000018206EAB0
	public bool Crossfade(string name, float time); // 0x000000018206F030-0x000000018206F120
	public bool CrossfadeQueued(string name, float time, QueueMode queueMode); // 0x000000018206ED20-0x000000018206EEF0
	private bool CrossfadeQueued(int index, float time, QueueMode queueMode); // 0x000000018206EBE0-0x000000018206ED20
	private bool Blend(int index, float targetWeight, float time); // 0x000000018206E130-0x000000018206E240
	public bool Blend(string name, float targetWeight, float time); // 0x000000018206E240-0x000000018206E3D0
	public override void OnGraphStop(Playable playable); // 0x000000018206FCA0-0x000000018206FED0
	private void UpdateDoneStatus(); // 0x0000000182071200-0x00000001820712A0
	private void CleanClonedStates(); // 0x000000018206E5C0-0x000000018206E7E0
	private void DisconnectInput(int index); // 0x000000018206F120-0x000000018206F280
	private void ConnectInput(int index); // 0x000000018206EAB0-0x000000018206EBE0
	private void UpdateStates(float deltaTime); // 0x00000001820713C0-0x0000000182071810
	private float CalculateQueueTimes(); // 0x000000018206E3D0-0x000000018206E5C0
	private void ClearQueuedStates(); // 0x000000018206E7E0-0x000000018206E980
	private void UpdateQueuedStates(); // 0x00000001820712A0-0x00000001820713C0
	private void InvalidateStateTimes(); // 0x000000018206F940-0x000000018206FA10
	public override void PrepareFrame(Playable owner, FrameData data); // 0x0000000182070540-0x0000000182070750
	public bool ValidateInput(int index, Playable input); // 0x0000000182071930-0x0000000182071AC0
	public bool ValidateIndex(int index); // 0x0000000182071900-0x0000000182071930
	private void InvalidateStates(); // 0x000000018206FA10-0x000000018206FA20
	private StateHandle StateInfoToHandle(StateInfo info); // 0x0000000182070E90-0x0000000182070F20
}

