/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class ActorDependencyVolumeController : ControllerBase // TypeDefIndex: 11889
{
	// Fields
	private static ActorDependencyVolumeController _instance; // 0x00
	public List<ActorDependencyVolume> _actorDependencyVolumes; // 0x28

	// Properties
	public static ActorDependencyVolumeController instance { get; } // 0x00000001821D7990-0x00000001821D7A60 

	// Nested types
	public enum EShape // TypeDefIndex: 11890
	{
		SPHERE = 0,
		RECTANGLE = 1
	}

	public enum EState // TypeDefIndex: 11891
	{
		NONE = 0,
		ENTER = 1,
		EXIT = 2
	}

	[Serializable]
	public class Dependencies // TypeDefIndex: 11892
	{
		// Fields
		public int players; // 0x10
		public int playerExperience; // 0x14
		public List<string> clothingItemDefId; // 0x18
		public List<string> animationDefId; // 0x20
		public List<string> bodyPartDefId; // 0x28
		public List<string> classDefId; // 0x30
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public List<string> inventoryDefId; // 0x38
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public List<string> factionDefId; // 0x40
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public List<string> familiarDefId; // 0x48
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public List<string> familiarClassDefId; // 0x50
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public List<string> objectiveCompletedDefId; // 0x58

		// Constructors
		public Dependencies(); // 0x00000001821E1540-0x00000001821E16C0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass14_0 // TypeDefIndex: 11893
	{
		// Fields
		public ActorDependencyVolume inVolume; // 0x10

		// Constructors
		public <>c__DisplayClass14_0(); // 0x0000000180373240-0x0000000180373250
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass14_1 // TypeDefIndex: 11894
	{
		// Fields
		public int ii; // 0x10
		public <>c__DisplayClass14_0 CS$<>8__locals1; // 0x18

		// Constructors
		public <>c__DisplayClass14_1(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <ValidClothingItem>b__0(ActorBase.AttachedClothingItem cClothingItem); // 0x00000001821EBD30-0x00000001821EBE00
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 11895
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Predicate<string> <>9__16_0; // 0x08

		// Constructors
		static <>c(); // 0x00000001821EBE50-0x00000001821EBEB0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <ValidClass>b__16_0(string sActorClass); // 0x00000001821EB7F0-0x00000001821EB880
	}

	// Constructors
	public ActorDependencyVolumeController(); // 0x00000001821D7910-0x00000001821D7990

	// Methods
	public void Add(ActorDependencyVolume inEnableInRangeToLocalActor); // 0x00000001821D6820-0x00000001821D68A0
	public void Remove(ActorDependencyVolume inEnableInRangeToLocalActor); // 0x00000001821D6DE0-0x00000001821D6E60
	private void Update(); // 0x00000001821D6E60-0x00000001821D6FF0
	private bool InRange(ActorDependencyVolume inVolume); // 0x00000001821D69E0-0x00000001821D6DE0
	private Vector3 GetRelativePosition(ActorDependencyVolume inVolume); // 0x00000001821D68A0-0x00000001821D69E0
	private bool ValidDependencies(ActorDependencyVolume inVolume); // 0x00000001821D7320-0x00000001821D7730
	private bool ValidAnimation(ActorDependencyVolume inVolume); // 0x00000001821D6FF0-0x00000001821D7050
	private bool ValidClothingItem(ActorDependencyVolume inVolume); // 0x00000001821D7180-0x00000001821D7320
	private bool ValidBodyPart(ActorDependencyVolume inVolume); // 0x0000000180380B60-0x0000000180380B70
	private bool ValidClass(ActorDependencyVolume inVolume); // 0x00000001821D7050-0x00000001821D7180
	private bool ValidInventory(ActorDependencyVolume inVolume); // 0x00000001821D7850-0x00000001821D78B0
	private bool ValidFaction(ActorDependencyVolume inVolume); // 0x00000001821D7730-0x00000001821D7790
	private bool ValidFamiliar(ActorDependencyVolume inVolume); // 0x00000001821D77F0-0x00000001821D7850
	private bool ValidFamiliarClass(ActorDependencyVolume inVolume); // 0x00000001821D7790-0x00000001821D77F0
	private bool ValidObjectiveCompleted(ActorDependencyVolume inVolume); // 0x00000001821D78B0-0x00000001821D7910
	private bool ValidExperience(ActorDependencyVolume inVolume); // 0x0000000180380B60-0x0000000180380B70
}

