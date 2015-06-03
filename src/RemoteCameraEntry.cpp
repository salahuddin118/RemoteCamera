#include <new>
#include "RemoteCamera.h"

using namespace Tizen::Base;
using namespace Tizen::Base::Collection;

#ifdef __cplusplus
extern "C"
{
#endif // __cplusplus



_EXPORT_ int OspMain(int argc, char* pArgv[]);

/**
 * The entry function of Tizen application called by the operating system.
 */
int
OspMain(int argc, char* pArgv[])
{
	result r = E_SUCCESS;

	AppLog("Application started.");
	ArrayList args;
	args.Construct();
	for (int i = 0; i < argc; i++)
	{
		args.Add(*(new (std::nothrow) String(pArgv[i])));
	}

	r = Tizen::App::Application::Execute(RemoteCamera::CreateInstance, &args);
	TryLog(r == E_SUCCESS, "Application execution failed-[%s].", GetErrorMessage(r));

	args.RemoveAll(true);
	AppLog("Application finished.");

	return static_cast< int >(r);
}
#ifdef __cplusplus
}
#endif // __cplusplus
