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
	public class FSpine_AnimatorPerchance : UnityEngine.MonoBehaviour // TypeDefIndex: 9880
	{
		// Fields
		[Tooltip] // 0x00000001800F8C70-0x00000001800F8CA0
		public List<Transform> SpineTransforms; // 0x18
		private List<FSpine_Point> proceduralPoints; // 0x20
		private List<FSpine_Point> helperProceduralPoints; // 0x28
		private List<float> initialBoneDistances; // 0x30
		[Range] // 0x00000001800F8E80-0x00000001800F8EE0
		[Tooltip] // 0x00000001800F8E80-0x00000001800F8EE0
		public float BlendToOriginal; // 0x38
		[Tooltip] // 0x00000001800F91D0-0x00000001800F9200
		public bool ReversedLeadBone; // 0x3C
		private bool reversedChangeFlag; // 0x3D
		[Tooltip] // 0x00000001800FF310-0x00000001800FF340
		public bool RolledBones; // 0x3E
		private Vector3 lookUp; // 0x40
		private bool rolledChangeFlag; // 0x4C
		[Tooltip] // 0x00000001800F9500-0x00000001800F9530
		public bool ConnectWithAnimator; // 0x4D
		[Tooltip] // 0x00000001800F9A90-0x00000001800F9AC0
		public bool AnchoredSpine; // 0x4E
		[Tooltip] // 0x00000001800F9D20-0x00000001800F9D50
		public Transform AnchorRoot; // 0x50
		[Tooltip] // 0x00000001800F9FC0-0x00000001800F9FF0
		public bool QueueToLastUpdate; // 0x58
		[Tooltip] // 0x00000001800FA1E0-0x00000001800FA210
		public bool PositionsNotAnimated; // 0x59
		public List<bool> SelectivePosNotAnimated; // 0x60
		[Tooltip] // 0x00000001800FA490-0x00000001800FA4C0
		public bool RotationsNotAnimated; // 0x68
		public List<bool> SelectiveRotNotAnimated; // 0x70
		private int leadingBoneIndex; // 0x78
		private int endingBoneIndex; // 0x7C
		private int reverser; // 0x80
		private List<FSpine_Point> staticCoordinates; // 0x88
		private List<FSpine_Point> staticCoordinatesBaseRef; // 0x90
		private List<FSpine_Point> referencePoses; // 0x98
		private FSpine_FixingSet spineLookDirectionsSet; // 0xA0
		[Tooltip] // 0x00000001800FA770-0x00000001800FA7A0
		public List<Vector3> ManualRotationOffsets; // 0xA8
		[Tooltip] // 0x00000001800FA770-0x00000001800FA7A0
		public List<Vector3> ManualPositionOffsets; // 0xB0
		[Tooltip] // 0x00000001800FAA10-0x00000001800FAA40
		public bool RoundCorrection; // 0xB8
		private bool wasRoundCorrection; // 0xB9
		[Tooltip] // 0x00000001800FC010-0x00000001800FC040
		public bool StartAfterTPose; // 0xBA
		[Tooltip] // 0x0000000180100030-0x0000000180100060
		public bool RefinedCorrection; // 0xBB
		private Quaternion initialRotation; // 0xBC
		private Vector3 previousScale; // 0xCC
		private Transform[] anchorHelpers; // 0xD8
		private Transform anchorsContainer; // 0xE0
		private bool wasSourceAnimation; // 0xE8
		private List<float> StaticYOffsets; // 0xF0
		private bool initialized; // 0xF8
		private Vector3 previousPos; // 0xFC
		[Range] // 0x00000001800FC220-0x00000001800FC270
		[Tooltip] // 0x00000001800FC220-0x00000001800FC270
		public float PosSmoother; // 0x108
		[Range] // 0x00000001800FC550-0x00000001800FC5A0
		[Tooltip] // 0x00000001800FC550-0x00000001800FC5A0
		public float RotSmoother; // 0x10C
		[Range] // 0x00000001800FC870-0x00000001800FC8C0
		[Tooltip] // 0x00000001800FC870-0x00000001800FC8C0
		public float AngleLimit; // 0x110
		[Range] // 0x00000001800FCBA0-0x00000001800FCBF0
		[Tooltip] // 0x00000001800FCBA0-0x00000001800FCBF0
		public float LimitSmoother; // 0x114
		[Range] // 0x00000001800FD090-0x00000001800FD0E0
		[Tooltip] // 0x00000001800FD090-0x00000001800FD0E0
		public float StraightenSpeed; // 0x118
		public bool TurboStraighten; // 0x11C
		[Range] // 0x00000001800FD270-0x00000001800FD2D0
		[Tooltip] // 0x00000001800FD270-0x00000001800FD2D0
		public float GoBackSpeed; // 0x120
		[Tooltip] // 0x00000001800FD720-0x00000001800FD750
		public Vector3 PivotOffset; // 0x124
	
		// Nested types
		[Serializable]
		public class FSpine_Point // TypeDefIndex: 9881
		{
			// Fields
			public Vector3 Position; // 0x10
			public Quaternion Rotation; // 0x1C
	
			// Constructors
			public FSpine_Point(); // 0x0000000181B67B90-0x0000000181B67C30
	
			// Methods
			public Vector3 TransformDirection(Vector3 dir); // 0x0000000181B67990-0x0000000181B67A40
		}
	
		[Serializable]
		public class FSpine_FixingSet // TypeDefIndex: 9882
		{
			// Fields
			public List<Vector3> Current; // 0x10
			public List<Vector3> Initial; // 0x18
			public List<Vector3> Rounded; // 0x20
			public List<Vector3> Reversed; // 0x28
			public List<Vector3> RoundedReversed; // 0x30
	
			// Constructors
			public FSpine_FixingSet(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void AddToAllNormal(Vector3 v); // 0x0000000181B675E0-0x0000000181B676F0
			internal FSpine_FixingSet Init(); // 0x0000000181B676F0-0x0000000181B677D0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <InitTPoseStartOffset>d__52 : IEnumerator<object> // TypeDefIndex: 9883
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public FSpine_AnimatorPerchance <>4__this; // 0x20
			private int <counter>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <InitTPoseStartOffset>d__52(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181B71030-0x0000000181B710E0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181B710E0-0x0000000181B71130
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ReactivateMe>d__77 : IEnumerator<object> // TypeDefIndex: 9884
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public FSpine_AnimatorPerchance <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ReactivateMe>d__77(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181B71330-0x0000000181B71410
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181B71410-0x0000000181B71460
		}
	
		// Constructors
		public FSpine_AnimatorPerchance(); // 0x0000000181B673B0-0x0000000181B674D0
	
		// Methods
		private void Init(); // 0x0000000181B615C0-0x0000000181B61670
		protected void ComputePredefinedVariables(); // 0x0000000181B5F670-0x0000000181B60BA0
		protected virtual void PrepareSpinePoints(); // 0x0000000181B64C50-0x0000000181B65650
		protected virtual void ConfigureBonesTransforms(); // 0x0000000181B60BA0-0x0000000181B60D60
		protected void Start(); // 0x0000000181B66C40-0x0000000181B66CE0
		[IteratorStateMachine] // 0x0000000180100FB0-0x0000000180101000
		private IEnumerator InitTPoseStartOffset(); // 0x0000000181B61560-0x0000000181B615C0
		private void UpdateReverseHelpVariables(); // 0x0000000181B67320-0x0000000181B673B0
		private void ReposeSpineAccord(); // 0x0000000181B65F80-0x0000000181B65FC0
		private void ReposeSpine(); // 0x0000000181B65FC0-0x0000000181B66900
		private void LateUpdate(); // 0x0000000181B61670-0x0000000181B64A60
		protected virtual void CalculateMotion(); // 0x0000000181B5E8A0-0x0000000181B5E960
		private void CalculateSpineBehaviourPosition(int index); // 0x0000000181B5E960-0x0000000181B5ECB0
		private void CalculateSpineBehaviourRotation(int index); // 0x0000000181B5ECB0-0x0000000181B5F400
		protected virtual Quaternion CalculateTargetRotation(FSpine_Point otherSpinePoint = null, FSpine_Point currentSpinePoint = null, int index = 0 /* Metadata: 0x00745FF7 */); // 0x0000000181B5F400-0x0000000181B5F670
		private void RefreshRefDirsOnReverse(); // 0x0000000181B65CB0-0x0000000181B65E00
		private void RefreshDistances(); // 0x0000000181B656B0-0x0000000181B65A50
		private float SmootherValue(float val); // 0x0000000181B66BD0-0x0000000181B66C40
		protected Vector3 RoundPosDiff(Vector3 pos, int digits = 1 /* Metadata: 0x00745FFB */); // 0x0000000181B66900-0x0000000181B669F0
		private Vector3 RoundToBiggestValue(Vector3 vec); // 0x0000000181B669F0-0x0000000181B66BD0
		private void DrawFatRay(Vector3 origin, Vector3 dir); // 0x0000000181B61160-0x0000000181B61560
		private void DrawFatLine(Vector3 origin, Vector3 dir); // 0x0000000181B60D60-0x0000000181B61160
		public void RefreshSelectivePosNotAnimated(); // 0x0000000181B65E00-0x0000000181B65EC0
		public void RefreshSelectiveRotNotAnimated(); // 0x0000000181B65EC0-0x0000000181B65F80
		public void RefreshManualPosOffs(); // 0x0000000181B65A50-0x0000000181B65B80
		public void RefreshManualRotOffs(); // 0x0000000181B65B80-0x0000000181B65CB0
		public void OnDestroy(); // 0x0000000181B64A60-0x0000000181B64C50
		public void TryAutoCorrect(Transform head = null); // 0x0000000181B66CE0-0x0000000181B67320
		public void DevLog(); // 0x00000001803581E0-0x00000001803581F0
		[IteratorStateMachine] // 0x0000000180101130-0x0000000180101180
		public IEnumerator ReactivateMe(); // 0x0000000181B65650-0x0000000181B656B0
	}
}
