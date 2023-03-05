using BookStoreDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreApp.ViewModels
{
    public class EditBookViewModel : AddBookViewModel
    {
        public EditBookViewModel(BookStoreLiteContext context) : base(context)
        {

        }

        public override void SaveBook()
        {

        }
    }
}
