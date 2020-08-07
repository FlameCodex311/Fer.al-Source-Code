/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[CreateAssetMenu] // 0x00000001801CDAD0-0x00000001801CDAE0
public class FeralAnimationEvents : ScriptableObject // TypeDefIndex: 11551
{
	// Fields
	[NonSerialized]
	private static Dictionary<string, EventInfo> _cachedEvents; // 0x00
	[NonSerialized]
	private static bool _eventsCached; // 0x08
	public List<AnimationEventInfo> animationEventInfos; // 0x18

	// Properties
	public static Dictionary<string, EventInfo> cachedEvents { get; } // 0x0000000180E36C90-0x0000000180E36FB0 

	// Nested types
	public enum EFXPlayState // TypeDefIndex: 11552
	{
		PLAY = 0,
		PLAY_ONESHOT = 1,
		KILL = 2
	}

	public enum EFXSpawnState // TypeDefIndex: 11553
	{
		NONE = 0,
		SPAWN = 1,
		DESPAWN = 2
	}

	[Serializable]
	public class EventInfo // TypeDefIndex: 11554
	{
		// Fields
		[Header] // 0x000000018021B870-0x000000018021B8A0
		public FeralAudioInfo feralAudioInfo; // 0x10
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public string eventFunctionName; // 0x18
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public string eventStringParameter; // 0x20
		[Header] // 0x000000018021BF40-0x000000018021BFC0
		[RootSelector] // 0x000000018021BF40-0x000000018021BFC0
		public string fxBundleId; // 0x28
		public string fxAttachmentNode; // 0x30
		public EFXPlayState playState; // 0x38
		public FXInfo fXInfo; // 0x40
		internal EventInfo killEventInfo; // 0x48

		// Constructors
		public EventInfo(); // 0x0000000180E1FDE0-0x0000000180E1FE50
	}

	public class FXInfo // TypeDefIndex: 11555
	{
		// Fields
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public GameObject refObject; // 0x10
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public string spawnedFxDefId; // 0x18
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public EFXSpawnState eSpawnState; // 0x20

		// Constructors
		public FXInfo(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	public class AnimationEventInfo // TypeDefIndex: 11556
	{
		// Fields
		public List<EventInfo> eventInfos; // 0x10

		// Constructors
		public AnimationEventInfo(); // 0x0000000180E1FD70-0x0000000180E1FDD0
	}

	// Constructors
	public FeralAnimationEvents(); // 0x0000000180E36C30-0x0000000180E36C90
	static FeralAnimationEvents(); // 0x0000000180E36BC0-0x0000000180E36C30
}

