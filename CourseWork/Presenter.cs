using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    class Presenter
    {
        private readonly IView _view;
        private readonly IMessageService _messageService;

        public Presenter(IView view, IMessageService service)
        {
            _view = view;
            _messageService = service;

            _view.ContinueClick += new EventHandler(_view_ContinueClick);
        }

        public void _view_ContinueClick(object sender, EventArgs e)
        {
            _view.Close();
        }
    }
}
