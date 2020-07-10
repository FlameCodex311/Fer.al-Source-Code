/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 56: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7165-7238

namespace CodeStage.AntiCheat.Detectors
{
	[AddComponentMenu] // 0x00000001800F2640-0x00000001800F26B0
	[DisallowMultipleComponent] // 0x00000001800F2640-0x00000001800F26B0
	[HelpURL] // 0x00000001800F2640-0x00000001800F26B0
	public class WallHackDetector : ACTkDetectorBase<CodeStage.AntiCheat.Detectors.WallHackDetector> // TypeDefIndex: 7227
	{
		// Fields
		public const string ComponentName = "WallHack Detector"; // Metadata: 0x007414AE
		internal const string FinalLogPrefix = "[ACTk] WallHack Detector: "; // Metadata: 0x007414C3
		internal const string WireframeShaderName = "Hidden/ACTk/WallHackTexture"; // Metadata: 0x007414E1
		private const string ServiceContainerName = "[WH Detector Service]"; // Metadata: 0x00741500
		private const int ShaderTextureSize = 4; // Metadata: 0x00741519
		private const int RenderTextureSize = 4; // Metadata: 0x0074151D
		private const int ColorsDifferenceThreshold = 5; // Metadata: 0x00741521
		private readonly Vector3 rigidPlayerVelocity; // 0x48
		private readonly WaitForEndOfFrame waitForEndOfFrame; // 0x58
		[SerializeField] // 0x00000001800F28E0-0x00000001800F2920
		[Tooltip] // 0x00000001800F28E0-0x00000001800F2920
		private bool checkRigidbody; // 0x60
		[SerializeField] // 0x00000001800F2BD0-0x00000001800F2C10
		[Tooltip] // 0x00000001800F2BD0-0x00000001800F2C10
		private bool checkController; // 0x61
		[SerializeField] // 0x00000001800F2E90-0x00000001800F2ED0
		[Tooltip] // 0x00000001800F2E90-0x00000001800F2ED0
		private bool checkWireframe; // 0x62
		[SerializeField] // 0x00000001800F3010-0x00000001800F3050
		[Tooltip] // 0x00000001800F3010-0x00000001800F3050
		private bool checkRaycast; // 0x63
		[Range] // 0x00000001800F32A0-0x00000001800F3300
		[Tooltip] // 0x00000001800F32A0-0x00000001800F3300
		public int wireframeDelay; // 0x64
		[Range] // 0x00000001800F3560-0x00000001800F35C0
		[Tooltip] // 0x00000001800F3560-0x00000001800F35C0
		public int raycastDelay; // 0x68
		[Tooltip] // 0x00000001800F3850-0x00000001800F3880
		public Vector3 spawnPosition; // 0x6C
		[Tooltip] // 0x00000001800F3B30-0x00000001800F3B60
		public byte maxFalsePositives; // 0x78
		private GameObject serviceContainer; // 0x80
		private GameObject solidWall; // 0x88
		private GameObject thinWall; // 0x90
		private Camera wfCamera; // 0x98
		private MeshRenderer foregroundRenderer; // 0xA0
		private MeshRenderer backgroundRenderer; // 0xA8
		private Color wfColor1; // 0xB0
		private Color wfColor2; // 0xC0
		private Shader wfShader; // 0xD0
		private Material wfMaterial; // 0xD8
		private Texture2D shaderTexture; // 0xE0
		private Texture2D targetTexture; // 0xE8
		private RenderTexture renderTexture; // 0xF0
		private int whLayer; // 0xF8
		private int raycastMask; // 0xFC
		private Rigidbody rigidPlayer; // 0x100
		private CharacterController charControllerPlayer; // 0x108
		private float charControllerVelocity; // 0x110
		private byte rigidbodyDetections; // 0x114
		private byte controllerDetections; // 0x115
		private byte wireframeDetections; // 0x116
		private byte raycastDetections; // 0x117
		private bool wireframeDetected; // 0x118
		private readonly RaycastHit[] rayHits; // 0x120
	
