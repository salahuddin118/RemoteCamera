
#include <new>
#include "RemoteCameraForm.h"
#include "InfoCompare.h"

using namespace Tizen::App;
using namespace Tizen::Base;
using namespace Tizen::Ui;
using namespace Tizen::Ui::Controls;
using namespace Tizen::Uix::Vision;
using namespace Tizen::Graphics;
using namespace Tizen::Media;
using namespace Tizen::Base::Collection;
using namespace Tizen::Base::Runtime;

//static const int SPACE_X = 10;
static const int SPACE_Y = 80;

//static const int SCREEN_W = 480;

static const wchar_t* BUTTON1_NAME = L"Start";
static const wchar_t* BUTTON2_NAME = L"Capture";
static const wchar_t* BUTTON3_NAME = L"Stop";

static const int FPS = 5;
static const int INTERVAL = 1000/FPS;
static const int TIMER_START = 200;
static const int TIMER_STOP = 202;

RemoteCameraForm::RemoteCameraForm(void)
	: __stat(0)
	, __count(0)
	, __pCanvas(null)
	, __pTimerDraw(null)
	, __pTizenRemoteCamera(null)
{
}

RemoteCameraForm::~RemoteCameraForm(void)
{
	delete __pCanvas;
	__pCanvas = null;
	delete __pTimerDraw;
	__pTimerDraw = null;
	delete __pTizenRemoteCamera;
	__pTizenRemoteCamera = null;
}

result
RemoteCameraForm::OnInitializing(void)
{
	Footer* pFooter = this->GetFooter();

	// Create Timer
	__pTimerDraw = new (std::nothrow) Timer();
	__pTimerDraw->Construct(*this);

	// Create object
	__pTizenRemoteCamera = new (std::nothrow) TizenRemoteCamera();
	TryReturn(__pTizenRemoteCamera != null, E_FAILURE, "Failed to create info");
	__pTizenRemoteCamera->Initialize();

	if(pFooter != null)
	{
		pFooter->SetStyle(FOOTER_STYLE_BUTTON_TEXT);
		this->SetFormBackEventListener(this);

		FooterItem footerItemStart;
		footerItemStart.Construct(ID_BUTTON1);
		footerItemStart.SetText(BUTTON1_NAME);
		pFooter->AddItem(footerItemStart);

		FooterItem footerItemCapture;
		footerItemCapture.Construct(ID_BUTTON2);
		footerItemCapture.SetText(BUTTON2_NAME);
		pFooter->AddItem(footerItemCapture);

		FooterItem footerItemStop;
		footerItemStop.Construct(ID_BUTTON3);
		footerItemStop.SetText(BUTTON3_NAME);
		pFooter->AddItem(footerItemStop);

		pFooter->AddActionEventListener(*this);
	}

	return E_SUCCESS;
}

void
RemoteCameraForm::OnActionPerformed(const Tizen::Ui::Control& source, int actionId)
{
	switch (actionId)
	{
	case ID_BUTTON1:
		__pTizenRemoteCamera->StartRemoteCamera();
		__stat = TIMER_START;
		__pTimerDraw->Start(INTERVAL);
		break;

	case ID_BUTTON2:
		__pTizenRemoteCamera->CaptureRemoteCamera();
		break;

	case ID_BUTTON3:
		__pTizenRemoteCamera->StopRemoteCamera();
		__stat = TIMER_STOP;
		break;

	default:
		break;
	}

	RequestRedraw();
}

result
RemoteCameraForm::OnDraw(void)
{
	result r = E_SUCCESS;

	__pCanvas = GetCanvasN();
	__pCanvas->Clear();

	r = DrawImage(__pTizenRemoteCamera->GetBitmap());

	return r;
}

result
RemoteCameraForm::DrawImage(const Bitmap* pBitmap)
{
	result r = E_SUCCESS;

	int img_width = 0;
	int img_height = 0;
	int client_width = 0;
	img_width = pBitmap->GetWidth();
	img_height = pBitmap->GetHeight();
	client_width = GetClientAreaBounds().width;

	r = __pCanvas->DrawBitmap(Rectangle(client_width/2 - img_width/2, SPACE_Y, img_width, img_height), *pBitmap);

	return r;
}

void
RemoteCameraForm::OnTimerExpired(Timer& timer)
{
	RequestRedraw();
	AppLog("Timer: OnTimerExpired: %d", __count++);

	if(__stat == TIMER_STOP)
	{
		return;
	}

	result r = __pTimerDraw->Start(INTERVAL);
	if (IsFailed(r))
	{
		AppLog("Timer Start Fail.\n");
		return;
	}
}

void
RemoteCameraForm::OnFormBackRequested(Tizen::Ui::Controls::Form& source)
{
	UiApp* pApp = UiApp::GetInstance();
	AppAssert(pApp);
	pApp->Terminate();
}
