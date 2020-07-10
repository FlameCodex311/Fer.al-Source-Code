/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class AltUnityDriver : MonoBehaviour, AltIClientSocketHandlerDelegate // TypeDefIndex: 12753
{
	// Fields
	private Vector3 position; // 0x20
	private AltSocketServer socketServer; // 0x30
	private readonly string errorNotFoundMessage; // 0x38
	private readonly string errorPropertyNotFoundMessage; // 0x40
	private readonly string errorMethodNotFoundMessage; // 0x48
	private readonly string errorComponentNotFoundMessage; // 0x50
	private readonly string errorCouldNotPerformOperationMessage; // 0x58
	private readonly string errorCouldNotParseJsonString; // 0x60
	private readonly string errorIncorrectNumberOfParameters; // 0x68
	private readonly string errorFailedToParseArguments; // 0x70
	private readonly string errorObjectWasNotFound; // 0x78
	private readonly string errorPropertyNotSet; // 0x80
	private JsonSerializerSettings jsonSettings; // 0x88
	public int socketPortNumber; // 0x90
	public bool debugBuildNeeded; // 0x94
	private static AltResponseQueue responseQueue; // 0x00
	private int _actualScreenWidth; // 0x98
	private int _actualScreenHeight; // 0x9C

	// Properties
	public int ActualScreenWidth { get; } // 0x000000018103A290-0x000000018103A7C0 
	public int ActualScreenHeight { get; } // 0x0000000181039D60-0x000000018103A290 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass29_0 // TypeDefIndex: 12754
	{
		// Fields
		public string name; // 0x10
		public AltUnityDriver <>4__this; // 0x18
		public AltClientSocketHandler handler; // 0x20

		// Constructors
		public <>c__DisplayClass29_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <FindObjectByName>b__0(); // 0x000000018104D880-0x000000018104D9D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass30_0 // TypeDefIndex: 12755
	{
		// Fields
		public AltUnityDriver <>4__this; // 0x10
		public string name; // 0x18
		public AltClientSocketHandler handler; // 0x20

		// Constructors
		public <>c__DisplayClass30_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <FindObjectWhereNameContains>b__0(); // 0x000000018104D9D0-0x000000018104DBC0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass31_0 // TypeDefIndex: 12756
	{
		// Fields
		public AltUnityDriver <>4__this; // 0x10
		public string componentTypeName; // 0x18
		public AltClientSocketHandler handler; // 0x20

		// Constructors
		public <>c__DisplayClass31_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <FindObjectByComponent>b__0(); // 0x000000018104DBC0-0x000000018104DE40
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass32_0 // TypeDefIndex: 12757
	{
		// Fields
		public string name; // 0x10
		public AltUnityDriver <>4__this; // 0x18
		public AltClientSocketHandler handler; // 0x20

		// Constructors
		public <>c__DisplayClass32_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <FindObjectsByName>b__0(); // 0x000000018104DE40-0x000000018104E040
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass33_0 // TypeDefIndex: 12758
	{
		// Fields
		public string componentTypeName; // 0x10
		public AltUnityDriver <>4__this; // 0x18
		public AltClientSocketHandler handler; // 0x20

		// Constructors
		public <>c__DisplayClass33_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <FindObjectsByComponent>b__0(); // 0x000000018104E040-0x000000018104E300
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass34_0 // TypeDefIndex: 12759
	{
		// Fields
		public string name; // 0x10
		public AltUnityDriver <>4__this; // 0x18
		public AltClientSocketHandler handler; // 0x20

		// Constructors
		public <>c__DisplayClass34_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <FindObjectsWhereNameContains>b__0(); // 0x000000018104E300-0x000000018104E500
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass36_0 // TypeDefIndex: 12760
	{
		// Fields
		public AltClientSocketHandler handler; // 0x10

		// Constructors
		public <>c__DisplayClass36_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <GetCurrentScene>b__0(); // 0x000000018104E500-0x000000018104E600
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass37_0 // TypeDefIndex: 12761
	{
		// Fields
		public string name; // 0x10
		public AltClientSocketHandler handler; // 0x18
		public AltUnityDriver <>4__this; // 0x20

		// Constructors
		public <>c__DisplayClass37_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <TapObjectByName>b__0(); // 0x000000018104E600-0x000000018104E880
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass38_0 // TypeDefIndex: 12762
	{
		// Fields
		public AltUnityDriver <>4__this; // 0x10
		public string propertyString; // 0x18
		public string altObjectString; // 0x20
		public AltClientSocketHandler handler; // 0x28

		// Constructors
		public <>c__DisplayClass38_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <GetObjectComponentProperty>b__0(); // 0x000000018104E880-0x000000018104EB00
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass39_0 // TypeDefIndex: 12763
	{
		// Fields
		public AltUnityDriver <>4__this; // 0x10
		public string propertyString; // 0x18
		public string altObjectString; // 0x20
		public string valueString; // 0x28
		public AltClientSocketHandler handler; // 0x30

		// Constructors
		public <>c__DisplayClass39_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <SetObjectComponentProperty>b__0(); // 0x000000018104EB00-0x000000018104EDB0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass40_0 // TypeDefIndex: 12764
	{
		// Fields
		public AltUnityDriver <>4__this; // 0x10
		public string altObjectString; // 0x18
		public string actionString; // 0x20
		public AltClientSocketHandler handler; // 0x28

		// Constructors
		public <>c__DisplayClass40_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <CallComponentMethodForObject>b__0(); // 0x000000018104EDB0-0x000000018104F4B0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass41_0 // TypeDefIndex: 12765
	{
		// Fields
		public string altObjectString; // 0x10
		public AltUnityDriver <>4__this; // 0x18
		public AltClientSocketHandler handler; // 0x20

		// Constructors
		public <>c__DisplayClass41_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <GetText>b__0(); // 0x000000018104F4B0-0x000000018104F5F0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass43_0 // TypeDefIndex: 12766
	{
		// Fields
		public AltClientSocketHandler handler; // 0x10
		public AltUnityDriver <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass43_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <UnknownString>b__0(); // 0x000000018104F5F0-0x000000018104F630
	}

	// Constructors
	public AltUnityDriver(); // 0x00000001810398E0-0x00000001810399A0

	// Methods
	private void Start(); // 0x0000000181038F30-0x0000000181039700
	public void StartSocketServer(); // 0x0000000181038CD0-0x0000000181038F30
	private void OnApplicationQuit(); // 0x0000000181035FB0-0x0000000181036020
	public void CleanUp(); // 0x0000000181035FB0-0x0000000181036020
	private Vector3 getObjectScreenPosition(GameObject gameObject, Camera camera); // 0x00000001810399A0-0x0000000181039D60
	private AltUnityObject GameObjectToAltUnityObject(GameObject altGameObject, Camera camera = null); // 0x0000000181037670-0x0000000181037E30
	public void ClientSocketHandlerDidReadMessage(AltClientSocketHandler handler, string message); // 0x0000000181036020-0x0000000181037070
	private void FindObjectByName(string name, AltClientSocketHandler handler); // 0x0000000181037260-0x0000000181037330
	private void FindObjectWhereNameContains(string name, AltClientSocketHandler handler); // 0x0000000181037330-0x0000000181037400
	private void FindObjectByComponent(string componentTypeName, AltClientSocketHandler handler); // 0x0000000181037190-0x0000000181037260
	private void FindObjectsByName(string name, AltClientSocketHandler handler); // 0x00000001810374D0-0x00000001810375A0
	private void FindObjectsByComponent(string componentTypeName, AltClientSocketHandler handler); // 0x0000000181037400-0x00000001810374D0
	private void FindObjectsWhereNameContains(string name, AltClientSocketHandler handler); // 0x00000001810375A0-0x0000000181037670
	private void GetAllObjects(AltClientSocketHandler handler); // 0x0000000181037E30-0x0000000181037F20
	private void GetCurrentScene(AltClientSocketHandler handler); // 0x0000000181037F20-0x0000000181037FE0
	private void TapObjectByName(string name, AltClientSocketHandler handler); // 0x0000000181039700-0x00000001810397D0
	private void GetObjectComponentProperty(string altObjectString, string propertyString, AltClientSocketHandler handler); // 0x0000000181038230-0x0000000181038320
	private void SetObjectComponentProperty(string altObjectString, string propertyString, string valueString, AltClientSocketHandler handler); // 0x00000001810388E0-0x00000001810389D0
	private void CallComponentMethodForObject(string altObjectString, string actionString, AltClientSocketHandler handler); // 0x0000000181035EC0-0x0000000181035FB0
	private void GetText(string altObjectString, AltClientSocketHandler handler); // 0x0000000181038320-0x00000001810383F0
	private void CloseConnection(AltClientSocketHandler handler); // 0x0000000181037070-0x0000000181037090
	private void UnknownString(AltClientSocketHandler handler); // 0x00000001810397D0-0x0000000181039890
	private void Update(); // 0x0000000181039890-0x00000001810398E0
	public static Type GetType(string TypeName); // 0x00000001810383F0-0x0000000181038590
	private static GameObject GetGameObject(AltUnityObject altUnityObject); // 0x0000000181037FE0-0x00000001810380D0
	private MemberInfo GetMemberForObjectComponent(AltUnityObject altUnityObject, AltUnityObjectProperty altUnityObjectProperty); // 0x00000001810380D0-0x0000000181038230
	private string GetValueForMember(MemberInfo memberInfo, GameObject testableObject, AltUnityObjectProperty altProperty); // 0x0000000181038590-0x00000001810387D0
	private string SetValueForMember(MemberInfo memberInfo, string valueString, GameObject testableObject, AltUnityObjectProperty altProperty); // 0x00000001810389D0-0x0000000181038CD0
	private string SerializeMemberValue(object value, Type type); // 0x00000001810387D0-0x00000001810388E0
	private object DeserializeMemberValue(string valueString, Type type); // 0x0000000181037090-0x0000000181037190
}

