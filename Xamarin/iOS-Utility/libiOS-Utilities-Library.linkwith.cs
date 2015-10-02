using System;
using ObjCRuntime;

[assembly: LinkWith ("libiOS-Utilities-Library.a", LinkTarget.Simulator, SmartLink = true, ForceLoad = true)]
