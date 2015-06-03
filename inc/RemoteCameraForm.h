
#ifndef _REMOTE_CAMERA_FORM_H_
#define _REMOTE_CAMERA_FORM_H_

#include <FApp.h>
#include <FBase.h>
#include <FIo.h>
#include <FUi.h>
#include <FUix.h>
#include <FGraphics.h>
#include <FMedia.h>

#include "Info.h"

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

	Tizen::Base::ByteBuffer* LoadImageN(Tizen::Base::String FileName, int& nWidth, int& nHeight);
	result DrawImage(const Tizen::Graphics::Bitmap* pBitmap);
	result DrawFaceDetectArea(const Info* pInfo);
	Tizen::Base::Collection::IList* GetFaceDetectAreaN(const Info* pInfo);

	void DoRecognizing(void);
	bool FaceRecognize(Tizen::Base::Collection::IList* pFaceDetectList1, Tizen::Base::Collection::IList* pFaceDetectList2);
	void DoFaceSimilarity(void);
	int GetSimilarity(Tizen::Base::Collection::IList* pFaceDetectList1, Tizen::Base::Collection::IList* pFaceDetectList2);
	void OnFormBackRequested(Tizen::Ui::Controls::Form& source);

	void SetTimer(void);
	virtual void OnTimerExpired(Tizen::Base::Runtime::Timer& timer);

	void StartRemoteCamera(void);
	void StopRemoteCamera(void);

protected:
	static const int ID_BUTTON = 101;
	static const int ID_BUTTON2 = 102;

private:
	double __percent;
	int __panelY;
	int __stat;
	int __count;

	Tizen::Ui::Controls::Button* __pButton;
	Tizen::Ui::Controls::Button* __pButton2;
	Tizen::Ui::Controls::ScrollPanel* __pPanel;
	Tizen::Graphics::Canvas* __pCanvas;
	Info* __pPicture;
	Tizen::Base::Runtime::Timer* __pTimer;

	Tizen::Base::Collection::ArrayListT< Info >* __pInfoList;
};

#endif // _REMOTE_CAMERA_FORM_H_
