/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FIMSpace.FSpine
{
	public class FSpine_AnimatorPerchance : UnityEngine.MonoBehaviour // TypeDefIndex: 10334
	{
		// Fields
		[Tooltip] // 0x00000001801D6C30-0x00000001801D6C60
		public List<Transform> SpineTransforms; // 0x18
		private List<FSpine_Point> proceduralPoints; // 0x20
		private List<FSpine_Point> helperProceduralPoints; // 0x28
		private List<float> initialBoneDistances; // 0x30
		[Range] // 0x00000001801D6ED0-0x00000001801D6F30
		[Tooltip] // 0x00000001801D6ED0-0x00000001801D6F30
		public float BlendToOriginal; // 0x38
		[Tooltip] // 0x00000001801D70E0-0x00000001801D7110
		public bool ReversedLeadBone; // 0x3C
		private bool reversedChangeFlag; // 0x3D
		[Tooltip] // 0x00000001801DDB10-0x00000001801DDB40
		public bool RolledBones; // 0x3E
		private Vector3 lookUp; // 0x40
		private bool rolledChangeFlag; // 0x4C
		[Tooltip] // 0x00000001801D7390-0x00000001801D73C0
		public bool ConnectWithAnimator; // 0x4D
		[Tooltip] // 0x00000001801D7D20-0x00000001801D7D50
		public bool AnchoredSpine; // 0x4E
		[Tooltip] // 0x00000001801D8000-0x00000001801D8030
		public Transform AnchorRoot; // 0x50
		[Tooltip] // 0x00000001801D8370-0x00000001801D83A0
		public bool QueueToLastUpdate; // 0x58
		[Tooltip] // 0x00000001801D8700-0x00000001801D8730
		public bool PositionsNotAnimated; // 0x59
		public List<bool> SelectivePosNotAnimated; // 0x60
		[Tooltip] // 0x00000001801D89C0-0x00000001801D89F0
		public bool RotationsNotAnimated; // 0x68
		public List<bool> SelectiveRotNotAnimated; // 0x70
		private int leadingBoneIndex; // 0x78
		private int endingBoneIndex; // 0x7C
		private int reverser; // 0x80
		private List<FSpine_Point> staticCoordinates; // 0x88
		private List<FSpine_Point> staticCoordinatesBaseRef; // 0x90
		private List<FSpine_Point> referencePoses; // 0x98
		private FSpine_FixingSet spineLookDirectionsSet; // 0xA0
		[Tooltip] // 0x00000001801D8DA0-0x00000001801D8DD0
		public List<Vector3> ManualRotationOffsets; // 0xA8
		[Tooltip] // 0x00000001801D8DA0-0x00000001801D8DD0
		public List<Vector3> ManualPositionOffsets; // 0xB0
		[Tooltip] // 0x00000001801D9090-0x00000001801D90C0
		public bool RoundCorrection; // 0xB8
		private bool wasRoundCorrection; // 0xB9
		[Tooltip] // 0x00000001801D9360-0x00000001801D9390
		public bool StartAfterTPose; // 0xBA
		[Tooltip] // 0x00000001801DEC10-0x00000001801DEC40
		public bool RefinedCorrection; // 0xBB
		private Quaternion initialRotation; // 0xBC
		private Vector3 previousScale; // 0xCC
		private Transform[] anchorHelpers; // 0xD8
		private Transform anchorsContainer; // 0xE0
		private bool wasSourceAnimation; // 0xE8
		private List<float> StaticYOffsets; // 0xF0
		private bool initialized; // 0xF8
		private Vector3 previousPos; // 0xFC
		[Range] // 0x00000001801D96B0-0x00000001801D9700
		[Tooltip] // 0x00000001801D96B0-0x00000001801D9700
		public float PosSmoother; // 0x108
		[Range] // 0x00000001801D98C0-0x00000001801D9910
		[Tooltip] // 0x00000001801D98C0-0x00000001801D9910
		public float RotSmoother; // 0x10C
		[Range] // 0x00000001801D9B00-0x00000001801D9B50
		[Tooltip] // 0x00000001801D9B00-0x00000001801D9B50
		public float AngleLimit; // 0x110
		[Range] // 0x00000001801D9C70-0x00000001801D9CC0
		[Tooltip] // 0x00000001801D9C70-0x00000001801D9CC0
		public float LimitSmoother; // 0x114
		[Range] // 0x00000001801D9ED0-0x00000001801D9F20
		[Tooltip] // 0x00000001801D9ED0-0x00000001801D9F20
		public float StraightenSpeed; // 0x118
		public bool TurboStraighten; // 0x11C
		[Range] // 0x00000001801DA190-0x00000001801DA1F0
		[Tooltip] // 0x00000001801DA190-0x00000001801DA1F0
		public float GoBackSpeed; // 0x120
		[Tooltip] // 0x00000001801DA5E0-0x00000001801DA610
		public Vector3 PivotOffset; // 0x124
	
		// Nested types
		[Serializable]
		public class FSpine_Point // TypeDefIndex: 10335
		{
			// Fields
			public Vector3 Position; // 0x10
			public Quaternion Rotation; // 0x1C
	
			// Constructors
			public FSpine_Point(); // 0x000000018173BD30-0x000000018173BDD0
	
			// Methods
			public Vector3 TransformDirection(Vector3 dir); // 0x000000018173BB30-0x000000018173BBE0
		}
	
		[Serializable]
		public class FSpine_FixingSet // TypeDefIndex: 10336
		{
			// Fields
			public List<Vector3> Current; // 0x10
			public List<Vector3> Initial; // 0x18
			public List<Vector3> Rounded; // 0x20
			public List<Vector3> Reversed; // 0x28
			public List<Vector3> RoundedReversed; // 0x30
	
			// Constructors
			public FSpine_FixingSet(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void AddToAllNormal(Vector3 v); // 0x000000018173B780-0x000000018173B890
			internal FSpine_FixingSet Init(); // 0x000000018173B890-0x000000018173B970
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <InitTPoseStartOffset>d__52 : IEnumerator<object> // TypeDefIndex: 10337
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public FSpine_AnimatorPerchance <>4__this; // 0x20
			private int <counter>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <InitTPoseStartOffset>d__52(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000181744ED0-0x0000000181744F80
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181744F80-0x0000000181744FD0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ReactivateMe>d__77 : IEnumerator<object> // TypeDefIndex: 10338
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public FSpine_AnimatorPerchance <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ReactivateMe>d__77(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001817451D0-0x00000001817452B0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001817452B0-0x0000000181745300
		}
	
		// Constructors
		public FSpine_AnimatorPerchance(); // 0x000000018173B550-0x000000018173B670
	
		// Methods
		private void Init(); // 0x0000000181735A00-0x0000000181735AB0
		protected void ComputePredefinedVariables(); // 0x0000000181733B60-0x0000000181734FF0
		protected virtual void PrepareSpinePoints(); // 0x0000000181738ED0-0x0000000181739870
		protected virtual void ConfigureBonesTransforms(); // 0x0000000181734FF0-0x00000001817351A0
		protected void Start(); // 0x000000018173AE00-0x000000018173AEA0
		[IteratorStateMachine] // 0x00000001801DFF00-0x00000001801DFF50
		private IEnumerator InitTPoseStartOffset(); // 0x00000001817359A0-0x0000000181735A00
		private void UpdateReverseHelpVariables(); // 0x000000018173B4C0-0x000000018173B550
		private void ReposeSpineAccord(); // 0x000000018173A180-0x000000018173A1C0
		private void ReposeSpine(); // 0x000000018173A1C0-0x000000018173AAC0
		private void LateUpdate(); // 0x0000000181735AB0-0x0000000181738CF0
		protected virtual void CalculateMotion(); // 0x0000000181732DB0-0x0000000181732E70
		private void CalculateSpineBehaviourPosition(int index); // 0x0000000181732E70-0x00000001817331B0
		private void CalculateSpineBehaviourRotation(int index); // 0x00000001817331B0-0x00000001817338F0
		protected virtual Quaternion CalculateTargetRotation(FSpine_Point otherSpinePoint = null, FSpine_Point currentSpinePoint = null, int index = 0 /* Metadata: 0x0077BAA9 */); // 0x00000001817338F0-0x0000000181733B60
		private void RefreshRefDirsOnReverse(); // 0x0000000181739EB0-0x000000018173A000
		private void RefreshDistances(); // 0x00000001817398D0-0x0000000181739C50
		private float SmootherValue(float val); // 0x000000018173AD90-0x000000018173AE00
		protected Vector3 RoundPosDiff(Vector3 pos, int digits = 1 /* Metadata: 0x0077BAAD */); // 0x000000018173AAC0-0x000000018173ABB0
		private Vector3 RoundToBiggestValue(Vector3 vec); // 0x000000018173ABB0-0x000000018173AD90
		private void DrawFatRay(Vector3 origin, Vector3 dir); // 0x00000001817355A0-0x00000001817359A0
		private void DrawFatLine(Vector3 origin, Vector3 dir); // 0x00000001817351A0-0x00000001817355A0
		public void RefreshSelectivePosNotAnimated(); // 0x000000018173A000-0x000000018173A0C0
		public void RefreshSelectiveRotNotAnimated(); // 0x000000018173A0C0-0x000000018173A180
		public void RefreshManualPosOffs(); // 0x0000000181739C50-0x0000000181739D80
		public void RefreshManualRotOffs(); // 0x0000000181739D80-0x0000000181739EB0
		public void OnDestroy(); // 0x0000000181738CF0-0x0000000181738ED0
		public void TryAutoCorrect(Transform head = null); // 0x000000018173AEA0-0x000000018173B4C0
		public void DevLog(); // 0x00000001803774A0-0x00000001803774B0
		[IteratorStateMachine] // 0x00000001801E0140-0x00000001801E0190
		public IEnumerator ReactivateMe(); // 0x0000000181739870-0x00000001817398D0
	}
}
