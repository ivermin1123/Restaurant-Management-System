using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.Handler;
using DevExpress.XtraGrid.Views.Base.ViewInfo;

namespace QuanLyQuanBeer
{
    [ToolboxItem(true)]
    public class CustomGrid1 : GridControl
    {
        protected override BaseView CreateDefaultView()
        {
            return CreateView("CustomGridView1");
        }

        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new CustomGridView1InfoRegistrator());
        }
    }

    public class CustomGridView1InfoRegistrator : GridInfoRegistrator
    {
        public override string ViewName => "CustomGridView1";

        public override BaseView CreateView(GridControl grid)
        {
            return new CustomGridView1(grid);
        }

        public override BaseViewInfo CreateViewInfo(BaseView view)
        {
            return new CustomGridView1Info(view as CustomGridView1);
        }

        public override BaseViewHandler CreateHandler(BaseView view)
        {
            return new CustomGridView1Handler(view as CustomGridView1);
        }

        public override BaseViewPainter CreatePainter(BaseView view)
        {
            return new CustomGridView1Painter(view as CustomGridView1);
        }
    }

    public class CustomGridView1 : DevExpress.XtraGrid.Views.Grid.GridView
    {
        public CustomGridView1()
        {
        }

        public CustomGridView1(GridControl grid) : base(grid)
        {
        }

        protected override string ViewName => "CustomGridView1";
    }

    public class CustomGridView1Info : DevExpress.XtraGrid.Views.Grid.ViewInfo.GridViewInfo
    {
        public CustomGridView1Info(DevExpress.XtraGrid.Views.Grid.GridView view) : base(view)
        {
        }
    }

    public class CustomGridView1Handler : DevExpress.XtraGrid.Views.Grid.Handler.GridHandler
    {
        public CustomGridView1Handler(DevExpress.XtraGrid.Views.Grid.GridView view) : base(view)
        {
        }
    }

    public class CustomGridView1Painter : DevExpress.XtraGrid.Views.Grid.Drawing.GridPainter
    {
        public CustomGridView1Painter(DevExpress.XtraGrid.Views.Grid.GridView view) : base(view)
        {
        }
    }
}
