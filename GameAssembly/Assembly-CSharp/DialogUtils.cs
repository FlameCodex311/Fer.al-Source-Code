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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class DialogUtils // TypeDefIndex: 10417
{
	// Fields
	private static string[] parseArg; // 0x00

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 10418
	{
		// Fields
		public Action<GameObject> dialogTreeControllerGameObject; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <GetDialog>b__0(GameObject go); // 0x000000018119D480-0x000000018119D4D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass2_0 // TypeDefIndex: 10419
	{
		// Fields
		public Action<DialogueTreeController> dialogTreeController; // 0x10

		// Constructors
		public <>c__DisplayClass2_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <GetDialog>b__0(GameObject go); // 0x000000018119D4D0-0x000000018119D540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass3_0 // TypeDefIndex: 10420
	{
		// Fields
		public Action<GameObject> dialogTreeControllerGameObject; // 0x10

		// Constructors
		public <>c__DisplayClass3_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <GetDialogFromList>b__0(GameObject go); // 0x000000018119D540-0x000000018119D590
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass4_0 // TypeDefIndex: 10421
	{
		// Fields
		public Action<DialogueTreeController> dialogTreeController; // 0x10

		// Constructors
		public <>c__DisplayClass4_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <GetDialogFromList>b__0(GameObject go); // 0x000000018119D590-0x000000018119D600
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass5_0 // TypeDefIndex: 10422
	{
		// Fields
		public Action<List<GameObject>> dialogTreeControllerGameObjects; // 0x10

		// Constructors
		public <>c__DisplayClass5_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <GetAllAvailableDialogFromList>b__0(List<GameObject> dtcg); // 0x000000018119D600-0x000000018119D650
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 10423
	{
		// Fields
		public Action<List<DialogueTreeController>> dialogTreeControllers; // 0x10

		// Constructors
		public <>c__DisplayClass6_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <GetAllAvailableDialogFromList>b__0(List<DialogueTreeController> dtc); // 0x000000018119D9B0-0x000000018119DA00
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass7_0 // TypeDefIndex: 10424
	{
		// Fields
		public List<DialogueTreeController> gComponents; // 0x10
		public Action<DialogueTreeController> <>9__0; // 0x18

		// Constructors
		public <>c__DisplayClass7_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <GetAllAvailableDialogFromList>b__0(DialogueTreeController cComponent); // 0x000000018119DA00-0x000000018119DA90
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <GetAllAvailableDialogFromList>d__7 : IEnumerator<object> // TypeDefIndex: 10425
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <GetAllAvailableDialogFromList>d__7(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018119B800-0x000000018119BA30
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018119BA30-0x000000018119BA80
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass8_0 // TypeDefIndex: 10426
	{
		// Fields
		public List<GameObject> gObjects; // 0x10
		public Action<GameObject> <>9__0; // 0x18

		// Constructors
		public <>c__DisplayClass8_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <GetAllAvailableDialogFromList>b__0(GameObject go); // 0x000000018119DA90-0x000000018119DAF0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <GetAllAvailableDialogFromList>d__8 : IEnumerator<object> // TypeDefIndex: 10427
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <GetAllAvailableDialogFromList>d__8(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018119BA80-0x000000018119BCE0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018119BCE0-0x000000018119C4A0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass15_0 // TypeDefIndex: 10428
	{
		// Fields
		public string inDefId; // 0x10
		public GameObject inDialogAttach; // 0x18
		public Transform inActorDialoging; // 0x20
		public Action<AudioScriptableObject> <>9__1; // 0x28

		// Constructors
		public <>c__DisplayClass15_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <PlayDialogEvent>b__0(); // 0x000000018119D1A0-0x000000018119D440
		internal void <PlayDialogEvent>b__1(AudioScriptableObject result); // 0x000000018119D440-0x000000018119D480
	}

	// Constructors
	public DialogUtils(); // 0x000000018036B6C0-0x000000018036B6D0
	static DialogUtils(); // 0x0000000181185840-0x00000001811858F0

	// Methods
	public static void GetDialog(GameObject inGameObject, string inDialogDefId, Action<GameObject> dialogTreeControllerGameObject); // 0x0000000181184FB0-0x0000000181185130
	public static void GetDialog(GameObject inGameObject, string inDialogDefId, Action<DialogueTreeController> dialogTreeController); // 0x0000000181184E30-0x0000000181184FB0
	public static void GetDialogFromList(GameObject inGameObject, string inListDefId, Action<GameObject> dialogTreeControllerGameObject); // 0x0000000181184CC0-0x0000000181184E30
	public static void GetDialogFromList(GameObject inGameObject, string inListDefId, Action<DialogueTreeController> dialogTreeController); // 0x0000000181184B50-0x0000000181184CC0
	public static void GetAllAvailableDialogFromList(GameObject inGameObject, string inListDefId, Action<List<GameObject>> dialogTreeControllerGameObjects); // 0x00000001811846E0-0x0000000181184840
	public static void GetAllAvailableDialogFromList(GameObject inGameObject, string inListDefId, Action<List<DialogueTreeController>> dialogTreeControllers); // 0x0000000181184500-0x0000000181184660
	[IteratorStateMachine] // 0x000000018010D2D0-0x000000018010D320
	private static IEnumerator GetAllAvailableDialogFromList(GameObject inGameObject, List<DialogDefComponent> inComponents, Action<List<DialogueTreeController>> dialogTreeControllers); // 0x0000000181184480-0x0000000181184500
	[IteratorStateMachine] // 0x000000018010D610-0x000000018010D660
	private static IEnumerator GetAllAvailableDialogFromList(GameObject inGameObject, List<DialogDefComponent> inComponents, Action<List<GameObject>> dialogTreeControllerGameObjects); // 0x0000000181184660-0x00000001811846E0
	private static List<DialogDefComponent> GetAllDialogDefComponentsAvailableFromList(string inListDefId); // 0x0000000181184840-0x00000001811849F0
	private static DialogDefComponent GetDialogDefComponentAvailableFromList(string inListDefId); // 0x00000001811849F0-0x0000000181184B50
	private static bool IsDialogAvailable(string inDialogDefId); // 0x0000000181185380-0x0000000181185400
	private static void GetExpressionAndTime(string inString, out string outExpression, out float outTime); // 0x0000000181185130-0x0000000181185220
	public static string ParseDialog(string inText, GameObject inDialogAttach, Transform inActorDialoging); // 0x0000000181185400-0x0000000181185780
	private static string GetExpressionDef(string inExpression); // 0x0000000181185220-0x0000000181185380
	private static void PlayDialogEvent(string inDefId, float inTime, GameObject inDialogAttach, Transform inActorDialoging); // 0x0000000181185780-0x0000000181185840
}

