/*
 * TizenRemoteCamera.h
 *
 *  Created on: Jun 6, 2015
 *      Author: Salahuddin
 */

#ifndef _TIZEN_REMOTE_CAMERA_H_
#define _TIZEN_REMOTE_CAMERA_H_

#include <FApp.h>
#include <FBase.h>
#include <FIo.h>
#include <FGraphics.h>
#include <FMedia.h>

#include "Info.h"

class TizenRemoteCamera
	: public Tizen::Base::Object
	, public Tizen::Base::Runtime::ITimerEventListener
{
public:
		TizenRemoteCamera(void);
		virtual ~TizenRemoteCamera(void);

		void Initialize(void);
		const Tizen::Graphics::Bitmap* GetBitmap(void) const;
		Tizen::Base::ByteBuffer* LoadImageN(Tizen::Base::String FileName, int& nWidth, int& nHeight);
		Tizen::Base::ByteBuffer* LoadImageNRaw(Tizen::Base::String FileName, int& nWidth, int& nHeight);

		void GetRemoteImage(void);
		virtual void OnTimerExpired(Tizen::Base::Runtime::Timer& timer);

		void StartRemoteCamera(void);
		void CaptureRemoteCamera(void);
		void StopRemoteCamera(void);

private:
		double __percent;
		int __panelY;
		int __stat;
		int __count;

		Info* __pPicture;
		Tizen::Base::Runtime::Timer* __pTimer;
		Tizen::Base::Collection::ArrayListT< Info >* __pInfoList;
};

#endif // _TIZEN_REMOTE_CAMERA_H_
