/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using UnityEngine.Playables;

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

internal sealed class CinemachineMixer : PlayableBehaviour // TypeDefIndex: 7421
{
	// Fields
	private CinemachineBrain mBrain; // 0x10
	private int mBrainOverrideId; // 0x18
	private bool mPlaying; // 0x1C
	private float mLastOverrideFrame; // 0x20

	// Nested types
	private struct ClipInfo // TypeDefIndex: 7422
	{
		// Fields
		public ICinemachineCamera vcam; // 0x00
		public float weight; // 0x08
		public double localTime; // 0x10
		public double duration; // 0x18
	}

	// Constructors
	public CinemachineMixer(); // 0x0000000181FF2780-0x0000000181FF2790

	// Methods
	public override void OnPlayableDestroy(Playable playable); // 0x0000000181FF2160-0x0000000181FF21F0
	public override void PrepareFrame(Playable playable, FrameData info); // 0x0000000181FF21F0-0x0000000181FF2220
	public override void ProcessFrame(Playable playable, FrameData info, object playerData); // 0x0000000181FF2220-0x0000000181FF2780
	private float GetDeltaTime(float deltaTime); // 0x0000000181FF20B0-0x0000000181FF2160
}

