using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5
{
    public partial class Form1 : Form
    {
        BindingList<Product> products = new BindingList<Product>();

        public Form1()
        {
            products.Add(new FoodProduct("Food1", "Description1", 200, "Country1", new DateTime(2021, 1, 1), new DateTime(2022, 1, 1), 5, "g"));
            products.Add(new FoodProduct("Food2", "Description2", 300, "Country2", new DateTime(2022, 1,1 ), new DateTime(2023, 1, 1), 2, "l"));
            products.Add(new Book("Book2", "Description3", 500, "Country3", new DateTime(2020, 1, 1), 100, "Publisher1", new List<string>{"Author1", "Author2"}));
            InitializeComponent();
            dataGridView1.DataSource = products;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ChangeRemoveProductWindow(false);
            ChangeAddBaseProductWindow(true);
            ChangeAddBookProductWindow(true);
            ChangeAddFoodProductWindow(false);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ChangeRemoveProductWindow(false);
            ChangeAddBaseProductWindow(true);
            ChangeAddBookProductWindow(false);
            ChangeAddFoodProductWindow(true);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ChangeAddBaseProductWindow(false);
            ChangeAddBookProductWindow(false);
            ChangeAddFoodProductWindow(false);
            ChangeRemoveProductWindow(true);
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ChangeRemoveProductWindow(bool status)
        {
            labelError.Visible = false;
            labeld.Visible = status;
            numericUpDownId.Visible = status;
            buttonRemove.Visible = status;
        }
        private void ChangeAddBaseProductWindow(bool status)
        {
            labelError.Visible = false;
            labelName.Visible = status;
            labelDescription.Visible = status;
            labelPrice.Visible = status;
            labelCountry.Visible = status;
            buttonAddFoodProduct.Visible = status;

            textBoxName.Visible = status;
            textBoxDescription.Visible = status;
            textBoxPrice.Visible = status;
            textBoxCountry.Visible = status;
        }

        private void ChangeAddBookProductWindow(bool status)
        {
            labelPagesCount.Visible = status;
            labelPublisher.Visible = status;
            labelAuthors.Visible = status;

            numericUpDownPagesCount.Visible = status;
            textBoxPublisher.Visible = status;
            textBoxAuthors.Visible = status;

            buttonAddBookProduct.Visible = status;
        }

        private void ChangeAddFoodProductWindow(bool status)
        {
            labelExpirationDate.Visible = status;
            labelMeasureUnit.Visible = status;
            labelQuantity.Visible = status;

            numericUpDownQuantity.Visible = status;
            dateTimeExpirationDate.Visible = status;
            textBoxMeasureUnit.Visible = status;

            buttonAddFoodProduct.Visible = status;
        }

        private void buttonAddFoodProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxName.Text))
                {
                    throw new Exception();
                }
                labelError.Visible = false;
                Product product = new FoodProduct(textBoxName.Text, textBoxDescription.Text, Convert.ToDecimal(textBoxPrice.Text.Replace(".", ",")), textBoxCountry.Text, DateTime.Now, dateTimeExpirationDate.Value, (int)numericUpDownQuantity.Value, textBoxMeasureUnit.Text);
                products.Add(product);
            }
            catch (Exception)
            {

                labelError.Visible = true;
            }

        }


        private void buttonAddBookProduct_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> authors = textBoxAuthors.Text.Split(',').Select(s => s.Trim()).ToList();
                
                labelError.Visible = false;
                if (string.IsNullOrEmpty(textBoxName.Text))
                {
                    throw new Exception();
                }
                Product product = new Book(textBoxName.Text, textBoxDescription.Text, Convert.ToDecimal(textBoxPrice.Text.Replace(".", ",")), textBoxCountry.Text, DateTime.Now, (int)numericUpDownPagesCount.Value, textBoxPublisher.Text, authors);
                products.Add(product);
            }
            catch (Exception)
            {
                labelError.Visible = true;
            }

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (products.Count > (int)numericUpDownId.Value)
            {
                products.RemoveAt((int)numericUpDownId.Value);
            }
            
        }
    }
}
