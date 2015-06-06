
#ifndef _REMOTE_CAMERA_FORM_H_
#define _REMOTE_CAMERA_FORM_H_

#include <FApp.h>
#include <FBase.h>
#include <FIo.h>
#include <FUi.h>
#include <FUix.h>
#include <FGraphics.h>
#include <FMedia.h>

#include "TizenRemoteCamera.h"

class RemoteCameraForm
	: public Tizen::Ui::Controls::Form
	, public Tizen::Ui::IActionEventListener
	, public Tizen::Base::Runtime::ITimerEventListener
	, public Tizen::Ui::Controls::IFormBackEventListener

{
public:
	RemoteCameraForm(void);
	virtual ~RemoteCameraForm(void);

	virtual result OnInitializing(void);
	virtual void OnActionPerformed(const Tizen::Ui::Control& source, int actionId);
	virtual result OnDraw(void);

	result DrawImage(const Tizen::Graphics::Bitmap* pBitmap);
	virtual void OnTimerExpired(Tizen::Base::Runtime::Timer& timer);
	void OnFormBackRequested(Tizen::Ui::Controls::Form& source);

protected:
	static const int ID_BUTTON1 = 101;
	static const int ID_BUTTON2 = 102;
	static const int ID_BUTTON3 = 103;

private:
	int __stat;
	int __count;

	Tizen::Graphics::Canvas* __pCanvas;
	Tizen::Base::Runtime::Timer* __pTimerDraw;
	TizenRemoteCamera* __pTizenRemoteCamera;
};

#endif // _REMOTE_CAMERA_FORM_H_
