﻿//    This file is part of Nfield.SDK.
//
//    Nfield.SDK is free software: you can redistribute it and/or modify
//    it under the terms of the GNU Lesser General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    Nfield.SDK is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public License
//    along with Nfield.SDK.  If not, see <http://www.gnu.org/licenses/>.

using Newtonsoft.Json;

namespace Nfield.Models
{
    /// <summary>
    /// Holds all properties of a template theme
    /// </summary>
    public class TemplateTheme
    {
        /// <summary>
        /// Unique ID of the template theme
        /// </summary>
        [JsonProperty]
        public string ThemeId  { get; internal set; }

        /// <summary>
        /// Template ID
        /// </summary>
        public string TemplateId { get; set; }

        /// <summary>
        /// Template theme name
        /// </summary>
        public string ThemeName { get; set; }

        /// <summary>
        /// Zip file Name
        /// </summary>
        public string ZipFileName { get; set; }

    }
}
