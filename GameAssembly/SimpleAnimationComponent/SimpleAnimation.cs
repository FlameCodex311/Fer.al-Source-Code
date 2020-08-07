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
using UnityEngine.Playables;

// Image 68: SimpleAnimationComponent.dll - Assembly: SimpleAnimationComponent, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8524-8541

[RequireComponent] // 0x0000000180236F50-0x0000000180236FF0
[RequireComponent] // 0x0000000180236F50-0x0000000180236FF0
public class SimpleAnimation : UnityEngine.MonoBehaviour, IAnimationClipSource // TypeDefIndex: 8526
{
	// Fields
	private const string kDefaultStateName = "Default"; // Metadata: 0x00778006
	protected PlayableGraph m_Graph; // 0x18
	protected PlayableHandle m_LayerMixer; // 0x28
	protected PlayableHandle m_TransitionMixer; // 0x38
	protected Animator m_Animator; // 0x48
	protected bool m_Initialized; // 0x50
	protected bool m_IsPlaying; // 0x51
	protected SimpleAnimationPlayable m_Playable; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected bool m_PlayAutomatically; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected bool m_AnimatePhysics; // 0x61
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected AnimatorCullingMode m_CullingMode; // 0x64
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected WrapMode m_WrapMode; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected AnimationClip m_Clip; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private EditorState[] m_States; // 0x78

	// Properties
	public Animator animator { get; } // 0x00000001820744E0-0x0000000182074560 
	public bool animatePhysics { get; set; } // 0x0000000180459DB0-0x0000000180459DC0 0x00000001820745C0-0x0000000182074600
	public AnimatorCullingMode cullingMode { get; set; } // 0x0000000182074560-0x0000000182074590 0x0000000182074630-0x0000000182074670
	public bool isPlaying { get; } // 0x0000000182074590-0x00000001820745C0 
	public bool playAutomatically { get; set; } // 0x00000001803CE080-0x00000001803CE090 0x000000018045A0C0-0x000000018045A0D0
	public AnimationClip clip { get; set; } // 0x0000000180418980-0x0000000180418990 0x0000000182074600-0x0000000182074630
	public WrapMode wrapMode { get; set; } // 0x00000001806F4980-0x00000001806F4990 0x00000001806F4B40-0x00000001806F4B50
	public State this[string name] { get => default; } // 0x0000000182072540-0x00000001820725E0 

	// Nested types
	public interface State // TypeDefIndex: 8527
	{
		// Properties
		bool enabled { get; set; }
		bool isValid { get; }
		float time { get; set; }
		float normalizedTime { get; set; }
		float speed { get; set; }
		string name { get; set; }
		float weight { get; set; }
		float length { get; }
		AnimationClip clip { get; }
		WrapMode wrapMode { get; set; }
	}

	private class StateEnumerable : IEnumerable<State> // TypeDefIndex: 8528
	{
		// Fields
		private SimpleAnimation m_Owner; // 0x10

		// Nested types
		private class StateEnumerator : IEnumerator<State> // TypeDefIndex: 8529
		{
			// Fields
			private SimpleAnimation m_Owner; // 0x10
			private IEnumerator<SimpleAnimationPlayable.IState> m_Impl; // 0x18

			// Properties
			object IEnumerator.Current { get; } // 0x0000000182074DA0-0x0000000182074DB0 
			State IEnumerator<SimpleAnimation.State>.Current { get; } // 0x0000000182074DA0-0x0000000182074DB0 

			// Constructors
			public StateEnumerator(SimpleAnimation owner); // 0x0000000182074DB0-0x0000000182074EB0

			// Methods
			private State GetCurrent(); // 0x0000000182074A70-0x0000000182074B00
			public void Dispose(); // 0x00000001803774A0-0x00000001803774B0
			public bool MoveNext(); // 0x0000000182074C70-0x0000000182074CC0
			public void Reset(); // 0x0000000182074D40-0x0000000182074D90
		}

		// Constructors
		public StateEnumerable(SimpleAnimation owner); // 0x0000000180400150-0x0000000180400180

		// Methods
		public IEnumerator<State> GetEnumerator(); // 0x0000000182074750-0x00000001820747B0
		IEnumerator IEnumerable.GetEnumerator(); // 0x0000000182074890-0x00000001820748F0
	}

	private class StateImpl : State // TypeDefIndex: 8530
	{
		// Fields
		private SimpleAnimationPlayable.IState m_StateHandle; // 0x10
		private SimpleAnimation m_Component; // 0x18

