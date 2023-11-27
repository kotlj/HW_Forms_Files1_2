using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HW_Forms_Files1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text != null && textBoxSecondName.Text != null && textBoxEmail.Text != null && textBoxPhone.Text != null)
            {
                Human human = new Human();
                human.Name = textBoxFirstName.Text;
                human.Surname = textBoxSecondName.Text;
                human.EMail = textBoxEmail.Text;
                human.Phone = textBoxPhone.Text;
                listBox1.Items.Add(human);
                listBox1.ValueMember = "Name";
                listBox1.Update();
            }
            else
            {
                MessageBox.Show("All fields must be filled in");
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox1.Update();
            }
            else
            {
                MessageBox.Show("Select an item first!");
            }
        }

        private void buttonRedact_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Human human = listBox1.SelectedItem as Human;
                listBox1.Items.Remove(human);
                textBoxFirstName.Text = human.Name;
                textBoxSecondName.Text = human.Surname;
                textBoxEmail.Text = human.EMail;
                textBoxPhone.Text = human.Phone;
                listBox1.Update();
            }
            else
            {
                MessageBox.Show("Select an item first!");
            }
        }

        private void buttonToTxT_Click(object sender, EventArgs e)
        {
            using (StreamWriter wr = new StreamWriter("TextSave.txt", false))
            {
                foreach (Human h in listBox1.Items)
                {
                    wr.WriteLine(h.ToString());
                }
                wr.Close();
            }
        }

        private void buttonToXML_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlElement root = xmlDoc.CreateElement("List");
            xmlDoc.AppendChild(root);

            foreach (Human h in listBox1.Items)
            {
                XmlElement Human0 = xmlDoc.CreateElement("Human");

                XmlElement name = xmlDoc.CreateElement("Name");
                name.InnerText = h.Name;
                Human0.AppendChild(name);

                XmlElement surname = xmlDoc.CreateElement("Surname");
                surname.InnerText = h.Surname;
                Human0.AppendChild(surname);

                XmlElement email = xmlDoc.CreateElement("Email");
                email.InnerText = h.EMail;
                Human0.AppendChild(email);

                XmlElement phone = xmlDoc.CreateElement("Phone");
                phone.InnerText = h.Phone;
                Human0.AppendChild(phone);

                root.AppendChild(Human0);
            }
            xmlDoc.Save("XMLSave.xml");
        }
    }
}