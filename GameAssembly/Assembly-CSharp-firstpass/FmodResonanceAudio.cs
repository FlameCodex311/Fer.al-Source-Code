/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FMOD;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

public static class FmodResonanceAudio // TypeDefIndex: 9285
{
	// Fields
	public const float maxGainDb = 24f; // Metadata: 0x00744F60
	public const float minGainDb = -24f; // Metadata: 0x00744F64
	public const float maxReverbBrightness = 1f; // Metadata: 0x00744F68
	public const float minReverbBrightness = -1f; // Metadata: 0x00744F6C
	public const float maxReverbTime = 3f; // Metadata: 0x00744F70
	public const float maxReflectivity = 2f; // Metadata: 0x00744F74
	private static readonly Matrix4x4 flipZ; // 0x00
	private static readonly string listenerPluginName; // 0x40
	private static readonly int roomPropertiesSize; // 0x48
	private static readonly int roomPropertiesIndex; // 0x4C
	private static Bounds bounds; // 0x50
	private static List<FmodResonanceAudioRoom> enabledRooms; // 0x68
	private static VECTOR listenerPositionFmod; // 0x70
	private static DSP listenerPlugin; // 0x80

	// Properties
	private static DSP ListenerPlugin { get; } // 0x0000000181651600-0x00000001816516D0 

	// Nested types
	private struct RoomProperties // TypeDefIndex: 9286
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
	static FmodResonanceAudio(); // 0x00000001816513A0-0x0000000181651600

	// Methods
	public static void UpdateAudioRoom(FmodResonanceAudioRoom room, bool roomEnabled); // 0x0000000181651030-0x00000001816513A0
	public static bool IsListenerInsideRoom(FmodResonanceAudioRoom room); // 0x0000000181650D30-0x0000000181651030
	private static float ConvertAmplitudeFromDb(float db); // 0x0000000181650150-0x00000001816501C0
	private static void ConvertAudioTransformFromUnity(ref Vector3 position, ref Quaternion rotation); // 0x00000001816501C0-0x0000000181650530
	private static byte[] GetBytes(IntPtr ptr, int length); // 0x0000000181650530-0x00000001816505E0
	private static RoomProperties GetRoomProperties(FmodResonanceAudioRoom room); // 0x00000001816505E0-0x0000000181650890
	private static DSP Initialize(); // 0x0000000181650890-0x0000000181650D30
}

