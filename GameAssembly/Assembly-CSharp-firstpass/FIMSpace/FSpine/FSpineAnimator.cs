/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FIMSpace.FSpine
{
	public class FSpineAnimator : UnityEngine.MonoBehaviour // TypeDefIndex: 9875
	{
		// Fields
		[Tooltip] // 0x00000001800F8C70-0x00000001800F8CA0
		public List<Transform> SpineTransforms; // 0x18
		private List<FSpine_Point> proceduralPoints; // 0x20
		private List<FSpine_Point> ProceduralReferencePose; // 0x28
		private List<FSpine_Point> helperProceduralPoints; // 0x30
		private List<float> initialBoneDistances; // 0x38
		[Range] // 0x00000001800F8E80-0x00000001800F8EE0
		[Tooltip] // 0x00000001800F8E80-0x00000001800F8EE0
		public float BlendToOriginal; // 0x40
		[Tooltip] // 0x00000001800F91D0-0x00000001800F9200
		public bool LastBoneLeading; // 0x44
		private bool reversedChangeFlag; // 0x45
		private Vector3 lookUp; // 0x48
		[Tooltip] // 0x00000001800F9260-0x00000001800F9290
		public bool InversedVerticalRotation; // 0x54
		[Tooltip] // 0x00000001800F9500-0x00000001800F9530
		public bool ConnectWithAnimator; // 0x55
		[Tooltip] // 0x00000001800F9610-0x00000001800F9640
		public bool AnimateLeadingBone; // 0x56
		[Tooltip] // 0x00000001800F97D0-0x00000001800F9800
		public bool LeadingAnimateAfterMotion; // 0x57
		[Tooltip] // 0x00000001800F9900-0x00000001800F9930
		public bool PhysicalUpdate; // 0x58
		[Tooltip] // 0x00000001800F9A90-0x00000001800F9AC0
		public bool AnchorToThis; // 0x59
		[Tooltip] // 0x00000001800F9D20-0x00000001800F9D50
		public Transform AnchorRoot; // 0x60
		[Tooltip] // 0x00000001800F9E90-0x00000001800F9EC0
		public Vector3 CustomAnchorRotationOffset; // 0x68
		[Tooltip] // 0x00000001800F9FC0-0x00000001800F9FF0
		public bool QueueToLastUpdate; // 0x74
		[Tooltip] // 0x00000001800FA1E0-0x00000001800FA210
		public bool PositionsNotAnimated; // 0x75
		public List<bool> SelectivePosNotAnimated; // 0x78
		[Tooltip] // 0x00000001800FA490-0x00000001800FA4C0
		public bool RotationsNotAnimated; // 0x80
		public List<bool> SelectiveRotNotAnimated; // 0x88
		private int leadingBoneIndex; // 0x90
		private int reverser; // 0x94
		private int adjuster; // 0x98
		private List<FSpine_Point> staticCoordinates; // 0xA0
		private FSpine_FixingSet spineLookDirectionsSet; // 0xA8
		[Tooltip] // 0x00000001800FA640-0x00000001800FA670
		public List<Vector3> lookDirectionsAdditiveCorrection; // 0xB0
		[Tooltip] // 0x00000001800FA770-0x00000001800FA7A0
		public List<Vector3> ManualRotationOffsets; // 0xB8
		[Tooltip] // 0x00000001800FA770-0x00000001800FA7A0
		public List<Vector3> ManualPositionOffsets; // 0xC0
		[Tooltip] // 0x00000001800FAA10-0x00000001800FAA40
		public bool RoundCorrection; // 0xC8
		private bool wasRoundCorrection; // 0xC9
		[Tooltip] // 0x00000001800FAC20-0x00000001800FAC50
		public bool UnifyCorrection; // 0xCA
		private bool wasUnified; // 0xCB
		[Tooltip] // 0x00000001800FC010-0x00000001800FC040
		public bool StartAfterTPose; // 0xCC
		private Vector3 previousScale; // 0xD0
		private Transform[] anchorHelpers; // 0xE0
		private Transform anchorsContainer; // 0xE8
		private bool wasSourceAnimation; // 0xF0
		private bool initialized; // 0xF1
		private Vector3 previousPos; // 0xF4
		[Range] // 0x00000001800FC220-0x00000001800FC270
		[Tooltip] // 0x00000001800FC220-0x00000001800FC270
		public float PosSmoother; // 0x100
		[Range] // 0x00000001800FC550-0x00000001800FC5A0
		[Tooltip] // 0x00000001800FC550-0x00000001800FC5A0
		public float RotSmoother; // 0x104
		[Range] // 0x00000001800FC870-0x00000001800FC8C0
		[Tooltip] // 0x00000001800FC870-0x00000001800FC8C0
		public float AngleLimit; // 0x108
		[Range] // 0x00000001800FCBA0-0x00000001800FCBF0
		[Tooltip] // 0x00000001800FCBA0-0x00000001800FCBF0
		public float LimitSmoother; // 0x10C
		[Range] // 0x00000001800FD090-0x00000001800FD0E0
		[Tooltip] // 0x00000001800FD090-0x00000001800FD0E0
		public float StraightenSpeed; // 0x110
		public bool TurboStraighten; // 0x114
		[Range] // 0x00000001800FD270-0x00000001800FD2D0
		[Tooltip] // 0x00000001800FD270-0x00000001800FD2D0
		public float GoBackSpeed; // 0x118
		[Tooltip] // 0x00000001800FD4E0-0x00000001800FD510
		public Vector3 MainPivotOffset; // 0x11C
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public Transform mainPivotOffsetTransform; // 0x128
		[Tooltip] // 0x00000001800FD720-0x00000001800FD750
		public Vector3 SegmentsPivotOffset; // 0x130
		[Tooltip] // 0x00000001800FD840-0x00000001800FD870
		public float DistancesMultiplier; // 0x13C
		public Transform rotationRef; // 0x140
	
		// Nested types
		[Serializable]
		public class FSpine_Point // TypeDefIndex: 9876
		{
			// Fields
			public Vector3 Position; // 0x10
			public Quaternion Rotation; // 0x1C
	
			// Constructors
			public FSpine_Point(); // 0x0000000181B67AF0-0x0000000181B67B90
	
			// Methods
			public Vector3 TransformDirection(Vector3 dir); // 0x0000000181B67A40-0x0000000181B67AF0
		}
	
		[Serializable]
		public class FSpine_FixingSet // TypeDefIndex: 9877
		{
			// Fields
			public List<Vector3> Current; // 0x10
			public List<Vector3> Initial; // 0x18
			public List<Vector3> Rounded; // 0x20
			public List<Vector3> Reversed; // 0x28
			public List<Vector3> RoundedReversed; // 0x30
			public List<Vector3> Unified; // 0x38
	
			// Constructors
			public FSpine_FixingSet(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			public List<Vector3> SetUnified(List<Vector3> toUnify); // 0x0000000181B678B0-0x0000000181B67990
			internal void AddToAllNormal(Vector3 v); // 0x0000000181B674D0-0x0000000181B675E0
			internal FSpine_FixingSet Init(); // 0x0000000181B677D0-0x0000000181B678B0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <InitTPoseStartOffset>d__59 : IEnumerator<object> // TypeDefIndex: 9878
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public FSpineAnimator <>4__this; // 0x20
			private int <counter>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <InitTPoseStartOffset>d__59(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181B71130-0x0000000181B711F0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181B711F0-0x0000000181B71240
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <LateFixedUpdate>d__63 : IEnumerator<object> // TypeDefIndex: 9879
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public FSpineAnimator <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <LateFixedUpdate>d__63(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181B71240-0x0000000181B712E0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181B712E0-0x0000000181B71330
		}
	
		// Constructors
		public FSpineAnimator(); // 0x00000001815E48E0-0x00000001815E4A50
	
		// Methods
		private void Init(); // 0x00000001815DF600-0x00000001815DF6B0
		protected void ComputePredefinedVariables(); // 0x00000001815DCFB0-0x00000001815DE240
		protected virtual void PrepareSpinePoints(); // 0x00000001815DFF10-0x00000001815E0930
		protected virtual void ConfigureBonesTransforms(); // 0x00000001815DE240-0x00000001815DE400
		private void OnEnable(); // 0x00000001815DFA70-0x00000001815DFAC0
		private void OnDisable(); // 0x00000001815DFA30-0x00000001815DFA70
		protected void Start(); // 0x00000001815E3FD0-0x00000001815E4110
		[IteratorStateMachine] // 0x00000001800FDAC0-0x00000001800FDB10
		private IEnumerator InitTPoseStartOffset(); // 0x00000001815DF590-0x00000001815DF600
		private void UpdateReverseHelpVariables(); // 0x00000001815E4860-0x00000001815E48E0
		private void ReposeSpine(); // 0x00000001815E1750-0x00000001815E1940
		private void LateUpdate(); // 0x00000001815DF720-0x00000001815DF730
		[IteratorStateMachine] // 0x00000001800FDDA0-0x00000001800FDDF0
		private IEnumerator LateFixedUpdate(); // 0x00000001815DF6B0-0x00000001815DF720
		private void SpineMotion(); // 0x00000001815E1D30-0x00000001815E3FD0
		private FSpine_Point GetLeadingBoneCoordinates(); // 0x00000001815DEC50-0x00000001815DF590
		protected virtual void CalculateMotion(); // 0x00000001815DC2E0-0x00000001815DC3A0
		private void CalculateSpineBehaviourPosition(int index); // 0x00000001815DC3A0-0x00000001815DC710
		private void CalculateSpineBehaviourRotation(int index); // 0x00000001815DC710-0x00000001815DCFB0
		private void RefreshRefDirsOnReverse(); // 0x00000001815E14E0-0x00000001815E15C0
		private void RefreshDistances(); // 0x00000001815E0EE0-0x00000001815E1280
		private float SmootherValue(float val); // 0x00000001815E1CC0-0x00000001815E1D30
		protected Vector3 RoundPosDiff(Vector3 pos, int digits = 1 /* Metadata: 0x00745FF3 */); // 0x00000001815E19F0-0x00000001815E1AE0
		private Vector3 RoundToBiggestValue(Vector3 vec); // 0x00000001815E1AE0-0x00000001815E1CC0
		private void DrawFatRay(Vector3 origin, Vector3 dir); // 0x00000001815DE850-0x00000001815DEC50
		private void DrawBoneLine(Vector3 origin, Vector3 dir); // 0x00000001815DE450-0x00000001815DE850
		public void RefreshSelectivePosNotAnimated(); // 0x00000001815E15C0-0x00000001815E1680
		public void RefreshSelectiveRotNotAnimated(); // 0x00000001815E1680-0x00000001815E1750
		public void RefreshManualPosOffs(); // 0x00000001815E1280-0x00000001815E13B0
		public void RefreshManualRotOffs(); // 0x00000001815E13B0-0x00000001815E14E0
		public void OnDestroy(); // 0x00000001815DF730-0x00000001815DFA30
		private void RestoreBasePivotChildren(); // 0x00000001815E1940-0x00000001815E19F0
		private void OnValidate(); // 0x00000001815DFAC0-0x00000001815DFF10
		private void RefreshDifferenceReference(); // 0x00000001815E0930-0x00000001815E0EE0
		public void TryAutoCorrect(Transform head = null); // 0x00000001815E4110-0x00000001815E4860
		public void DevLog(); // 0x00000001815DE400-0x00000001815DE450
	}
}
