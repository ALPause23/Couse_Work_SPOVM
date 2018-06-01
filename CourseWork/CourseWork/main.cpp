#include "DLL.h"
#include <Windows.h>
#using <ClassLibrary1.dll>

void main()
{
	HMODULE hLib;
	hLib = LoadLibrary(TEXT("ClassLibrary1.dll"));

}