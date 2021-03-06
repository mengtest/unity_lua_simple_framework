﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class LuaFramework_PanelManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaFramework.PanelManager), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("CreateLayer", CreateLayer);
		L.RegFunction("CreatePanelSync", CreatePanelSync);
		L.RegFunction("GetGameObject", GetGameObject);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreateLayer(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaFramework.PanelManager obj = (LuaFramework.PanelManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.PanelManager));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Transform o = obj.CreateLayer(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreatePanelSync(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			LuaFramework.PanelManager obj = (LuaFramework.PanelManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.PanelManager));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			string arg1 = ToLua.CheckString(L, 3);
			UnityEngine.GameObject o = obj.CreatePanelSync(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetGameObject(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaFramework.PanelManager obj = (LuaFramework.PanelManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.PanelManager));
			string arg0 = ToLua.CheckString(L, 2);
			UnityEngine.GameObject o = obj.GetGameObject(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

