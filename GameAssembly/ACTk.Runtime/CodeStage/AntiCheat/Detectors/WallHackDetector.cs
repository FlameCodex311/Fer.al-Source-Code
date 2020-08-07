/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 57: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7331-7404

namespace CodeStage.AntiCheat.Detectors
{
	[AddComponentMenu] // 0x00000001802543A0-0x0000000180254410
	[DisallowMultipleComponent] // 0x00000001802543A0-0x0000000180254410
	[HelpURL] // 0x00000001802543A0-0x0000000180254410
	public class WallHackDetector : ACTkDetectorBase<CodeStage.AntiCheat.Detectors.WallHackDetector> // TypeDefIndex: 7393
	{
		// Fields
		public const string ComponentName = "WallHack Detector"; // Metadata: 0x0077619C
		internal const string FinalLogPrefix = "[ACTk] WallHack Detector: "; // Metadata: 0x007761B1
		internal const string WireframeShaderName = "Hidden/ACTk/WallHackTexture"; // Metadata: 0x007761CF
		private const string ServiceContainerName = "[WH Detector Service]"; // Metadata: 0x007761EE
		private const int ShaderTextureSize = 4; // Metadata: 0x00776207
		private const int RenderTextureSize = 4; // Metadata: 0x0077620B
		private const int ColorsDifferenceThreshold = 5; // Metadata: 0x0077620F
		private readonly Vector3 rigidPlayerVelocity; // 0x48
		private readonly WaitForEndOfFrame waitForEndOfFrame; // 0x58
		[SerializeField] // 0x0000000180254650-0x0000000180254690
		[Tooltip] // 0x0000000180254650-0x0000000180254690
		private bool checkRigidbody; // 0x60
		[SerializeField] // 0x0000000180254820-0x0000000180254860
		[Tooltip] // 0x0000000180254820-0x0000000180254860
		private bool checkController; // 0x61
		[SerializeField] // 0x0000000180254B00-0x0000000180254B40
		[Tooltip] // 0x0000000180254B00-0x0000000180254B40
		private bool checkWireframe; // 0x62
		[SerializeField] // 0x0000000180254E10-0x0000000180254E50
		[Tooltip] // 0x0000000180254E10-0x0000000180254E50
		private bool checkRaycast; // 0x63
		[Range] // 0x0000000180254FB0-0x0000000180255010
		[Tooltip] // 0x0000000180254FB0-0x0000000180255010
		public int wireframeDelay; // 0x64
		[Range] // 0x0000000180255200-0x0000000180255260
		[Tooltip] // 0x0000000180255200-0x0000000180255260
		public int raycastDelay; // 0x68
		[Tooltip] // 0x00000001802554E0-0x0000000180255510
		public Vector3 spawnPosition; // 0x6C
		[Tooltip] // 0x00000001802556B0-0x00000001802556E0
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
		public bool CheckRigidbody { get; set; } // 0x00000001803CE080-0x00000001803CE090 0x000000018188BF70-0x000000018188C000
		public bool CheckController { get; set; } // 0x0000000180459DB0-0x0000000180459DC0 0x000000018188BE50-0x000000018188BEE0
		public bool CheckWireframe { get; set; } // 0x00000001810731A0-0x00000001810731B0 0x000000018188C000-0x000000018188C090
		public bool CheckRaycast { get; set; } // 0x00000001810731B0-0x00000001810731C0 0x000000018188BEE0-0x000000018188BF70
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <InitDetector>d__71 : IEnumerator<object> // TypeDefIndex: 7394
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public WallHackDetector <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <InitDetector>d__71(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000181887E50-0x0000000181887F00
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181887F00-0x0000000181887F50
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <CaptureFrame>d__76 : IEnumerator<object> // TypeDefIndex: 7395
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public WallHackDetector <>4__this; // 0x20
			private RenderTexture <previousActive>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <CaptureFrame>d__76(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000181887740-0x0000000181887E00
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181887E00-0x0000000181887E50
		}
	
		// Constructors
		private WallHackDetector(); // 0x000000018188BD40-0x000000018188BE50
	
		// Methods
		public static WallHackDetector AddToSceneOrGetExisting(); // 0x0000000181887FF0-0x0000000181888020
		public static WallHackDetector StartDetection(); // 0x0000000181889640-0x0000000181889850
		public static WallHackDetector StartDetection(Action callback); // 0x0000000181889540-0x0000000181889640
		public static WallHackDetector StartDetection(Action callback, Vector3 spawnPosition); // 0x00000001818898E0-0x00000001818899A0
		public static WallHackDetector StartDetection(Action callback, Vector3 spawnPosition, byte maxFalsePositives); // 0x0000000181889850-0x00000001818898E0
		public static void StopDetection(); // 0x000000018188A060-0x000000018188A160
		public static void Dispose(); // 0x0000000181888330-0x0000000181888430
		protected override void OnDestroy(); // 0x0000000181888940-0x0000000181888AC0
		private void FixedUpdate(); // 0x0000000181888430-0x0000000181888530
		private void Update(); // 0x000000018188BBA0-0x000000018188BD40
		private WallHackDetector StartDetectionInternal(Action callback, Vector3 servicePosition, byte falsePositivesInRow); // 0x0000000181889360-0x0000000181889540
		protected override void StartDetectionAutomatically(); // 0x0000000181889320-0x0000000181889360
		protected override void PauseDetector(); // 0x0000000181888AC0-0x0000000181888B80
		protected override bool ResumeDetector(); // 0x0000000181888B80-0x0000000181888CF0
		protected override void StopDetectionInternal(); // 0x000000018188A000-0x000000018188A060
		protected override string GetComponentName(); // 0x00000001818885A0-0x00000001818885D0
		private void UpdateServiceContainer(); // 0x000000018188A440-0x000000018188BBA0
		[IteratorStateMachine] // 0x00000001802557D0-0x0000000180255820
		private IEnumerator InitDetector(); // 0x0000000181888750-0x00000001818887B0
		private void StartRigidModule(); // 0x0000000181889A30-0x0000000181889ED0
		private void StartControllerModule(); // 0x0000000181888F80-0x0000000181889320
		private void StartWireframeModule(); // 0x0000000181889ED0-0x0000000181889F70
		private void ShootWireframeModule(); // 0x0000000181888EE0-0x0000000181888F80
		[IteratorStateMachine] // 0x0000000180255A40-0x0000000180255A90
		private IEnumerator CaptureFrame(); // 0x0000000181888020-0x0000000181888080
		private bool ColorsDiffer(Color a, Color b); // 0x0000000181888080-0x00000001818881B0
		private void StartRaycastModule(); // 0x00000001818899A0-0x0000000181889A30
		private void ShootRaycastModule(); // 0x0000000181888CF0-0x0000000181888EE0
		private void StopRigidModule(); // 0x000000018188A1A0-0x000000018188A280
		private void StopControllerModule(); // 0x0000000181889F70-0x000000018188A000
		private void StopWireframeModule(); // 0x000000018188A280-0x000000018188A2C0
		private void StopRaycastModule(); // 0x000000018188A160-0x000000018188A1A0
		private void InitRigidModule(); // 0x00000001818887B0-0x0000000181888940
		private void InitControllerModule(); // 0x00000001818885D0-0x0000000181888750
		private void UninitRigidModule(); // 0x000000018188A380-0x000000018188A440
		private void UninitControllerModule(); // 0x000000018188A2C0-0x000000018188A380
		private bool Detect(); // 0x00000001818882E0-0x0000000181888330
		private static Color32 GenerateColor(); // 0x0000000181888530-0x00000001818885A0
		private static bool ColorsSimilar(Color32 c1, Color32 c2, int tolerance); // 0x00000001818881B0-0x00000001818882E0
	}
}
