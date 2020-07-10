/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[CreateAssetMenu] // 0x00000001800B36B0-0x00000001800B36C0
public class FeralAnimationEvents : ScriptableObject // TypeDefIndex: 10061
{
	// Fields
	[NonSerialized]
	private static Dictionary<string, EventInfo> _cachedEvents; // 0x00
	[NonSerialized]
	private static bool _eventsCached; // 0x08
	public List<AnimationEventInfo> animationEventInfos; // 0x18

	// Properties
	public static Dictionary<string, EventInfo> cachedEvents { get; } // 0x00000001814A7A20-0x00000001814A7D50 

	// Nested types
	public enum EFXPlayState // TypeDefIndex: 10062
	{
		PLAY = 0,
		PLAY_ONESHOT = 1,
		KILL = 2
	}

	public enum EFXSpawnState // TypeDefIndex: 10063
	{
		NONE = 0,
		SPAWN = 1,
		DESPAWN = 2
	}

	[Serializable]
	public class EventInfo // TypeDefIndex: 10064
	{
		// Fields
		[Header] // 0x0000000180140B70-0x0000000180140BA0
		public FeralAudioInfo feralAudioInfo; // 0x10
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public string eventFunctionName; // 0x18
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public string eventStringParameter; // 0x20
		[Header] // 0x0000000180140F80-0x0000000180141000
		[RootSelector] // 0x0000000180140F80-0x0000000180141000
		public string fxBundleId; // 0x28
		public string fxAttachmentNode; // 0x30
		public EFXPlayState playState; // 0x38
		public FXInfo fXInfo; // 0x40
		internal EventInfo killEventInfo; // 0x48

		// Constructors
		public EventInfo(); // 0x000000018148C190-0x000000018148C200
	}

	public class FXInfo // TypeDefIndex: 10065
	{
		// Fields
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public GameObject refObject; // 0x10
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public string spawnedFxDefId; // 0x18
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public EFXSpawnState eSpawnState; // 0x20

		// Constructors
		public FXInfo(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	public class AnimationEventInfo // TypeDefIndex: 10066
	{
		// Fields
		public List<EventInfo> eventInfos; // 0x10

		// Constructors
		public AnimationEventInfo(); // 0x000000018148C120-0x000000018148C180
	}

	// Constructors
	public FeralAnimationEvents(); // 0x00000001814A79C0-0x00000001814A7A20
	static FeralAnimationEvents(); // 0x00000001814A7950-0x00000001814A79C0
}

