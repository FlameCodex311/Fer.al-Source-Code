/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class AltUnityDriver : MonoBehaviour, AltIClientSocketHandlerDelegate // TypeDefIndex: 10410
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
	public int ActualScreenWidth { get; } // 0x0000000182153530-0x0000000182153A40 
	public int ActualScreenHeight { get; } // 0x0000000182153020-0x0000000182153530 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass29_0 // TypeDefIndex: 10411
	{
		// Fields
		public string name; // 0x10
		public AltUnityDriver <>4__this; // 0x18
		public AltClientSocketHandler handler; // 0x20

		// Constructors
		public <>c__DisplayClass29_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <FindObjectByName>b__0(); // 0x0000000182160500-0x0000000182160650
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass30_0 // TypeDefIndex: 10412
	{
		// Fields
		public AltUnityDriver <>4__this; // 0x10
		public string name; // 0x18
		public AltClientSocketHandler handler; // 0x20

		// Constructors
		public <>c__DisplayClass30_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <FindObjectWhereNameContains>b__0(); // 0x0000000182160650-0x0000000182160830
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass31_0 // TypeDefIndex: 10413
	{
		// Fields
		public AltUnityDriver <>4__this; // 0x10
		public string componentTypeName; // 0x18
		public AltClientSocketHandler handler; // 0x20

		// Constructors
		public <>c__DisplayClass31_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <FindObjectByComponent>b__0(); // 0x0000000182160830-0x0000000182160AA0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass32_0 // TypeDefIndex: 10414
	{
		// Fields
		public string name; // 0x10
		public AltUnityDriver <>4__this; // 0x18
		public AltClientSocketHandler handler; // 0x20

		// Constructors
		public <>c__DisplayClass32_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <FindObjectsByName>b__0(); // 0x0000000182160AA0-0x0000000182160C90
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass33_0 // TypeDefIndex: 10415
	{
		// Fields
		public string componentTypeName; // 0x10
		public AltUnityDriver <>4__this; // 0x18
		public AltClientSocketHandler handler; // 0x20

		// Constructors
		public <>c__DisplayClass33_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <FindObjectsByComponent>b__0(); // 0x0000000182160C90-0x0000000182160F40
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass34_0 // TypeDefIndex: 10416
	{
		// Fields
		public string name; // 0x10
		public AltUnityDriver <>4__this; // 0x18
		public AltClientSocketHandler handler; // 0x20

		// Constructors
		public <>c__DisplayClass34_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <FindObjectsWhereNameContains>b__0(); // 0x0000000182160F40-0x0000000182161130
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass36_0 // TypeDefIndex: 10417
	{
		// Fields
		public AltClientSocketHandler handler; // 0x10

		// Constructors
		public <>c__DisplayClass36_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <GetCurrentScene>b__0(); // 0x0000000182161130-0x0000000182161230
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass37_0 // TypeDefIndex: 10418
	{
		// Fields
		public string name; // 0x10
		public AltClientSocketHandler handler; // 0x18
		public AltUnityDriver <>4__this; // 0x20

		// Constructors
		public <>c__DisplayClass37_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <TapObjectByName>b__0(); // 0x0000000182161230-0x00000001821614A0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass38_0 // TypeDefIndex: 10419
	{
		// Fields
		public AltUnityDriver <>4__this; // 0x10
		public string propertyString; // 0x18
		public string altObjectString; // 0x20
		public AltClientSocketHandler handler; // 0x28

		// Constructors
		public <>c__DisplayClass38_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <GetObjectComponentProperty>b__0(); // 0x00000001821614A0-0x0000000182161710
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass39_0 // TypeDefIndex: 10420
	{
		// Fields
		public AltUnityDriver <>4__this; // 0x10
		public string propertyString; // 0x18
		public string altObjectString; // 0x20
		public string valueString; // 0x28
		public AltClientSocketHandler handler; // 0x30

		// Constructors
		public <>c__DisplayClass39_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <SetObjectComponentProperty>b__0(); // 0x0000000182161710-0x00000001821619C0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass40_0 // TypeDefIndex: 10421
	{
		// Fields
		public AltUnityDriver <>4__this; // 0x10
		public string altObjectString; // 0x18
		public string actionString; // 0x20
		public AltClientSocketHandler handler; // 0x28

		// Constructors
		public <>c__DisplayClass40_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <CallComponentMethodForObject>b__0(); // 0x00000001821619C0-0x0000000182162080
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass41_0 // TypeDefIndex: 10422
	{
		// Fields
		public string altObjectString; // 0x10
		public AltUnityDriver <>4__this; // 0x18
		public AltClientSocketHandler handler; // 0x20

		// Constructors
		public <>c__DisplayClass41_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <GetText>b__0(); // 0x0000000182162080-0x00000001821621B0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass43_0 // TypeDefIndex: 10423
	{
		// Fields
		public AltClientSocketHandler handler; // 0x10
		public AltUnityDriver <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass43_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <UnknownString>b__0(); // 0x00000001821621B0-0x00000001821621F0
	}

	// Constructors
	public AltUnityDriver(); // 0x0000000182152BC0-0x0000000182152C80

	// Methods
	private void Start(); // 0x0000000182152250-0x00000001821529E0
	public void StartSocketServer(); // 0x0000000182152000-0x0000000182152250
	private void OnApplicationQuit(); // 0x000000018214F3C0-0x000000018214F430
	public void CleanUp(); // 0x000000018214F3C0-0x000000018214F430
	private Vector3 getObjectScreenPosition(GameObject gameObject, Camera camera); // 0x0000000182152C80-0x0000000182153020
	private AltUnityObject GameObjectToAltUnityObject(GameObject altGameObject, Camera camera = null); // 0x00000001821509E0-0x0000000182151190
	public void ClientSocketHandlerDidReadMessage(AltClientSocketHandler handler, string message); // 0x000000018214F430-0x00000001821503E0
	private void FindObjectByName(string name, AltClientSocketHandler handler); // 0x00000001821505D0-0x00000001821506A0
	private void FindObjectWhereNameContains(string name, AltClientSocketHandler handler); // 0x00000001821506A0-0x0000000182150770
	private void FindObjectByComponent(string componentTypeName, AltClientSocketHandler handler); // 0x0000000182150500-0x00000001821505D0
	private void FindObjectsByName(string name, AltClientSocketHandler handler); // 0x0000000182150840-0x0000000182150910
	private void FindObjectsByComponent(string componentTypeName, AltClientSocketHandler handler); // 0x0000000182150770-0x0000000182150840
	private void FindObjectsWhereNameContains(string name, AltClientSocketHandler handler); // 0x0000000182150910-0x00000001821509E0
	private void GetAllObjects(AltClientSocketHandler handler); // 0x0000000182151190-0x0000000182151280
	private void GetCurrentScene(AltClientSocketHandler handler); // 0x0000000182151280-0x0000000182151340
	private void TapObjectByName(string name, AltClientSocketHandler handler); // 0x00000001821529E0-0x0000000182152AB0
	private void GetObjectComponentProperty(string altObjectString, string propertyString, AltClientSocketHandler handler); // 0x0000000182151580-0x0000000182151660
	private void SetObjectComponentProperty(string altObjectString, string propertyString, string valueString, AltClientSocketHandler handler); // 0x0000000182151C10-0x0000000182151D00
	private void CallComponentMethodForObject(string altObjectString, string actionString, AltClientSocketHandler handler); // 0x000000018214F2E0-0x000000018214F3C0
	private void GetText(string altObjectString, AltClientSocketHandler handler); // 0x0000000182151660-0x0000000182151730
	private void CloseConnection(AltClientSocketHandler handler); // 0x00000001821503E0-0x0000000182150400
	private void UnknownString(AltClientSocketHandler handler); // 0x0000000182152AB0-0x0000000182152B70
	private void Update(); // 0x0000000182152B70-0x0000000182152BC0
	public static Type GetType(string TypeName); // 0x0000000182151730-0x00000001821518C0
	private static GameObject GetGameObject(AltUnityObject altUnityObject); // 0x0000000182151340-0x0000000182151420
	private MemberInfo GetMemberForObjectComponent(AltUnityObject altUnityObject, AltUnityObjectProperty altUnityObjectProperty); // 0x0000000182151420-0x0000000182151580
	private string GetValueForMember(MemberInfo memberInfo, GameObject testableObject, AltUnityObjectProperty altProperty); // 0x00000001821518C0-0x0000000182151B00
	private string SetValueForMember(MemberInfo memberInfo, string valueString, GameObject testableObject, AltUnityObjectProperty altProperty); // 0x0000000182151D00-0x0000000182152000
	private string SerializeMemberValue(object value, Type type); // 0x0000000182151B00-0x0000000182151C10
	private object DeserializeMemberValue(string valueString, Type type); // 0x0000000182150400-0x0000000182150500
}

