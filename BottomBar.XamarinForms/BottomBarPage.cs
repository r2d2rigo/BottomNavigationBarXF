/*
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
	public class BottomBarPage : MultiPage<Page>
    {
        public static readonly BindableProperty BarBackgroundColorProperty = BindableProperty.Create(nameof(BarBackgroundColor), typeof(Color), typeof(TabbedPage), Color.Default);

        public static readonly BindableProperty BarTextColorProperty = BindableProperty.Create(nameof(BarTextColor), typeof(Color), typeof(TabbedPage), Color.Default);

        public Color BarBackgroundColor
        {
            get
            {
                return (Color)GetValue(BarBackgroundColorProperty);
            }
            set
            {
                SetValue(BarBackgroundColorProperty, value);
            }
        }

        public Color BarTextColor
        {
            get
            {
                return (Color)GetValue(BarTextColorProperty);
            }
            set
            {
                SetValue(BarTextColorProperty, value);
            }
        }

        public enum BarThemeTypes { Light, DarkWithAlpha, DarkWithoutAlpha }

		public bool FixedMode { get; set; }
		public BarThemeTypes BarTheme { get; set; }

		public void RaiseCurrentPageChanged()
		{
			OnCurrentPageChanged();
		}

        protected override Page CreateDefault(object item)
        {
            var page = new Page();
            if (item != null)
                page.Title = item.ToString();

            return page;
        }
    }
}

