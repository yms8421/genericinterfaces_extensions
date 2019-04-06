using BilgeAdam.GenericsAndInterfaces.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.GenericsAndInterfaces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var imlLarge = new ImageList();
            imlLarge.Images.Add("cityIcon", ProjectResources.cityIcon);
            listView1.LargeImageList = imlLarge;
            var people = new HashSet<Person>(new PersonComparer());
            people.Add(new Person { FirstName = "Can", LastName = "Perk", BirthDate = new DateTime(1999, 2, 28) });
            people.Add(new Person { FirstName = "Alper", LastName = "Köklü", BirthDate = new DateTime(1986, 1, 12) });
            people.Add(new Person { FirstName = "Neslihan", LastName = "Şimşek", BirthDate = new DateTime(2002, 2, 3) });
            people.Add(new Person { FirstName = "Mehmet", LastName = "İlhan", BirthDate = new DateTime(1999, 2, 8) });
            people.Add(new Person { FirstName = "Ali", LastName = "Ercan", BirthDate = new DateTime(1993, 2, 3) });
            people.Add(new Person { FirstName = "Gülşah", LastName = "Duman", BirthDate = new DateTime(1967, 10, 8) });
            people.Add(new Person { FirstName = "Fatih", LastName = "Eser", BirthDate = new DateTime(1999, 9, 3) });
            people.Add(new Person { FirstName = "Berkay", LastName = "Tüzen", BirthDate = new DateTime(1992, 7, 3) });
            people.Add(new Person { FirstName = "Can", LastName = "Perk", BirthDate = new DateTime(1999, 2, 28) });
            people.Add(new Person { FirstName = "Mehmet", LastName = "İlhan", BirthDate = new DateTime(1999, 2, 8) });
            people.Add(new Person { FirstName = "Gülşah", LastName = "Duman", BirthDate = new DateTime(1967, 10, 8) });


            var list = new HashSet<string>();
            list.Add("Adana");
            list.Add("Adana");
            list.Add("Adana");
            list.Add("Adana");
            list.Add("Ankara");
            list.Add("İstanbul");
            list.Add("İstanbul");
            list.Add("İstanbul");
            list.Add("İzmir");
            list.Add("Trabzon");
            list.Add("Trabzon");

            dataGridView1.DataSource = people.ToList();
            listBox1.DataSource = list.ToList();

            foreach (var city in list)
            {
                checkedListBox1.Items.Add(city);
                listView1.Items.Add(new ListViewItem(city, "cityIcon"));
            }

            //var f = StringExtensions.MakeFormal("can perk");
            var name = "can perk";
            var formalname = name.MakeFormal();
            var edge = 9;
            var q = edge.GetDoubled();
           
        }
        private string MakeFormal(string name)
        {
            var startOfLastname = name.Trim().LastIndexOf(' ') + 1;
            var lastname = name.Substring(startOfLastname).ToUpper();
            var firstName = name.Substring(0, name.Length - startOfLastname).Trim();
            return $"{firstName.Substring(0, 1).ToUpper() + firstName.Substring(1).ToLower()} {lastname}";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var msg = string.Empty;
            foreach (var item in checkedListBox1.CheckedItems)
            {
                msg += item.ToString();
            }
            MessageBox.Show(msg);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            var pwd = rnd.GetPassword(12);
            MessageBox.Show(pwd);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var dict = new Dictionary<string, string>();
            dict.AddOrUpdate("name", "Can");
            dict.AddOrUpdate("surname", "Perk");
            dict.AddOrUpdate("place", "Ankara");
            dict.AddOrUpdate("age", "31");
            dict.AddOrUpdate("name", "Cem");
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
