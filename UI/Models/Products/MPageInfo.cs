using System;

namespace UI.Models.Products
{
    public class MPageInfo
    {
        public MPageInfo(int Pagesize, int TotalProduct, int CurrentPage)
        {
            TotalPageNumber = (int)Math.Ceiling((decimal)TotalProduct / Pagesize);
            CurrentPagenumber = CurrentPage;
            SelectedPageSize = Pagesize;
        }

        public int TotalPageNumber { get; }
        public int CurrentPagenumber { get; }
        public int SelectedPageSize { set; get; }
        public int[] PageSizeArray { set; get; } = { 4, 6, 8, 10 };

}
}
