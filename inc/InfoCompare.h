//
// Tizen C++ SDK
// Copyright (c) 2012-2013 Samsung Electronics Co., Ltd.
//
// Licensed under the Flora License, Version 1.1 (the License);
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://floralicense.org/license/
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an AS IS BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

#ifndef _INFO_COMPARE_H_
#define _INFO_COMPARE_H_

#include "Info.h"
#include <FBaseComparerT.h>

class InfoCompare
	: public Tizen::Base::ComparerT<Info>
{
public:
	InfoCompare(void);
	virtual ~InfoCompare(void);

	void SetCompareOpt(int opt);
	virtual result  Compare (const Info &obj1, const Info &obj2, int &cmp) const ;

	static const int SORT_DES = 0;
	static const int SORT_ASC = 1;
	static const int SORT_BY_STRING = 3;

private:
	int	__sortOpt;
};

#endif // _INFO_COMPARE_H_
