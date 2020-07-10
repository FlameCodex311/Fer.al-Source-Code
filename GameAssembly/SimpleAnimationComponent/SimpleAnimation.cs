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

// Image 67: SimpleAnimationComponent.dll - Assembly: SimpleAnimationComponent, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8358-8375

[RequireComponent] // 0x00000001800D88E0-0x00000001800D8980
[RequireComponent] // 0x00000001800D88E0-0x00000001800D8980
public class SimpleAnimation : UnityEngine.MonoBehaviour, IAnimationClipSource // TypeDefIndex: 8360
{
	// Fields
	private const string kDefaultStateName = "Default"; // Metadata: 0x00743318
	protected PlayableGraph m_Graph; // 0x18
	protected PlayableHandle m_LayerMixer; // 0x28
	protected PlayableHandle m_TransitionMixer; // 0x38
	protected Animator m_Animator; // 0x48
	protected bool m_Initialized; // 0x50
	protected bool m_IsPlaying; // 0x51
	protected SimpleAnimationPlayable m_Playable; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected bool m_PlayAutomatically; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected bool m_AnimatePhysics; // 0x61
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected AnimatorCullingMode m_CullingMode; // 0x64
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected WrapMode m_WrapMode; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected AnimationClip m_Clip; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private EditorState[] m_States; // 0x78

	// Properties
	public Animator animator { get; } // 0x00000001822A92E0-0x00000001822A9360 
	public bool animatePhysics { get; set; } // 0x0000000180478640-0x0000000180478650 0x00000001822A93C0-0x00000001822A9400
	public AnimatorCullingMode cullingMode { get; set; } // 0x00000001822A9360-0x00000001822A9390 0x00000001822A9430-0x00000001822A9470
	public bool isPlaying { get; } // 0x00000001822A9390-0x00000001822A93C0 
	public bool playAutomatically { get; set; } // 0x00000001804785B0-0x00000001804785C0 0x000000018062BA40-0x000000018062BA50
	public AnimationClip clip { get; set; } // 0x0000000180369B50-0x0000000180369B60 0x00000001822A9400-0x00000001822A9430
	public WrapMode wrapMode { get; set; } // 0x00000001803DAC60-0x00000001803DAC70 0x00000001803DAE50-0x00000001803DAE60
	public State this[string name] { get => default; } // 0x00000001822A9240-0x00000001822A92E0 

	// Nested types
	public interface State // TypeDefIndex: 8361
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

	private class StateEnumerable : IEnumerable<State> // TypeDefIndex: 8362
	{
		// Fields
		private SimpleAnimation m_Owner; // 0x10

		// Nested types
		private class StateEnumerator : IEnumerator<State> // TypeDefIndex: 8363
		{
			// Fields
			private SimpleAnimation m_Owner; // 0x10
			private IEnumerator<SimpleAnimationPlayable.IState> m_Impl; // 0x18

			// Properties
			object IEnumerator.Current { get; } // 0x00000001822A9BB0-0x00000001822A9BC0 
			State IEnumerator<SimpleAnimation.State>.Current { get; } // 0x00000001822A9BB0-0x00000001822A9BC0 

			// Constructors
			public StateEnumerator(SimpleAnimation owner); // 0x00000001822A9BC0-0x00000001822A9CC0

			// Methods
			private State GetCurrent(); // 0x00000001822A9870-0x00000001822A9900
			public void Dispose(); // 0x00000001803581E0-0x00000001803581F0
			public bool MoveNext(); // 0x00000001822A9A80-0x00000001822A9AD0
			public void Reset(); // 0x00000001822A9B50-0x00000001822A9BA0
		}

		// Constructors
		public StateEnumerable(SimpleAnimation owner); // 0x000000018037D3F0-0x000000018037D420

		// Methods
		public IEnumerator<State> GetEnumerator(); // 0x00000001822A9550-0x00000001822A95B0
		IEnumerator IEnumerable.GetEnumerator(); // 0x00000001822A9690-0x00000001822A96F0
	}

	private class StateImpl : State // TypeDefIndex: 8364
	{
		// Fields
		private SimpleAnimationPlayable.IState m_StateHandle; // 0x10
		private SimpleAnimation m_Component; // 0x18

