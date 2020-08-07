/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.BehaviourTrees;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class NetworkedObjectInfo : WorldObject // TypeDefIndex: 12388
{
	// Fields
	public EActorType actorType; // 0x70
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int <Local>k__BackingField; // 0x74
	public string uuid; // 0x78
	public int State; // 0x80
	[RootSelector] // 0x00000001801FCC70-0x00000001801FCCD0
	public string dialogListDefId; // 0x88
	public DialogueTreeController[] dialogueTreeController; // 0x90
	protected GraphOwner _graphOwner; // 0x98
	protected NodeCanvas.BehaviourTrees.Switch _switchNode; // 0xA0
	private int _numStates; // 0xA8

	// Properties
	public int Local { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001804428A0-0x00000001804428B0 0x00000001805CF180-0x00000001805CF190

	// Nested types
	public enum EActorType // TypeDefIndex: 12389
	{
		NONE = 0,
		npc = 1,
		volumeTrigger = 3,
		circleTrigger = 4,
		volumeBlocker = 5,
		circleBlocker = 6,
		variable = 7,
		timer = 8,
		treasure = 13,
		speaker = 16,
		startup = 18,
		harvestItem = 31,
		npcQuestItem = 32,
		dailyQuest = 33
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <GraphInitializeWait>d__16 : IEnumerator<object> // TypeDefIndex: 12390
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public NetworkedObjectInfo <>4__this; // 0x20
		private float <t>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <GraphInitializeWait>d__16(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807D8050-0x00000001807D8190
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807D8190-0x00000001807D85E0
	}

	// Constructors
	public NetworkedObjectInfo(); // 0x00000001807D6D80-0x00000001807D6DD0

	// Methods
	public override void OnObjectInfo(WorldObjectInfoMessage inInfoMessage); // 0x00000001807D67B0-0x00000001807D6AE0
	internal bool HasStates(); // 0x00000001807D64E0-0x00000001807D67B0
	internal void UpdateState(int inState); // 0x00000001807D6BC0-0x00000001807D6D80
	[IteratorStateMachine] // 0x000000018028A350-0x000000018028A3A0
	private IEnumerator GraphInitializeWait(); // 0x00000001807D6480-0x00000001807D64E0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnObjectInfo>b__13_0(DialogueTreeController dtc); // 0x00000001807D6AE0-0x00000001807D6BC0
}

