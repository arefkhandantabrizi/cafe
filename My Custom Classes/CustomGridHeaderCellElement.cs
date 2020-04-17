using System;
using System.Drawing;
using System.Reflection;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Localization;

namespace HomeCafe.My_Custom_Classes
{
    public class CustomGridHeaderCellElement : GridHeaderCellElement
    {
        private static readonly MethodInfo MenuItemColumnChooserClickMethodInfo;
        private static readonly Font font = new Font("IRANSansDNFaNum", 9.0f, FontStyle.Regular);
        static CustomGridHeaderCellElement()
        {
            MenuItemColumnChooserClickMethodInfo = typeof(GridHeaderCellElement).GetMethod("MenuItemColumnChooser_Click",
                BindingFlags.Instance | BindingFlags.NonPublic);
        }

        private readonly EventHandler _menuItemColumnChooserClickEventHandler;

        public CustomGridHeaderCellElement(GridViewColumn column, GridRowElement row)
            : base(column, row)
        {
            Font = font;
            _menuItemColumnChooserClickEventHandler = (EventHandler)Delegate.CreateDelegate(typeof(EventHandler), this, MenuItemColumnChooserClickMethodInfo);

        }

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(GridHeaderCellElement);
            }
        }

        protected override void CreateColumnChooserMenuItems(RadDropDownMenu contextMenu)
        {
            base.CreateColumnChooserMenuItems(contextMenu);

            var menu = GetMenuItem(contextMenu, RadGridLocalizationProvider.CurrentProvider.GetLocalizedString(RadGridStringId.ColumnChooserMenuItem));
            menu.Font = font;
            if (menu != null)
            {
                menu.Click -= _menuItemColumnChooserClickEventHandler;
                menu.Click += menu_Click;
            }
        }

        private RadMenuItem GetMenuItem(RadDropDownMenu contextMenu, string text)
        {
            if (contextMenu == null) throw new ArgumentNullException("contextMenu");
            foreach (var item in contextMenu.Items)
            {
                var menuItem = item as RadMenuItem;

                if (menuItem != null && menuItem.Text == text)
                {
                    return menuItem;
                }
            }

            return null;
        }

        private void menu_Click(object sender, EventArgs e)
        {
            StackLayoutElement elementHolder = GridViewElement.ColumnChooser.ColumnChooserControl.ColumnChooserElement.ElementsHolder;
            elementHolder.ChildrenChanged += OnChildrenChanged;
            _menuItemColumnChooserClickEventHandler(sender, e);
        }


        private static void OnChildrenChanged(object sender, ChildrenChangedEventArgs e)
        {
            if (e.ChangeOperation != ItemsChangeOperation.Inserted) return;
            var item = e.Child as LightVisualElement;
            if (item != null) item.TextAlignment = ContentAlignment.TopLeft;
        }
    }
}