		// Properties
		bool State.enabled { get; set; } // 0x0000000182076230-0x0000000182076280 0x0000000182076570-0x0000000182076660
		bool State.isValid { get; } // 0x0000000182076280-0x00000001820762D0 
		float State.time { get; set; } // 0x0000000182076410-0x0000000182076460 0x0000000182076820-0x00000001820768A0
		float State.normalizedTime { get; set; } // 0x0000000182076370-0x00000001820763C0 0x0000000182076720-0x00000001820767A0
		float State.speed { get; set; } // 0x00000001820763C0-0x0000000182076410 0x00000001820767A0-0x0000000182076820
		string State.name { get; set; } // 0x0000000182076320-0x0000000182076370 0x0000000182076660-0x0000000182076720
		float State.weight { get; set; } // 0x0000000182076460-0x00000001820764B0 0x00000001820768A0-0x0000000182076920
		float State.length { get; } // 0x00000001820762D0-0x0000000182076320 
		AnimationClip State.clip { get; } // 0x00000001820761E0-0x0000000182076230 
		WrapMode State.wrapMode { get; set; } // 0x00000001820764B0-0x0000000182076570 0x0000000182076920-0x0000000182076970

		// Constructors
		public StateImpl(SimpleAnimationPlayable.IState handle, SimpleAnimation component); // 0x0000000180372010-0x00000001803720F0
	}

	[Serializable]
	public class EditorState // TypeDefIndex: 8531
	{
		// Fields
		public AnimationClip clip; // 0x10
		public string name; // 0x18
		public bool defaultState; // 0x20

		// Constructors
		public EditorState(); // 0x0000000180373240-0x0000000180373250
	}

	// Constructors
	public SimpleAnimation(); // 0x00000001820744C0-0x00000001820744E0

	// Methods
	public void AddClip(AnimationClip clip, string newName); // 0x0000000182071C00-0x0000000182071C80
	public void Blend(string stateName, float targetWeight, float fadeLength); // 0x0000000182071D10-0x0000000182071EE0
	public void CrossFade(string stateName, float fadeLength); // 0x0000000182072160-0x0000000182072290
	public void CrossFadeQueued(string stateName, float fadeLength, QueueMode queueMode); // 0x0000000182071F60-0x0000000182072160
	public int GetClipCount(); // 0x0000000182072460-0x0000000182072540
	public bool IsPlaying(string stateName); // 0x0000000182072D00-0x0000000182072E40
	public void Stop(); // 0x00000001820743E0-0x0000000182074400
	public void Stop(string stateName); // 0x0000000182074400-0x00000001820744C0
	public void Sample(); // 0x00000001820743D0-0x00000001820743E0
	public bool Play(); // 0x0000000182073A60-0x0000000182073B20
	public void AddState(AnimationClip clip, string name); // 0x0000000182071C80-0x0000000182071D00
	public void RemoveState(string name); // 0x0000000182074050-0x0000000182074150
	public bool Play(string stateName); // 0x00000001820739F0-0x0000000182073A60
	public void PlayQueued(string stateName, QueueMode queueMode); // 0x00000001820737F0-0x00000001820739F0
	public void RemoveClip(AnimationClip clip); // 0x0000000182073E80-0x0000000182074050
	public void Rewind(); // 0x00000001820742D0-0x00000001820743D0
	public void Rewind(string stateName); // 0x0000000182074190-0x00000001820742D0
	public State GetState(string stateName); // 0x0000000182072540-0x00000001820725E0
	public IEnumerable<State> GetStates(); // 0x00000001820725E0-0x0000000182072640
	protected void Kick(); // 0x0000000182072E40-0x0000000182072E70
	protected virtual void OnEnable(); // 0x0000000182072FA0-0x0000000182072FF0
	protected virtual void OnDisable(); // 0x0000000182072F60-0x0000000182072FA0
	private void Reset(); // 0x0000000182074150-0x0000000182074190
	private void Initialize(); // 0x0000000182072640-0x0000000182072BB0
	private void EnsureDefaultStateExists(); // 0x0000000182072290-0x0000000182072360
	protected virtual void Awake(); // 0x0000000182071D00-0x0000000182071D10
	protected void OnDestroy(); // 0x0000000182072F30-0x0000000182072F60
	private void OnPlayableDone(); // 0x0000000182072FF0-0x0000000182073010
	private void RebuildStates(); // 0x0000000182073B20-0x0000000182073E80
	private EditorState CreateDefaultEditorState(); // 0x0000000182071EE0-0x0000000182071F60
	private static void LegacyClipCheck(AnimationClip clip); // 0x0000000182072E70-0x0000000182072F30
	private void InvalidLegacyClipError(string clipName, string stateName); // 0x0000000182072BB0-0x0000000182072D00
	private void OnValidate(); // 0x0000000182073010-0x00000001820737F0
	public void GetAnimationClips(List<AnimationClip> results); // 0x0000000182072360-0x0000000182072460
}