		// Properties
		bool State.enabled { get; set; } // 0x00000001822AB090-0x00000001822AB0E0 0x00000001822AB3D0-0x00000001822AB4C0
		bool State.isValid { get; } // 0x00000001822AB0E0-0x00000001822AB130 
		float State.time { get; set; } // 0x00000001822AB270-0x00000001822AB2C0 0x00000001822AB6A0-0x00000001822AB730
		float State.normalizedTime { get; set; } // 0x00000001822AB1D0-0x00000001822AB220 0x00000001822AB580-0x00000001822AB610
		float State.speed { get; set; } // 0x00000001822AB220-0x00000001822AB270 0x00000001822AB610-0x00000001822AB6A0
		string State.name { get; set; } // 0x00000001822AB180-0x00000001822AB1D0 0x00000001822AB4C0-0x00000001822AB580
		float State.weight { get; set; } // 0x00000001822AB2C0-0x00000001822AB310 0x00000001822AB730-0x00000001822AB7C0
		float State.length { get; } // 0x00000001822AB130-0x00000001822AB180 
		AnimationClip State.clip { get; } // 0x00000001822AB040-0x00000001822AB090 
		WrapMode State.wrapMode { get; set; } // 0x00000001822AB310-0x00000001822AB3D0 0x00000001822AB7C0-0x00000001822AB810

		// Constructors
		public StateImpl(SimpleAnimationPlayable.IState handle, SimpleAnimation component); // 0x00000001803DA900-0x00000001803DA940
	}

	[Serializable]
	public class EditorState // TypeDefIndex: 8365
	{
		// Fields
		public AnimationClip clip; // 0x10
		public string name; // 0x18
		public bool defaultState; // 0x20

		// Constructors
		public EditorState(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	// Constructors
	public SimpleAnimation(); // 0x00000001822A9220-0x00000001822A9240

	// Methods
	public void AddClip(AnimationClip clip, string newName); // 0x00000001822A6A00-0x00000001822A6A80
	public void Blend(string stateName, float targetWeight, float fadeLength); // 0x00000001822A6B10-0x00000001822A6CF0
	public void CrossFade(string stateName, float fadeLength); // 0x00000001822A6E00-0x00000001822A6F30
	public void CrossFadeQueued(string stateName, float fadeLength, QueueMode queueMode); // 0x00000001822A6D70-0x00000001822A6E00
	public int GetClipCount(); // 0x00000001822A7100-0x00000001822A71E0
	public bool IsPlaying(string stateName); // 0x00000001822A79D0-0x00000001822A7B10
	public void Stop(); // 0x00000001822A9130-0x00000001822A9150
	public void Stop(string stateName); // 0x00000001822A9150-0x00000001822A9220
	public void Sample(); // 0x00000001822A9120-0x00000001822A9130
	public bool Play(); // 0x00000001822A8790-0x00000001822A8850
	public void AddState(AnimationClip clip, string name); // 0x00000001822A6A80-0x00000001822A6B00
	public void RemoveState(string name); // 0x00000001822A8D90-0x00000001822A8E90
	public bool Play(string stateName); // 0x00000001822A8720-0x00000001822A8790
	public void PlayQueued(string stateName, QueueMode queueMode); // 0x00000001822A8510-0x00000001822A8720
	public void RemoveClip(AnimationClip clip); // 0x00000001822A8BC0-0x00000001822A8D90
	public void Rewind(); // 0x00000001822A9010-0x00000001822A9120
	public void Rewind(string stateName); // 0x00000001822A8ED0-0x00000001822A9010
	public State GetState(string stateName); // 0x00000001822A71E0-0x00000001822A7280
	public IEnumerable<State> GetStates(); // 0x00000001822A7280-0x00000001822A72E0
	protected void Kick(); // 0x00000001822A7B10-0x00000001822A7B40
	protected virtual void OnEnable(); // 0x00000001822A7C70-0x00000001822A7CC0
	protected virtual void OnDisable(); // 0x00000001822A7C30-0x00000001822A7C70
	private void Reset(); // 0x00000001822A8E90-0x00000001822A8ED0
	private void Initialize(); // 0x00000001822A72E0-0x00000001822A7870
	private void EnsureDefaultStateExists(); // 0x00000001822A6F30-0x00000001822A7000
	protected virtual void Awake(); // 0x00000001822A6B00-0x00000001822A6B10
	protected void OnDestroy(); // 0x00000001822A7C00-0x00000001822A7C30
	private void OnPlayableDone(); // 0x00000001822A7CC0-0x00000001822A7CE0
	private void RebuildStates(); // 0x00000001822A8850-0x00000001822A8BC0
	private EditorState CreateDefaultEditorState(); // 0x00000001822A6CF0-0x00000001822A6D70
	private static void LegacyClipCheck(AnimationClip clip); // 0x00000001822A7B40-0x00000001822A7C00
	private void InvalidLegacyClipError(string clipName, string stateName); // 0x00000001822A7870-0x00000001822A79D0
	private void OnValidate(); // 0x00000001822A7CE0-0x00000001822A8510
	public void GetAnimationClips(List<AnimationClip> results); // 0x00000001822A7000-0x00000001822A7100
}

