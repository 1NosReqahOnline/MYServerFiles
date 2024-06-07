﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// 
// Copyright (C) 2019 - NosCore
// 
// NosCore is a free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using NosCore.Shared.Enumerations;
using System.Collections.Generic;

namespace NosCore.Data.Dto
{
    public class I18NString : Dictionary<RegionType, string>
    {
        public I18NString()
        {
            Add(RegionType.EN, "NONAME");
            Add(RegionType.DE, "NONAME");
            Add(RegionType.FR, "NONAME");
            Add(RegionType.IT, "NONAME");
            Add(RegionType.PL, "NONAME");
            Add(RegionType.ES, "NONAME");
            Add(RegionType.CS, "NONAME");
            Add(RegionType.TR, "NONAME");
            Add(RegionType.RU, "NONAME");
        }
    }
}