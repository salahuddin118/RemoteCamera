
#include <new>
#include "RemoteCamera.h"
#include "RemoteCameraForm.h"

using namespace Tizen::App;
using namespace Tizen::Base;
using namespace Tizen::Graphics;
using namespace Tizen::Io;
using namespace Tizen::System;
using namespace Tizen::Text;
using namespace Tizen::Ui;
using namespace Tizen::Ui::Controls;

RemoteCamera::RemoteCamera(void)
{
}

RemoteCamera::~RemoteCamera(void)
{
}

Application*
RemoteCamera::CreateInstance(void)
{
	return new RemoteCamera();
}

bool
RemoteCamera::OnAppInitializing(AppRegistry& appRegistry)
{
	Frame* pAppFrame = new (std::nothrow) Frame();
	pAppFrame->Construct();
	AddFrame(*pAppFrame); 
	
	RemoteCameraForm* pForm = new (std::nothrow) RemoteCameraForm();
	TryReturn(pForm != null, false, "Failed to create form");
	result r = pForm->Construct(FORM_STYLE_NORMAL | FORM_STYLE_HEADER | FORM_STYLE_FOOTER | FORM_STYLE_INDICATOR);
	TryReturn(r == E_SUCCESS, false, "Failed to construct form");

	// Set Header
	Header* pHeader = pForm->GetHeader();
	pHeader->SetTitleText(L"Remote Camera");

	r = GetAppFrame()->GetFrame()->AddControl(pForm);
	TryReturn(r == E_SUCCESS, false, "Failed to attach FormMgr to the frame");

	pForm->Draw();

	return true;
}

bool
RemoteCamera::OnAppTerminating(AppRegistry& appRegistry, bool forcedTermination)
{
	return true;
}

void
RemoteCamera::OnForeground(void)
{
}

void
RemoteCamera::OnBackground(void)
{
}

void
RemoteCamera::OnLowMemory(void)
{
}

void
RemoteCamera::OnBatteryLevelChanged(BatteryLevel batteryLevel)
{
}

void
RemoteCamera::OnScreenOn(void)
{
}

void
RemoteCamera::OnScreenOff(void)
{
}
