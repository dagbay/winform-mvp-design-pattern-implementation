using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDWinFormsMVP.Views
{
    public partial class PetView : Form, IPetView
    {
        private string petId;
        private string petName;
        private string petType;
        private string petColour;
        private string searchValue;
        private bool isEdit;
        private bool isSuccessful;
        private string message;

        public PetView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPagePetDetail);
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter) SearchEvent?.Invoke(this, EventArgs.Empty);
            };
        }

        public string PetId 
        { 
            get { return petId; } 
            set { petId = value; } 
        }

        public string PetName 
        { 
            get { return petName; } 
            set { petName = value; } 
        }

        public string PetType 
        { 
            get { return petType; } 
            set { petType = value; } 
        }

        public string PetColour 
        { 
            get { return petColour; } 
            set { petColour = value; } 
        }

        public string SearchValue 
        { 
            get { return searchValue; } 
            set { searchValue = value; } 
        }

        public bool IsEdit 
        { 
            get { return isEdit; } 
            set { isEdit = value; } 
        }

        public bool IsSuccessful 
        { 
            get { return isSuccessful;  } 
            set { IsSuccessful = value; } 
        }

        public string Message 
        { 
            get { return message; } 
            set { message = value; } 
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetPetListBindingSource(BindingSource petList)
        {
            dgvPets.DataSource = petList;
        }
    }
}
