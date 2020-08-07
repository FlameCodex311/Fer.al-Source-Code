/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

internal interface sNfUcPzqbmfpkWQZGXbzVNvzIYo // TypeDefIndex: 6685
{
	// Properties
	ControllerMap MWiOWGzUiqOkOMPKltvfuPDthis[int index] { get => default; }
	int SHujHYUxHggDGFiBfPBtOLtZhMW { get; }
	IList<ControllerMap> JCOaizEBVSmHYTLsOlmPEmHhbdXD { get; }

	// Methods
	IEnumerable<ControllerMap> IterateMapsInCategory_ControllerMap(int param_0000dd8c);
	IList<T> GetMaps<T>()
		where T : ControllerMap;
	void Add(ControllerMap param_0000dd8d, BoolOption param_0000dd8e);
	void Remove(ControllerMap param_0000dd8f);
	void Remove(int param_0000dd90);
	void Remove(int param_0000dd91, int param_0000dd92);
	void RemoveById(int param_0000dd93);
	int IndexOf(int param_0000dd94);
	int IndexOf(int param_0000dd95, int param_0000dd96);
	bool Contains(int param_0000dd97);
	bool Contains(int param_0000dd98, int param_0000dd99);
	void Clear(bool param_0000dd9a);
	void Clear(int param_0000dd9b, bool param_0000dd9c);
	void ClearByLayout(int param_0000dd9d, bool param_0000dd9e);
	int SetEnabledAll(bool param_0000dd9f);
	int SetEnabledByCategory(bool param_0000dda0, int param_0000dda1);
	int SetEnabledByCategory(bool param_0000dda2, int param_0000dda3, int param_0000dda4);
	bool ContainsMapInCategory(int param_0000dda5);
	ControllerMap GetMap(int param_0000dda6);
	ControllerMap GetMap(int param_0000dda7, int param_0000dda8);
	ControllerMap[] GetMaps();
	ControllerMap GetMapByCategory(int param_0000dda9);
	ControllerMap[] GetMapsByCategory(int param_0000ddaa);
	int GetMapsByCategory(int param_0000ddab, List<ControllerMap> param_0000ddac, bool param_0000ddad);
	int GetMapsByCategory<T>(int param_0000ddae, List<T> param_0000ddaf, bool param_0000ddb0)
		where T : ControllerMap;
	int GetMaps(List<ControllerMap> param_0000ddb1, bool param_0000ddb2);
	int GetMaps<T>(List<T> param_0000ddb3, bool param_0000ddb4)
		where T : ControllerMap;
}

