/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FMOD;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

public static class FmodResonanceAudio // TypeDefIndex: 9689
{
	// Fields
	public const float maxGainDb = 24f; // Metadata: 0x0077A26A
	public const float minGainDb = -24f; // Metadata: 0x0077A26E
	public const float maxReverbBrightness = 1f; // Metadata: 0x0077A272
	public const float minReverbBrightness = -1f; // Metadata: 0x0077A276
	public const float maxReverbTime = 3f; // Metadata: 0x0077A27A
	public const float maxReflectivity = 2f; // Metadata: 0x0077A27E
	private static readonly Matrix4x4 flipZ; // 0x00
	private static readonly string listenerPluginName; // 0x40
	private static readonly int roomPropertiesSize; // 0x48
	private static readonly int roomPropertiesIndex; // 0x4C
	private static Bounds bounds; // 0x50
	private static List<FmodResonanceAudioRoom> enabledRooms; // 0x68
	private static VECTOR listenerPositionFmod; // 0x70
	private static DSP listenerPlugin; // 0x80

	// Properties
	private static DSP ListenerPlugin { get; } // 0x0000000180D25380-0x0000000180D25450 

	// Nested types
	private struct RoomProperties // TypeDefIndex: 9690
	{
		// Fields
		public float positionX; // 0x00
		public float positionY; // 0x04
		public float positionZ; // 0x08
		public float rotationX; // 0x0C
		public float rotationY; // 0x10
		public float rotationZ; // 0x14
		public float rotationW; // 0x18
		public float dimensionsX; // 0x1C
		public float dimensionsY; // 0x20
		public float dimensionsZ; // 0x24
		public FmodResonanceAudioRoom.SurfaceMaterial materialLeft; // 0x28
		public FmodResonanceAudioRoom.SurfaceMaterial materialRight; // 0x2C
		public FmodResonanceAudioRoom.SurfaceMaterial materialBottom; // 0x30
		public FmodResonanceAudioRoom.SurfaceMaterial materialTop; // 0x34
		public FmodResonanceAudioRoom.SurfaceMaterial materialFront; // 0x38
		public FmodResonanceAudioRoom.SurfaceMaterial materialBack; // 0x3C
		public float reflectionScalar; // 0x40
		public float reverbGain; // 0x44
		public float reverbTime; // 0x48
		public float reverbBrightness; // 0x4C
	}

	// Constructors
	static FmodResonanceAudio(); // 0x0000000180D25120-0x0000000180D25380

	// Methods
	public static void UpdateAudioRoom(FmodResonanceAudioRoom room, bool roomEnabled); // 0x0000000180D24DB0-0x0000000180D25120
	public static bool IsListenerInsideRoom(FmodResonanceAudioRoom room); // 0x0000000180D24A60-0x0000000180D24DB0
	private static float ConvertAmplitudeFromDb(float db); // 0x0000000180D23DE0-0x0000000180D23E50
	private static void ConvertAudioTransformFromUnity(ref Vector3 position, ref Quaternion rotation); // 0x0000000180D23E50-0x0000000180D241C0
	private static byte[] GetBytes(IntPtr ptr, int length); // 0x0000000180D241C0-0x0000000180D24270
	private static RoomProperties GetRoomProperties(FmodResonanceAudioRoom room); // 0x0000000180D24270-0x0000000180D24520
	private static DSP Initialize(); // 0x0000000180D24520-0x0000000180D24A60
}

