/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.DialogueTrees;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class DialogUtils // TypeDefIndex: 11905
{
	// Fields
	private static string[] parseArg; // 0x00

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 11906
	{
		// Fields
		public Action<GameObject> dialogTreeControllerGameObject; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <GetDialog>b__0(GameObject go); // 0x0000000180568050-0x00000001805680A0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass2_0 // TypeDefIndex: 11907
	{
		// Fields
		public Action<DialogueTreeController> dialogTreeController; // 0x10

		// Constructors
		public <>c__DisplayClass2_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <GetDialog>b__0(GameObject go); // 0x00000001805680A0-0x0000000180568110
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass3_0 // TypeDefIndex: 11908
	{
		// Fields
		public Action<GameObject> dialogTreeControllerGameObject; // 0x10

		// Constructors
		public <>c__DisplayClass3_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <GetDialogFromList>b__0(GameObject go); // 0x00000001805682E0-0x0000000180568330
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass4_0 // TypeDefIndex: 11909
	{
		// Fields
		public Action<DialogueTreeController> dialogTreeController; // 0x10

		// Constructors
		public <>c__DisplayClass4_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <GetDialogFromList>b__0(GameObject go); // 0x00000001805686E0-0x0000000180568750
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass5_0 // TypeDefIndex: 11910
	{
		// Fields
		public Action<List<GameObject>> dialogTreeControllerGameObjects; // 0x10

		// Constructors
		public <>c__DisplayClass5_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <GetAllAvailableDialogFromList>b__0(List<GameObject> dtcg); // 0x0000000180568750-0x00000001805687A0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 11911
	{
		// Fields
		public Action<List<DialogueTreeController>> dialogTreeControllers; // 0x10

		// Constructors
		public <>c__DisplayClass6_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <GetAllAvailableDialogFromList>b__0(List<DialogueTreeController> dtc); // 0x0000000180568840-0x0000000180568890
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass7_0 // TypeDefIndex: 11912
	{
		// Fields
		public List<DialogueTreeController> gComponents; // 0x10
		public Action<DialogueTreeController> <>9__0; // 0x18

		// Constructors
		public <>c__DisplayClass7_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <GetAllAvailableDialogFromList>b__0(DialogueTreeController cComponent); // 0x0000000180568890-0x0000000180568920
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <GetAllAvailableDialogFromList>d__7 : IEnumerator<object> // TypeDefIndex: 11913
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public List<DialogDefComponent> inComponents; // 0x20
		public GameObject inGameObject; // 0x28
		private <>c__DisplayClass7_0 <>8__1; // 0x30
		public Action<List<DialogueTreeController>> dialogTreeControllers; // 0x38
		private int <ii>5__2; // 0x40

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <GetAllAvailableDialogFromList>d__7(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001805649B0-0x0000000180564BD0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180564BD0-0x0000000180564C20
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass8_0 // TypeDefIndex: 11914
	{
		// Fields
		public List<GameObject> gObjects; // 0x10
		public Action<GameObject> <>9__0; // 0x18

		// Constructors
		public <>c__DisplayClass8_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <GetAllAvailableDialogFromList>b__0(GameObject go); // 0x0000000180568920-0x0000000180568980
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <GetAllAvailableDialogFromList>d__8 : IEnumerator<object> // TypeDefIndex: 11915
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public List<DialogDefComponent> inComponents; // 0x20
		public GameObject inGameObject; // 0x28
		private <>c__DisplayClass8_0 <>8__1; // 0x30
		public Action<List<GameObject>> dialogTreeControllerGameObjects; // 0x38
		private int <ii>5__2; // 0x40

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <GetAllAvailableDialogFromList>d__8(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180564C20-0x0000000180564E70
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180564E70-0x0000000180565190
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass15_0 // TypeDefIndex: 11916
	{
		// Fields
		public string inDefId; // 0x10
		public GameObject inDialogAttach; // 0x18
		public Transform inActorDialoging; // 0x20
		public Action<AudioScriptableObject> <>9__1; // 0x28

		// Constructors
		public <>c__DisplayClass15_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <PlayDialogEvent>b__0(); // 0x0000000180567D90-0x0000000180568020
		internal void <PlayDialogEvent>b__1(AudioScriptableObject result); // 0x0000000180568020-0x0000000180568050
	}

	// Constructors
	public DialogUtils(); // 0x0000000180373240-0x0000000180373250
	static DialogUtils(); // 0x00000001805610A0-0x0000000180561150

	// Methods
	public static void GetDialog(GameObject inGameObject, string inDialogDefId, Action<GameObject> dialogTreeControllerGameObject); // 0x0000000180560850-0x00000001805609C0
	public static void GetDialog(GameObject inGameObject, string inDialogDefId, Action<DialogueTreeController> dialogTreeController); // 0x00000001805606E0-0x0000000180560850
	public static void GetDialogFromList(GameObject inGameObject, string inListDefId, Action<GameObject> dialogTreeControllerGameObject); // 0x0000000180560580-0x00000001805606E0
	public static void GetDialogFromList(GameObject inGameObject, string inListDefId, Action<DialogueTreeController> dialogTreeController); // 0x0000000180560420-0x0000000180560580
	public static void GetAllAvailableDialogFromList(GameObject inGameObject, string inListDefId, Action<List<GameObject>> dialogTreeControllerGameObjects); // 0x000000018055FFD0-0x0000000180560130
	public static void GetAllAvailableDialogFromList(GameObject inGameObject, string inListDefId, Action<List<DialogueTreeController>> dialogTreeControllers); // 0x000000018055FDF0-0x000000018055FF50
	[IteratorStateMachine] // 0x00000001801DE7D0-0x00000001801DE820
	private static IEnumerator GetAllAvailableDialogFromList(GameObject inGameObject, List<DialogDefComponent> inComponents, Action<List<DialogueTreeController>> dialogTreeControllers); // 0x000000018055FD70-0x000000018055FDF0
	[IteratorStateMachine] // 0x00000001801DEB10-0x00000001801DEB60
	private static IEnumerator GetAllAvailableDialogFromList(GameObject inGameObject, List<DialogDefComponent> inComponents, Action<List<GameObject>> dialogTreeControllerGameObjects); // 0x000000018055FF50-0x000000018055FFD0
	private static List<DialogDefComponent> GetAllDialogDefComponentsAvailableFromList(string inListDefId); // 0x0000000180560130-0x00000001805602D0
	private static DialogDefComponent GetDialogDefComponentAvailableFromList(string inListDefId); // 0x00000001805602D0-0x0000000180560420
	private static bool IsDialogAvailable(string inDialogDefId); // 0x0000000180560BF0-0x0000000180560C70
	private static void GetExpressionAndTime(string inString, out string outExpression, out float outTime); // 0x00000001805609C0-0x0000000180560AA0
	public static string ParseDialog(string inText, GameObject inDialogAttach, Transform inActorDialoging); // 0x0000000180560C70-0x0000000180560FE0
	private static string GetExpressionDef(string inExpression); // 0x0000000180560AA0-0x0000000180560BF0
	private static void PlayDialogEvent(string inDefId, float inTime, GameObject inDialogAttach, Transform inActorDialoging); // 0x0000000180560FE0-0x00000001805610A0
}

