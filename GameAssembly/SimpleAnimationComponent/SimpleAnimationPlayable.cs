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

// Image 67: SimpleAnimationComponent.dll - Assembly: SimpleAnimationComponent, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8358-8375

public class SimpleAnimationPlayable : PlayableBehaviour // TypeDefIndex: 8366
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
	public bool keepStoppedPlayablesConnected { get; set; } // 0x00000001803C19F0-0x00000001803C1A00 0x00000001822A69F0-0x00000001822A6A00
	protected Playable self { get; } // 0x000000018036CB50-0x000000018036CB60 
	public Playable playable { get; } // 0x000000018036CB50-0x000000018036CB60 
	protected PlayableGraph graph { get; } // 0x00000001822A6990-0x00000001822A69F0 

	// Nested types
	private class StateEnumerable : IEnumerable<IState> // TypeDefIndex: 8367
	{
		// Fields
		private SimpleAnimationPlayable m_Owner; // 0x10

		// Nested types
		private class StateEnumerator : IEnumerator<IState> // TypeDefIndex: 8368
		{
			// Fields
			private int m_Index; // 0x10
			private int m_Version; // 0x14
			private SimpleAnimationPlayable m_Owner; // 0x18

			// Properties
			object IEnumerator.Current { get; } // 0x00000001822A9BA0-0x00000001822A9BB0 
			IState IEnumerator<SimpleAnimationPlayable.IState>.Current { get; } // 0x00000001822A9BA0-0x00000001822A9BB0 

			// Constructors
			public StateEnumerator(SimpleAnimationPlayable owner); // 0x00000001822A9CC0-0x00000001822A9D70

			// Methods
			private bool IsValid(); // 0x00000001822A9900-0x00000001822A9920
			private IState GetCurrentHandle(int index); // 0x00000001822A96F0-0x00000001822A9870
			public void Dispose(); // 0x00000001803581E0-0x00000001803581F0
			public bool MoveNext(); // 0x00000001822A9920-0x00000001822A9A80
			public void Reset(); // 0x00000001822A9AD0-0x00000001822A9B50
		}

		// Constructors
		public StateEnumerable(SimpleAnimationPlayable owner); // 0x000000018037D3F0-0x000000018037D420

		// Methods
		public IEnumerator<IState> GetEnumerator(); // 0x00000001822A9470-0x00000001822A9550
		IEnumerator IEnumerable.GetEnumerator(); // 0x00000001822A95B0-0x00000001822A9690
	}

	public interface IState // TypeDefIndex: 8369
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

	public class StateHandle : IState // TypeDefIndex: 8370
	{
		// Fields
		private SimpleAnimationPlayable m_Parent; // 0x10
		private int m_Index; // 0x18
		private Playable m_Target; // 0x20

		// Properties
		public bool enabled { get; set; } // 0x00000001822AA070-0x00000001822AA170 0x00000001822AA950-0x00000001822AAAA0
		public float time { get; set; } // 0x00000001822AA6B0-0x00000001822AA750 0x00000001822AAE30-0x00000001822AAEE0
		public float normalizedTime { get; set; } // 0x00000001822AA480-0x00000001822AA570 0x00000001822AABF0-0x00000001822AACE0
		public float speed { get; set; } // 0x00000001822AA570-0x00000001822AA6B0 0x00000001822AACE0-0x00000001822AAE30
		public string name { get; set; } // 0x00000001822AA380-0x00000001822AA480 0x00000001822AAAA0-0x00000001822AABF0
		public float weight { get; set; } // 0x00000001822AA750-0x00000001822AA850 0x00000001822AAEE0-0x00000001822AB040
		public float length { get; } // 0x00000001822AA170-0x00000001822AA380 
		public AnimationClip clip { get; } // 0x00000001822A9F70-0x00000001822AA070 
		public WrapMode wrapMode { get; } // 0x00000001822AA850-0x00000001822AA950 
		public int index { get; } // 0x0000000180367710-0x0000000180367720 

		// Constructors
		public StateHandle(SimpleAnimationPlayable s, int index, Playable target); // 0x00000001822A9F20-0x00000001822A9F70

		// Methods
		public bool IsValid(); // 0x00000001822A9D70-0x00000001822A9F20
	}

	private class StateInfo // TypeDefIndex: 8371
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
		public bool enabled { get; } // 0x0000000180375540-0x0000000180375550 
		public int index { get; set; } // 0x0000000180372360-0x0000000180372370 0x000000018036C6F0-0x000000018036C700
		public string stateName { get; set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
		public bool fading { get; } // 0x00000001803C19E0-0x00000001803C19F0 
		public float targetWeight { get; } // 0x0000000180487D50-0x0000000180487D60 
		public float weight { get; } // 0x0000000180487D70-0x0000000180487D80 
		public float fadeSpeed { get; } // 0x0000000180485990-0x00000001804859A0 
		public float speed { get; set; } // 0x00000001822ABCE0-0x00000001822ABD30 0x00000001822ABD30-0x00000001822ABD90
		public float playableDuration { get; } // 0x00000001822ABC90-0x00000001822ABCE0 
		public AnimationClip clip { get; } // 0x0000000180369BB0-0x0000000180369BC0 
		public bool isDone { get; } // 0x00000001822ABC40-0x00000001822ABC90 
		public Playable playable { get; } // 0x000000018038E080-0x000000018038E090 
		public WrapMode wrapMode { get; } // 0x0000000180369BA0-0x0000000180369BB0 
		public bool isClone { get; } // 0x0000000180F6A9C0-0x0000000180F6A9D0 
		public bool isReadyForCleanup { get; } // 0x00000001810B8B80-0x00000001810B8B90 
		public StateHandle parentState { get; } // 0x0000000180357120-0x0000000180357130 
		public bool enabledDirty { get; } // 0x0000000180478640-0x0000000180478650 
		public bool weightDirty { get; } // 0x00000001804785B0-0x00000001804785C0 

		// Constructors
		public StateInfo(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		public void Initialize(string name, AnimationClip clip, WrapMode wrapMode); // 0x00000001822AB9F0-0x00000001822ABA00
		public float GetTime(); // 0x00000001822AB980-0x00000001822AB9F0
		public void SetTime(float newTime); // 0x00000001822ABAD0-0x00000001822ABBB0
		public void Enable(); // 0x00000001822AB8C0-0x00000001822AB8D0
		public void Disable(); // 0x00000001822AB8B0-0x00000001822AB8C0
		public void Pause(); // 0x00000001822ABA00-0x00000001822ABA50
		public void Play(); // 0x00000001822ABA50-0x00000001822ABAA0
		public void Stop(); // 0x00000001822ABBC0-0x00000001822ABC40
		public void ForceWeight(float weight); // 0x00000001822AB960-0x00000001822AB980
		public void SetWeight(float weight); // 0x00000001822ABBB0-0x00000001822ABBC0
		public void FadeTo(float weight, float speed); // 0x00000001822AB8D0-0x00000001822AB960
		public void DestroyPlayable(); // 0x00000001822AB810-0x00000001822AB8B0
		public void SetAsCloneOf(StateHandle handle); // 0x00000001822ABAB0-0x00000001822ABAC0
		public void SetPlayable(Playable playable); // 0x00000001822ABAC0-0x00000001822ABAD0
		public void ResetDirtyFlags(); // 0x00000001822ABAA0-0x00000001822ABAB0
		public void InvalidateTime(); // 0x0000000180ABA5A0-0x0000000180ABA5B0
	}

	private class StateManagement // TypeDefIndex: 8372
	{
		// Fields
		private List<StateInfo> m_States; // 0x10
		private int m_Count; // 0x18

		// Properties
		public int Count { get; } // 0x0000000180367710-0x0000000180367720 
		public StateInfo this[int i] { get => default; } // 0x00000001822ACE90-0x00000001822ACEF0 

		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 8373
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Predicate<StateInfo> <>9__7_0; // 0x08
			public static Predicate<StateInfo> <>9__8_0; // 0x10

			// Constructors
			static <>c(); // 0x00000001822ACF20-0x00000001822ACF80
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

			// Methods
			internal bool <InsertState>b__7_0(StateInfo s); // 0x000000018057B850-0x000000018057B860
			internal bool <AnyStatePlaying>b__8_0(StateInfo s); // 0x00000001822ACEF0-0x00000001822ACF00
		}

		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass11_0 // TypeDefIndex: 8374
		{
			// Fields
			public string name; // 0x10

			// Constructors
			public <>c__DisplayClass11_0(); // 0x000000018036B6C0-0x000000018036B6D0

			// Methods
			internal bool <FindState>b__0(StateInfo s); // 0x00000001822ACF00-0x00000001822ACF20
		}

		// Constructors
		public StateManagement(); // 0x00000001822ACE30-0x00000001822ACE90

		// Methods
		public StateInfo InsertState(); // 0x00000001822AC6C0-0x00000001822AC850
		public bool AnyStatePlaying(); // 0x00000001822ABD90-0x00000001822ABE90
		public void RemoveState(int index); // 0x00000001822ACA10-0x00000001822ACB50
		public bool RemoveClip(AnimationClip clip); // 0x00000001822AC900-0x00000001822ACA10
		public StateInfo FindState(string name); // 0x00000001822ABF90-0x00000001822AC090
		public void EnableState(int index); // 0x00000001822ABF10-0x00000001822ABF90
		public void DisableState(int index); // 0x00000001822ABE90-0x00000001822ABF10
		public void SetInputWeight(int index, float weight); // 0x00000001822ACB50-0x00000001822ACBD0
		public void SetStateTime(int index, float time); // 0x00000001822ACD10-0x00000001822ACD90
		public float GetStateTime(int index); // 0x00000001822AC580-0x00000001822AC650
		public bool IsCloneOf(int potentialCloneIndex, int originalIndex); // 0x00000001822AC850-0x00000001822AC900
		public float GetStateSpeed(int index); // 0x00000001822AC4D0-0x00000001822AC580
		public void SetStateSpeed(int index, float value); // 0x00000001822ACC50-0x00000001822ACD10
		public float GetInputWeight(int index); // 0x00000001822AC150-0x00000001822AC1C0
		public float GetStateLength(int index); // 0x00000001822AC230-0x00000001822AC3B0
		public float GetClipLength(int index); // 0x00000001822AC090-0x00000001822AC150
		public float GetStatePlayableDuration(int index); // 0x00000001822AC420-0x00000001822AC4D0
		public AnimationClip GetStateClip(int index); // 0x00000001822AC1C0-0x00000001822AC230
		public WrapMode GetStateWrapMode(int index); // 0x00000001822AC650-0x00000001822AC6C0
		public string GetStateName(int index); // 0x00000001822AC3B0-0x00000001822AC420
		public void SetStateName(int index, string name); // 0x00000001822ACBD0-0x00000001822ACC50
		public void StopState(int index, bool cleanup); // 0x00000001822ACD90-0x00000001822ACE30
	}

	private struct QueuedState // TypeDefIndex: 8375
	{
		// Fields
		public StateHandle state; // 0x00
		public float fadeTime; // 0x08

		// Constructors
		public QueuedState(StateHandle s, float t); // 0x00000001802A3420-0x00000001802A3480
	}

	// Constructors
	public SimpleAnimationPlayable(); // 0x00000001822A68C0-0x00000001822A6990

	// Methods
	private void UpdateStoppedPlayablesConnections(); // 0x00000001822A6600-0x00000001822A66F0
	public Playable GetInput(int index); // 0x00000001822A44D0-0x00000001822A4590
	public override void OnPlayableCreate(Playable playable); // 0x00000001822A4C60-0x00000001822A4DF0
	public IEnumerable<IState> GetStates(); // 0x00000001822A4640-0x00000001822A46A0
	public IState GetState(string name); // 0x00000001822A4590-0x00000001822A4640
	private StateInfo DoAddClip(string name, AnimationClip clip); // 0x00000001822A4130-0x00000001822A4350
	public bool AddClip(AnimationClip clip, string name); // 0x00000001822A2EE0-0x00000001822A2FC0
	public bool RemoveClip(string name); // 0x00000001822A5620-0x00000001822A5700
	public bool RemoveClip(AnimationClip clip); // 0x00000001822A5500-0x00000001822A5620
	public bool Play(string name); // 0x00000001822A5100-0x00000001822A51B0
	private bool Play(int index); // 0x00000001822A51B0-0x00000001822A52E0
	public bool PlayQueued(string name, QueueMode queueMode); // 0x00000001822A4DF0-0x00000001822A4FC0
	private bool PlayQueued(int index, QueueMode queueMode); // 0x00000001822A4FC0-0x00000001822A5100
	public void Rewind(string name); // 0x00000001822A59E0-0x00000001822A5B00
	private void Rewind(int index); // 0x00000001822A5960-0x00000001822A59E0
	public void Rewind(); // 0x00000001822A5880-0x00000001822A5960
	private void RemoveClones(StateInfo state); // 0x00000001822A5700-0x00000001822A5880
	public bool Stop(string name); // 0x00000001822A5F20-0x00000001822A5FE0
	private void DoStop(int index); // 0x00000001822A4350-0x00000001822A4400
	public bool StopAll(); // 0x00000001822A5CF0-0x00000001822A5F20
	public bool IsPlaying(); // 0x00000001822A4A00-0x00000001822A4A20
	public bool IsPlaying(string stateName); // 0x00000001822A48B0-0x00000001822A4A00
	private bool IsClonePlaying(StateInfo state); // 0x00000001822A4790-0x00000001822A48B0
	public int GetClipCount(); // 0x00000001822A4400-0x00000001822A44D0
	private void SetupLerp(StateInfo state, float targetWeight, float time); // 0x00000001822A5B00-0x00000001822A5C60
	private bool Crossfade(int index, float time); // 0x00000001822A3D90-0x00000001822A3EE0
	private StateInfo CloneState(int index); // 0x00000001822A3820-0x00000001822A3950
	public bool Crossfade(string name, float time); // 0x00000001822A3EE0-0x00000001822A3FD0
	public bool CrossfadeQueued(string name, float time, QueueMode queueMode); // 0x00000001822A3BC0-0x00000001822A3D90
	private bool CrossfadeQueued(int index, float time, QueueMode queueMode); // 0x00000001822A3A80-0x00000001822A3BC0
	private bool Blend(int index, float targetWeight, float time); // 0x00000001822A2FC0-0x00000001822A30D0
	public bool Blend(string name, float targetWeight, float time); // 0x00000001822A30D0-0x00000001822A3270
	public override void OnGraphStop(Playable playable); // 0x00000001822A4A20-0x00000001822A4C60
	private void UpdateDoneStatus(); // 0x00000001822A5FE0-0x00000001822A6080
	private void CleanClonedStates(); // 0x00000001822A3460-0x00000001822A3680
	private void DisconnectInput(int index); // 0x00000001822A3FD0-0x00000001822A4130
	private void ConnectInput(int index); // 0x00000001822A3950-0x00000001822A3A80
	private void UpdateStates(float deltaTime); // 0x00000001822A61B0-0x00000001822A6600
	private float CalculateQueueTimes(); // 0x00000001822A3270-0x00000001822A3460
	private void ClearQueuedStates(); // 0x00000001822A3680-0x00000001822A3820
	private void UpdateQueuedStates(); // 0x00000001822A6080-0x00000001822A61B0
	private void InvalidateStateTimes(); // 0x00000001822A46A0-0x00000001822A4780
	public override void PrepareFrame(Playable owner, FrameData data); // 0x00000001822A52E0-0x00000001822A5500
	public bool ValidateInput(int index, Playable input); // 0x00000001822A6720-0x00000001822A68C0
	public bool ValidateIndex(int index); // 0x00000001822A66F0-0x00000001822A6720
	private void InvalidateStates(); // 0x00000001822A4780-0x00000001822A4790
	private StateHandle StateInfoToHandle(StateInfo info); // 0x00000001822A5C60-0x00000001822A5CF0
}

