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

#include "InfoCompare.h"

InfoCompare::InfoCompare(void)
	: __sortOpt(0)
{
}

InfoCompare::~InfoCompare(void)
{
}

void
InfoCompare::SetCompareOpt(int opt)
{
	__sortOpt = opt;
}

result
InfoCompare::Compare (const Info &obj1, const Info &obj2, int &cmp) const
{
	switch(__sortOpt)
	{
	case SORT_DES:
	{
		if (obj1 > obj2)
		{
			cmp = -1;
		}
		else if (obj1 < obj2)
		{
			cmp = 1;
		}
		else
		{
			cmp = 0;
		}
	}
	break;

	case SORT_ASC:
	{
		if (obj1 > obj2)
		{
			cmp = 1;
		}
		else if (obj1 < obj2)
		{
			cmp = -1;
		}
		else
		{
			cmp = 0;
		}
	}
	break;

	case SORT_BY_STRING:
	{
		if (obj1 > obj2.GetFileName())
		{
			cmp = 1;
		}
		else if (obj1 < obj2.GetFileName())
		{
			cmp = -1;
		}
		else
		{
			cmp = 0;
		}
	}
	break;

	default:
		break;
	}

	return E_SUCCESS;
}
