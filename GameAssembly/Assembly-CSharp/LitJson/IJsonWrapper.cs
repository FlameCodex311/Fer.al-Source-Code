/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace LitJson
{
	public interface IJsonWrapper : IList, IOrderedDictionary // TypeDefIndex: 16062
	{
		// Properties
		bool IsArray { get; }
		bool IsBoolean { get; }
		bool IsDouble { get; }
		bool IsInt { get; }
		bool IsLong { get; }
		bool IsObject { get; }
		bool IsString { get; }
	
		// Methods
		bool GetBoolean();
		double GetDouble();
		int GetInt();
		JsonType GetJsonType();
		long GetLong();
		string GetString();
		void SetBoolean(bool val);
		void SetDouble(double val);
		void SetInt(int val);
		void SetJsonType(JsonType type);
		void SetLong(long val);
		void SetString(string val);
		string ToJson();
		void ToJson(JsonWriter writer);
	}
}
