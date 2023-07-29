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
            btnNew.Click += delegate 
            { 
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPagePetList);
                tabControl1.TabPages.Add(tabPagePetDetail);
                tabPagePetDetail.Text = "Add Pet";
            };
            btnEdit.Click += delegate 
            { 
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPagePetList);
                tabControl1.TabPages.Add(tabPagePetDetail);
                tabPagePetDetail.Text = "Edit Pet";
            };
            btnDelete.Click += delegate 
            { 
                var result = MessageBox.Show("Are you sure you want to delete the selected pet?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPagePetDetail);
                    tabControl1.TabPages.Add(tabPagePetList);
                }
                MessageBox.Show(Message);
            };
            btnCancel.Click += delegate 
            { 
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPagePetDetail);
                tabControl1.TabPages.Add(tabPagePetList);
            };

            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter) SearchEvent?.Invoke(this, EventArgs.Empty);
            };
        }

        public string PetId 
        { 
            get { return txtPetID.Text; } 
            set { txtPetID.Text = value; } 
        }

        public string PetName 
        { 
            get { return txtPetName.Text; } 
            set { txtPetName.Text = value; } 
        }

        public string PetType 
        { 
            get { return txtPetType.Text; } 
            set { txtPetType.Text = value; } 
        }

        public string PetColour 
        { 
            get { return txtPetColour.Text; } 
            set { txtPetColour.Text = value; } 
        }

        public string SearchValue 
        { 
            get { return txtSearch.Text; } 
            set { txtSearch.Text = value; } 
        }

        public bool IsEdit 
        { 
            get { return isEdit; } 
            set { isEdit = value; } 
        }

        public bool IsSuccessful 
        { 
            get { return isSuccessful;  } 
            set { isSuccessful = value; } 
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

        // Singleton Pattern (Open a single form instance)
        private static PetView instance;
        public static PetView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PetView();
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized) instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
    }
}