		// Properties
		public bool CheckRigidbody { get; set; } // 0x00000001804785B0-0x00000001804785C0 0x0000000181BBBF60-0x0000000181BBBFF0
		public bool CheckController { get; set; } // 0x0000000180478640-0x0000000180478650 0x0000000181BBBE40-0x0000000181BBBED0
		public bool CheckWireframe { get; set; } // 0x0000000180AD7CB0-0x0000000180AD7CC0 0x0000000181BBBFF0-0x0000000181BBC080
		public bool CheckRaycast { get; set; } // 0x0000000180AD7CA0-0x0000000180AD7CB0 0x0000000181BBBED0-0x0000000181BBBF60
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <InitDetector>d__71 : IEnumerator<object> // TypeDefIndex: 7228
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public WallHackDetector <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <InitDetector>d__71(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181BB7DA0-0x0000000181BB7E50
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181BB7E50-0x0000000181BB7EA0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <CaptureFrame>d__76 : IEnumerator<object> // TypeDefIndex: 7229
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public WallHackDetector <>4__this; // 0x20
			private RenderTexture <previousActive>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <CaptureFrame>d__76(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181BB7670-0x0000000181BB7D50
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181BB7D50-0x0000000181BB7DA0
		}
	
		// Constructors
		private WallHackDetector(); // 0x0000000181BBBD30-0x0000000181BBBE40
	
		// Methods
		public static WallHackDetector AddToSceneOrGetExisting(); // 0x0000000181BB7F40-0x0000000181BB7F70
		public static WallHackDetector StartDetection(); // 0x0000000181BB95D0-0x0000000181BB97E0
		public static WallHackDetector StartDetection(Action callback); // 0x0000000181BB94C0-0x0000000181BB95D0
		public static WallHackDetector StartDetection(Action callback, Vector3 spawnPosition); // 0x0000000181BB9870-0x0000000181BB9930
		public static WallHackDetector StartDetection(Action callback, Vector3 spawnPosition, byte maxFalsePositives); // 0x0000000181BB97E0-0x0000000181BB9870
		public static void StopDetection(); // 0x0000000181BBA000-0x0000000181BBA100
		public static void Dispose(); // 0x0000000181BB8280-0x0000000181BB8380
		protected override void OnDestroy(); // 0x0000000181BB88A0-0x0000000181BB8A20
		private void FixedUpdate(); // 0x0000000181BB8380-0x0000000181BB8480
		private void Update(); // 0x0000000181BBBB90-0x0000000181BBBD30
		private WallHackDetector StartDetectionInternal(Action callback, Vector3 servicePosition, byte falsePositivesInRow); // 0x0000000181BB92E0-0x0000000181BB94C0
		protected override void StartDetectionAutomatically(); // 0x0000000181BB92A0-0x0000000181BB92E0
		protected override void PauseDetector(); // 0x0000000181BB8A20-0x0000000181BB8AE0
		protected override bool ResumeDetector(); // 0x0000000181BB8AE0-0x0000000181BB8C50
		protected override void StopDetectionInternal(); // 0x0000000181BB9FA0-0x0000000181BBA000
		protected override string GetComponentName(); // 0x0000000181BB84F0-0x0000000181BB8520
		private void UpdateServiceContainer(); // 0x0000000181BBA3E0-0x0000000181BBBB90
		[IteratorStateMachine] // 0x00000001800F3CD0-0x00000001800F3D20
		private IEnumerator InitDetector(); // 0x0000000181BB86A0-0x0000000181BB8700
		private void StartRigidModule(); // 0x0000000181BB99C0-0x0000000181BB9E70
		private void StartControllerModule(); // 0x0000000181BB8EF0-0x0000000181BB92A0
		private void StartWireframeModule(); // 0x0000000181BB9E70-0x0000000181BB9F10
		private void ShootWireframeModule(); // 0x0000000181BB8E50-0x0000000181BB8EF0
		[IteratorStateMachine] // 0x00000001800F3ED0-0x00000001800F3F20
		private IEnumerator CaptureFrame(); // 0x0000000181BB7F70-0x0000000181BB7FD0
		private bool ColorsDiffer(Color a, Color b); // 0x0000000181BB7FD0-0x0000000181BB8100
		private void StartRaycastModule(); // 0x0000000181BB9930-0x0000000181BB99C0
		private void ShootRaycastModule(); // 0x0000000181BB8C50-0x0000000181BB8E50
		private void StopRigidModule(); // 0x0000000181BBA140-0x0000000181BBA220
		private void StopControllerModule(); // 0x0000000181BB9F10-0x0000000181BB9FA0
		private void StopWireframeModule(); // 0x0000000181BBA220-0x0000000181BBA260
		private void StopRaycastModule(); // 0x0000000181BBA100-0x0000000181BBA140
		private void InitRigidModule(); // 0x0000000181BB8700-0x0000000181BB88A0
		private void InitControllerModule(); // 0x0000000181BB8520-0x0000000181BB86A0
		private void UninitRigidModule(); // 0x0000000181BBA320-0x0000000181BBA3E0
		private void UninitControllerModule(); // 0x0000000181BBA260-0x0000000181BBA320
		private bool Detect(); // 0x0000000181BB8230-0x0000000181BB8280
		private static Color32 GenerateColor(); // 0x0000000181BB8480-0x0000000181BB84F0
		private static bool ColorsSimilar(Color32 c1, Color32 c2, int tolerance); // 0x0000000181BB8100-0x0000000181BB8230
	}
}
