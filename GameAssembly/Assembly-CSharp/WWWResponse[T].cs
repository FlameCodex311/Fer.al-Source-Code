/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class WWWResponse<T> // TypeDefIndex: 12481
	where T : new()
{
	// Fields
	public int status;
	public T value;
	public string body;

	// Properties
	public bool IsSuccess { get; }

	// Constructors
	public WWWResponse(int status);
	public WWWResponse(int status, T value);
	public WWWResponse(WWWResponse originalResponse);
}

