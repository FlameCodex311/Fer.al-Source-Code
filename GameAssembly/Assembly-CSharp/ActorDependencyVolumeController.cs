/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class ActorDependencyVolumeController : ControllerBase // TypeDefIndex: 10401
{
	// Fields
	private static ActorDependencyVolumeController _instance; // 0x00
	public List<ActorDependencyVolume> _actorDependencyVolumes; // 0x28

	// Properties
	public static ActorDependencyVolumeController instance { get; } // 0x0000000181405C20-0x0000000181405CF0 

	// Nested types
	public enum EShape // TypeDefIndex: 10402
	{
		SPHERE = 0,
		RECTANGLE = 1
	}

	public enum EState // TypeDefIndex: 10403
	{
		NONE = 0,
		ENTER = 1,
		EXIT = 2
	}

	[Serializable]
	public class Dependencies // TypeDefIndex: 10404
	{
		// Fields
		public int players; // 0x10
		public int playerExperience; // 0x14
		public List<string> clothingItemDefId; // 0x18
		public List<string> animationDefId; // 0x20
		public List<string> bodyPartDefId; // 0x28
		public List<string> classDefId; // 0x30
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public List<string> inventoryDefId; // 0x38
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public List<string> factionDefId; // 0x40
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public List<string> familiarDefId; // 0x48
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public List<string> familiarClassDefId; // 0x50
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public List<string> objectiveCompletedDefId; // 0x58

		// Constructors
		public Dependencies(); // 0x0000000181411160-0x00000001814112E0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass14_0 // TypeDefIndex: 10405
	{
		// Fields
		public ActorDependencyVolume inVolume; // 0x10

		// Constructors
		public <>c__DisplayClass14_0(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass14_1 // TypeDefIndex: 10406
	{
		// Fields
		public int ii; // 0x10
		public <>c__DisplayClass14_0 CS$<>8__locals1; // 0x18

		// Constructors
		public <>c__DisplayClass14_1(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <ValidClothingItem>b__0(ActorBase.AttachedClothingItem cClothingItem); // 0x000000018141C930-0x000000018141CA10
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 10407
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Predicate<string> <>9__16_0; // 0x08

		// Constructors
		static <>c(); // 0x000000018141D040-0x000000018141D0A0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <ValidClass>b__16_0(string sActorClass); // 0x000000018141C3F0-0x000000018141C480
	}

	// Constructors
	public ActorDependencyVolumeController(); // 0x0000000181405BA0-0x0000000181405C20

	// Methods
	public void Add(ActorDependencyVolume inEnableInRangeToLocalActor); // 0x0000000181404A60-0x0000000181404AE0
	public void Remove(ActorDependencyVolume inEnableInRangeToLocalActor); // 0x0000000181405040-0x00000001814050C0
	private void Update(); // 0x00000001814050C0-0x0000000181405250
	private bool InRange(ActorDependencyVolume inVolume); // 0x0000000181404C30-0x0000000181405040
	private Vector3 GetRelativePosition(ActorDependencyVolume inVolume); // 0x0000000181404AE0-0x0000000181404C30
	private bool ValidDependencies(ActorDependencyVolume inVolume); // 0x0000000181405580-0x00000001814059C0
	private bool ValidAnimation(ActorDependencyVolume inVolume); // 0x0000000181405250-0x00000001814052B0
	private bool ValidClothingItem(ActorDependencyVolume inVolume); // 0x00000001814053E0-0x0000000181405580
	private bool ValidBodyPart(ActorDependencyVolume inVolume); // 0x00000001803C29F0-0x00000001803C2A00
	private bool ValidClass(ActorDependencyVolume inVolume); // 0x00000001814052B0-0x00000001814053E0
	private bool ValidInventory(ActorDependencyVolume inVolume); // 0x0000000181405AE0-0x0000000181405B40
	private bool ValidFaction(ActorDependencyVolume inVolume); // 0x00000001814059C0-0x0000000181405A20
	private bool ValidFamiliar(ActorDependencyVolume inVolume); // 0x0000000181405A80-0x0000000181405AE0
	private bool ValidFamiliarClass(ActorDependencyVolume inVolume); // 0x0000000181405A20-0x0000000181405A80
	private bool ValidObjectiveCompleted(ActorDependencyVolume inVolume); // 0x0000000181405B40-0x0000000181405BA0
	private bool ValidExperience(ActorDependencyVolume inVolume); // 0x00000001803C29F0-0x00000001803C2A00
}

