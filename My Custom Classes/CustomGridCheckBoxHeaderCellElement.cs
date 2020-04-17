using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace HomeCafe.My_Custom_Classes
{
    class CustomGridCheckBoxHeaderCellElement : GridCheckBoxHeaderCellElement
    {
        public CustomGridCheckBoxHeaderCellElement(GridViewColumn column, GridRowElement row)
            : base(column, row)
        {
        }

        readonly RadCheckBoxElement _myCheckBoxElement = new RadCheckBoxElement();

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            _myCheckBoxElement.ToggleStateChanged += myCheckBoxElement_ToggleStateChanged;
            Children.Add(_myCheckBoxElement);
        }

        private void myCheckBoxElement_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            GridControl.BeginUpdate();
            RowInfo.Tag = args.ToggleState;

            foreach (var row in GridControl.Rows)
            {
                if (row.HierarchyLevel == 1)
                {
                    row.Cells["FactoredColumn"].Value = args.ToggleState;
                }
            }
            GridControl.EndUpdate();
        }

        public override void SetContent()
        {
            base.SetContent();
            _myCheckBoxElement.ToggleStateChanged -= myCheckBoxElement_ToggleStateChanged;
            if (RowInfo.Tag != null)
            {
                _myCheckBoxElement.ToggleState = (ToggleState)RowInfo.Tag;
            }
            _myCheckBoxElement.ToggleStateChanged += myCheckBoxElement_ToggleStateChanged;
        }
    }
}
