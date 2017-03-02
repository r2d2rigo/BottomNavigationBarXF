﻿/*
 * BottomNavigationBar for Xamarin Forms
 * Copyright (c) 2016 Thrive GmbH and others (http://github.com/thrive-now).
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using Xamarin.Forms;

namespace BottomBar.XamarinForms
{
	public static class BottomBarPageExtensions
	{
		#region TabColorProperty

		public static readonly BindableProperty TabColorProperty = BindableProperty.CreateAttached (
				propertyName: "TabColor",
				returnType: typeof (Color?),
				declaringType: typeof (Page),
				defaultValue: null,
				defaultBindingMode: BindingMode.OneWay,
				validateValue: null,
				propertyChanged: null);

		public static void SetTabColor (this Page page, Color? color)
		{
			page.SetValue (TabColorProperty, color);
		}

		public static Color? GetTabColor (this Page page)
		{
			return (Color?)page.GetValue (TabColorProperty);
		}

        #endregion

        public static readonly BindableProperty IsTabVisibleProperty = BindableProperty.CreateAttached(
            "IsTabVisible",
            typeof(bool),
            typeof(Page),
            true);

        public static void SetIsTabVisible(this Page page, bool tabVisible)
        {
            page.SetValue(IsTabVisibleProperty, tabVisible);
        }

        public static bool GetIsTabVisible(this Page page)
        {
            return (bool)page.GetValue(IsTabVisibleProperty);
        }
	}
}

