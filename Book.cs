using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftEng
{
    public class Book
    {
        private string input;
        private int page = 0;
        public void ShowPage()
        {
            //Show Graphics for current page
            input = Console.ReadLine();     
            if(input == "left")
            {
                PageLeft();
            }
            else if(input == "right")
            {
                PageRight();
            }
            //An den tupwthei oute Left oute Right kanei exit
        }
        private void PageLeft()
        {
            page--;
            ShowPage();
        }
        private void PageRight()
        {
            page++;
            ShowPage();
        }
    }
}
