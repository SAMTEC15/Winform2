using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using ToDoList.Data;
using ToDoList.Data.Entities;

namespace SamTechToDoApp
{
    public partial class Form1 : Form
    {
        AppUser appUser = new AppUser();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvdisplay.CurrentRow.Index != -1)
            {
                appUser.Id = Convert.ToInt32(dgvdisplay.CurrentRow.Cells["Id"].Value);
                using(SamDbContext db = new SamDbContext())
                {
                    appUser = db.AppUsers.Where(c=>c.Id == appUser.Id).FirstOrDefault();
                    sheet.Text = appUser.Task;
                }
                add.Text = "Update";
                delete.Enabled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();
            loadData();
            timer1.Start();
            this.ActiveControl = sheet;
        }
        void loadData()
        {
            //dgvdisplay.AutoGenerateColumns = false;
            using (SamDbContext db = new SamDbContext())
            {
                dgvdisplay.DataSource = db.AppUsers.ToList<AppUser>();
            }
            Reset();
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
        void Reset()
        {
            sheet.Text = string.Empty;
            add.Text = "Add";
            delete.Enabled = false;
            appUser.Id = 0;
            this.ActiveControl = sheet;
        }

        private void add_Click(object sender, EventArgs e)
        {
            var search = sheet.Text.Trim();
            if (string.IsNullOrEmpty(search))
            {
                MessageBox.Show("Box can not be empty");

            }
            else
            {
                try
                {
                    appUser.UpdatedAt = DateTime.UtcNow;
                    appUser.CreatedAt = DateTime.UtcNow;
                    appUser.Task = sheet.Text.Trim();



                    using (SamDbContext db = new SamDbContext())
                    {
                        if (appUser.Id == 0)
                            db.AppUsers.Add(appUser);
                        else
                            db.Entry(appUser).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                    Reset();
                    loadData();
                    MessageBox.Show("Item added successfully!");            //MessageBoxButtons.OK, MessageBoxIcon.Error
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "While try to add the task");
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want delete this item?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using(SamDbContext db = new SamDbContext())
                {
                    var choice = db.Entry(appUser);
                    if(choice.State == EntityState.Detached)
                    {
                        db.AppUsers.Attach(appUser);
                        db.AppUsers.Remove(appUser);
                        db.SaveChanges();
                        loadData();
                    }
                    
                    MessageBox.Show("Items succesfully deleted");
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                string Searchitem = search.Text.Trim();
                using (SamDbContext item = new SamDbContext())
                {
                    int searchId;
                    bool isNumeric = int.TryParse(Searchitem, out searchId);

                    var searchResult = item.AppUsers
                        .Where(v =>
                            v.Task.Contains(Searchitem) ||
                            v.CreatedAt.ToString().Contains(Searchitem) ||
                            v.UpdatedAt.ToString().Contains(Searchitem) ||
                            (isNumeric && v.Id == searchId) // Check if input can be parsed to an integer and then search by Id
                        )
                        .ToList(); // Execute the query and convert the result to a list
                    int resultCount = searchResult.Count;
                    richTextBox1.Text = $"Found {resultCount} result(s).";

                    dgvdisplay.DataSource = searchResult;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Occured while trying to excute search");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int current = label1.Location.X;
            current = 0;
            if (current + label1.Width < 0)
            {
                current = this.Width;
            }
            label1.Location = new System.Drawing.Point(current, label1.Location.Y);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvdisplay_DoubleClick(object sender, EventArgs e)
        {
            if(dgvdisplay.CurrentRow.Index != -1)
            {
                appUser.Id = Convert.ToInt32(dgvdisplay.CurrentRow.Cells["Id"].Value);
                using (SamDbContext db = new SamDbContext())
                {
                    appUser = db.AppUsers.Where(x=> x.Id == appUser.Id).FirstOrDefault();
                    sheet.Text = appUser.Task;
                }
                update.Text = "EDIT";
                delete.Enabled = true;
            }
        }
    }
}
