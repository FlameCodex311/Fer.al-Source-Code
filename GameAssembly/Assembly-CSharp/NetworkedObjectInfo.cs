/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.BehaviourTrees;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class NetworkedObjectInfo : WorldObject // TypeDefIndex: 10866
{
	// Fields
	public EActorType actorType; // 0x70
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private int <Local>k__BackingField; // 0x74
	public string uuid; // 0x78
	public int State; // 0x80
	[RootSelector] // 0x00000001800E9180-0x00000001800E91E0
	public string dialogListDefId; // 0x88
	public DialogueTreeController[] dialogueTreeController; // 0x90
	protected GraphOwner _graphOwner; // 0x98
	protected Switch _switchNode; // 0xA0
	private int _numStates; // 0xA8

	// Properties
	public int Local { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001803DAD10-0x00000001803DAD20 0x00000001803DAEB0-0x00000001803DAEC0

	// Nested types
	public enum EActorType // TypeDefIndex: 10867
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

	// Constructors
	public NetworkedObjectInfo(); // 0x000000018156F7C0-0x000000018156F810

	// Methods
	public override void OnObjectInfo(WorldObjectInfoMessage inInfoMessage); // 0x000000018156F220-0x000000018156F5D0
	internal bool HasStates(); // 0x000000018156EF50-0x000000018156F220
	internal void UpdateState(int inState); // 0x000000018156F6C0-0x000000018156F7C0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnObjectInfo>b__13_0(DialogueTreeController dtc); // 0x000000018156F5D0-0x000000018156F6C0
}

