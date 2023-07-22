using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUDWinFormsMVP.Models;
using CRUDWinFormsMVP.Views;

namespace CRUDWinFormsMVP.Presenters
{
    public class PetPresenter
    {
        // Fields
        private IPetView view;
        private IPetRepository repository;
        private BindingSource petsBindingSource;
        private IEnumerable<PetModel> petList;

        // Constructor
        public PetPresenter(IPetView view, IPetRepository repository)
        {
            this.petsBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            // Subscribe Event Handler Methods to View Events
            this.view.SearchEvent += SearchPet;
            this.view.AddNewEvent += AddPet;
            this.view.EditEvent += LoadSelectedPetToEdit;
            this.view.DeleteEvent += DeleteSelectedPet;
            this.view.SaveEvent += SavePet;
            this.view.CancelEvent += CancelEvent;

            // Set Pets Binding Source
            this.view.SetPetListBindingSource(petsBindingSource);

            // Load Pet List View
            LoadAllPetList();

            // Show the View
            this.view.Show();
        }

        private void LoadAllPetList()
        {
            petList = repository.GetAll();
            petsBindingSource.DataSource = petList;
        }

        private void SearchPet(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                petList = repository.GetByValue(this.view.SearchValue);
                petsBindingSource.DataSource = petList;
            }
            else
            {
                LoadAllPetList();
            }
        }

        private void CancelEvent(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SavePet(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedPet(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectedPetToEdit(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddPet(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}
