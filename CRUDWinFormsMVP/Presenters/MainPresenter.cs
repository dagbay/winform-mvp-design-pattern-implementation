using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDWinFormsMVP.Views;
using CRUDWinFormsMVP.Models;
using CRUDWinFormsMVP.Repository;

namespace CRUDWinFormsMVP.Presenters
{
    public class MainPresenter
    {
        private IMainView _mainView;
        private readonly string _sqlConnectionString;
        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this._mainView = mainView;
            this._sqlConnectionString = sqlConnectionString;
            this._mainView.ShowPetView += ShowPetsView;
        }

        private void ShowPetsView(object sender, EventArgs e)
        {
            IPetView view = PetView.GetInstance();
            IPetRepository repository = new PetRepository(this._sqlConnectionString);
            new PetPresenter(view, repository);
        }
    }
}
